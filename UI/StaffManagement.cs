using DataAccessLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class StaffManagement : Form
    {
        public StaffManagement()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    string searchText = tbSearch.Text.Trim();

                    // Lấy danh sách sản phẩm từ database dựa trên điều kiện tìm kiếm
                    var values = context.NhanViens
                      .Select(nv => new {
                          nv.MaNV,
                          nv.HoNV,
                          nv.TenNV,
                          nv.NgaySinh,
                          nv.GioiTinh,
                          nv.SoDT,
                          nv.DiaChi,
                          nv.Luong
                      }).Where(p => p.TenNV.Contains(searchText) || p.HoNV.Contains(searchText)).ToList();

                    // Xóa dữ liệu hiện có trong DataGridView trước khi thêm dữ liệu mới
                    gwStaff.DataSource = null;

                    // Thêm dữ liệu mới từ products vào DataGridView
                    gwStaff.DataSource = values;
                }
                catch (Exception)
                {
                    MessageBox.Show("Tải dữ liệu không thành công!!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void RbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                // Vô hiệu hóa RadioButton 2
                rbFemale.Checked = false;
            }
        }

        private void RbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                // Vô hiệu hóa RadioButton 2
                rbMale.Checked = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                var query = context.NhanViens
                      .Select(nv => new {
                          nv.MaNV,
                          nv.HoNV,
                          nv.TenNV,
                          nv.NgaySinh,
                          nv.GioiTinh,
                          nv.SoDT,
                          nv.DiaChi,
                          nv.Luong
                      }); // Chọn các cột MaSP, TenSP, DonGia

                gwStaff.Columns.Add("MaNV", "Mã Nhân Viên");
                gwStaff.Columns["MaNV"].DataPropertyName = "MaNV";

                gwStaff.Columns.Add("HoNV", "Họ");
                gwStaff.Columns["HoNV"].DataPropertyName = "HoNV";

                gwStaff.Columns.Add("TenNV", "Tên");
                gwStaff.Columns["TenNV"].DataPropertyName = "TenNV";

                gwStaff.Columns.Add("NgaySinh", "Ngày Sinh");
                gwStaff.Columns["NgaySinh"].DataPropertyName = "NgaySinh";

                gwStaff.Columns.Add("GioiTinh", "Giới Tính");
                gwStaff.Columns["GioiTinh"].DataPropertyName = "GioiTinh";

                gwStaff.Columns.Add("SoDT", "Số Điện Thoại");
                gwStaff.Columns["SoDT"].DataPropertyName = "SoDT";

                gwStaff.Columns.Add("DiaChi", "Địa Chỉ");
                gwStaff.Columns["DiaChi"].DataPropertyName = "DiaChi";

                gwStaff.Columns.Add("Luong", "Lương");
                gwStaff.Columns["Luong"].DataPropertyName = "Luong";

                // Gán dữ liệu từ query vào gwProduct.DataSource
                gwStaff.DataSource = query.ToList();

                var distinctRoles = context.TaiKhoans
                          .Select(tk => tk.Role)
                          .Distinct()
                          .ToList();
                //Datasource cua Role
                cbRole.DisplayMember = "Role";
                cbRole.ValueMember = "Role";
                cbRole.DataSource = distinctRoles;
            }
        }

        private void gwStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                //var query = context.TaiKhoans
                //      .Select(tk => new {
                //          tk.UserName,
                //          tk.Password,
                //          tk.MaNV,
                //          tk.Role,
                //      }).Where(nv => nv.MaNV.Contains(tbMaNV.Text));


                // Get the value of the "MaNV" cell from the selected row
                string maNV = gwStaff.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                string hoNV = gwStaff.Rows[e.RowIndex].Cells["HoNV"].Value.ToString();
                string tenNV = gwStaff.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
                object ngaySinhObj = gwStaff.Rows[e.RowIndex].Cells["NgaySinh"].Value;
                string ngaySinhStr = ngaySinhObj?.ToString();
                string gioiTinh = gwStaff.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                string soDT = gwStaff.Rows[e.RowIndex].Cells["SoDT"].Value.ToString();
                string diaChi = gwStaff.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                string luong = gwStaff.Rows[e.RowIndex].Cells["Luong"].Value.ToString();

                // Assign the value to the textbox tbMaNV
                tbMaNV.Text = maNV;
                tbHo.Text = hoNV;
                tbTen.Text = tenNV;
                if (DateTime.TryParse(ngaySinhStr, out DateTime ngaySinh))
                {
                    // Assign the parsed DateTime value to the DateTimePicker control
                    dtpDate.Value = ngaySinh;
                }
                if (gioiTinh.Contains("Nam"))
                {
                    rbMale.Checked = true;
                }
                else if (gioiTinh.Contains("Nữ"))
                {
                    rbFemale.Checked = true;
                }
                tbSDT.Text = soDT;
                tbAddress.Text = diaChi;
                tbLuong.Text = luong;
                string maNv = gwStaff.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                var taiKhoan = context.TaiKhoans.FirstOrDefault(tk => tk.MaNV.Contains(maNv));

                // Kiểm tra xem taiKhoan có null hay không trước khi truy cập các thuộc tính của nó
                if (taiKhoan != null)
                {
                    tbUsername.Text = taiKhoan.UserName;
                    tbPassword.Text = taiKhoan.Password;
                    // Các truy cập thuộc tính khác...
                    if (taiKhoan.Role.Contains("staff"))
                    {
                        cbRole.SelectedIndex = 0;
                    }
                    else
                    {
                        cbRole.SelectedIndex = 1;

                    }
                }

            }
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    string newMaNV = "";
                    var lastEmployee = context.NhanViens.OrderByDescending(nv => nv.MaNV).FirstOrDefault();

                    if (lastEmployee != null)
                    {
                        string lastEmployeeMaNV = lastEmployee.MaNV;
                        // Sử dụng mã nhân viên của nhân viên cuối cùng ở đây
                        string last3Chars = lastEmployeeMaNV.Substring(Math.Max(0, lastEmployeeMaNV.Length - 3)); // Lấy 3 ký tự cuối
                        int last3CharsAsNumber = int.Parse(last3Chars);
                        last3CharsAsNumber++;
                        // Chuyển đổi số thành chuỗi có 3 ký tự
                        string newNumberString = last3CharsAsNumber.ToString("D3");

                        // Sử dụng PadLeft để thêm số 0 vào trước nếu cần
                        newMaNV = "NV" + newNumberString.PadLeft(3, '0');
                    }
                    else
                    {
                        newMaNV = "NV001";
                    }
                    string gioiTinh = rbMale.Checked ? "Nam" : "Nữ";
                    NhanVien nhanVien = new NhanVien
                    {
                        MaNV = newMaNV,
                        HoNV = tbHo.Text,
                        TenNV = tbTen.Text,
                        NgaySinh = dtpDate.Value,
                        GioiTinh = gioiTinh,
                        SoDT = tbSDT.Text,
                        DiaChi = tbAddress.Text,
                        Luong = decimal.Parse(tbLuong.Text),
                    };
                    TaiKhoan taiKhoan = new TaiKhoan
                    {
                        UserName = tbUsername.Text,
                        Password = tbPassword.Text,
                        MaNV = newMaNV,
                        Role = cbRole.SelectedItem.ToString(),
                    };
                    context.NhanViens.Add(nhanVien);
                    context.SaveChanges();
                    context.TaiKhoans.Add(taiKhoan);
                    context.SaveChanges();
                    MessageBox.Show("Thêm thông tin thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiểm tra lại thông tin!!!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                var query = context.NhanViens
                  .Select(nv => new
                  {
                      nv.MaNV,
                      nv.HoNV,
                      nv.TenNV,
                      nv.NgaySinh,
                      nv.GioiTinh,
                      nv.SoDT,
                      nv.DiaChi,
                      nv.Luong
                  })
                  .ToList(); // Execute the query and retrieve data into memory

                gwStaff.DataSource = null;
                gwStaff.DataSource = query;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbRole.Text.Contains("sysadmin"))
            {
                MessageBox.Show("Bạn không thể người ngang quyền hạn!!!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int rowIndex = gwStaff.CurrentCell.RowIndex;
                string firstCellValueAsString = "";
                if (rowIndex >= 0 && rowIndex < gwStaff.Rows.Count)
                {
                    // Lấy dòng tương ứng với ô đã chọn
                    DataGridViewRow row = gwStaff.Rows[rowIndex];
                    object firstCellValue = row.Cells[0].Value;

                    // Kiểm tra nếu giá trị không null trước khi sử dụng
                    if (firstCellValue != null)
                    {
                        firstCellValueAsString = firstCellValue.ToString();
                        //MessageBox.Show(firstCellValueAsString);
                    }
                }
                using (var context = new DBGroceryContext())
                {
                    try
                    {
                        // Tìm và lấy ra các tài khoản có tham chiếu đến nhân viên cần xóa
                        var taiKhoansToDelete = context.TaiKhoans.Where(tk => tk.MaNV.Contains(firstCellValueAsString)).ToList();

                        // Xóa các tài khoản có tham chiếu đến nhân viên
                        context.TaiKhoans.RemoveRange(taiKhoansToDelete);

                        // Lưu thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();

                        // Sau đó, bạn có thể tiếp tục xóa nhân viên từ bảng NhanViens
                        var nhanViensToDelete = context.NhanViens.Where(nv => nv.MaNV.Contains(firstCellValueAsString)).ToList();
                        context.NhanViens.RemoveRange(nhanViensToDelete);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Xóa không thành công!!!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = gwStaff.CurrentCell.RowIndex;
            string firstCellValueAsString = "";
            if (rowIndex >= 0 && rowIndex < gwStaff.Rows.Count)
            {
                // Lấy dòng tương ứng với ô đã chọn
                DataGridViewRow row = gwStaff.Rows[rowIndex];
                object firstCellValue = row.Cells[0].Value;

                // Kiểm tra nếu giá trị không null trước khi sử dụng
                if (firstCellValue != null)
                {
                    firstCellValueAsString = firstCellValue.ToString();
                }
            }
            using (var context = new DBGroceryContext())
            {
                try
                {

                    // Tìm và lấy ra các tài khoản có tham chiếu đến nhân viên cần xóa
                    var taiKhoan = context.TaiKhoans.FirstOrDefault(tk => tk.MaNV == firstCellValueAsString);
                    if (taiKhoan != null)
                    {
                        taiKhoan.UserName = tbUsername.Text;
                        taiKhoan.Password = tbPassword.Text;
                        taiKhoan.Role = cbRole.SelectedItem.ToString();

                        // Lưu thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();
                    }
                    // Xóa các tài khoản có tham chiếu đến nhân viên
                    string gioiTinh = rbMale.Checked ? "Nam" : "Nữ";
                    // Sau đó, bạn có thể tiếp tục xóa nhân viên từ bảng NhanViens
                    var nhanVien = context.NhanViens.FirstOrDefault(nv => nv.MaNV == firstCellValueAsString);
                    if (nhanVien != null)
                    {
                        nhanVien.HoNV = tbHo.Text;
                        nhanVien.TenNV = tbTen.Text;
                        nhanVien.NgaySinh = dtpDate.Value;
                        nhanVien.GioiTinh = gioiTinh;
                        nhanVien.SoDT = tbSDT.Text;
                        nhanVien.DiaChi = tbAddress.Text;
                        nhanVien.Luong = decimal.Parse(tbLuong.Text);
                        context.SaveChanges();
                    }
                    context.SaveChanges();
                    MessageBox.Show("Sửa thông tin thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Sửa không thành công!!!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
