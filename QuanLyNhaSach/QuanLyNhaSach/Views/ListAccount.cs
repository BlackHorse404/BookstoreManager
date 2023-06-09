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
    public partial class ListAccount : Form
    {
        public ListAccount()
        {
            InitializeComponent();
        }

        BookstoreBussiness bs = new BookstoreBussiness();

        private string getSelected(DataGridView t, string columnName)
        {
            string ms = string.Empty;
            int index = t.SelectedCells[0].OwningRow.Index;
            try
            {
                ms = t.Rows[index].Cells[columnName].Value.ToString();
            }
            catch
            {
                if (ms == string.Empty)//default get fisrt
                    ms = t.Rows[0].Cells[columnName].Value.ToString();
            }
            return ms;
        }
        public void loadTabAccount()
        {
            if(dataGV_DSTaiKhoan.Rows.Count != 0)
            {
                dataGV_DSTaiKhoan.DataSource = null;
                dataGV_DSTaiKhoan.Columns.Clear();
                dataGV_DSTaiKhoan.Rows.Clear();
            }
            //tab account
            dataGV_DSTaiKhoan.DataSource = bs.loadDataTaiKhoan();

            dataGV_DSTaiKhoan.Columns["TENTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGV_DSTaiKhoan.Columns["MATKHAU"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void loadTabNhanVien()
        {
            if (dataGridView_NhanVien.Rows.Count != 0)
            {
                dataGridView_NhanVien.DataSource = null;
                dataGridView_NhanVien.Columns.Clear();
                dataGridView_NhanVien.Rows.Clear();
            }
            //tab nhanvien
            dataGridView_NhanVien.DataSource = bs.loadDataNhanVien();

            dataGridView_NhanVien.Columns["TENNV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_NhanVien.Columns["DIACHI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void ListAccount_Load(object sender, EventArgs e)
        {
            loadTabAccount();
            loadTabNhanVien();
        }

        //tab1 Account
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadTabAccount();
        }
        private void btn_DeleteAcc_Click(object sender, EventArgs e)
        {
            string username = getSelected(dataGV_DSTaiKhoan, "TENTK");

            DialogResult kq = MessageBox.Show(string.Format("Bạn chắc chắn muốn xóa Tài khoản: {0} .", username.TrimEnd()),"Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(kq == DialogResult.Yes)
            {
                int rs = bs.deleteTaiKhoan(username);
                Ultilities.showDialogNotice(rs, "Xóa", "Xóa không thành công !");
                if (rs == 1)
                    loadTabAccount();
            }
        }
        private void btn_AddAcc_Click(object sender, EventArgs e)
        {
            AddNewAccount f = new AddNewAccount();
            f.ShowDialog();
            loadTabAccount();
        }
        private void btn_EditAcc_Click(object sender, EventArgs e)
        {
            EditAccount f = new EditAccount();
            f.tenTK = getSelected(dataGV_DSTaiKhoan, "TENTK");
            f.ShowDialog();
            loadTabAccount();
        }


        //tab 2 Nhân Viên
        private void btn_refreshTab2_Click(object sender, EventArgs e)
        {
            loadTabNhanVien();
        }
        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            string maNV = getSelected(dataGridView_NhanVien, "MANV");

            DialogResult kq = MessageBox.Show(string.Format("Bạn chắc chắn muốn xóa Nhân Viên có mã: {0} .", maNV.TrimEnd()), "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                int rs = bs.deleteNhanVien(maNV);
                Ultilities.showDialogNotice(rs, "Xóa", "Xóa không thành công !");
                if (rs == 1)
                    loadTabNhanVien();
            }
        }
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            AddNewNhanVien f = new AddNewNhanVien();
            f.ShowDialog();
            loadTabNhanVien();
        }
        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            EditNhanVien f = new EditNhanVien();
            f.maNhanVien = getSelected(dataGridView_NhanVien, "MANV");
            f.ShowDialog();
            loadTabNhanVien();
        }

    }
}
