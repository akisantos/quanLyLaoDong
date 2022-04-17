namespace quanLyLaoDong
{
    partial class mainMenuControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hiTB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hiTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 100);
            this.panel1.TabIndex = 1;
            // 
            // hiTB
            // 
            this.hiTB.AutoSize = true;
            this.hiTB.Location = new System.Drawing.Point(40, 63);
            this.hiTB.Name = "hiTB";
            this.hiTB.Size = new System.Drawing.Size(171, 21);
            this.hiTB.TabIndex = 1;
            this.hiTB.Text = "Thông tin về công trình";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin dự án";
            // 
            // statusPanel
            // 
            this.statusPanel.AutoScroll = true;
            this.statusPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statusPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusPanel.Location = new System.Drawing.Point(3, 106);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(1096, 498);
            this.statusPanel.TabIndex = 2;
            // 
            // mainMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.panel1);
            this.Name = "mainMenuControl";
            this.Size = new System.Drawing.Size(1114, 620);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel statusPanel;
        private System.Windows.Forms.Label hiTB;
    }
}
