using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class Home : Form
    {
        private DBGroceryContext _context;
        public Home()
        {
            InitializeComponent();
            _context = new DBGroceryContext(); // Khởi tạo đối tượng context trong constructor
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnTop10Pro_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Home_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            try
            {
                // Lấy tất cả các chi tiết hóa đơn bán hàng trong ngày hôm nay
                var orderDetailsToday = _context.ChiTietHDs
                                               .Where(ct => ct.HoaDonBanHang.NgayDatHang == today)
                                               .ToList();

                // Tính tổng số lượng sản phẩm đã bán và tổng doanh thu trong ngày hôm nay
                int totalQuantitySold = orderDetailsToday.Sum(ct => ct.SoLuongSP);
                decimal totalRevenue = orderDetailsToday.Sum(ct => ct.SoLuongSP * (ct.DonGia ?? 0));

                // Hiển thị thông tin
                lbSellPro.Text = totalQuantitySold.ToString();
                lbDTPro.Text = totalRevenue.ToString("C"); // Hiển thị số tiền dưới dạng tiền tệ
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lấy dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Lấy tháng và năm hiện tại
            int currentMonth = DateTime.Today.Month;
            int currentYear = DateTime.Today.Year;

            // Vẽ biểu đồ doanh thu cho tháng hiện tại
            DrawRevenueChartForMonth(currentMonth, currentYear);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _context.Dispose(); // Giải phóng đối tượng context khi đóng form
        }
        private void DrawRevenueChartForMonth(int month, int year)
        {
            // Xóa các dữ liệu hiện có trong Chart (nếu có)
            chartRevenue.Series.Clear();

            // Tạo một Series mới cho biểu đồ (ví dụ: loại biểu đồ là Column)
            Series series = new Series("Doanh thu bán trong tháng");
            series.ChartType = SeriesChartType.Column; // Loại biểu đồ cột

            // Truy xuất dữ liệu từ cơ sở dữ liệu
            using (var context = new DBGroceryContext())
            {
                // Lấy tổng doanh thu bán của mỗi ngày trong tháng
                var revenueByDay = context.HoaDonBanHangs
                                           .Where(h => h.NgayDatHang.Month == month && h.NgayDatHang.Year == year)
                                           .GroupBy(h => h.NgayDatHang.Day)
                                           .Select(group => new
                                           {
                                               Day = group.Key,
                                               TotalRevenue = group.Sum(h => h.TongSoTien ?? 0)
                                           })
                                           .OrderBy(item => item.Day)
                                           .ToList();

                // Thêm dữ liệu vào Series để vẽ biểu đồ
                foreach (var item in revenueByDay)
                {
                    series.Points.AddXY(item.Day, item.TotalRevenue);
                }
            }

            // Thêm Series vào Chart
            chartRevenue.Series.Add(series);

            // Cài đặt tiêu đề và trục cho biểu đồ
            chartRevenue.Titles.Add("Biểu đồ doanh thu bán trong tháng");
            chartRevenue.ChartAreas[0].AxisX.Title = "Ngày";
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu";

            // Cập nhật lại biểu đồ trên giao diện
            chartRevenue.Update();
        }

    }
}
