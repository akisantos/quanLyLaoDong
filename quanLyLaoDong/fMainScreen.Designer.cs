namespace quanLyLaoDong
{
    partial class fMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.helloTxt = new System.Windows.Forms.Label();
            this.quitButton = new FontAwesome.Sharp.IconButton();
            this.accountManagerBTN = new FontAwesome.Sharp.IconButton();
            this.editModeBTN = new FontAwesome.Sharp.IconButton();
            this.searchBTN = new FontAwesome.Sharp.IconButton();
            this.mainScreenBTN = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenuControl1 = new quanLyLaoDong.mainMenuControl();
            this.searchControl1 = new quanLyLaoDong.searchControl();
            this.phanCongControl1 = new quanLyLaoDong.phanCongControl();
            this.accountControl1 = new quanLyLaoDong.accountControl();
            this.infoLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(143)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.infoLB);
            this.panel1.Controls.Add(this.helloTxt);
            this.panel1.Controls.Add(this.quitButton);
            this.panel1.Controls.Add(this.accountManagerBTN);
            this.panel1.Controls.Add(this.editModeBTN);
            this.panel1.Controls.Add(this.searchBTN);
            this.panel1.Controls.Add(this.mainScreenBTN);
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 529);
            this.panel1.TabIndex = 0;
            // 
            // helloTxt
            // 
            this.helloTxt.AutoSize = true;
            this.helloTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloTxt.Location = new System.Drawing.Point(9, 435);
            this.helloTxt.Name = "helloTxt";
            this.helloTxt.Size = new System.Drawing.Size(0, 17);
            this.helloTxt.TabIndex = 5;
            // 
            // quitButton
            // 
            this.quitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(199)))), ((int)(((byte)(174)))));
            this.quitButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.quitButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(199)))), ((int)(((byte)(174)))));
            this.quitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.quitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.quitButton.Location = new System.Drawing.Point(0, 296);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(142, 74);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Thoát";
            this.quitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // accountManagerBTN
            // 
            this.accountManagerBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountManagerBTN.FlatAppearance.BorderSize = 0;
            this.accountManagerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountManagerBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountManagerBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(199)))), ((int)(((byte)(174)))));
            this.accountManagerBTN.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.accountManagerBTN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(199)))), ((int)(((byte)(174)))));
            this.accountManagerBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountManagerBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.accountManagerBTN.Location = new System.Drawing.Point(0, 222);
            this.accountManagerBTN.Name = "accountManagerBTN";
            this.accountManagerBTN.Size = new System.Drawing.Size(142, 74);
            this.accountManagerBTN.TabIndex = 3;
            this.accountManagerBTN.Text = "Quản lý nâng cao";
            this.accountManagerBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.accountManagerBTN.UseVisualStyleBackColor = true;
            this.accountManagerBTN.Click += new System.EventHandler(this.accountManagerBTN_Click);
            // 
            // editModeBTN
            // 
            this.editModeBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.editModeBTN.FlatAppearance.BorderSize = 0;
            this.editModeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editModeBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editModeBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(199)))), ((int)(((byte)(174)))));
            this.editModeBTN.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.editModeBTN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(199)))), ((int)(((byte)(174)))));
            this.editModeBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editModeBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editModeBTN.Location = new System.Drawing.Point(0, 148);
            this.editModeBTN.Name = "editModeBTN";
            this.editModeBTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editModeBTN.Size = new System.Drawing.Size(142, 74);
            this.editModeBTN.TabIndex = 2;
            this.editModeBTN.Text = "Phân công";
            this.editModeBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editModeBTN.UseVisualStyleBackColor = true;
            this.editModeBTN.Click += new System.EventHandler(this.editModeBTN_Click);
            // 
            // searchBTN
            // 
            this.searchBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBTN.FlatAppearance.BorderSize = 0;
            this.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(199)))), ((int)(((byte)(174)))));
            this.searchBTN.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBTN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(199)))), ((int)(((byte)(174)))));
            this.searchBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBTN.Location = new System.Drawing.Point(0, 74);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(142, 74);
            this.searchBTN.TabIndex = 1;
            this.searchBTN.Text = "Tìm kiếm";
            this.searchBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // mainScreenBTN
            // 
            this.mainScreenBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.mainScreenBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainScreenBTN.FlatAppearance.BorderSize = 0;
            this.mainScreenBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainScreenBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenBTN.ForeColor = System.Drawing.Color.White;
            this.mainScreenBTN.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.mainScreenBTN.IconColor = System.Drawing.Color.White;
            this.mainScreenBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mainScreenBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainScreenBTN.Location = new System.Drawing.Point(0, 0);
            this.mainScreenBTN.Name = "mainScreenBTN";
            this.mainScreenBTN.Size = new System.Drawing.Size(142, 74);
            this.mainScreenBTN.TabIndex = 0;
            this.mainScreenBTN.Text = "Màn hình chính";
            this.mainScreenBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mainScreenBTN.UseVisualStyleBackColor = false;
            this.mainScreenBTN.Click += new System.EventHandler(this.mainScreenBTN_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1248, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 625);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(143)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 113);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quanLyLaoDong.Properties.Resources.firmefoxm_icon_by_imyamak_de8uzca;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainMenuControl1
            // 
            this.mainMenuControl1.BackColor = System.Drawing.Color.White;
            this.mainMenuControl1.Location = new System.Drawing.Point(142, 0);
            this.mainMenuControl1.Name = "mainMenuControl1";
            this.mainMenuControl1.Size = new System.Drawing.Size(1109, 625);
            this.mainMenuControl1.TabIndex = 2;
            // 
            // searchControl1
            // 
            this.searchControl1.BackColor = System.Drawing.Color.White;
            this.searchControl1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchControl1.Location = new System.Drawing.Point(142, 0);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(0);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(1109, 625);
            this.searchControl1.TabIndex = 6;
            // 
            // phanCongControl1
            // 
            this.phanCongControl1.BackColor = System.Drawing.Color.White;
            this.phanCongControl1.Location = new System.Drawing.Point(142, 0);
            this.phanCongControl1.Margin = new System.Windows.Forms.Padding(0);
            this.phanCongControl1.Name = "phanCongControl1";
            this.phanCongControl1.Size = new System.Drawing.Size(1109, 625);
            this.phanCongControl1.TabIndex = 5;
            // 
            // accountControl1
            // 
            this.accountControl1.BackColor = System.Drawing.Color.White;
            this.accountControl1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.accountControl1.Location = new System.Drawing.Point(142, 0);
            this.accountControl1.Margin = new System.Windows.Forms.Padding(0);
            this.accountControl1.Name = "accountControl1";
            this.accountControl1.Size = new System.Drawing.Size(1109, 625);
            this.accountControl1.TabIndex = 4;
            // 
            // infoLB
            // 
            this.infoLB.AutoSize = true;
            this.infoLB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLB.ForeColor = System.Drawing.Color.White;
            this.infoLB.Location = new System.Drawing.Point(3, 484);
            this.infoLB.Name = "infoLB";
            this.infoLB.Size = new System.Drawing.Size(54, 13);
            this.infoLB.TabIndex = 6;
            this.infoLB.Text = "Xin chào!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phiên bản 0.0.0.0";
            // 
            // fMainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainMenuControl1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.phanCongControl1);
            this.Controls.Add(this.accountControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton mainScreenBTN;
        private FontAwesome.Sharp.IconButton quitButton;
        private FontAwesome.Sharp.IconButton accountManagerBTN;
        private FontAwesome.Sharp.IconButton editModeBTN;
        private FontAwesome.Sharp.IconButton searchBTN;
        private System.Windows.Forms.Label helloTxt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private mainMenuControl mainMenuControl1;
        private System.Windows.Forms.Panel panel2;
        private accountControl accountControl1;
        private phanCongControl phanCongControl1;
        private searchControl searchControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label infoLB;
        private System.Windows.Forms.Label label1;
    }
}