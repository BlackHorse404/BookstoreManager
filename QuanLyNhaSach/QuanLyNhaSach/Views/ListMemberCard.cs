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
    public partial class ListMemberCard : Form
    {
        public ListMemberCard()
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
                if (t.Rows[index].Cells["MATHE"].Value == null)
                    throw new Exception("Err");
                ms = t.Rows[index].Cells["MATHE"].Value.ToString();
                return ms;
            }
            catch (Exception err)
            {
                MessageBox.Show("Không tìm thấy thông tin sách phù hợp !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void loadData()
        {
            dataGV_DSMemberCard.DataSource = bs.loadDataForListMemberCard();

            dataGV_DSMemberCard.Columns["TENKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGV_DSMemberCard.Columns["TENTHE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void ListMemberCard_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddMemberCard f = new AddMemberCard();
            f.ShowDialog();
            loadData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteMemberCard f = new DeleteMemberCard();
            f.maThe = getSelectedKeyOfObject(dataGV_DSMemberCard);
            f.ShowDialog();
            loadData();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            EditMemberCard f = new EditMemberCard();
            f.maThe = getSelectedKeyOfObject(dataGV_DSMemberCard);
            f.ShowDialog();
            loadData();
        }
    }
}
