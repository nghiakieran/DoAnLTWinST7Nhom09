using DataAccessLayer.Models;
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
using BusinessAccessLayer;

namespace UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gwSellProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMoneyPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            string qty = tbQty.Text;
            int qtyInt = int.Parse(qty);
            if (qtyInt > 1)
            {
                qtyInt -= 1;
                tbQty.Text = qtyInt.ToString();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            string qty = tbQty.Text;
            int qtyInt = int.Parse(qty);
            qtyInt += 1;
            tbQty.Text = qtyInt.ToString();

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {

                try
                {
                    string newMaKH = "";
                    var lastKH = context.KhachHangs.OrderByDescending(nv => nv.MaKH).FirstOrDefault();

                    if (lastKH != null)
                    {
                        string lastMaKH = lastKH.MaKH;
                        // Sử dụng mã nhân viên của nhân viên cuối cùng ở đây
                        string last3Chars = lastMaKH.Substring(Math.Max(0, lastMaKH.Length - 3)); // Lấy 3 ký tự cuối
                        int last3CharsAsNumber = int.Parse(last3Chars);
                        last3CharsAsNumber++;
                        // Chuyển đổi số thành chuỗi có 3 ký tự
                        string newNumberString = last3CharsAsNumber.ToString("D3");

                        // Sử dụng PadLeft để thêm số 0 vào trước nếu cần
                        newMaKH = "KH" + newNumberString.PadLeft(3, '0');
                    }
                    else
                    {
                        newMaKH = "KH001";
                    }

                    string newMaHD = "";
                    var lastHD = context.HoaDonBanHangs.OrderByDescending(nv => nv.MaHD).FirstOrDefault();

                    if (lastHD != null)
                    {
                        string lastMaHD = lastHD.MaHD;
                        // Sử dụng mã nhân viên của nhân viên cuối cùng ở đây
                        string last3Chars = lastMaHD.Substring(Math.Max(0, lastMaHD.Length - 3)); // Lấy 3 ký tự cuối
                        int last3CharsAsNumberHD = int.Parse(last3Chars);
                        last3CharsAsNumberHD++;
                        // Chuyển đổi số thành chuỗi có 3 ký tự
                        string newNumberStringHD = last3CharsAsNumberHD.ToString("D3");

                        // Sử dụng PadLeft để thêm số 0 vào trước nếu cần
                        newMaHD = "HD" + newNumberStringHD.PadLeft(3, '0');
                    }
                    else
                    {
                        newMaHD = "HD001";
                    }
                    if (tbNameCus.Text == null && tbNumberCus.Text == null)
                    {
                        tbNameCus.Text = "Khach hang moi";
                        tbNumberCus.Text = "0999999999";
                    }

                    KhachHang khach = new KhachHang
                    {
                        MaKH = newMaKH,
                        TenKH = tbNameCus.Text,
                        SoDT = tbNumberCus.Text
                    };
                    context.KhachHangs.Add(khach);
                    context.SaveChanges();
                    HoaDonBanHang hoaDon = new HoaDonBanHang
                    {
                        MaHD = newMaHD,
                        NgayDatHang = DateTime.Now,
                        TongSoTien = decimal.Parse(lbMoneyPay.Text),
                        MaNV = DBCurrentLogin.GetCurrentLoginInfo().MaNV,
                        MaKH = newMaKH
                    };
                    context.HoaDonBanHangs.Add(hoaDon);
                    context.SaveChanges();
                    foreach (DataGridViewRow row in gwSellProduct.Rows)
                    {
                        // Kiểm tra xem hàng hiện tại không phải là hàng mới
                        if (!row.IsNewRow)
                        {
                            // Lấy giá trị từ các ô trong hàng
                            string maSP = row.Cells["MaSP"].Value?.ToString();
                            string tenSP = row.Cells["TenSP"].Value?.ToString();
                            string donGia = row.Cells["DonGia"].Value?.ToString();
                            string soLuong = row.Cells["SoLuong"].Value?.ToString();
                            // Tiếp tục xử lý dữ liệu, ví dụ: tạo đối tượng ChiTietHD và thêm vào danh sách
                            ChiTietHD chiTiet = new ChiTietHD
                            {
                                MaHD = newMaHD,
                                MaSP = maSP,
                                DonGia = decimal.Parse(donGia),
                                SoLuongSP = int.Parse(soLuong),
                            };
                            context.ChiTietHDs.Add(chiTiet);
                            context.SaveChanges();
                            // Thực hiện các hành động khác ở đây
                            var sanPham = context.SanPhams.FirstOrDefault(tk => tk.MaSP == (maSP));
                            if (sanPham != null)
                            {
                                sanPham.MaSP = maSP;
                                sanPham.TenSP = tenSP;
                                sanPham.SoLuong = sanPham.SoLuong - int.Parse(soLuong);
                                sanPham.DonGia = decimal.Parse(donGia);
                                // Lưu thay đổi vào cơ sở dữ liệu
                                context.SaveChanges();
                            }
                        }
                    }
                    context.SaveChanges();

                    MessageBox.Show("Thanh toán thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gwSellProduct.Rows.Clear();
                    tbQty.Text = "0";
                    UpdateTotalMoney();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiểm tra lại thông tin!!!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            gwSellProduct.Rows.Clear();
            tbQty.Text = "0";
            UpdateTotalMoney();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                var query = context.SanPhams
                      .Select(s => new { s.MaSP, s.TenSP, s.DonGia, s.SoLuong }); // Chọn các cột MaSP, TenSP, DonGia

                // Thêm các cột vào gwProduct và gán dữ liệu từ query vào các cột tương ứng
                gwProduct.Columns.Add("MaSP", "Mã Sản Phẩm");
                gwProduct.Columns["MaSP"].DataPropertyName = "MaSP";

                gwProduct.Columns.Add("TenSP", "Tên Sản Phẩm");
                gwProduct.Columns["TenSP"].DataPropertyName = "TenSP";

                gwProduct.Columns.Add("DonGia", "Đơn Giá");
                gwProduct.Columns["DonGia"].DataPropertyName = "DonGia";
                gwProduct.Columns.Add("SoLuong", "Số lượng");
                gwProduct.Columns["SoLuong"].DataPropertyName = "SoLuong";

                // Gán dữ liệu từ query vào gwProduct.DataSource
                gwProduct.DataSource = query.ToList();
            }
        }

        private void gwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem ô đã được chọn có phải là một hàng không và hàng đó có dữ liệu không
            if (e.RowIndex >= 0 && e.RowIndex < gwProduct.Rows.Count)
            {
                if (gwSellProduct.Columns.Count == 0)
                {
                    gwSellProduct.Columns.Add("MaSP", "Mã Sản Phẩm");
                    gwSellProduct.Columns.Add("TenSP", "Tên Sản Phẩm");
                    gwSellProduct.Columns.Add("DonGia", "Đơn Giá");
                    gwSellProduct.Columns.Add("SoLuong", "Số Lượng"); // Thêm cột số lượng
                }
                // Lấy ra dữ liệu từ ô được chọn trong gwProduct
                DataGridViewRow selectedRow = gwProduct.Rows[e.RowIndex];

                // Kiểm tra xem dữ liệu đã tồn tại trong gwSellProduct hay chưa
                bool existed = false;
                foreach (DataGridViewRow row in gwSellProduct.Rows)
                {
                    // Kiểm tra xem các giá trị không phải null trước khi sử dụng ToString()
                    if (row.Cells["MaSP"].Value != null && selectedRow.Cells["MaSP"].Value != null &&
                        row.Cells[0].Value.ToString().Contains(selectedRow.Cells[0].Value.ToString()))
                    {
                        // Nếu dữ liệu đã tồn tại, tăng giá trị của cột "Số lượng" lên 1 và thoát khỏi vòng lặp
                        int quantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        row.Cells["SoLuong"].Value = quantity + 1;
                        existed = true;
                        tbQty.Text = (quantity + 1).ToString(); // Hiển thị số lượng tương ứng vào tbQty
                        break;
                    }
                }

                // Nếu dữ liệu chưa tồn tại, thêm một hàng mới vào gwSellProduct
                if (!existed)
                {
                    gwSellProduct.Rows.Add(selectedRow.Cells["MaSP"].Value,
                                            selectedRow.Cells["TenSP"].Value,
                                            selectedRow.Cells["DonGia"].Value,
                                            1); // Số lượng mặc định bằng 1
                    tbQty.Text = "1"; // Hiển thị số lượng mặc định vào tbQty
                }
            }
            UpdateTotalMoney();
        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            /*// Kiểm tra xem tbQty có rỗng hay không
            if (!string.IsNullOrEmpty(tbQty.Text))
            {
                int newQuantity = int.Parse(tbQty.Text);
                if (newQuantity >= 0)
                {
                    // Lấy chỉ số hàng đang được chọn trong gwSellProduct (nếu có)
                    int selectedRowIndex = gwSellProduct.CurrentRow.Index;
                    if (selectedRowIndex >= 0)
                    {
                        // Cập nhật giá trị của cột "SoLuong" trong hàng đang được chọn
                        //gwSellProduct.Rows[selectedRowIndex].Cells["SoLuong"].Value = newQuantity;

                        // Nếu giá trị số lượng là 0, xóa hàng đó ra khỏi gwSellProduct
                        if (newQuantity == 0)
                        {
                            gwSellProduct.Rows.RemoveAt(selectedRowIndex);
                        }
                    }
                }
            }*/
            if (gwSellProduct.SelectedRows.Count > 0)
            {
                // Lấy chỉ số hàng đầu tiên được chọn
                int selectedRowIndex = gwSellProduct.SelectedRows[0].Index;
                string ma = gwSellProduct.Rows[selectedRowIndex].Cells["MaSP"].Value.ToString();
                using (var context = new DBGroceryContext())
                {
                    var q = context.SanPhams.Select(s => new { s.MaSP, s.SoLuong }).Where(c => c.MaSP.Contains(ma)).FirstOrDefault();
                    if (int.Parse(gwSellProduct.Rows[selectedRowIndex].Cells["SoLuong"].Value.ToString()) > q.SoLuong)
                    {
                        MessageBox.Show("Số lượng vượt quá số lượng tồn!!!");
                        tbQty.Text = q.SoLuong.ToString();
                    }
                    else
                    {
                        // Kiểm tra xem chỉ số hàng hợp lệ và giá trị trong tbQty có chứa trong cột "SoLuong" không
                        if (selectedRowIndex >= 0 && gwSellProduct.Rows[selectedRowIndex].Cells["SoLuong"].Value.ToString() != tbQty.Text)
                        {
                            // Cập nhật giá trị của cột "SoLuong" trong hàng được chọn
                            gwSellProduct.Rows[selectedRowIndex].Cells["SoLuong"].Value = tbQty.Text;
                        }
                    }
                }

            }
            UpdateTotalMoney();
        }

        private void gwSellProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            if (gwProduct.Rows.Count > 0)
            {
                // Lấy chỉ số hàng đang được chọn trong gwSellProduct(nếu có)
                int selectedRowIndex = gwSellProduct.CurrentCell?.RowIndex ?? -1;
                if (selectedRowIndex >= 0)
                {
                    // Kiểm tra xem hàng đang chọn có phải là hàng mới không
                    if (!gwSellProduct.Rows[selectedRowIndex].IsNewRow)
                    {
                        // Nếu không phải là hàng mới, thực hiện việc xóa
                        gwSellProduct.Rows.RemoveAt(selectedRowIndex);
                        UpdateTotalMoney();
                    }
                    else
                    {
                        // Nếu là hàng mới, bạn có thể xử lý hoặc bỏ qua tùy theo yêu cầu của ứng dụng
                        // Ví dụ:
                        MessageBox.Show("Thêm tối thiểu 1 sản phẩm!");
                    }
                }

            }
        }

        private void gwProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gwSellProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void gwSellProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //// Kiểm tra xem sự thay đổi có xảy ra trong cột "Đơn giá" hoặc cột "Số lượng" không
            //if (e.ColumnIndex == gwSellProduct.Columns["DonGia"].Index || e.ColumnIndex == gwSellProduct.Columns["SoLuong"].Index)
            //{
            //    UpdateTotalMoney();
            //}
        }

        private void UpdateTotalMoney()
        {
            double totalMoney = 0;
            foreach (DataGridViewRow row in gwSellProduct.Rows)
            {
                // Lấy giá trị từ cột "DonGia" và "SoLuong" bằng cách sử dụng chỉ mục cột
                if (row.Cells[2].Value != null && row.Cells[3].Value != null)
                {
                    double price = Convert.ToDouble(row.Cells[2].Value);

                    if (row.Cells[3].Value != null)
                    {
                        // Kiểm tra xem giá trị của ô có phải là một số nguyên hợp lệ hay không
                        if (int.TryParse(row.Cells[3].Value.ToString(), out int quantity))
                        {
                            quantity = Convert.ToInt32(row.Cells[3].Value);
                            totalMoney += price * quantity;
                        }
                        else
                        {
                            quantity = Convert.ToInt32(1);
                            totalMoney += price * quantity;
                        }
                    }
                    // Tính tổng tiền

                }
            }
            lbMoneyPay.Text = totalMoney.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    string searchText = tbSearch.Text.Trim();

                    // Lấy danh sách sản phẩm từ database dựa trên điều kiện tìm kiếm
                    var products = context.SanPhams.Select(s => new { s.MaSP, s.TenSP, s.DonGia, s.SoLuong }).Where(p => p.TenSP.Contains(searchText)).ToList();

                    // Xóa dữ liệu hiện có trong DataGridView trước khi thêm dữ liệu mới
                    gwProduct.DataSource = null;

                    // Thêm dữ liệu mới từ products vào DataGridView
                    gwProduct.DataSource = products;
                }
                catch (Exception)
                {
                    MessageBox.Show("Tải dữ liệu không thành công!!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gwSellProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (gwSellProduct.SelectedRows.Count > 0)
            {
                // Kiểm tra và thực hiện hành động tương ứng
                if (gwSellProduct.SelectedRows.Count > 0)
                {
                    // Lấy chỉ số hàng đầu tiên được chọn
                    int selectedRowIndex = gwSellProduct.SelectedRows[0].Index;

                    // Kiểm tra và thực hiện hành động tương ứng
                    if (selectedRowIndex >= 0)
                    {
                        // Kiểm tra xem ô "SoLuong" của hàng đó có giá trị không
                        DataGridViewCell cell = gwSellProduct.Rows[selectedRowIndex].Cells["SoLuong"];
                        if (cell.Value != null)
                        {
                            tbQty.Text = cell.Value.ToString();
                        }
                        else
                        {
                            // Xử lý trường hợp giá trị là null (nếu cần)
                        }
                    }
                }
            }
        }

        private void lbMoneyPay_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
