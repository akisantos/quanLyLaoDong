namespace quanLyLaoDong
{
    partial class fCongTrinhAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tenCTTB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctNameTB = new System.Windows.Forms.TextBox();
            this.ctPosTB = new System.Windows.Forms.TextBox();
            this.ngayCapPhepDP = new System.Windows.Forms.DateTimePicker();
            this.ngayKhoiCongDP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.phongQLTB = new System.Windows.Forms.ComboBox();
            this.ngayHoanThanhDP = new System.Windows.Forms.DateTimePicker();
            this.addBTN = new FontAwesome.Sharp.IconButton();
            this.cancelBTN = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm công trình";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelBTN);
            this.panel1.Controls.Add(this.addBTN);
            this.panel1.Controls.Add(this.ngayHoanThanhDP);
            this.panel1.Controls.Add(this.phongQLTB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ngayKhoiCongDP);
            this.panel1.Controls.Add(this.ngayCapPhepDP);
            this.panel1.Controls.Add(this.ctPosTB);
            this.panel1.Controls.Add(this.ctNameTB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tenCTTB);
            this.panel1.Location = new System.Drawing.Point(39, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 364);
            this.panel1.TabIndex = 1;
            // 
            // tenCTTB
            // 
            this.tenCTTB.AutoSize = true;
            this.tenCTTB.Location = new System.Drawing.Point(3, 34);
            this.tenCTTB.Name = "tenCTTB";
            this.tenCTTB.Size = new System.Drawing.Size(108, 21);
            this.tenCTTB.TabIndex = 0;
            this.tenCTTB.Text = "Tên công trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày khởi công";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày cấp phép";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày hoàn thành";
            // 
            // ctNameTB
            // 
            this.ctNameTB.Location = new System.Drawing.Point(129, 31);
            this.ctNameTB.Name = "ctNameTB";
            this.ctNameTB.Size = new System.Drawing.Size(508, 29);
            this.ctNameTB.TabIndex = 5;
            // 
            // ctPosTB
            // 
            this.ctPosTB.Location = new System.Drawing.Point(129, 66);
            this.ctPosTB.Name = "ctPosTB";
            this.ctPosTB.Size = new System.Drawing.Size(508, 29);
            this.ctPosTB.TabIndex = 6;
            // 
            // ngayCapPhepDP
            // 
            this.ngayCapPhepDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayCapPhepDP.Location = new System.Drawing.Point(129, 172);
            this.ngayCapPhepDP.Name = "ngayCapPhepDP";
            this.ngayCapPhepDP.Size = new System.Drawing.Size(247, 29);
            this.ngayCapPhepDP.TabIndex = 7;
            // 
            // ngayKhoiCongDP
            // 
            this.ngayKhoiCongDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayKhoiCongDP.Location = new System.Drawing.Point(129, 216);
            this.ngayKhoiCongDP.Name = "ngayKhoiCongDP";
            this.ngayKhoiCongDP.Size = new System.Drawing.Size(247, 29);
            this.ngayKhoiCongDP.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phòng quản lý";
            // 
            // phongQLTB
            // 
            this.phongQLTB.FormattingEnabled = true;
            this.phongQLTB.Location = new System.Drawing.Point(129, 124);
            this.phongQLTB.Name = "phongQLTB";
            this.phongQLTB.Size = new System.Drawing.Size(508, 29);
            this.phongQLTB.TabIndex = 10;
            // 
            // ngayHoanThanhDP
            // 
            this.ngayHoanThanhDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayHoanThanhDP.Location = new System.Drawing.Point(129, 260);
            this.ngayHoanThanhDP.Name = "ngayHoanThanhDP";
            this.ngayHoanThanhDP.Size = new System.Drawing.Size(247, 29);
            this.ngayHoanThanhDP.TabIndex = 11;
            // 
            // addBTN
            // 
            this.addBTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addBTN.IconColor = System.Drawing.Color.Black;
            this.addBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBTN.Location = new System.Drawing.Point(405, 312);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(113, 49);
            this.addBTN.TabIndex = 12;
            this.addBTN.Text = "Thêm";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cancelBTN.IconColor = System.Drawing.Color.Black;
            this.cancelBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelBTN.Location = new System.Drawing.Point(524, 312);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(113, 49);
            this.cancelBTN.TabIndex = 13;
            this.cancelBTN.Text = "Hủy";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // fCongTrinhAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fCongTrinhAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm công trình";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker ngayHoanThanhDP;
        private System.Windows.Forms.ComboBox phongQLTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ngayKhoiCongDP;
        private System.Windows.Forms.DateTimePicker ngayCapPhepDP;
        private System.Windows.Forms.TextBox ctPosTB;
        private System.Windows.Forms.TextBox ctNameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tenCTTB;
        private FontAwesome.Sharp.IconButton addBTN;
        private FontAwesome.Sharp.IconButton cancelBTN;
    }
}