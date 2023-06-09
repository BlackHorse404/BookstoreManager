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
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        public string MaNhanVien { get; set; }
        private string pathFile;

        BookstoreBussiness bs = new BookstoreBussiness();

        private void txt_GiaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btn_brAnhBia_Click(object sender, EventArgs e)
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
            lb_AnhBia.Text = fileName;
            pathFile = path;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AcceptAdd_Click(object sender, EventArgs e)
        {
            int rs = bs.insertSach(txt_MaSach.Text, txt_TenSach.Text, ((int)numSoLuong.Value), float.Parse(txtGiaSach.Text), txt_moTa.Text, lb_AnhBia.Text);
            if (rs == 1)
                rs = bs.insertPhieuNhapAndCTPhieuNhap(txt_MaPhieu.Text, txt_MaSach.Text, ((int)numSoLuong.Value), MaNhanVien, float.Parse(txtGiaSach.Text));
            if (rs == 1)
                rs = bs.insertThongTinChiTietSach(txt_MaSach.Text, cB_TacGia.SelectedValue.ToString(), cb_NXB.SelectedValue.ToString(), cb_TheLoai.SelectedValue.ToString());

            Ultilities.showDialogNotice(rs, "Thêm", "Trùng dữ liệu vui lòng kiểm lại !");
            if(rs == 1)
            {
                //copy file to AnhBia folder
                string sourcePath = pathFile;
                string targetPath = Path.GetFullPath(@"./../../AnhBia/" + lb_AnhBia.Text);

                System.IO.File.Copy(sourcePath, targetPath, true);
            }
            if (rs == 1)
                Start.soSachNhap += ((int)numSoLuong.Value);
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
            //fill in combobox
            Ultilities.fillDataCombobox(cB_TacGia, bs.loadDataTacGia(), "TENTG", "MATG");
            Ultilities.fillDataCombobox(cb_NXB, bs.loadDataNXB(), "TENNXB", "MANXB");
            Ultilities.fillDataCombobox(cb_TheLoai, bs.loadDataTheLoai(), "TENTL", "MATL");
        }
    }
}
