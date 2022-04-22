using quanLyLaoDong.DAO;
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
                statusButton.Text = "Dự án: "+ item.Name +"\nNgày khởi công: "+ DateTime.Parse(item.NgayKhoiCong).ToShortDateString()+"\nNgày cấp phép: " + DateTime.Parse(item.NgayCapPhep).ToShortDateString()  + "\nNgày hoàn thành dự kiến: " + DateTime.Parse(item.NgayHoanThanhDuKien).ToShortDateString();
                statusButton.Width = 250;
                statusButton.Height = 320;
                statusButton.BackColor = Color.FromArgb(255, 255, 255);
                statusButton.ForeColor = Color.FromArgb(33, 129, 115);
                statusButton.FlatStyle = FlatStyle.Flat;
                statusButton.TextAlign = ContentAlignment.MiddleLeft;
                statusButton.Click += button_Click;
                
                statusPanel.Controls.Add(statusButton);
            }
           
        }

        #endregion


        void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Text);
        }
    }
}
