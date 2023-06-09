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
    public partial class DeleteMemberCard : Form
    {
        public DeleteMemberCard()
        {
            InitializeComponent();
        }

        public string maThe { get; set; }

        BookstoreBussiness bs = new BookstoreBussiness();
        DataTable t = new DataTable();
        private void DeleteMemberCard_Load(object sender, EventArgs e)
        {
            //fill in form
            t = bs.loadDataMemberCardAndInfoByMaThe(maThe);
            lb_MaThe.Text = maThe;
            lb_ngayCapThe.Text = DateTime.Parse(t.Rows[0]["NGAYCAP"].ToString()).ToString("d");
            lb_TenKH.Text = t.Rows[0]["TENKH"].ToString();
            lb_UuDai.Text = (float.Parse(t.Rows[0]["CHIETKHAU"].ToString())*100).ToString() +" %";
            lb_TenThe.Text = t.Rows[0]["TENTHE"].ToString();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int kq = bs.deleteMemberCard(maThe, t.Rows[0]["MAKH"].ToString(), t.Rows[0]["TENKH"].ToString(), t.Rows[0]["GIOITINH"].ToString(), t.Rows[0]["SDT"].ToString());
            Ultilities.showDialogNotice(kq, "Xóa Thẻ Thành Viên", "Xóa thẻ Thành Viên không thành công !");
        }
    }
}
