
namespace QuanLyNhaSach
{
    partial class ListBook
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
            System.Windows.Forms.Button btn_Add;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBook));
            System.Windows.Forms.Button btn_Details;
            this.dataGV_DSSach = new System.Windows.Forms.DataGridView();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_TongSLSach = new System.Windows.Forms.Label();
            this.btn_RefreshData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            btn_Add = new System.Windows.Forms.Button();
            btn_Details = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DSSach)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
            btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Add.Font = new System.Drawing.Font("Segoe UI", 14F);
            btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            btn_Add.Location = new System.Drawing.Point(512, 65);
            btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new System.Drawing.Size(223, 55);
            btn_Add.TabIndex = 5;
            btn_Add.Text = "Thêm";
            btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
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
            btn_Details.Location = new System.Drawing.Point(741, 65);
            btn_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Details.Name = "btn_Details";
            btn_Details.Size = new System.Drawing.Size(223, 55);
            btn_Details.TabIndex = 8;
            btn_Details.Text = "Chi Tiết";
            btn_Details.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_Details.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_Details.UseVisualStyleBackColor = false;
            btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // dataGV_DSSach
            // 
            this.dataGV_DSSach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGV_DSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_DSSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_DSSach.Location = new System.Drawing.Point(0, 0);
            this.dataGV_DSSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGV_DSSach.Name = "dataGV_DSSach";
            this.dataGV_DSSach.RowHeadersWidth = 51;
            this.dataGV_DSSach.RowTemplate.Height = 29;
            this.dataGV_DSSach.Size = new System.Drawing.Size(1022, 345);
            this.dataGV_DSSach.TabIndex = 0;
            this.dataGV_DSSach.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGV_DSSach_CellFormatting);
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
            this.btn_Edit.Location = new System.Drawing.Point(283, 65);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(223, 55);
            this.btn_Edit.TabIndex = 7;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(54, 65);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(223, 55);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 345);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 122);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Delete, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Edit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(btn_Add, 3, 2);
            this.tableLayoutPanel1.Controls.Add(btn_Details, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_TongSLSach, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_RefreshData, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1022, 122);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lb_TongSLSach
            // 
            this.lb_TongSLSach.AutoSize = true;
            this.lb_TongSLSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TongSLSach.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lb_TongSLSach.Location = new System.Drawing.Point(741, 0);
            this.lb_TongSLSach.Name = "lb_TongSLSach";
            this.lb_TongSLSach.Size = new System.Drawing.Size(223, 52);
            this.lb_TongSLSach.TabIndex = 9;
            this.lb_TongSLSach.Text = "label1";
            this.lb_TongSLSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_RefreshData
            // 
            this.btn_RefreshData.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_RefreshData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RefreshData.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btn_RefreshData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_RefreshData.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshData.Image")));
            this.btn_RefreshData.Location = new System.Drawing.Point(54, 2);
            this.btn_RefreshData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RefreshData.Name = "btn_RefreshData";
            this.btn_RefreshData.Size = new System.Drawing.Size(223, 48);
            this.btn_RefreshData.TabIndex = 10;
            this.btn_RefreshData.Text = "Làm Mới";
            this.btn_RefreshData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RefreshData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RefreshData.UseVisualStyleBackColor = false;
            this.btn_RefreshData.Click += new System.EventHandler(this.btn_RefreshData_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGV_DSSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 345);
            this.panel1.TabIndex = 1;
            // 
            // ListBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1022, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListBook";
            this.Text = "DANH SÁCH SẢN PHẨM";
            this.Load += new System.EventHandler(this.ListBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DSSach)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGV_DSSach;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_TongSLSach;
        private System.Windows.Forms.Button btn_RefreshData;
    }
}