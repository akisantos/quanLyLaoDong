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
            List<PhanCong> phanCongList = PhanCongDAO.Instance.LoadPhanCong();
            List<PhongBan> phongBanList = PhongBanDAO.Instance.LoadPhongBan();
            int NV = 0;
            string tenPhong = "";
            foreach (var item in congTrinhList)
            {
                foreach (var item2 in phanCongList)
                {
                    if (item2.MaCongTrinh == item.Id) NV++;
                }
                foreach (var item3 in phongBanList)
                {
                    if (item3.MaPhong == item.MaPhongQL) tenPhong = item3.TenPhong;
                }

                projectInfo ttda = new projectInfo();
                if (DateTime.Parse(item.NgayKhoiCong) < DateTime.Now)
                {
                    ttda.BackColor = Color.FromArgb(249, 255, 164);
                }
                
                if (DateTime.Parse(item.NgayKhoiCong) < DateTime.Parse(item.NgayCapPhep)){
                    ttda.BackColor = Color.FromArgb(253, 93, 93);
                    ttda.ForeColor = Color.White;
                }
                
                ttda.tenCongTrinhTrans = item.Name;
                ttda.tenPhongBanTras = tenPhong;
                ttda.ngayCapPhepTrans = item.NgayCapPhep;
                ttda.NgayKhoiCongTrans = item.NgayKhoiCong;
                ttda.ngayHoanThanhTrans = item.NgayHoanThanhDuKien;
                ttda.soNguoiTrans = NV;
               
                statusPanel.Controls.Add(ttda);
                NV = 0; tenPhong = "";
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
