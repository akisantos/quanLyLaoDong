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
    public partial class fNVAdd : Form
    {
        public fNVAdd()
        {
            InitializeComponent();
            InitData();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        void InitData()
        {

            //get data for PhongBan
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from dbo.PhongBan");
            PhongQLCB.ValueMember = "MaPhong";
            PhongQLCB.DisplayMember = "TenPhong";

            DataRow dr = data.NewRow();
            dr[0] = 0;
            dr[1] = "- Chọn một";
            data.Rows.InsertAt(dr, 0);
            PhongQLCB.DataSource = data;
            PhongQLCB.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            if (checkInfo())
            {
                int id = CapID();
                string hoTen = nvHoTenTB.Text;
                DateTime ngaySinh = nvNgaySinhDP.Value;
                bool gioiTinh = gioiTinhCheckBox.Checked;
                string phongQL = PhongQLCB.SelectedValue.ToString();
                string diachi = nvDiaChiTB.Text;
                DataProvider.Instance.ExcuteQuery("NhanVienAdd @MaNhanVien , @MaPhong , @HoTen , @NgaySinh , @GioiTinh , @DiaChi", new object[] { id, phongQL, hoTen, ngaySinh, gioiTinh, diachi });
                this.Close();
            }
            else
            {
                MessageBox.Show("Chú ý chưa nhập đủ thông tin!", "Thông báo");
            }


        }

        int CapID()
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("select MaNhanVien from dbo.NhanVien");
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["MaNhanVien"];
            dt.PrimaryKey = key;

            for (int i = 1; i < dt.Rows.Count + 1; i++)
            {
                if (!dt.Rows.Contains(i))
                {
                    return i;
                }
            }

            return 0;
        }

        bool checkInfo()
        {
            string hoTen = nvHoTenTB.Text;
           
            string phongQL = PhongQLCB.SelectedValue.ToString();
            string diachi = nvDiaChiTB.Text;

            bool q1 =false, q2= false, q3 = false;
            if (int.Parse(phongQL) > 0) q1 = true;
            if (hoTen != "" && hoTen != null) q2=  true;

            if (diachi != "" && diachi != null) q3 = true;

            if (q1 == q2 && q2 ==q3 && q3==true) return true;
            return false;
        }
    }
}
