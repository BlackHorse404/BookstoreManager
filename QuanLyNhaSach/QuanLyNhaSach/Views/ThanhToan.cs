using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhaSach.Bussiness;
using QuanLyNhaSach.DataAccess;
using QuanLyNhaSach.Extensions;

namespace QuanLyNhaSach
{
    public partial class ThanhToan : Form
    {
        public string maNV { get; set ; }
        public ThanhToan()
        {
            InitializeComponent();
            maNV = Ultilities.maNV;
        }

        BookstoreBussiness bs = new BookstoreBussiness();
        DataSet HoaDon = new DataSet();

        private void loadReportBill(string MAKH, string MAHD, bool ttv)
        {
            DataSet ds = new DataSet();
            ds = bs.loadDataForBill(MAHD, MAKH);
            if (ttv)
            {
                Bill2 x = new Bill2();
                x.DataSourceConnections[0].SetConnection(DBConfig.ServerName, DBConfig.DBname, DBConfig.Username, DBConfig.Password);
                x.SetDatabaseLogon(DBConfig.Username, DBConfig.Password, DBConfig.ServerName, DBConfig.DBname);
                x.SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = x;
            }
            else
            {
                Bill1 x = new Bill1();
                x.DataSourceConnections[0].SetConnection(DBConfig.ServerName, DBConfig.DBname, DBConfig.Username, DBConfig.Password);
                x.SetDatabaseLogon(DBConfig.Username, DBConfig.Password, DBConfig.ServerName, DBConfig.DBname);
                x.SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = x;
            }
            crystalReportViewer1.Refresh();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            DataTable Sachs = bs.loadDataSach();
            Ultilities.fillDataCombobox(cB_sach, Sachs, "TENSACH", "MASACH");
        }
        static string maHD = string.Empty;
        static string maKH_Old = string.Empty;
        private void btn_Next_Click(object sender, EventArgs e)
        {
            string maKH = string.Empty;
            try
            {
                string maSach = cB_sach.SelectedValue.ToString();
                int slSachTonKho = int.Parse(bs.loadDataSachByMaSach(maSach).Rows[0]["SOLUONGTON"].ToString());
                int slSachKhachMua = (int)numSLMua.Value;
                if (slSachTonKho < 1)
                {
                    MessageBox.Show("Sách đã hết hàng vui lòng chọn sách khác !", "Thông Báo Hết Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(slSachKhachMua > slSachTonKho)
                {
                    MessageBox.Show("Số lượng sách vượt quá số lượng tồn. Giao dịch thất bại !", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int state = bs.insertHoaDonAndCTHoaDon(maSach, txt_TenKH.Text.Trim(), maNV, slSachKhachMua, ref maHD, out maKH);

                    Ultilities.showDialogNotice(state, "Lưu Hóa Đơn", "Lưu Hóa Đơn Thất Bại !");
                    //load lại bill
                    if (state == 1)
                    {
                        loadReportBill(maKH, maHD, chkBox_TTV.Checked);
                        if (maKH_Old == string.Empty || maKH != maKH_Old)
                            Start.tongSoKhach += 1;
                        if (bs.updateSLSachTrongKho(maSach, ((int)numSLMua.Value)) != 1)
                            MessageBox.Show(string.Format("Lỗi không cập nhật được SL Sách {0}", cB_sach.SelectedValue.ToString()));
                        Start.soSachBanRa += ((int)numSLMua.Value);
                        Start.doanhThuTrongNgay += bs.layThanhTienSachWith(cB_sach.SelectedValue.ToString(), ((int)numSLMua.Value));
                        //lay maKH cũ
                        maKH_Old = maKH;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có Lỗi Xảy Ra vui lòng thử lại !");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_TenKH.Clear();
            numSLMua.Value = 0;

            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.Refresh();
        }

        private void btn_PrintBill_Click(object sender, EventArgs e)
        {
            if (this.crystalReportViewer1.ReportSource == null)
                MessageBox.Show("Vui lòng load dữ liệu báo cáo !");
            else
            {
                this.crystalReportViewer1.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintToPrinter;
                this.crystalReportViewer1.PrintReport();
            }
        }
    }
}
