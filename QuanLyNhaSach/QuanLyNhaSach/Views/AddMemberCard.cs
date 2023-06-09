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
using QuanLyNhaSach.Extensions;

namespace QuanLyNhaSach
{
    public partial class AddMemberCard : Form
    {
        public AddMemberCard()
        {
            InitializeComponent();
        }

        BookstoreBussiness bs = new BookstoreBussiness();

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int kq = bs.insertMemberCard(txt_MaThe.Text, txt_tenKH.Text, cB_GioiTinh.SelectedItem.ToString(), txt_SDT.Text, cB_TenThe.SelectedItem.ToString(), cB_LoaiThe.SelectedValue.ToString());

            Ultilities.showDialogNotice(kq, "Tạo Thẻ Thành Viên", "Lỗi tạo thẻ thành viên không thành công !");
        }

        private void AddMemberCard_Load(object sender, EventArgs e)
        {
            cB_GioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            cB_TenThe.Items.AddRange(new string[] { "Khách Hàng Thân Thiết", "Khách Hàng VIP", "Khách Hàng Thành Viên" });

            cB_LoaiThe.DataSource = bs.loadDataLoaiThe();
            cB_LoaiThe.DisplayMember = "TENTHE";
            cB_LoaiThe.ValueMember = "MALOAITHE";
        }
    }
}
