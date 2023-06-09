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
using QuanLyNhaSach.DataAccess;

namespace QuanLyNhaSach
{
    public partial class FrmReportPhieuNhap : Form
    {
        public FrmReportPhieuNhap()
        {
            InitializeComponent();
        }

        BookstoreBussiness bs = new BookstoreBussiness();
        DataTable t = null;

        private void FrmReportPhieuNhap_Load(object sender, EventArgs e)
        {
            rptPhieuNhap rpt = new rptPhieuNhap();
            if(t == null)
            {
                rpt.DataSourceConnections[0].SetConnection(DBConfig.ServerName, DBConfig.DBname, DBConfig.Username, DBConfig.Password);
                rpt.SetDatabaseLogon(DBConfig.Username, DBConfig.Password, DBConfig.ServerName, DBConfig.DBname);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.DisplayStatusBar = true;
                crystalReportViewer1.DisplayToolbar = true;
                crystalReportViewer1.Refresh();
            }
        }
    }
}
