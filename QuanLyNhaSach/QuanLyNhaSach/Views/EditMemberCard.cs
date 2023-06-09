using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Extensions;
using QuanLyNhaSach.Bussiness;

namespace QuanLyNhaSach
{
    public partial class EditMemberCard : Form
    {
        public EditMemberCard()
        {
            InitializeComponent();
        }

        public string maThe { get; set; }

        BookstoreBussiness bs = new BookstoreBussiness();
        DataTable t = new DataTable();
        private void EditMemberCard_Load(object sender, EventArgs e)
        {
            DataTable TLoaiThe = bs.loadDataLoaiThe();
            Ultilities.fillDataCombobox(cB_LoaiThe, TLoaiThe, "MALOAITHE", "MALOAITHE");

            cB_GioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            cB_TenThe.Items.AddRange(new string[] { "Khách Hàng Thân Thiết", "Khách Hàng VIP", "Khách Hàng Thành Viên" });

            //fill in form
            t = bs.loadDataMemberCardAndInfoByMaThe(maThe);
            txt_tenKH.Text = t.Rows[0]["TENKH"].ToString();
            txt_SDT.Text = t.Rows[0]["SDT"].ToString();
            cB_LoaiThe.SelectedIndex = Ultilities.getIndexFromDataTable(TLoaiThe, "MALOAITHE", t.Rows[0]["MALOAITHE"].ToString().Trim());
            
            int indexGT = cB_GioiTinh.FindString(t.Rows[0]["GIOITINH"].ToString().Trim());
            cB_GioiTinh.SelectedIndex = indexGT;

            int indexTenThe = cB_TenThe.FindString(t.Rows[0]["TENTHE"].ToString().Trim());
            cB_TenThe.SelectedIndex = indexTenThe;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int state = bs.updateMembercard(maThe, t.Rows[0]["MAKH"].ToString(), txt_tenKH.Text, cB_GioiTinh.SelectedItem.ToString(), txt_SDT.Text, cB_TenThe.SelectedItem.ToString(), cB_LoaiThe.SelectedValue.ToString());

            Ultilities.showDialogNotice(state, "Cập nhật", "Lỗi cập nhật không thành công !");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
