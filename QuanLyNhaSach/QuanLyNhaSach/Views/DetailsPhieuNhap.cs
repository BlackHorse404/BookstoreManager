using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Bussiness;

namespace QuanLyNhaSach
{
    public partial class DetailsPhieuNhap : Form
    {
        public DetailsPhieuNhap()
        {
            InitializeComponent();
            txt_TenSach.Enter += (s, e) => { txt_TenSach.Parent.Focus(); };
            txt_SoLuong.Enter += (s, e) => { txt_SoLuong.Parent.Focus(); };
        }

        public string maPhieu { get; set; }
        BookstoreBussiness bs = new BookstoreBussiness();

        private void DetailsPhieuNhap_Load(object sender, EventArgs e)
        {
            try
            {
                string newline = Environment.NewLine;
                DataTable t = bs.loadDataPhieuNhapByMaPhieu(maPhieu);
                lb_MaPhieu.Text = t.Rows[0]["MAPN"].ToString();
                lb_ngay.Text = DateTime.Parse(t.Rows[0]["NGAYNHAP"].ToString()).ToString("d");
                lb_TenNV.Text = t.Rows[0]["TENNV"].ToString();
                foreach (DataRow r in t.Rows)
                {
                    txt_TenSach.Text += r["TENSACH"].ToString() + newline + newline;
                    txt_SoLuong.Text += r["SOLUONG"].ToString() + newline + newline;
                }
            }
            catch
            {

            }
            
        }
    }
}
