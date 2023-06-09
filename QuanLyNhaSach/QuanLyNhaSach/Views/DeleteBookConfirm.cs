using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyNhaSach.Models;
using QuanLyNhaSach.Bussiness;
using QuanLyNhaSach.Extensions;
using System.IO;

namespace QuanLyNhaSach
{
    public partial class DeleteBookConfirm : Form
    {
        public DeleteBookConfirm()
        {
            InitializeComponent();
            txt_MoTa.Enter += (s, e) => { txt_MoTa.Parent.Focus(); };
        }

        public string maSach { get; set; }
        public string maPhieu { get; set; }

        BookstoreBussiness bs = new BookstoreBussiness();

        private void addValueToInfoBook(BookDetails_Model t)
        {
            lb_ms.Text = t.maSach.Trim();
            lb_ts.UseMnemonic = false; lb_ts.Text = t.tenSach.Trim();
            txt_MoTa.Text = t.moTa.Trim();
            lb_TheLoai.Text = t.theLoai.Trim();
            lb_TacGia.Text = t.tacGia.Trim();
            lb_NXB.Text = t.nxb.Trim();
            lb_GiaSach.Text = string.Format("{0:0,0} VNĐ", t.giaSach);
            lb_SoLuongTonKho.Text = t.slTon.ToString().Trim();
            try
            {
                string path = Path.GetFullPath(@"./../../AnhBia/" + t.anhBia.Trim());
                pictureBox.Image = Image.FromFile(path);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message + " Not found !");
            }
            txt_MoTa.SelectionStart = 0;

        }
        private void DeleteBookConfirm_Load(object sender, EventArgs e)
        {
            BookDetails_Model t = bs.loadInfoBookDetails(maSach);
            addValueToInfoBook(t);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhanXoa_Click(object sender, EventArgs e)
        {
            int kq = bs.deleteSachFromTable(maSach);
            Ultilities.showDialogNotice(kq, "Xóa", "Xóa Không thành công !");
            this.Close();
        }
    }
}
