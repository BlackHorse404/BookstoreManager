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
    public partial class ListBook : Form
    {
        public ListBook()
        {
            InitializeComponent();
        }

        public string MaNhanVien { get; set; }

        BookstoreBussiness bs = new BookstoreBussiness();
        public void loadDataIntoGridView()
        {
            if(dataGV_DSSach != null)
            {
                dataGV_DSSach.DataSource = null;
                dataGV_DSSach.Rows.Clear();
                dataGV_DSSach.Columns.Clear();
            }
            DataTable TDSsach = bs.loadDataForListBook();

            dataGV_DSSach.DataSource = TDSsach;
            dataGV_DSSach.Columns["TENSACH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGV_DSSach.Columns["TENNXB"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGV_DSSach.Columns["TENTL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGV_DSSach.Columns["TENTG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            int sl = dataGV_DSSach.Rows.Count - 1;
            lb_TongSLSach.Text = "Số Lượng Sách: " + (sl < 0 ? 0 : sl).ToString();

            dataGV_DSSach.Refresh();
            dataGV_DSSach.Update();
        }
        private string getSelectedMaSach()
        {
            try
            {
                string ms = null;
                int index = dataGV_DSSach.SelectedCells[0].OwningRow.Index;
                if (dataGV_DSSach.Rows[index].Cells["MASACH"].Value == null)
                    throw new Exception("Err");
                ms = dataGV_DSSach.Rows[index].Cells["MASACH"].Value.ToString();
                return ms;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy thông tin sách phù hợp !","Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }

        private void ListBook_Load(object sender, EventArgs e)
        {
            DataTable TDSsach = bs.loadDataForListBook();

            LoadDataProgress f = new LoadDataProgress();
            f.countData = TDSsach.Rows.Count;
            f.ShowDialog();

            loadDataIntoGridView();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddNewBook f = new AddNewBook();
            f.MaNhanVien = MaNhanVien;
            f.ShowDialog();
            loadDataIntoGridView();
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            string ms = getSelectedMaSach();
            DetailsBook f = new DetailsBook();
            f.maSachDetails = ms;
            f.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string maSach = getSelectedMaSach();
            EditBookInfo f = new EditBookInfo();
            f.maSach = maSach;
            f.ShowDialog();
            loadDataIntoGridView();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteBookConfirm f = new DeleteBookConfirm();
            string maSach = getSelectedMaSach();
            f.maSach = maSach;
            f.ShowDialog();
            loadDataIntoGridView();
        }

        private void btn_RefreshData_Click(object sender, EventArgs e)
        {
            loadDataIntoGridView();
        }

        private void dataGV_DSSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGV_DSSach.Rows.Count - 1; i++)
            {
                int slTon = int.Parse(dataGV_DSSach.Rows[i].Cells[2].Value.ToString());
                if (slTon > 0 && slTon <= 5)
                {
                    dataGV_DSSach.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGV_DSSach.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dataGV_DSSach.Rows[i].DefaultCellStyle.Font = new Font("Arial", 9.0f, FontStyle.Bold);
                }
                else if (slTon == 0)
                {
                    dataGV_DSSach.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                    dataGV_DSSach.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dataGV_DSSach.Rows[i].DefaultCellStyle.Font = new Font("Arial", 9.0f, FontStyle.Bold);
                }
            }
        }
    }
}
