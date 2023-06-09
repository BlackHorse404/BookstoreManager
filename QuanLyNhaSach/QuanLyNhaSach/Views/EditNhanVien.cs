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
    public partial class EditNhanVien : Form
    {
        public EditNhanVien()
        {
            InitializeComponent();
        }
        public string maNhanVien { get; set; }

        BookstoreBussiness bs = new BookstoreBussiness();

        private void EditNhanVien_Load(object sender, EventArgs e)
        {
            cB_LoginAccount.DataSource = bs.loadDataTaiKhoan();
            cB_LoginAccount.DisplayMember = "TENTK";
            cB_LoginAccount.ValueMember = "MATK";

            DataTable t = bs.loadDataNhanVienBy(maNhanVien);
            DataTable acc = bs.loadDataTaiKhoan();
            if (t != null)
            {
                txt_MaNV.Text = t.Rows[0]["MANV"].ToString();
                txt_TenNV.Text = t.Rows[0]["TENNV"].ToString();
                txt_SDT.Text = t.Rows[0]["SDT"].ToString();
                txt_DiaChi.Text = t.Rows[0]["DIACHI"].ToString();
                dT_ngaySinhNV.Value = DateTime.Parse(t.Rows[0]["NGAYSINH"].ToString());
                cB_LoginAccount.SelectedIndex = Ultilities.getIndexFromDataTable(acc, "MATK", t.Rows[0]["MATK"].ToString());
            }
        }

        private void btn_CancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SaveNV_Click(object sender, EventArgs e)
        {
            int kq = bs.updateNhanVien(maNhanVien, txt_TenNV.Text, dT_ngaySinhNV.Value, txt_DiaChi.Text, txt_SDT.Text, cB_LoginAccount.SelectedValue.ToString());

            Ultilities.showDialogNotice(kq, "Sửa Thông Tin NV", "Sửa không thành công !");
        }
    }
}
