using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.Bussiness;

namespace QuanLyNhaSach
{
    public partial class Start : Form
    {
        public static int tongSoKhach;
        public static int soSachBanRa;
        public static float doanhThuTrongNgay;
        public static int soSachNhap;
        public Start()
        {
            InitializeComponent();
        }

        BookstoreBussiness bs = new BookstoreBussiness();

        private void Start_Load(object sender, EventArgs e)
        {
            //cập nhật thông số dashboard trong ngày
            lb_TongKhachMua.Text = tongSoKhach.ToString("#,0");
            lb_SoSachBanRa.Text = soSachBanRa.ToString("#,0");
            lb_DoanhThuTrongNgay.Text = doanhThuTrongNgay.ToString("#,0");
            lb_SoSachNhap.Text = soSachNhap.ToString("#,0");


            //load data for chart
            chartSach.DataSource = bs.loadDataForChartSach();

            chartSach.Series["GiaoDichSach"].XValueMember = "TENSACH";
            chartSach.Series["GiaoDichSach"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            chartSach.Series["GiaoDichSach"].YValueMembers = "SL";
            chartSach.Series["GiaoDichSach"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            //ẩn label trên vùng vẽ chart
            chartSach.Series["GiaoDichSach"].IsValueShownAsLabel = true;
        }
    }
}
