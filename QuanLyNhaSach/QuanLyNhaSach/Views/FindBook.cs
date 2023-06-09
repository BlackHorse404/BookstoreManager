using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using QuanLyNhaSach.Bussiness;
using QuanLyNhaSach.Models;

namespace QuanLyNhaSach
{
    public partial class FindBook : Form
    {
        public FindBook()
        {
            InitializeComponent();
            txt_MoTa.Enter += (s, e) => { txt_MoTa.Parent.Focus(); };
        }

        BookstoreBussiness bs = new BookstoreBussiness();
        List<string> imgs = new List<string>(){
                                Path.GetFullPath("../../Resources/tick.png"),
                                Path.GetFullPath("../../Resources/ticked.png")
                            };
        private void FindBook_Load(object sender, EventArgs e)
        {
            //add img
            Image img1 = Image.FromFile(imgs[0]);
            Image img2 = Image.FromFile(imgs[1]);
            imageList1.Images.Add(img1);
            imageList1.Images.Add(img2);
            //load data gridview tab1
            DataTable t = bs.loadDataForListBook();
            DataGridView_Sach.DataSource = t;
            for(int i = 0; i < t.Rows.Count; i++)
            {
                DataGridView_Sach.Rows[i].Cells["STT"].Value = i+1;
            }

            cB_NXB.DataSource = bs.loadDataNXB();
            cB_NXB.ValueMember = "MANXB";
            cB_NXB.DisplayMember = "TENNXB";

            cB_TheLoai.DataSource = bs.loadDataTheLoai();
            cB_TheLoai.ValueMember = "MATL";
            cB_TheLoai.DisplayMember = "TENTL";

            //load tree view
            //level 1
            foreach(DataRow r in bs.loadDataTheLoai().Rows)
            {
                treeView_Sach.Nodes.Add(r["TENTL"].ToString(), r["TENTL"].ToString(), 0, 1);
            }
            //level 2
            for(var k = 0; k < treeView_Sach.Nodes.Count; k++)
            {
                TreeNode tn = treeView_Sach.Nodes[k];
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    if (t.Rows[i]["TENTL"].ToString().Equals(tn.Text.ToString()))
                    {
                        tn.Nodes.Add(t.Rows[i]["MASACH"].ToString(), t.Rows[i]["MASACH"].ToString() + " - " + t.Rows[i]["TENSACH"].ToString(), 0, 1);
                    }
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string strSearch = txt_StringSearch.Text;
            DataTable t = null;
            bool flag = false;
            //kiem tra phan loai ma sach hay ten sach
            try
            {
                int temp = int.Parse(strSearch.Substring(1, 4));
                flag = temp >= 1900 && temp <= int.Parse(DateTime.Now.ToString("yyyy")) ? true : false;
            }
            catch{}
            
            if (flag && strSearch.StartsWith("S", true, null))//tim theo mã sách
                t = bs.searchSachWithMaSach(strSearch);
            else
                t = bs.searchSachWithName(strSearch);

            //load data theo thong tin tim kiem
            if (t == null || t.Rows.Count == 0)
                MessageBox.Show("Không tìm thấy thông tin tra cứu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataGridView_Sach.DataSource = t;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    DataGridView_Sach.Rows[i].Cells["STT"].Value = i + 1;
                }
            }
        }

        private void cB_TheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strFilter = cB_TheLoai.SelectedValue.ToString();
            if (strFilter != null)
            {
                DataTable t = bs.filterSachByTheLoai(strFilter);
                DataGridView_Sach.DataSource = t;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    DataGridView_Sach.Rows[i].Cells["STT"].Value = i + 1;
                }
            }
        }

        private void cB_NXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strFilter = cB_NXB.SelectedValue.ToString();
            if(strFilter != null)
            {
                DataTable t = bs.filterSachByNXB(strFilter);
                DataGridView_Sach.DataSource = t;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    DataGridView_Sach.Rows[i].Cells["STT"].Value = i + 1;
                }
            }
        }

        private void addValueToInfoBook(BookDetails_Model t)
        {
            if (t != null)
            {
                lb_ms.Text = t.maSach.Trim();
                lb_ts.UseMnemonic = false; lb_ts.Text = t.tenSach.Trim();
                txt_MoTa.Text = t.moTa.Trim();
                lb_TheLoai.Text = t.theLoai.Trim();
                lb_TacGia.Text = t.tacGia.Trim();
                lb_NXB.Text = t.nxb.Trim();
                lb_GiaSach.Text = string.Format("{0:0,0} VNĐ", t.giaSach);
                lb_SoLuongTonKho.Text = t.slTon.ToString().Trim();
                txt_MoTa.SelectionStart = 0;
            }
        }

        private void treeView_Sach_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string maSach = treeView_Sach.SelectedNode.Name;
            try
            {
                BookDetails_Model t = bs.loadInfoBookDetails(maSach);
                addValueToInfoBook(t);
            }
            catch{}
        }
    }
}
