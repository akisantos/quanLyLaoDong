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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {

            string userName = userNameTB.Text;
            string password = passwordTB.Text;
            if (Login(userName, password))
            {
                this.Hide();
                fMainScreen fMainScreenHolder = new fMainScreen();
                fMainScreenHolder.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Hmm! Sai đâu đó ở tên với pass rổi","Thông báo");
            }
            
        }

        bool Login(string userName, string password)
        {
            return AccountDAO.Instance.Login(userName, password);
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
