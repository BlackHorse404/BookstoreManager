using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.Bussiness;

namespace QuanLyNhaSach
{
    public partial class QLDoanhThu : Form
    {
        public QLDoanhThu()
        {
            InitializeComponent();
        }

        BookstoreBussiness bs = new BookstoreBussiness();

        private void loadDataGridView(DataTable table)
        {
            if(dataGridView_HoaDon.Rows.Count != 0)
            {
                dataGridView_HoaDon.DataSource = null;
                dataGridView_HoaDon.Rows.Clear();
                dataGridView_HoaDon.Columns.Clear();
            }
            dataGridView_HoaDon.DataSource = table;

            dataGridView_HoaDon.Columns["TENSACH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_HoaDon.Columns["TENKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void QLDoanhThu_Load(object sender, EventArgs e)
        {
            txt_TongTien.Text = bs.SumMoney().ToString("#,0") + " VNĐ";
            loadDataGridView(bs.loadDataHoaDonDetails());
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            txt_TongTien.Text = bs.SumMoneyByDate(date).ToString("#,0") + " VNĐ";

            loadDataGridView(bs.loadDataHoaDonDetailsByDate(date));
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_TongTien.Text = bs.SumMoney().ToString("#,0") + " VNĐ";
            loadDataGridView(bs.loadDataHoaDonDetails());
        }

        private void btn_exportReport_Click(object sender, EventArgs e)
        {
            FrmReportDoanhThu f = new FrmReportDoanhThu();
            f.printReport();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            FrmReportDoanhThu F = new FrmReportDoanhThu();
            F.ShowDialog();
        }

        private void dataGridView_HoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView_HoaDon.Rows.Count - 1; i++)
            {
                int sl = int.Parse(dataGridView_HoaDon.Rows[i].Cells["SOLUONG"].Value.ToString());
                if (sl >= 10 && sl < 20)
                {
                    dataGridView_HoaDon.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridView_HoaDon.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView_HoaDon.Rows[i].DefaultCellStyle.Font = new Font("Arial", 9.0f, FontStyle.Bold);
                }
                else if(sl >= 20 && sl < 50)
                {
                    dataGridView_HoaDon.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridView_HoaDon.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView_HoaDon.Rows[i].DefaultCellStyle.Font = new Font("Arial", 9.0f, FontStyle.Bold);
                }
                else if (sl >= 50)
                {
                    dataGridView_HoaDon.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    dataGridView_HoaDon.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView_HoaDon.Rows[i].DefaultCellStyle.Font = new Font("Arial", 9.0f, FontStyle.Bold);
                }
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            FrmHelp_ChuThichDoanhThu f = new FrmHelp_ChuThichDoanhThu();
            f.ShowDialog();
        }
    }
}
