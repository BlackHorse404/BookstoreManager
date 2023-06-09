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
using System.IO;
using QuanLyNhaSach.Extensions;

namespace QuanLyNhaSach
{
    public partial class EditListPhieuNhap : Form
    {
        public EditListPhieuNhap()
        {
            InitializeComponent();
        }
        Image img = Image.FromFile(Path.GetFullPath(@"..\..\Resources\btn_Edit.png"));
        public string maPhieu { get; set; }

        BookstoreBussiness bs = new BookstoreBussiness();
        private void EditListPhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bs.loadDataCTPhieuNhap(maPhieu);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            dataGridView1.RowTemplate.Height = img.Height;
            editButtonColumn.Name = "";
            editButtonColumn.Text = "Edit";
            editButtonColumn.Width = img.Width;
            editButtonColumn.FlatStyle = FlatStyle.Flat;
            int columnIndex = 4;
            if (dataGridView1.Columns[""] == null)
            {
                dataGridView1.Columns.Insert(columnIndex, editButtonColumn);
            }
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = img.Width;
                var h = img.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string maPN = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string maSach = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                int sl = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                float gia = float.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                int state = bs.updateCTPhieuNhap(maPN, maSach, sl, gia);
                Ultilities.showDialogNotice(state, "Cập nhật Chi Tiết Phiếu Nhập", "Cập nhập không thành công !");
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
