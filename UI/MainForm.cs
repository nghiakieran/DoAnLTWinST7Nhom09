using BusinessAccessLayer;
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

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            timer1.Start();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(childForm);
            pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var context = new DBGroceryContext())
            {
                string ma = DBCurrentLogin.GetCurrentLoginInfo().MaNV;
                var nhanVien = context.NhanViens
                    .Select(nv => new { nv.MaNV, nv.HoNV, nv.TenNV })
                    .Where(p => p.MaNV.Contains(ma)).FirstOrDefault();
                lbName.Text = nhanVien.HoNV + " " + nhanVien.TenNV;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Provider());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductManagement());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (DBCurrentLogin.GetCurrentLoginInfo().Role.Contains("sysadmin"))
            {
                OpenChildForm(new StaffManagement());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Menu());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
