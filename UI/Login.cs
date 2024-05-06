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
    public partial class Login : Form
    {
        int i;
        public Login()
        {
            i = 0;
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (i == 0)
            {
                tbPassword.PasswordChar = '*';
                btnHide.Image = UI.Properties.Resources.hide;
                i++;
            }
            else
            {
                tbPassword.PasswordChar = '\0';
                btnHide.Image = UI.Properties.Resources.view;
                i--;
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string userName = tbUsername.Text;
                string password = tbPassword.Text;
                using (var context = new DBGroceryContext())
                {
                    var tk = context.TaiKhoans
                        .Select(t => new { t.UserName, t.Password, t.Role, t.MaNV })
                        .Where(n => n.UserName.Contains(userName) && n.Password.Contains(password))
                        .FirstOrDefault(); // Lấy một bản ghi đầu tiên nếu có

                    if (tk != null)
                    {
                        DBCurrentLogin.GetCurrentLoginInfo().UserName = userName;
                        DBCurrentLogin.GetCurrentLoginInfo().Password = password;
                        DBCurrentLogin.GetCurrentLoginInfo().Role = tk.Role;
                        DBCurrentLogin.GetCurrentLoginInfo().MaNV = tk.MaNV;
                        MainForm mainMenu = new MainForm();
                        this.Hide();
                        // Chuyển các giá trị userName, password, và role sang MainMenu
                        mainMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tải dữ liệu không thành công!!!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
