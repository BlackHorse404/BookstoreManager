using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Models;

namespace QuanLyNhaSach
{
    public partial class LoadDataProgress : Form
    {
        public LoadDataProgress()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Timer tmr;
        public int countData { get; set; }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private Task ProcessData(int countOfData, IProgress<ProcessReport> progress)
        {
            int index = 1;
            int totalProcress = countOfData;
            var progressRp = new ProcessReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcress; i++)
                {
                    progressRp.PercentComplete = index++ * 100 / totalProcress;
                    progress.Report(progressRp);
                    Thread.Sleep(5);
                }
            });
        }

        private void close()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(1).TotalMilliseconds;
            tmr.Start();
        }

        private async void LoadDataProgress_Load(object sender, EventArgs e)
        {
            lb_status.Text = "Loading...";
            var progress = new Progress<ProcessReport>();
            progress.ProgressChanged += (o, report) =>
            {
                lb_status.Text = string.Format("Loading...{0}%", report.PercentComplete);
                progressBar1.Value = report.PercentComplete;
                progressBar1.Update();
            };
            await ProcessData(countData, progress);
            lb_status.Text = "Done !";
            close();
        }
    }
}
