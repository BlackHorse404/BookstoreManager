using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using QuanLyNhaSach.DataAccess;

namespace QuanLyNhaSach
{
    public partial class FrmReportDoanhThu : Form
    {
        public FrmReportDoanhThu()
        {
            InitializeComponent();
        }

        public void loadReport()
        {
            rptDoanhThu rpt = new rptDoanhThu();
            rpt.DataSourceConnections[0].SetConnection(DBConfig.ServerName, DBConfig.DBname, DBConfig.Username, DBConfig.Password);
            rpt.SetDatabaseLogon(DBConfig.Username, DBConfig.Password, DBConfig.ServerName, DBConfig.DBname);
            crystalReportViewer.ReportSource = rpt;
            crystalReportViewer.DisplayStatusBar = true;
            crystalReportViewer.DisplayToolbar = true;
            crystalReportViewer.Refresh();
        }
        public void printReport()
        {
            loadReport();
            if (this.crystalReportViewer.ReportSource == null)
                MessageBox.Show("Vui lòng load dữ liệu báo cáo !");
            else
            {
                this.crystalReportViewer.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintToPrinter;
                this.crystalReportViewer.PrintReport();
            }
        }
        private void FrmReportDoanhThu_Load(object sender, EventArgs e)
        {
            loadReport();
        }
    }
}
