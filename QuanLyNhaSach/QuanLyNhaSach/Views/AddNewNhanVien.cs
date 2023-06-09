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
    public partial class AddNewNhanVien : Form
    {
        public AddNewNhanVien()
        {
            InitializeComponent();
        }

        BookstoreBussiness bs = new BookstoreBussiness();

        private void btn_SaveNV_Click(object sender, EventArgs e)
        {
            int kq = bs.insertNhanVien(txt_MaNV.Text, txt_TenNV.Text, dT_ngaySinhNV.Value, txt_DiaChi.Text, txt_SDT.Text, cB_LoginAccount.SelectedValue.ToString());

            Ultilities.showDialogNotice(kq, "Thêm Nhân Viên", "Nhân Viên Đã tồn tại !");
        }

        private void AddNewNhanVien_Load(object sender, EventArgs e)
        {
            cB_LoginAccount.DataSource = bs.loadDataTaiKhoan();
            cB_LoginAccount.DisplayMember = "TENTK";
            cB_LoginAccount.ValueMember = "MATK";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
