﻿namespace quanLyLaoDong
{
    partial class accountControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hiTB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminViewTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.congTrinhDataGridView = new System.Windows.Forms.DataGridView();
            this.MaCongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhoiCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCapPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoanThanhDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.congTrinhDelBtn = new FontAwesome.Sharp.IconButton();
            this.congTrinhEditBtn = new FontAwesome.Sharp.IconButton();
            this.searchCongTrinhBtn = new FontAwesome.Sharp.IconButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nvXoaBTN = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.addNVBTN = new FontAwesome.Sharp.IconButton();
            this.nhanVienGridView = new System.Windows.Forms.DataGridView();
            this.intMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgaySinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitGioiTinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaPhongQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.phongBanDeleteBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.phongBanDataGridView = new System.Windows.Forms.DataGridView();
            this.intMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.adminViewTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.congTrinhDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.hiTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 506);
            this.panel2.TabIndex = 4;
            // 
            // hiTB
            // 
            this.hiTB.AutoSize = true;
            this.hiTB.Location = new System.Drawing.Point(40, 63);
            this.hiTB.Name = "hiTB";
            this.hiTB.Size = new System.Drawing.Size(98, 21);
            this.hiTB.TabIndex = 1;
            this.hiTB.Text = "Xin chào aki!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nâng cao";
            // 
            // adminViewTab
            // 
            this.adminViewTab.Controls.Add(this.tabPage1);
            this.adminViewTab.Controls.Add(this.tabPage2);
            this.adminViewTab.Controls.Add(this.tabPage3);
            this.adminViewTab.Controls.Add(this.tabPage4);
            this.adminViewTab.Location = new System.Drawing.Point(3, 114);
            this.adminViewTab.Name = "adminViewTab";
            this.adminViewTab.SelectedIndex = 0;
            this.adminViewTab.Size = new System.Drawing.Size(1108, 503);
            this.adminViewTab.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1100, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Công trình";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.congTrinhDataGridView);
            this.panel4.Location = new System.Drawing.Point(6, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1085, 372);
            this.panel4.TabIndex = 1;
            // 
            // congTrinhDataGridView
            // 
            this.congTrinhDataGridView.AllowUserToAddRows = false;
            this.congTrinhDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.congTrinhDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.congTrinhDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.congTrinhDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.congTrinhDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.congTrinhDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.congTrinhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.congTrinhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCongTrinh,
            this.TenGoi,
            this.DiaDiem,
            this.NgayKhoiCong,
            this.NgayCapPhep,
            this.NgayHoanThanhDuKien,
            this.MaPhong});
            this.congTrinhDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.congTrinhDataGridView.Location = new System.Drawing.Point(4, 4);
            this.congTrinhDataGridView.Name = "congTrinhDataGridView";
            this.congTrinhDataGridView.RowTemplate.Height = 50;
            this.congTrinhDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.congTrinhDataGridView.Size = new System.Drawing.Size(1078, 389);
            this.congTrinhDataGridView.TabIndex = 0;
            // 
            // MaCongTrinh
            // 
            this.MaCongTrinh.HeaderText = "Mã Công Trình";
            this.MaCongTrinh.Name = "MaCongTrinh";
            // 
            // TenGoi
            // 
            this.TenGoi.HeaderText = "Tên Công Trình";
            this.TenGoi.Name = "TenGoi";
            // 
            // DiaDiem
            // 
            this.DiaDiem.HeaderText = "Địa Điểm";
            this.DiaDiem.Name = "DiaDiem";
            // 
            // NgayKhoiCong
            // 
            this.NgayKhoiCong.HeaderText = "Ngày Khởi Công";
            this.NgayKhoiCong.Name = "NgayKhoiCong";
            // 
            // NgayCapPhep
            // 
            this.NgayCapPhep.HeaderText = "Ngày Cấp Phép";
            this.NgayCapPhep.Name = "NgayCapPhep";
            // 
            // NgayHoanThanhDuKien
            // 
            this.NgayHoanThanhDuKien.HeaderText = "Ngày Hoàn Thành Dự Kiến";
            this.NgayHoanThanhDuKien.Name = "NgayHoanThanhDuKien";
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã Phòng Quản Lý";
            this.MaPhong.Name = "MaPhong";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.congTrinhDelBtn);
            this.panel3.Controls.Add(this.congTrinhEditBtn);
            this.panel3.Controls.Add(this.searchCongTrinhBtn);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1088, 79);
            this.panel3.TabIndex = 0;
            // 
            // congTrinhDelBtn
            // 
            this.congTrinhDelBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.congTrinhDelBtn.IconColor = System.Drawing.Color.Black;
            this.congTrinhDelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.congTrinhDelBtn.Location = new System.Drawing.Point(263, 3);
            this.congTrinhDelBtn.Name = "congTrinhDelBtn";
            this.congTrinhDelBtn.Size = new System.Drawing.Size(121, 73);
            this.congTrinhDelBtn.TabIndex = 4;
            this.congTrinhDelBtn.Text = "Xóa";
            this.congTrinhDelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.congTrinhDelBtn.UseVisualStyleBackColor = true;
            // 
            // congTrinhEditBtn
            // 
            this.congTrinhEditBtn.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.congTrinhEditBtn.IconColor = System.Drawing.Color.Black;
            this.congTrinhEditBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.congTrinhEditBtn.Location = new System.Drawing.Point(136, 3);
            this.congTrinhEditBtn.Name = "congTrinhEditBtn";
            this.congTrinhEditBtn.Size = new System.Drawing.Size(121, 73);
            this.congTrinhEditBtn.TabIndex = 3;
            this.congTrinhEditBtn.Text = "Sửa";
            this.congTrinhEditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.congTrinhEditBtn.UseVisualStyleBackColor = true;
            // 
            // searchCongTrinhBtn
            // 
            this.searchCongTrinhBtn.IconChar = FontAwesome.Sharp.IconChar.SteamSymbol;
            this.searchCongTrinhBtn.IconColor = System.Drawing.Color.Black;
            this.searchCongTrinhBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchCongTrinhBtn.Location = new System.Drawing.Point(4, 3);
            this.searchCongTrinhBtn.Name = "searchCongTrinhBtn";
            this.searchCongTrinhBtn.Size = new System.Drawing.Size(121, 73);
            this.searchCongTrinhBtn.TabIndex = 2;
            this.searchCongTrinhBtn.Text = "Thêm";
            this.searchCongTrinhBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchCongTrinhBtn.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nvXoaBTN);
            this.tabPage2.Controls.Add(this.iconButton1);
            this.tabPage2.Controls.Add(this.addNVBTN);
            this.tabPage2.Controls.Add(this.nhanVienGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1100, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nvXoaBTN
            // 
            this.nvXoaBTN.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.nvXoaBTN.IconColor = System.Drawing.Color.Black;
            this.nvXoaBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nvXoaBTN.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.nvXoaBTN.Location = new System.Drawing.Point(269, 15);
            this.nvXoaBTN.Name = "nvXoaBTN";
            this.nvXoaBTN.Size = new System.Drawing.Size(125, 64);
            this.nvXoaBTN.TabIndex = 4;
            this.nvXoaBTN.Text = "Xóa";
            this.nvXoaBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nvXoaBTN.UseVisualStyleBackColor = true;
            this.nvXoaBTN.Click += new System.EventHandler(this.nvXoaBTN_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton1.Location = new System.Drawing.Point(138, 15);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(125, 64);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Sửa";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // addNVBTN
            // 
            this.addNVBTN.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.addNVBTN.IconColor = System.Drawing.Color.Black;
            this.addNVBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addNVBTN.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addNVBTN.Location = new System.Drawing.Point(6, 15);
            this.addNVBTN.Name = "addNVBTN";
            this.addNVBTN.Size = new System.Drawing.Size(125, 64);
            this.addNVBTN.TabIndex = 2;
            this.addNVBTN.Text = "Thêm";
            this.addNVBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNVBTN.UseVisualStyleBackColor = true;
            this.addNVBTN.Click += new System.EventHandler(this.addNVBTN_Click);
            // 
            // nhanVienGridView
            // 
            this.nhanVienGridView.AllowUserToAddRows = false;
            this.nhanVienGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nhanVienGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.nhanVienGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhanVienGridView.BackgroundColor = System.Drawing.Color.White;
            this.nhanVienGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nhanVienGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.nhanVienGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVienGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intMaNhanVien,
            this.txtTenNhanVien,
            this.txtNgaySinhNV,
            this.bitGioiTinhNV,
            this.txtDiaChi,
            this.txtMaPhongQL});
            this.nhanVienGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.nhanVienGridView.Location = new System.Drawing.Point(6, 94);
            this.nhanVienGridView.Name = "nhanVienGridView";
            this.nhanVienGridView.ReadOnly = true;
            this.nhanVienGridView.RowTemplate.Height = 50;
            this.nhanVienGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nhanVienGridView.Size = new System.Drawing.Size(1088, 369);
            this.nhanVienGridView.TabIndex = 1;
            this.nhanVienGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhanVienGridView_CellDoubleClick);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.phongBanDeleteBtn);
            this.tabPage3.Controls.Add(this.iconButton7);
            this.tabPage3.Controls.Add(this.phongBanDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1100, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Phòng ban";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // phongBanDeleteBtn
            // 
            this.phongBanDeleteBtn.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.phongBanDeleteBtn.IconColor = System.Drawing.Color.Black;
            this.phongBanDeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.phongBanDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.phongBanDeleteBtn.Location = new System.Drawing.Point(138, 17);
            this.phongBanDeleteBtn.Name = "phongBanDeleteBtn";
            this.phongBanDeleteBtn.Size = new System.Drawing.Size(125, 64);
            this.phongBanDeleteBtn.TabIndex = 7;
            this.phongBanDeleteBtn.Text = "Xóa";
            this.phongBanDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.phongBanDeleteBtn.UseVisualStyleBackColor = true;
            this.phongBanDeleteBtn.Click += new System.EventHandler(this.phongBanDeleteBtn_Click);
            // 
            // iconButton7
            // 
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton7.Location = new System.Drawing.Point(6, 17);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(125, 64);
            this.iconButton7.TabIndex = 5;
            this.iconButton7.Text = "Thêm";
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = true;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // phongBanDataGridView
            // 
            this.phongBanDataGridView.AllowUserToAddRows = false;
            this.phongBanDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.phongBanDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.phongBanDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phongBanDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.phongBanDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.phongBanDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.phongBanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phongBanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intMaPhong,
            this.dataGridViewTextBoxColumn8});
            this.phongBanDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.phongBanDataGridView.Location = new System.Drawing.Point(3, 100);
            this.phongBanDataGridView.Name = "phongBanDataGridView";
            this.phongBanDataGridView.ReadOnly = true;
            this.phongBanDataGridView.RowTemplate.Height = 50;
            this.phongBanDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phongBanDataGridView.Size = new System.Drawing.Size(1097, 369);
            this.phongBanDataGridView.TabIndex = 2;
            // 
            // intMaPhong
            // 
            this.intMaPhong.HeaderText = "Mã phòng";
            this.intMaPhong.Name = "intMaPhong";
            this.intMaPhong.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Tên phòng";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.accountDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1100, 469);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tài khoản";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // accountDataGridView
            // 
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.Location = new System.Drawing.Point(3, 6);
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.Size = new System.Drawing.Size(569, 460);
            this.accountDataGridView.TabIndex = 0;
            // 
            // accountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminViewTab);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "accountControl";
            this.Size = new System.Drawing.Size(1114, 620);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.adminViewTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.congTrinhDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phongBanDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label hiTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl adminViewTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton searchCongTrinhBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView congTrinhDataGridView;
        private System.Windows.Forms.DataGridView accountDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhoiCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoanThanhDuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridView nhanVienGridView;
        private FontAwesome.Sharp.IconButton nvXoaBTN;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton addNVBTN;
        private FontAwesome.Sharp.IconButton congTrinhDelBtn;
        private FontAwesome.Sharp.IconButton congTrinhEditBtn;
        private System.Windows.Forms.DataGridView phongBanDataGridView;
        private FontAwesome.Sharp.IconButton phongBanDeleteBtn;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.DataGridViewTextBoxColumn intMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNgaySinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitGioiTinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaPhongQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn intMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
