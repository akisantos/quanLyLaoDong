using quanLyLaoDong.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyLaoDong
{
    public partial class fNVEdit : Form
    {
        public fNVEdit()
        {
            InitializeComponent();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string msnvTrasfer
        {
            get { return msnvLabel.Text; }
            set { msnvLabel.Text = value; }
        }
        public string hoTenTrasfer
        {
            get { return nvHoTenTB.Text; }
            set { nvHoTenTB.Text = value; }
        }

        public string NgaySinhTrasfer
        {
            get { return nsnv.Text; }
            set
            {
                nsnv.Text = value;
                string[] holder = nsnv.Text.Split(' ');
                nvNgaySinhDP.Value = DateTime.Parse(holder[0]);
            }
        }

        public string GioiTinhTransfer
        {
            get { return gioiTinhNV.Text; }
            set
            {

                gioiTinhNV.Text = value;
                if (gioiTinhNV.Text == "Nữ")
                {
                    gioiTinhCheckBox.Checked = true;
                }
            }
        }

        public string phongQLTransfer
        {
            get { return maPhongQLLabel.Text; }
            set { maPhongQLLabel.Text = value;

                DataInit();

                int selectedIndex = int.Parse(maPhongQLLabel.Text);
                PhongQLCB.SelectedIndex = 1;
            }
        }

        public string DiaChiTransfer
        {
            get { return nvDiaChiTB.Text; }
            set { nvDiaChiTB.Text = value; }
        }

        void DataInit()
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(msnvLabel.Text);
            string hoTen = nvHoTenTB.Text;
            DateTime ngaySinh = nvNgaySinhDP.Value;
            bool gioiTinh = gioiTinhCheckBox.Checked;
            string phongQL = PhongQLCB.SelectedValue.ToString();
            string diachi = nvDiaChiTB.Text;
            DataProvider.Instance.ExcuteQuery("NhanVienEdit @MaNhanVien , @MaPhong , @HoTen , @NgaySinh , @GioiTinh , @DiaChi", new object[] { id, phongQL, hoTen, ngaySinh, gioiTinh, diachi });
            this.Close();
        }
    }
}
