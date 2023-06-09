
namespace QuanLyNhaSach
{
    partial class ListMemberCard
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
            System.Windows.Forms.Button btn_Save;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMemberCard));
            System.Windows.Forms.Button btn_Add;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGV_DSMemberCard = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            btn_Save = new System.Windows.Forms.Button();
            btn_Add = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DSMemberCard)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
            btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            btn_Save.FlatAppearance.BorderSize = 0;
            btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Save.Font = new System.Drawing.Font("Segoe UI", 14F);
            btn_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            btn_Save.Location = new System.Drawing.Point(518, 2);
            btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new System.Drawing.Size(226, 58);
            btn_Save.TabIndex = 8;
            btn_Save.Text = "Sửa";
            btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
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
            btn_Add.Location = new System.Drawing.Point(54, 2);
            btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new System.Drawing.Size(226, 58);
            btn_Add.TabIndex = 9;
            btn_Add.Text = "Thêm";
            btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.451613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.03226F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.03226F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.03226F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.451613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(btn_Save, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Delete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(btn_Add, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 62);
            this.tableLayoutPanel1.TabIndex = 8;
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
            this.btn_Delete.Location = new System.Drawing.Point(286, 2);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(226, 58);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dataGV_DSMemberCard
            // 
            this.dataGV_DSMemberCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_DSMemberCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_DSMemberCard.Location = new System.Drawing.Point(0, 0);
            this.dataGV_DSMemberCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGV_DSMemberCard.Name = "dataGV_DSMemberCard";
            this.dataGV_DSMemberCard.RowHeadersWidth = 51;
            this.dataGV_DSMemberCard.RowTemplate.Height = 29;
            this.dataGV_DSMemberCard.Size = new System.Drawing.Size(800, 298);
            this.dataGV_DSMemberCard.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGV_DSMemberCard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 298);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 298);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 62);
            this.panel2.TabIndex = 2;
            // 
            // ListMemberCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListMemberCard";
            this.Text = "DANH SÁCH THẺ THÀNH VIÊN";
            this.Load += new System.EventHandler(this.ListMemberCard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DSMemberCard)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGV_DSMemberCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}