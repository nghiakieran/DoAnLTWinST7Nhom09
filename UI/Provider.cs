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
    public partial class Provider : Form
    {
        public Provider()
        {
            InitializeComponent();
        }

        private void Provider_Load(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                var query = context.SanPhams
                      .Select(s => new { s.MaSP, s.TenSP, s.DonGia, s.SoLuong }); // Chọn các cột MaSP, TenSP, DonGia

                // Thêm các cột vào gwProduct và gán dữ liệu từ query vào các cột tương ứng
                gwProProvider.Columns.Add("MaSP", "Mã Sản Phẩm");
                gwProProvider.Columns["MaSP"].DataPropertyName = "MaSP";

                gwProProvider.Columns.Add("TenSP", "Tên Sản Phẩm");
                gwProProvider.Columns["TenSP"].DataPropertyName = "TenSP";

                gwProProvider.Columns.Add("DonGia", "Đơn Giá");
                gwProProvider.Columns["DonGia"].DataPropertyName = "DonGia";

                gwProProvider.Columns.Add("SoLuong", "Số lượng");
                gwProProvider.Columns["SoLuong"].DataPropertyName = "SoLuong";

                // Gán dữ liệu từ query vào gwProduct.DataSource
                gwProProvider.DataSource = query.ToList();

                var nhaCC = context.NhaCungCaps.Select(ncc => ncc.TenNCC).ToList();
                cbNCC.DisplayMember = "TenNCC";
                cbNCC.DataSource = nhaCC;
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            ProviderDetails providerDetails = new ProviderDetails();
            providerDetails.Show();
        }

        private void gwProProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem ô đã được chọn có phải là một hàng không và hàng đó có dữ liệu không
            if (e.RowIndex >= 0 && e.RowIndex < gwProProvider.Rows.Count)
            {
                if (gwProvider.Columns.Count == 0)
                {
                    gwProvider.Columns.Add("MaSP", "Mã Sản Phẩm");
                    gwProvider.Columns.Add("TenSP", "Tên Sản Phẩm");
                    gwProvider.Columns.Add("DonGia", "Đơn Giá");
                    gwProvider.Columns.Add("SoLuong", "Số Lượng"); // Thêm cột số lượng
                }
                // Lấy ra dữ liệu từ ô được chọn trong gwProduct
                DataGridViewRow selectedRow = gwProProvider.Rows[e.RowIndex];

                // Kiểm tra xem dữ liệu đã tồn tại trong gwSellProduct hay chưa
                bool existed = false;
                foreach (DataGridViewRow row in gwProvider.Rows)
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
                    gwProvider.Rows.Add(selectedRow.Cells["MaSP"].Value,
                                            selectedRow.Cells["TenSP"].Value,
                                            selectedRow.Cells["DonGia"].Value,
                                            1); // Số lượng mặc định bằng 1
                    tbQty.Text = "1"; // Hiển thị số lượng mặc định vào tbQty
                }
            }
            UpdateTotalMoney();
        }
        private void UpdateTotalMoney()
        {
            double totalMoney = 0;
            foreach (DataGridViewRow row in gwProvider.Rows)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            if (gwProvider.SelectedRows.Count > 0)
            {
                // Lấy chỉ số hàng đầu tiên được chọn
                int selectedRowIndex = gwProvider.SelectedRows[0].Index;

                // Kiểm tra xem chỉ số hàng hợp lệ và giá trị trong tbQty có chứa trong cột "SoLuong" không
                if (selectedRowIndex >= 0 && gwProvider.Rows[selectedRowIndex].Cells["SoLuong"].Value != null
                    && gwProvider.Rows[selectedRowIndex].Cells["SoLuong"].Value.ToString() != tbQty.Text)
                {
                    // Cập nhật giá trị của cột "SoLuong" trong hàng được chọn
                    gwProvider.Rows[selectedRowIndex].Cells["SoLuong"].Value = tbQty.Text;
                }

            }
            UpdateTotalMoney();
        }

        private void gwProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gwProvider_SelectionChanged(object sender, EventArgs e)
        {
            if (gwProvider.SelectedRows.Count > 0)
            {
                // Kiểm tra và thực hiện hành động tương ứng
                if (gwProvider.SelectedRows.Count > 0)
                {
                    // Lấy chỉ số hàng đầu tiên được chọn
                    int selectedRowIndex = gwProvider.SelectedRows[0].Index;

                    // Kiểm tra và thực hiện hành động tương ứng
                    if (selectedRowIndex >= 0)
                    {
                        // Kiểm tra xem ô "SoLuong" của hàng đó có giá trị không
                        DataGridViewCell cell = gwProvider.Rows[selectedRowIndex].Cells["SoLuong"];
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

        private void btnReloadProvider_Click(object sender, EventArgs e)
        {
            gwProvider.Rows.Clear();
            tbQty.Text = "0";
            UpdateTotalMoney();
        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    string newPN = "";
                    var lastPN = context.HoaDonNhapHangs.OrderByDescending(nv => nv.MaPhieu).FirstOrDefault();

                    if (lastPN != null)
                    {
                        string lastMaPN = lastPN.MaPhieu;
                        // Sử dụng mã nhân viên của nhân viên cuối cùng ở đây
                        string last3Chars = lastMaPN.Substring(Math.Max(0, lastMaPN.Length - 3)); // Lấy 3 ký tự cuối
                        int last3CharsAsNumber = int.Parse(last3Chars);
                        last3CharsAsNumber++;
                        // Chuyển đổi số thành chuỗi có 3 ký tự
                        string newNumberString = last3CharsAsNumber.ToString("D3");

                        // Sử dụng PadLeft để thêm số 0 vào trước nếu cần
                        newPN = "HDNH" + newNumberString.PadLeft(3, '0');
                    }
                    else
                    {
                        newPN = "HDNH001";
                    }
                    var nhacc = context.NhaCungCaps.Select(ncc => new { ncc.MaNCC, ncc.TenNCC }).Where(c => c.TenNCC.Contains(cbNCC.Text)).FirstOrDefault();
                    HoaDonNhapHang hoaDonNhapHang = new HoaDonNhapHang
                    {
                        MaPhieu = newPN,
                        NgayNhap = DateTime.Now,
                        TongTienDonNhap = decimal.Parse(lbMoneyPay.Text),
                        MaNV = DBCurrentLogin.GetCurrentLoginInfo().MaNV,
                        MaNCC = nhacc.MaNCC,
                    };
                    context.HoaDonNhapHangs.Add(hoaDonNhapHang);
                    context.SaveChanges();
                    foreach (DataGridViewRow row in gwProvider.Rows)
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
                            ChiTietPhieuNhap chiTiet = new ChiTietPhieuNhap
                            {
                                MaPhieu = newPN,
                                MaSP = maSP,
                                DonGia = decimal.Parse(donGia),
                                SoLuong = int.Parse(soLuong),
                            };
                            context.ChiTietPhieuNhaps.Add(chiTiet);
                            context.SaveChanges();
                            // Thực hiện các hành động khác ở đây
                            var sanPham = context.SanPhams.FirstOrDefault(tk => tk.MaSP == (maSP));
                            if (sanPham != null)
                            {
                                sanPham.MaSP = maSP;
                                sanPham.TenSP = tenSP;
                                sanPham.SoLuong = sanPham.SoLuong + int.Parse(soLuong);
                                sanPham.DonGia = decimal.Parse(donGia);
                                // Lưu thay đổi vào cơ sở dữ liệu
                                context.SaveChanges();
                            }
                        }
                    }
                    context.SaveChanges();

                    MessageBox.Show("Thêm phiếu nhập thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gwProvider.Rows.Clear();
                    tbQty.Text = "0";
                    UpdateTotalMoney();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiểm tra lại thông tin!!!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbSearchProvider_TextChanged(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    string searchText = tbSearchProvider.Text.Trim();

                    // Lấy danh sách sản phẩm từ database dựa trên điều kiện tìm kiếm
                    var products = context.SanPhams.Select(s => new { s.MaSP, s.TenSP, s.DonGia, s.SoLuong }).Where(p => p.TenSP.Contains(searchText)).ToList();

                    // Xóa dữ liệu hiện có trong DataGridView trước khi thêm dữ liệu mới
                    gwProProvider.DataSource = null;

                    // Thêm dữ liệu mới từ products vào DataGridView
                    gwProProvider.DataSource = products;
                }
                catch (Exception)
                {
                    MessageBox.Show("Tải dữ liệu không thành công!!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
