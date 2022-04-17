﻿using quanLyLaoDong.DAO;
using quanLyLaoDong.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyLaoDong
{
    public partial class mainMenuControl : UserControl
    {
        public mainMenuControl()
        {
            InitializeComponent();

            loadProjectStatusTest();
        }

        private void statusPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Method
        void loadProjectStatusTest()
        {
            List<CongTrinh> congTrinhList = CongTrinhDAO.Instance.LoadCongTrinh();

            foreach (var item in congTrinhList)
            {


                Button statusButton = new FontAwesome.Sharp.IconButton();
                statusButton.Text = "Dự án: "+ item.Name +"\nNgày khởi công: "+item.NgayKhoiCong+"\nNgày cấp phép: "+ item.NgayCapPhep + "\nNgày hoàn thành dự kiến: " + item.NgayHoanThanhDuKien;
                statusButton.Width = 250;
                statusButton.Height = 120;
                statusButton.BackColor = Color.FromArgb(0, 223, 246, 255);
                statusButton.ForeColor = Color.FromArgb(1, 5, 19, 103);
                statusButton.FlatStyle = FlatStyle.Flat;
                statusButton.TextAlign = ContentAlignment.MiddleLeft;
                statusButton.Click += button_Click;
                statusPanel.Controls.Add(statusButton);
            }
            /*
            Button statusButton = new FontAwesome.Sharp.IconButton();
            statusButton.Text = "Dự án Aki \nNgày khởi công: 03 / 02 / 2018\nSố lượng nhân viên: 100\nPhòng quản lý: Phòng quản lý dự án 01";
            statusButton.Width = 250;
            statusButton.Height = 120;
            statusButton.BackColor = Color.FromArgb(0, 223, 246, 255);
            statusButton.ForeColor = Color.FromArgb(1, 5, 19, 103);
            statusButton.FlatStyle = FlatStyle.Flat;
            statusButton.TextAlign = ContentAlignment.MiddleLeft;
            statusButton.Click += button_Click;
            statusPanel.Controls.Add(statusButton);

            */
        }

        #endregion


        void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Text);
        }
    }
}
