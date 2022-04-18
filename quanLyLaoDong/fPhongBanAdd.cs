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
    public partial class fPhongBanAdd : Form
    {
        public fPhongBanAdd()
        {
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string ten = TenPhongTB.Text;
            if (ten != "" || ten != null)
            {
                int maPhong = CapID();
                int id = CapID();
                DataProvider.Instance.ExcuteQuery("PhongBanAdd @MaPhong , @TenPhongBan", new object[] { id, ten });
                this.Close();
            }
            else
            {
                MessageBox.Show("Chú ý chưa nhập đủ thông tin!", "Thông báo");
            }
        }

        int CapID()
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("select MaPhong from dbo.PhongBan");
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["MaPhong"];
            dt.PrimaryKey = key;

            for (int i = 0; i < dt.Rows.Count + 1; i++)
            {
                if (!dt.Rows.Contains(i))
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
