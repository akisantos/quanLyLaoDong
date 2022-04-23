namespace quanLyLaoDong
{
    partial class fPhanCongEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPhanCongEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.nvTB = new System.Windows.Forms.Label();
            this.ctTB = new System.Windows.Forms.Label();
            this.soGioTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.maPCTB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉnh sửa giờ phân công";
            // 
            // nvTB
            // 
            this.nvTB.AutoSize = true;
            this.nvTB.Location = new System.Drawing.Point(38, 105);
            this.nvTB.Name = "nvTB";
            this.nvTB.Size = new System.Drawing.Size(148, 21);
            this.nvTB.TabIndex = 1;
            this.nvTB.Text = "Thông tin nhân viên";
            // 
            // ctTB
            // 
            this.ctTB.AutoSize = true;
            this.ctTB.Location = new System.Drawing.Point(38, 139);
            this.ctTB.Name = "ctTB";
            this.ctTB.Size = new System.Drawing.Size(124, 21);
            this.ctTB.TabIndex = 2;
            this.ctTB.Text = "thuộc công trình";
            // 
            // soGioTB
            // 
            this.soGioTB.Location = new System.Drawing.Point(42, 207);
            this.soGioTB.Name = "soGioTB";
            this.soGioTB.Size = new System.Drawing.Size(177, 29);
            this.soGioTB.TabIndex = 3;
            this.soGioTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soGioTB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập số giờ";
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(225, 207);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(100, 29);
            this.updateBTN.TabIndex = 5;
            this.updateBTN.Text = "Nhập";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(331, 206);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(100, 29);
            this.cancelBTN.TabIndex = 6;
            this.cancelBTN.Text = "Hủy";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // maPCTB
            // 
            this.maPCTB.AutoSize = true;
            this.maPCTB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maPCTB.Location = new System.Drawing.Point(12, 252);
            this.maPCTB.Name = "maPCTB";
            this.maPCTB.Size = new System.Drawing.Size(83, 13);
            this.maPCTB.TabIndex = 7;
            this.maPCTB.Text = "Mã Phân Công";
            // 
            // fPhanCongEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 274);
            this.Controls.Add(this.maPCTB);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soGioTB);
            this.Controls.Add(this.ctTB);
            this.Controls.Add(this.nvTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fPhanCongEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa giờ phân công";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nvTB;
        private System.Windows.Forms.Label ctTB;
        private System.Windows.Forms.TextBox soGioTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Label maPCTB;
    }
}