
namespace QuanLyNhaSach
{
    partial class QLDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLDoanhThu));
            this.dataGridView_HoaDon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ThongKeLocTheoNgay = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_HoaDon
            // 
            this.dataGridView_HoaDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_HoaDon.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_HoaDon.Name = "dataGridView_HoaDon";
            this.dataGridView_HoaDon.RowHeadersWidth = 51;
            this.dataGridView_HoaDon.RowTemplate.Height = 29;
            this.dataGridView_HoaDon.Size = new System.Drawing.Size(928, 332);
            this.dataGridView_HoaDon.TabIndex = 0;
            this.dataGridView_HoaDon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_HoaDon_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 68);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Filter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(928, 68);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Filter.AutoSize = true;
            this.btn_Filter.BackColor = System.Drawing.Color.White;
            this.btn_Filter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Filter.BackgroundImage")));
            this.btn_Filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Filter.FlatAppearance.BorderSize = 0;
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Filter.Location = new System.Drawing.Point(420, 20);
            this.btn_Filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(40, 27);
            this.btn_Filter.TabIndex = 1;
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(145, 17);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(269, 34);
            this.dateTimePicker.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.01205F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.98795F));
            this.tableLayoutPanel2.Controls.Add(this.txt_TongTien, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(512, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 64);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_TongTien.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TongTien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_TongTien.Location = new System.Drawing.Point(139, 18);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(231, 27);
            this.txt_TongTien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng Tiền:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 71);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0005F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.33273F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.0004F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.33273F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.0004F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.33273F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0005F));
            this.tableLayoutPanel3.Controls.Add(this.btn_ThongKeLocTheoNgay, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_ThongKe, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Reset, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_help, 6, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(928, 71);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btn_ThongKeLocTheoNgay
            // 
            this.btn_ThongKeLocTheoNgay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ThongKeLocTheoNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ThongKeLocTheoNgay.FlatAppearance.BorderSize = 0;
            this.btn_ThongKeLocTheoNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKeLocTheoNgay.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_ThongKeLocTheoNgay.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKeLocTheoNgay.Image")));
            this.btn_ThongKeLocTheoNgay.Location = new System.Drawing.Point(49, 2);
            this.btn_ThongKeLocTheoNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThongKeLocTheoNgay.Name = "btn_ThongKeLocTheoNgay";
            this.btn_ThongKeLocTheoNgay.Size = new System.Drawing.Size(247, 67);
            this.btn_ThongKeLocTheoNgay.TabIndex = 0;
            this.btn_ThongKeLocTheoNgay.Text = "In Báo Cáo";
            this.btn_ThongKeLocTheoNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThongKeLocTheoNgay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThongKeLocTheoNgay.UseVisualStyleBackColor = false;
            this.btn_ThongKeLocTheoNgay.Click += new System.EventHandler(this.btn_exportReport_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ThongKe.FlatAppearance.BorderSize = 0;
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.Image")));
            this.btn_ThongKe.Location = new System.Drawing.Point(339, 2);
            this.btn_ThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(247, 67);
            this.btn_ThongKe.TabIndex = 1;
            this.btn_ThongKe.Text = "Thống Kê Tổng";
            this.btn_ThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.Location = new System.Drawing.Point(629, 2);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(247, 67);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Làm Mới";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_HoaDon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 332);
            this.panel3.TabIndex = 2;
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_help.BackgroundImage")));
            this.btn_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Location = new System.Drawing.Point(882, 3);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(43, 65);
            this.btn_help.TabIndex = 3;
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // QLDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 471);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLDoanhThu";
            this.Text = "QUẢN LÝ DOANH THU";
            this.Load += new System.EventHandler(this.QLDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_HoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_ThongKeLocTheoNgay;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_help;
    }
}