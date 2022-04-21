namespace quanLyLaoDong
{
    partial class searchControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.resultPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchCategoryCB = new System.Windows.Forms.ComboBox();
            this.searchBTN = new FontAwesome.Sharp.IconButton();
            this.searchContentTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultPanel
            // 
            this.resultPanel.AutoScroll = true;
            this.resultPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultPanel.Controls.Add(this.resultDataGridView);
            this.resultPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.resultPanel.Location = new System.Drawing.Point(3, 114);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Padding = new System.Windows.Forms.Padding(10);
            this.resultPanel.Size = new System.Drawing.Size(1108, 498);
            this.resultPanel.TabIndex = 4;
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.AllowUserToAddRows = false;
            this.resultDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.resultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.resultDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.resultDataGridView.Location = new System.Drawing.Point(13, 13);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.ReadOnly = true;
            this.resultDataGridView.RowTemplate.Height = 50;
            this.resultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultDataGridView.Size = new System.Drawing.Size(1078, 473);
            this.resultDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.searchCategoryCB);
            this.panel1.Controls.Add(this.searchBTN);
            this.panel1.Controls.Add(this.searchContentTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 101);
            this.panel1.TabIndex = 3;
            // 
            // searchCategoryCB
            // 
            this.searchCategoryCB.BackColor = System.Drawing.Color.White;
            this.searchCategoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCategoryCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.searchCategoryCB.FormattingEnabled = true;
            this.searchCategoryCB.Location = new System.Drawing.Point(386, 52);
            this.searchCategoryCB.Name = "searchCategoryCB";
            this.searchCategoryCB.Size = new System.Drawing.Size(121, 29);
            this.searchCategoryCB.TabIndex = 3;
            this.searchCategoryCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchCategoryCB_KeyPress);
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.White;
            this.searchBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(199)))), ((int)(((byte)(174)))));
            this.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.searchBTN.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBTN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.searchBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBTN.IconSize = 26;
            this.searchBTN.Location = new System.Drawing.Point(514, 52);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(117, 29);
            this.searchBTN.TabIndex = 4;
            this.searchBTN.Text = "Tìm kiếm";
            this.searchBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchContentTB
            // 
            this.searchContentTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))));
            this.searchContentTB.Location = new System.Drawing.Point(40, 52);
            this.searchContentTB.Name = "searchContentTB";
            this.searchContentTB.Size = new System.Drawing.Size(339, 29);
            this.searchContentTB.TabIndex = 2;
            this.searchContentTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchContentTB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "searchControl";
            this.Size = new System.Drawing.Size(1114, 620);
            this.resultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel resultPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchContentTB;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.ComboBox searchCategoryCB;
        private FontAwesome.Sharp.IconButton searchBTN;
    }
}
