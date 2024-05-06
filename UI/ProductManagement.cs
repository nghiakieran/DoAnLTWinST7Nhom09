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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
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

        private void btnSearchPro_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    string searchText = tbSearchProduct.Text.Trim();

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

        private void gwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gwProduct.Rows.Count)
            {
                tbMaSP.Text = gwProduct.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                tbName.Text = gwProduct.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
                tbPrice.Text = gwProduct.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                tbQty.Text = gwProduct.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            }
        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    string newMaSP = "";
                    var lastSP = context.SanPhams.OrderByDescending(nv => nv.MaSP).FirstOrDefault();

                    if (lastSP != null)
                    {
                        string lastMaSP = lastSP.MaSP;
                        // Sử dụng mã nhân viên của nhân viên cuối cùng ở đây
                        string last3Chars = lastMaSP.Substring(Math.Max(0, lastMaSP.Length - 3)); // Lấy 3 ký tự cuối
                        int last3CharsAsNumber = int.Parse(last3Chars);
                        last3CharsAsNumber++;
                        // Chuyển đổi số thành chuỗi có 3 ký tự
                        string newNumberString = last3CharsAsNumber.ToString("D3");

                        // Sử dụng PadLeft để thêm số 0 vào trước nếu cần
                        newMaSP = "SP" + newNumberString.PadLeft(3, '0');
                    }
                    else
                    {
                        newMaSP = "SP001";
                    }
                    SanPham sanPham = new SanPham
                    {
                        MaSP = newMaSP,
                        TenSP = tbName.Text.Trim(),
                        DonGia = decimal.Parse(tbPrice.Text.Trim()),
                        SoLuong = int.Parse(tbQty.Text.Trim())
                    };
                    context.SanPhams.Add(sanPham);
                    context.SaveChanges();
                    MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiểm tra lại thông tin, có thể trùng tên sản phẩm!!!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                var query = context.SanPhams
                      .Select(s => new { s.MaSP, s.TenSP, s.DonGia, s.SoLuong });

                // Gán dữ liệu từ query vào gwProduct.DataSource
                gwProduct.DataSource = query.ToList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    string ma = tbMaSP.Text.Trim();
                    var sp = context.SanPhams
                                    .Where(s => s.MaSP.Contains(ma))
                                    .FirstOrDefault();
                    if (sp != null)
                    {
                        sp.TenSP = tbName.Text.Trim();
                        sp.SoLuong = int.Parse(tbQty.Text.Trim());
                        sp.DonGia = decimal.Parse(tbPrice.Text.Trim());
                    }
                    context.SaveChanges();
                    MessageBox.Show("Sửa thông tin thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Sửa không thành công!!!" + " " + ex, "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
