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
    public partial class projectInfo : UserControl
    {
        public projectInfo()
        {
            InitializeComponent();
        }

        public string tenCongTrinhTrans
        {
            set { projectNameLB.Text = value; }
        }
        public string tenPhongBanTras
        {
            set { phongLB.Text = value; }
        }
        public string NgayKhoiCongTrans
        {
            set { ngayKhoiCongLB.Text = DateTime.Parse(value).ToShortDateString(); }
        }
        public string ngayCapPhepTrans
        {
            set { ngayCapPhepLB.Text = DateTime.Parse(value).ToShortDateString(); }
        }
        public string ngayHoanThanhTrans
        {
            set { ngayHoanThanhLB.Text = DateTime.Parse(value).ToShortDateString(); }
        }
        public int soNguoiTrans
        {
            set { soNhanVienLB.Text = value.ToString(); }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
