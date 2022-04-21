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
    public partial class fPhanCongEdit : Form
    {
        public fPhanCongEdit()
        {
            InitializeComponent();
        }

        public string maNhanVienTrans
        {
            get { return nvTB.Text; }
            set { nvTB.Text = "Nhân viên: " + value; }
        }

        public string TenCongTrinhTrans
        {
            get { return ctTB.Text; }
            set { ctTB.Text = "thuộc công trình: "+ value; }
        }

        public string maPhanCong
        {
            get { return maPCTB.Text; }
            set { maPCTB.Text = value; }
        }

        private void soGioTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(soGioTB.Text))
            {
                float holder = float.Parse(soGioTB.Text);
                int maPC = int.Parse(maPCTB.Text);
                DataProvider.Instance.ExcuteQuery("editPhanCong @maPhanCong , @soGio", new object[] { maPC, holder });
                Close();
            }
            else
            {
                MessageBox.Show("Lỗi nhập liệu", "Thông báo");
            }
        }
    }
}
