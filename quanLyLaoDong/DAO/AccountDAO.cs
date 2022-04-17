using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyLaoDong.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string usrName, string userPAss)
        {
            string q = "select * from dbo.Account where userName ='"+ usrName + "' and userPassword= '"+ userPAss +"'";
            DataTable res = DataProvider.Instance.ExcuteQuery(q);
            return res.Rows.Count >0;
        }
    }
}
