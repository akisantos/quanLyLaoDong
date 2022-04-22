namespace quanLyLaoDong
{
    partial class phanCongControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hiTB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.phanCongDataGridView = new System.Windows.Forms.DataGridView();
            this.MaPhanCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.delBTN = new FontAwesome.Sharp.IconButton();
            this.editBTN = new FontAwesome.Sharp.IconButton();
            this.addPhanCongBTN = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phanCongDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // hiTB
            // 
            this.hiTB.AutoSize = true;
            this.hiTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.hiTB.Location = new System.Drawing.Point(40, 63);
            this.hiTB.Name = "hiTB";
            this.hiTB.Size = new System.Drawing.Size(253, 21);
            this.hiTB.TabIndex = 1;
            this.hiTB.Text = "Phân công công việc cho nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân công";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.hiTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 101);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 506);
            this.panel2.TabIndex = 4;
            // 
            // phanCongDataGridView
            // 
            this.phanCongDataGridView.AllowUserToAddRows = false;
            this.phanCongDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.phanCongDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.phanCongDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phanCongDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.phanCongDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phanCongDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.phanCongDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.phanCongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phanCongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhanCong,
            this.MaCongTrinh,
            this.MaNhanVien,
            this.soGio});
            this.phanCongDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.phanCongDataGridView.Location = new System.Drawing.Point(4, 94);
            this.phanCongDataGridView.Name = "phanCongDataGridView";
            this.phanCongDataGridView.ReadOnly = true;
            this.phanCongDataGridView.RowTemplate.Height = 50;
            this.phanCongDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phanCongDataGridView.Size = new System.Drawing.Size(1101, 409);
            this.phanCongDataGridView.TabIndex = 0;
            this.phanCongDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.phanCongDataGridView_CellDoubleClick);
            // 
            // MaPhanCong
            // 
            this.MaPhanCong.HeaderText = "Mã phân công";
            this.MaPhanCong.Name = "MaPhanCong";
            this.MaPhanCong.ReadOnly = true;
            // 
            // MaCongTrinh
            // 
            this.MaCongTrinh.HeaderText = "Tên Công Trình";
            this.MaCongTrinh.Name = "MaCongTrinh";
            this.MaCongTrinh.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "Tên Nhân Viên";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // soGio
            // 
            this.soGio.HeaderText = "Số giờ được giao";
            this.soGio.Name = "soGio";
            this.soGio.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.delBTN);
            this.panel4.Controls.Add(this.editBTN);
            this.panel4.Controls.Add(this.addPhanCongBTN);
            this.panel4.Controls.Add(this.phanCongDataGridView);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(3, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1108, 508);
            this.panel4.TabIndex = 5;
            // 
            // delBTN
            // 
            this.delBTN.BackColor = System.Drawing.Color.White;
            this.delBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.delBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.delBTN.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.delBTN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.delBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delBTN.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.delBTN.Location = new System.Drawing.Point(278, 15);
            this.delBTN.Name = "delBTN";
            this.delBTN.Size = new System.Drawing.Size(125, 64);
            this.delBTN.TabIndex = 7;
            this.delBTN.Text = "Xóa";
            this.delBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delBTN.UseVisualStyleBackColor = false;
            this.delBTN.Click += new System.EventHandler(this.delBTN_Click);
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.Color.White;
            this.editBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.editBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.editBTN.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.editBTN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.editBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editBTN.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.editBTN.Location = new System.Drawing.Point(147, 15);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(125, 64);
            this.editBTN.TabIndex = 6;
            this.editBTN.Text = "Chỉnh sửa";
            this.editBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // addPhanCongBTN
            // 
            this.addPhanCongBTN.BackColor = System.Drawing.Color.White;
            this.addPhanCongBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.addPhanCongBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPhanCongBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.addPhanCongBTN.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.addPhanCongBTN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.addPhanCongBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addPhanCongBTN.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addPhanCongBTN.Location = new System.Drawing.Point(15, 15);
            this.addPhanCongBTN.Name = "addPhanCongBTN";
            this.addPhanCongBTN.Size = new System.Drawing.Size(125, 64);
            this.addPhanCongBTN.TabIndex = 5;
            this.addPhanCongBTN.Text = "Phân công";
            this.addPhanCongBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPhanCongBTN.UseVisualStyleBackColor = false;
            this.addPhanCongBTN.Click += new System.EventHandler(this.addPhanCongBTN_Click);
            // 
            // phanCongControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "phanCongControl";
            this.Size = new System.Drawing.Size(1114, 620);
            this.Load += new System.EventHandler(this.phanCongControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phanCongDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hiTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView phanCongDataGridView;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton delBTN;
        private FontAwesome.Sharp.IconButton editBTN;
        private FontAwesome.Sharp.IconButton addPhanCongBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhanCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGio;
    }
}
