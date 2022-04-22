using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyLaoDong.DTO
{
    internal class Account
    {
        private int accountID;
        private string accountUsername;
        private string accountPassword;
        private int accountType;

        public int AccountID { get => accountID; set => accountID = value; }
        public string AccountUsername { get => accountUsername; set => accountUsername = value; }
        public string AccountPassword { get => accountPassword; set => accountPassword = value; }
        public int AccountType { get => accountType; set => accountType = value; }

        public Account(int id, string userName, string password, int type)
        {
            this.AccountID = id;
            this.AccountUsername = userName;
            this.AccountPassword = password;
            this.AccountType = type;
        }

        public Account(DataRow data)
        {
            this.AccountID = (int)data["MaAccount"];
            this.AccountUsername = data["userName"].ToString();
            this.AccountPassword = data["userPassword"].ToString();
            this.AccountType = (int)data["accountType"];
        }
    }
}
