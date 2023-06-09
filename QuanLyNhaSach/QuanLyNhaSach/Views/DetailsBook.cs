using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.Bussiness;
using QuanLyNhaSach.Models;
using System.IO;

namespace QuanLyNhaSach
{
    public partial class DetailsBook : Form
    {
        public DetailsBook()
        {
            InitializeComponent();
            txt_MoTa.Enter += (s, e) => { txt_MoTa.Parent.Focus(); };
        }

        public string maSachDetails { get; set; }

        private BookstoreBussiness bs = new BookstoreBussiness();

        private void addValueToInfoBook(BookDetails_Model t)
        {
            if(t != null)
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
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + " Not found !");
                }
                txt_MoTa.SelectionStart = 0;
            }
        }

        private void DetailsBook_Load(object sender, EventArgs e)
        {
            this.TableInfoSach.Padding = new Padding(0, 5, 0, 0);
            BookDetails_Model t = bs.loadInfoBookDetails(maSachDetails);
            addValueToInfoBook(t);
        }
    }
}
