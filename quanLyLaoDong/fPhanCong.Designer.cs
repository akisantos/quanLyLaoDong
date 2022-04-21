namespace quanLyLaoDong
{
    partial class fPhanCong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.phancongTab = new System.Windows.Forms.TabControl();
            this.congTrinhTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.phanCongBTN = new FontAwesome.Sharp.IconButton();
            this.exitBTN = new FontAwesome.Sharp.IconButton();
            this.confirmDataGridView = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floatSoGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addPCBTN = new FontAwesome.Sharp.IconButton();
            this.searchBTN = new FontAwesome.Sharp.IconButton();
            this.nhanVienGridView = new System.Windows.Forms.DataGridView();
            this.intMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgaySinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitGioiTinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaPhongQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchContentTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.congTrinhCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nvTab = new System.Windows.Forms.TabPage();
            this.phancongTab.SuspendLayout();
            this.congTrinhTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 375);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(568, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phân công";
            // 
            // phancongTab
            // 
            this.phancongTab.Controls.Add(this.congTrinhTab);
            this.phancongTab.Controls.Add(this.nvTab);
            this.phancongTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.phancongTab.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.phancongTab.Location = new System.Drawing.Point(0, 76);
            this.phancongTab.Name = "phancongTab";
            this.phancongTab.SelectedIndex = 0;
            this.phancongTab.Size = new System.Drawing.Size(1327, 600);
            this.phancongTab.TabIndex = 0;
            // 
            // congTrinhTab
            // 
            this.congTrinhTab.Controls.Add(this.label4);
            this.congTrinhTab.Controls.Add(this.phanCongBTN);
            this.congTrinhTab.Controls.Add(this.exitBTN);
            this.congTrinhTab.Controls.Add(this.confirmDataGridView);
            this.congTrinhTab.Controls.Add(this.panel2);
            this.congTrinhTab.Controls.Add(this.congTrinhCB);
            this.congTrinhTab.Controls.Add(this.label2);
            this.congTrinhTab.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.congTrinhTab.Location = new System.Drawing.Point(4, 30);
            this.congTrinhTab.Name = "congTrinhTab";
            this.congTrinhTab.Padding = new System.Windows.Forms.Padding(3);
            this.congTrinhTab.Size = new System.Drawing.Size(1319, 566);
            this.congTrinhTab.TabIndex = 0;
            this.congTrinhTab.Text = "Theo Công trình";
            this.congTrinhTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(632, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Danh sách NV được phân công";
            // 
            // phanCongBTN
            // 
            this.phanCongBTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.phanCongBTN.IconColor = System.Drawing.Color.Black;
            this.phanCongBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.phanCongBTN.Location = new System.Drawing.Point(1012, 497);
            this.phanCongBTN.Name = "phanCongBTN";
            this.phanCongBTN.Size = new System.Drawing.Size(140, 59);
            this.phanCongBTN.TabIndex = 9;
            this.phanCongBTN.Text = "Phân Công";
            this.phanCongBTN.UseVisualStyleBackColor = true;
            this.phanCongBTN.Click += new System.EventHandler(this.phanCongBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.exitBTN.IconColor = System.Drawing.Color.Black;
            this.exitBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBTN.Location = new System.Drawing.Point(1158, 497);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(140, 59);
            this.exitBTN.TabIndex = 8;
            this.exitBTN.Text = "Hủy";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // confirmDataGridView
            // 
            this.confirmDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.confirmDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.confirmDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.confirmDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.confirmDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.confirmDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.confirmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confirmDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.strTen,
            this.floatSoGio,
            this.congTrinh});
            this.confirmDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.confirmDataGridView.Location = new System.Drawing.Point(637, 47);
            this.confirmDataGridView.Name = "confirmDataGridView";
            this.confirmDataGridView.RowTemplate.Height = 50;
            this.confirmDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.confirmDataGridView.Size = new System.Drawing.Size(661, 444);
            this.confirmDataGridView.TabIndex = 7;
            this.confirmDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.confirmDataGridView_CellBeginEdit);
            this.confirmDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.confirmDataGridView_CellValidating);
            this.confirmDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.confirmDataGridView_EditingControlShowing);
            this.confirmDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmDataGridView_KeyPress);
            // 
            // maNV
            // 
            this.maNV.HeaderText = "Mã Nhân Viên";
            this.maNV.Name = "maNV";
            this.maNV.ReadOnly = true;
            // 
            // strTen
            // 
            this.strTen.HeaderText = "Tên NV";
            this.strTen.Name = "strTen";
            this.strTen.ReadOnly = true;
            // 
            // floatSoGio
            // 
            this.floatSoGio.HeaderText = "Số giờ";
            this.floatSoGio.Name = "floatSoGio";
            // 
            // congTrinh
            // 
            this.congTrinh.HeaderText = "Công Trình";
            this.congTrinh.Name = "congTrinh";
            this.congTrinh.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addPCBTN);
            this.panel2.Controls.Add(this.searchBTN);
            this.panel2.Controls.Add(this.nhanVienGridView);
            this.panel2.Controls.Add(this.searchContentTB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(9, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 478);
            this.panel2.TabIndex = 3;
            // 
            // addPCBTN
            // 
            this.addPCBTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addPCBTN.IconColor = System.Drawing.Color.Black;
            this.addPCBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addPCBTN.Location = new System.Drawing.Point(479, 415);
            this.addPCBTN.Name = "addPCBTN";
            this.addPCBTN.Size = new System.Drawing.Size(140, 59);
            this.addPCBTN.TabIndex = 7;
            this.addPCBTN.Text = ">>";
            this.addPCBTN.UseVisualStyleBackColor = true;
            this.addPCBTN.Click += new System.EventHandler(this.addPCBTN_Click);
            // 
            // searchBTN
            // 
            this.searchBTN.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBTN.IconColor = System.Drawing.Color.Black;
            this.searchBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBTN.IconSize = 26;
            this.searchBTN.Location = new System.Drawing.Point(486, 50);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(117, 29);
            this.searchBTN.TabIndex = 6;
            this.searchBTN.Text = "Tìm kiếm";
            this.searchBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // nhanVienGridView
            // 
            this.nhanVienGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nhanVienGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.nhanVienGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhanVienGridView.BackgroundColor = System.Drawing.Color.White;
            this.nhanVienGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nhanVienGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.nhanVienGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVienGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intMaNhanVien,
            this.txtTenNhanVien,
            this.txtNgaySinhNV,
            this.bitGioiTinhNV,
            this.txtDiaChi,
            this.txtMaPhongQL});
            this.nhanVienGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.nhanVienGridView.Location = new System.Drawing.Point(3, 85);
            this.nhanVienGridView.Name = "nhanVienGridView";
            this.nhanVienGridView.ReadOnly = true;
            this.nhanVienGridView.RowTemplate.Height = 50;
            this.nhanVienGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nhanVienGridView.Size = new System.Drawing.Size(616, 324);
            this.nhanVienGridView.TabIndex = 2;
            // 
            // intMaNhanVien
            // 
            this.intMaNhanVien.HeaderText = "Mã Nhân Viên";
            this.intMaNhanVien.Name = "intMaNhanVien";
            this.intMaNhanVien.ReadOnly = true;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.HeaderText = "Tên NV";
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            // 
            // txtNgaySinhNV
            // 
            this.txtNgaySinhNV.HeaderText = "Ngày sinh";
            this.txtNgaySinhNV.Name = "txtNgaySinhNV";
            this.txtNgaySinhNV.ReadOnly = true;
            // 
            // bitGioiTinhNV
            // 
            this.bitGioiTinhNV.HeaderText = "Giới Tính";
            this.bitGioiTinhNV.Name = "bitGioiTinhNV";
            this.bitGioiTinhNV.ReadOnly = true;
            this.bitGioiTinhNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.HeaderText = "Địa chỉ";
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            // 
            // txtMaPhongQL
            // 
            this.txtMaPhongQL.HeaderText = "Mã phòng quản lý";
            this.txtMaPhongQL.Name = "txtMaPhongQL";
            this.txtMaPhongQL.ReadOnly = true;
            // 
            // searchContentTB
            // 
            this.searchContentTB.Location = new System.Drawing.Point(3, 50);
            this.searchContentTB.Name = "searchContentTB";
            this.searchContentTB.Size = new System.Drawing.Size(477, 29);
            this.searchContentTB.TabIndex = 5;
            this.searchContentTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchContentTB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm kiếm thông tin NV";
            // 
            // congTrinhCB
            // 
            this.congTrinhCB.FormattingEnabled = true;
            this.congTrinhCB.Location = new System.Drawing.Point(9, 47);
            this.congTrinhCB.Name = "congTrinhCB";
            this.congTrinhCB.Size = new System.Drawing.Size(619, 29);
            this.congTrinhCB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Công trình";
            // 
            // nvTab
            // 
            this.nvTab.Location = new System.Drawing.Point(4, 30);
            this.nvTab.Name = "nvTab";
            this.nvTab.Padding = new System.Windows.Forms.Padding(3);
            this.nvTab.Size = new System.Drawing.Size(1304, 566);
            this.nvTab.TabIndex = 1;
            this.nvTab.Text = "Theo nhân viên";
            this.nvTab.UseVisualStyleBackColor = true;
            // 
            // fPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 676);
            this.Controls.Add(this.phancongTab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "fPhanCong";
            this.Text = "fPhanCong";
            this.phancongTab.ResumeLayout(false);
            this.congTrinhTab.ResumeLayout(false);
            this.congTrinhTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl phancongTab;
        private System.Windows.Forms.TabPage congTrinhTab;
        private System.Windows.Forms.ComboBox congTrinhCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage nvTab;
        private System.Windows.Forms.DataGridView nhanVienGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn intMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNgaySinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitGioiTinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaPhongQL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton searchBTN;
        private System.Windows.Forms.TextBox searchContentTB;
        private System.Windows.Forms.DataGridView confirmDataGridView;
        private FontAwesome.Sharp.IconButton addPCBTN;
        private FontAwesome.Sharp.IconButton phanCongBTN;
        private FontAwesome.Sharp.IconButton exitBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn strTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn floatSoGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn congTrinh;
    }
}