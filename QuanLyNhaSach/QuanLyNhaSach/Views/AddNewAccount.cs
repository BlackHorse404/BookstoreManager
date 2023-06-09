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
    public partial class AddNewAccount : Form
    {
        public AddNewAccount()
        {
            InitializeComponent();
        }

        BookstoreBussiness bs = new BookstoreBussiness();

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string username = txt_tenTK.Text;
            string password = txt_matkhau.Text;
            int quyen = cB_QuyenHan.SelectedIndex;

            int kq = bs.insertTaiKhoan(username, password, quyen);
            Ultilities.showDialogNotice(kq, "Thêm Tài Khoản " + username + " ", "Tài khoản đã tồn tại !");
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            string[] Quyen = {"Quản Lý", "Kế Toán", "Nhân viên"};
            cB_QuyenHan.Items.AddRange(Quyen);
        }
    }
}
