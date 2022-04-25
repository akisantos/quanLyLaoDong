using quanLyLaoDong.DAO;
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
    public partial class fCTEdit : Form
    {
        int maCongTrinh;

        public fCTEdit()
        {
            InitializeComponent();
            InitData();
        }
        public int MaCTTrans
        {
            set { maCongTrinh = value; }
        }
        public string tenCongTrinhTrans
        {
            set { ctNameTB.Text = value;  }
        }
        public string diaDiemTrans
        {
            set { ctPosTB.Text = value; }
        }

        public int PhongQuanLyTrans
        {
            set { phongQLTB.SelectedValue = value; }
        }

        public DateTime ngayCapPhepTrans
        {
            set {
                string holder1 = value.ToString();
                string[] holder = holder1.Split(' ');
                ngayCapPhepDP.Value = DateTime.Parse(holder[0]);
            }
        }

        public DateTime ngayKCTrans
        {
            set {
                string holder1 = value.ToString();
                string[] holder = holder1.Split(' ');
                ngayKhoiCongDP.Value = DateTime.Parse(holder[0]);
            }
        }

        public DateTime ngayKTTrans
        {
            set {
                string holder1 = value.ToString();
                string[] holder = holder1.Split(' ');
                ngayHoanThanhDP.Value = DateTime.Parse(holder[0]);
            }
        }


        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        void InitData()
        {

            //get data for PhongBan
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from dbo.PhongBan");
            phongQLTB.ValueMember = "MaPhong";
            phongQLTB.DisplayMember = "TenPhong";

            DataRow dr = data.NewRow();
            dr[0] = 0;
            dr[1] = "- Chọn một";
            data.Rows.InsertAt(dr, 0);
            phongQLTB.DataSource = data;
            phongQLTB.DropDownStyle = ComboBoxStyle.DropDownList;

            
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ctNameTB.Text) && !String.IsNullOrEmpty(ctPosTB.Text))
            {
                int ID = maCongTrinh;
                string tenCT = ctNameTB.Text;   
                string diaDiem = ctPosTB.Text;
                int phongQL = (int)phongQLTB.SelectedValue;
                DateTime ngayKhoiCong = ngayKhoiCongDP.Value;
                DateTime ngayCapKPhep = ngayCapPhepDP.Value;
                DateTime ngayHoanThanh = ngayHoanThanhDP.Value;

                int holder = DataProvider.Instance.ExcuteNonQuery("editCongTrinh @MaCongTrinh , @Tengoi , @DiaChi , @MaPhongQL , @NgayCapPhep , @NgayKhoiCong , @NgayHoanThanh", 
                    new object[] { ID, tenCT, diaDiem, phongQL , ngayCapKPhep , ngayKhoiCong, ngayHoanThanh});

                if (holder != -1)
                {
                    MessageBox.Show("Đã cập nhật!","Thông báo");
                    Close();
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi!", "Thông báo");
                    Close();
                }
            }
        }
    }
}
