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
    public partial class fCongTrinhAdd : Form
    {
        public fCongTrinhAdd()
        {
            InitializeComponent();
            InitData();
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

        int CapID()
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("select MaCongTrinh from dbo.CongTrinh");
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["MaCongTrinh"];
            dt.PrimaryKey = key;

            for (int i =1; i < dt.Rows.Count + 1; i++)
            {
                if (!dt.Rows.Contains(i))
                {
                    return i;
                }
            }

            return 0;
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            int Id = CapID();
            string tenCT = ctNameTB.Text;
            string diaDiem = ctPosTB.Text;
            string phongQL = phongQLTB.SelectedValue.ToString();
            MessageBox.Show(phongQLTB.SelectedValue.ToString());
            DateTime ngayCapPhep = ngayCapPhepDP.Value.Date;
            DateTime ngayKhoiCong = ngayKhoiCongDP.Value.Date;
            DateTime ngayHoanThanh = ngayHoanThanhDP.Value.Date;

            if (!String.IsNullOrEmpty(tenCT) && !String.IsNullOrEmpty(diaDiem) && phongQL != "0")
            {
                DataProvider.Instance.ExcuteQuery("addCongTrinh @maCongTrinh , @maPhongQL , @TenGoi , @DiaDiemCongTrinh , @NgayCapPhep , @NgayKhoiCong , @NgayHoanThanhDuKien", 
                new object[] {Id, phongQL, tenCT, diaDiem, ngayCapPhep , ngayKhoiCong, ngayHoanThanh });
                Close();
            }
            else
            {
                MessageBox.Show("Lỗi nhập liệu", "Thông báo");
            }

        }
    }
}
