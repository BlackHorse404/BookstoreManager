using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            lb_name_Account.Text = Login.lastname;
            if(Login.quyen == 1)
            {
                btn_QLTaiKhoan.Enabled = false;
                btn_QLTheTV.Enabled = false;
            }
            else if(Login.quyen == 2)
            {
                btn_QLTaiKhoan.Enabled = false;
                btn_DoanhThu.Enabled = false;
            }
        }

        //open form into panel main
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            lb_title.Text = childForm.Text;
            pannel_Main.Controls.Add(childForm);
            pannel_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //reset button
        public void resetActiveButton()
        {
            Color primaryColor = Color.FromArgb(41, 52, 98);
            btn_dashboard.BackColor = primaryColor;
            btn_ListBook.BackColor = primaryColor;
            btn_QLNhapSP.BackColor = primaryColor;
            btn_QLTaiKhoan.BackColor = primaryColor;
            btn_QLTheTV.BackColor = primaryColor;
            btn_DoanhThu.BackColor = primaryColor;
            btn_ThanhToan.BackColor = primaryColor;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            openChildForm(new Start());
            btn_dashboard.BackColor = Color.FromArgb(13, 76, 146);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Start());
            resetActiveButton();
            btn_dashboard.BackColor = Color.FromArgb(13, 76, 146);
        }

        private void btn_ListBook_Click(object sender, EventArgs e)
        {
            ListBook lb = new ListBook();
            lb.MaNhanVien = Login.maNV;
            openChildForm(lb);
            resetActiveButton();
            btn_ListBook.BackColor = Color.FromArgb(13, 76, 146);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult t= MessageBox.Show("Bạn chắc chắn muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(t == DialogResult.Yes)
            {
                Login f = new Login();
                f.Show();
                this.Hide();
            }
        }

        private void btn_QLNhapSP_Click(object sender, EventArgs e)
        {
            openChildForm(new ListPhieuNhap());
            resetActiveButton();
            btn_QLNhapSP.BackColor = Color.FromArgb(13, 76, 146);
        }

        private void btn_QLTaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new ListAccount());
            resetActiveButton();
            btn_QLTaiKhoan.BackColor = Color.FromArgb(13, 76, 146);
        }

        private void btn_QLTheTV_Click(object sender, EventArgs e)
        {
            openChildForm(new ListMemberCard());
            resetActiveButton();
            btn_QLTheTV.BackColor = Color.FromArgb(13, 76, 146);
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            openChildForm(new QLDoanhThu());
            resetActiveButton();
            btn_DoanhThu.BackColor = Color.FromArgb(13, 76, 146);
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            openChildForm(new ThanhToan());
            resetActiveButton();
            btn_ThanhToan.BackColor = Color.FromArgb(13, 76, 146);
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult t;
            t = MessageBox.Show("Bạn Chắc Chắn Muốn Thoát Ứng Dụng ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (t == DialogResult.No)
                e.Cancel = true;
            else
                Environment.Exit(1);
        }

        private void btn_SearchSach_Click(object sender, EventArgs e)
        {
            FindBook f = new FindBook();
            f.ShowDialog();
        }

        private void btn_SearchSach_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_SearchSach, "Tra cứu thông tin của sách.");
        }
    }
}
