using quanLyLaoDong.DAO;
using quanLyLaoDong.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyLaoDong
{
    public partial class accountControl : UserControl
    {
        public accountControl()
        {
            InitializeComponent();
            LoadAccount();
            LoadCongTrinh();
            LoadNhanVien();
        }


        void LoadAccount()
        {
            DataProvider data = new DataProvider();
            accountDataGridView.DataSource = data.ExcuteQuery("select * from dbo.Account");
        }

        void LoadCongTrinh()
        {
            List<CongTrinh> congTrinhList = CongTrinhDAO.Instance.LoadCongTrinh();

            foreach (var item in congTrinhList)
            {
                congTrinhDataGridView.Rows.Add(item.Id, item.Name, item.DiaDiem, item.NgayKhoiCong, item.NgayCapPhep, item.NgayHoanThanhDuKien, item.MaPhongQL);
            }
        }

        void LoadNhanVien()
        {
            List<NhanVien> nvList = NhanVienDAO.Instance.LoadNhanVien();

            foreach (var item in nvList)
            {
                nhanVienGridView.Rows.Add(item.Id, item.TenNV, item.NgaySinh, item.GioiTinh, item.DiaChi, item.MaPhong);
            }
        }
    }

}
