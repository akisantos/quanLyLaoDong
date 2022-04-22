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
                int accountType = 0;
                List<Account> list = AccountDAO.Instance.Login(userName, password);
                foreach (var item in list)
                {
                    if (item.AccountUsername == userName && item.AccountPassword == password)
                    {
                        accountType = item.AccountType;
                    }
                }

                this.Hide();
                fMainScreen fMainScreenHolder = new fMainScreen();
                fMainScreenHolder.AccountInfoTrans = userName;
                fMainScreenHolder.LoggedAccount = accountType;
                fMainScreenHolder.ShowDialog();
                passwordTB.Text = "";
                this.Show();

            }
            else
            {
                MessageBox.Show("Hmm! Sai đâu đó ở tên với pass rổi","Thông báo");
            }
            
        }

        bool Login(string userName, string password)
        {
            List<Account> list =  AccountDAO.Instance.Login(userName, password);
            if (list.Any())
            {
                return true;
            }
            return false;
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
