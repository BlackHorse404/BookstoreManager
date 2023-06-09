using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.Bussiness;
using QuanLyNhaSach.Extensions;
using System.IO;

namespace QuanLyNhaSach
{
    public partial class EditBookInfo : Form
    {
        public string maSach { get; set; }
        private static string pathFile = string.Empty;
        public EditBookInfo()
        {
            InitializeComponent();
        }

        BookstoreBussiness bs = new BookstoreBussiness();

        private void EditBookInfo_Load(object sender, EventArgs e)
        {
            DataTable tg = bs.loadDataTacGia();
            DataTable nxb = bs.loadDataNXB();
            DataTable tl = bs.loadDataTheLoai();
            DataTable SachByMaSach = null;
            if (maSach != null)
                SachByMaSach = bs.loadDataSachByMaSach(maSach);

            DataTable infoDetail = bs.loadDataDetailSachByMaSach(maSach);

            //fill in combobox
            Ultilities.fillDataCombobox(cB_TacGia, tg, "TENTG", "MATG");
            Ultilities.fillDataCombobox(cB_NXB, nxb, "TENNXB", "MANXB");
            Ultilities.fillDataCombobox(cB_TheLoai, tl, "TENTL", "MATL");

            //fill in with masach
            DataRow sachSelected = SachByMaSach.Rows[0];
            txt_MaSach.Text = sachSelected["MASACH"].ToString();
            txt_TenSach.Text = sachSelected["TENSACH"].ToString();
            txt_mota.Text = sachSelected["MOTA"].ToString();
            txt_GiaSach.Text = string.Format("{0:0,0}", float.Parse(sachSelected["GIASACH"].ToString()));
            num_SoLuongTon.Value = int.Parse(sachSelected["SOLUONGTON"].ToString());
            lb_anhBia.Text = sachSelected["ANHBIA"].ToString();

            //find index combobox
            int indexNXB = Ultilities.getIndexFromDataTable(nxb, "MANXB", infoDetail.Rows[0]["MANXB"].ToString());
            int indexTG = Ultilities.getIndexFromDataTable(tg, "MATG", infoDetail.Rows[0]["MATG"].ToString());
            int indexTL = Ultilities.getIndexFromDataTable(tl, "MATL", infoDetail.Rows[0]["MATHELOAI"].ToString());

            cB_NXB.SelectedIndex = indexNXB;
            cB_TacGia.SelectedIndex = indexTG;
            cB_TheLoai.SelectedIndex = indexTL;

        }

        private void btn_ChooseAnhBia_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                path = openFileDialog1.FileName;
            }

            //lấy tên ảnh bìa (###.jpg)
            string[] strs = path.Split('\\');
            string fileName = strs[strs.Length - 1];
            lb_anhBia.Text = fileName;

            pathFile = path;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //update data
            int kq = bs.updateSach(txt_MaSach.Text, txt_TenSach.Text, ((int)num_SoLuongTon.Value), float.Parse(txt_GiaSach.Text), txt_mota.Text, lb_anhBia.Text, cB_TacGia.SelectedValue.ToString(), cB_NXB.SelectedValue.ToString(), cB_TheLoai.SelectedValue.ToString());

            if(kq == 1 && pathFile != string.Empty)
            {
                //copy file image to folder AnhBia
                string sourcePath = pathFile;
                string targetPath = Path.GetFullPath(@"./../../AnhBia/" + lb_anhBia.Text);

                System.IO.File.Copy(sourcePath, targetPath, true);
            }

            //notice
            Ultilities.showDialogNotice(kq, "Sửa", "Sửa không thành công !");
        }
    }
}
