using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.Bussiness;
using QuanLyNhaSach.Extensions;

namespace QuanLyNhaSach
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btn_Login;
        }

        public static string lastname = string.Empty;
        public static string maNV = string.Empty;
        public static int quyen = -1;

        BookstoreBussiness bs = new BookstoreBussiness();

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();
            if(bs.checkLoginAccount(username, password, ref lastname, ref maNV, out quyen))
            {
                Dashboard f = new Dashboard();
                f.Show();
                Ultilities.maNV = maNV;
                this.Hide();
            }
            else {
                MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Sai !"+Environment.NewLine+"Vui lòng kiểm tra lại.", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn chắc chắn muốn hủy đăng nhập ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
