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
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        public string tenTK { get; set; }
        BookstoreBussiness bs = new BookstoreBussiness();

        private void btn_SaveTK_Click(object sender, EventArgs e)
        {
            int kq = bs.updateTaiKhoan(txt_MaTK.Text, tenTK, txt_Password.Text, cB_Quyen.SelectedIndex);
            Ultilities.showDialogNotice(kq, "Sửa Thông Tin Tài Khoản", "Sửa không thành công !");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            cB_Quyen.Items.AddRange(new string[] {"Quản Lý", "Kế Toán","Nhân Viên"});

            DataTable t = bs.loadDataTaiKhoanBy(tenTK);
            txt_MaTK.Text = t.Rows[0]["MATK"].ToString();
            txt_username.Text = tenTK;
            txt_Password.Text = t.Rows[0]["MATKHAU"].ToString();
            cB_Quyen.SelectedIndex = int.Parse(t.Rows[0]["QUYEN"].ToString());
        }
    }
}
