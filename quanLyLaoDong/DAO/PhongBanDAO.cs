using quanLyLaoDong.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyLaoDong.DAO
{
    internal class PhongBanDAO
    {
        private static PhongBanDAO instance;

        public static PhongBanDAO Instance
        {
            get { if (instance == null) instance = new PhongBanDAO();  return instance; }
            set { instance = value; }
        }


        private PhongBanDAO() { }

        public List<PhongBan> LoadPhongBan()
        {


            List<PhongBan> pbList = new List<PhongBan>();
            string q = "select * from dbo.PhongBan";

            DataTable dt = DataProvider.Instance.ExcuteQuery(q);

            foreach (DataRow item in dt.Rows)
            {
                PhongBan pb = new PhongBan(item);
                pbList.Add(pb);
            }
            return pbList;


        }

    }
}
