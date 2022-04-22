using quanLyLaoDong.DTO;
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

        public List<Account> Login(string usrName, string userPAss)
        {
            List<Account> list = new List<Account>();
            string q = "select * from dbo.Account where userName ='"+ usrName + "' and userPassword= '"+ userPAss +"'";
            DataTable res = DataProvider.Instance.ExcuteQuery(q);
            foreach (DataRow item in res.Rows)
            {
                Account ac = new Account(item);
                list.Add(ac);
            }
            return list;
        }

       

        public List<Account> LoadAccountList()
        {
            List<Account> list = new List<Account>();

            string q = "select * from dbo.Account";

            DataTable dt = DataProvider.Instance.ExcuteQuery(q);

            foreach (DataRow item in dt.Rows)
            {
                Account ac = new Account(item);
                list.Add(ac);
            }
            return list;
        }
    }
}
