
namespace QuanLyNhaSach
{
    partial class ListPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btn_Report;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPhieuNhap));
            System.Windows.Forms.Button btn_Details;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.dataGV_DSPhieuNhap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            btn_Report = new System.Windows.Forms.Button();
            btn_Details = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DSPhieuNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Report
            // 
            btn_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
            btn_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            btn_Report.FlatAppearance.BorderSize = 0;
            btn_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Report.Font = new System.Drawing.Font("Segoe UI", 14F);
            btn_Report.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_Report.Image = ((System.Drawing.Image)(resources.GetObject("btn_Report.Image")));
            btn_Report.Location = new System.Drawing.Point(541, 2);
            btn_Report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Report.Name = "btn_Report";
            btn_Report.Size = new System.Drawing.Size(227, 58);
            btn_Report.TabIndex = 8;
            btn_Report.Text = "Báo Cáo";
            btn_Report.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_Report.UseVisualStyleBackColor = false;
            btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_Details
            // 
            btn_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
            btn_Details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            btn_Details.FlatAppearance.BorderSize = 0;
            btn_Details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            btn_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Details.Font = new System.Drawing.Font("Segoe UI", 14F);
            btn_Details.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_Details.Image = ((System.Drawing.Image)(resources.GetObject("btn_Details.Image")));
            btn_Details.Location = new System.Drawing.Point(292, 2);
            btn_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Details.Name = "btn_Details";
            btn_Details.Size = new System.Drawing.Size(227, 58);
            btn_Details.TabIndex = 5;
            btn_Details.Text = "Xem Chi Tiết";
            btn_Details.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_Details.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_Details.UseVisualStyleBackColor = false;
            btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.66574F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.0004F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.66574F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.0004F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.66574F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.001F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Edit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(btn_Details, 3, 0);
            this.tableLayoutPanel1.Controls.Add(btn_Report, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 405);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 62);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
            this.btn_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.Location = new System.Drawing.Point(43, 2);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(227, 58);
            this.btn_Edit.TabIndex = 7;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // dataGV_DSPhieuNhap
            // 
            this.dataGV_DSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_DSPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_DSPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.dataGV_DSPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGV_DSPhieuNhap.Name = "dataGV_DSPhieuNhap";
            this.dataGV_DSPhieuNhap.RowHeadersWidth = 51;
            this.dataGV_DSPhieuNhap.RowTemplate.Height = 29;
            this.dataGV_DSPhieuNhap.Size = new System.Drawing.Size(814, 405);
            this.dataGV_DSPhieuNhap.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGV_DSPhieuNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 405);
            this.panel1.TabIndex = 11;
            // 
            // ListPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListPhieuNhap";
            this.Text = "DANH SÁCH PHIẾU NHẬP";
            this.Load += new System.EventHandler(this.ListPhieuNhap_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DSPhieuNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DataGridView dataGV_DSPhieuNhap;
        private System.Windows.Forms.Panel panel1;
    }
}