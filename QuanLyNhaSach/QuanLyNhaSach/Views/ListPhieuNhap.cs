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
    public partial class ListPhieuNhap : Form
    {
        public ListPhieuNhap()
        {
            InitializeComponent();
        }

        BookstoreBussiness bs = new BookstoreBussiness();

        private string getSelectedKeyOfObject(DataGridView t)
        {
            try
            {
                string ms = null;
                int index = t.SelectedCells[0].OwningRow.Index;
                if (t.Rows[index].Cells["MAPN"].Value == null)
                    throw new Exception("Err");
                ms = t.Rows[index].Cells["MAPN"].Value.ToString();
                return ms;
            }
            catch (Exception err)
            {
                MessageBox.Show("Không tìm thấy thông tin sách phù hợp !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ListPhieuNhap_Load(object sender, EventArgs e)
        {
            dataGV_DSPhieuNhap.DataSource = bs.loadDataForListPhieuNhap();
            //rename
            dataGV_DSPhieuNhap.Columns["MAPN"].HeaderText = "Mã Phiếu";
            dataGV_DSPhieuNhap.Columns["NGAYNHAP"].HeaderText = "Ngày Nhập Sách";
            dataGV_DSPhieuNhap.Columns["MANV"].HeaderText = "Mã Nhân Viên";
            //auto resize
            dataGV_DSPhieuNhap.Columns["MAPN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGV_DSPhieuNhap.Columns["NGAYNHAP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            DetailsPhieuNhap f = new DetailsPhieuNhap();
            f.maPhieu = getSelectedKeyOfObject(dataGV_DSPhieuNhap);
            f.ShowDialog();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            FrmReportPhieuNhap f = new FrmReportPhieuNhap();
            f.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //sua gia sach, so luong nhap
            EditListPhieuNhap f = new EditListPhieuNhap();
            f.maPhieu = dataGV_DSPhieuNhap.CurrentRow.Cells["MAPN"].Value.ToString();
            f.ShowDialog();
        }
    }
}
