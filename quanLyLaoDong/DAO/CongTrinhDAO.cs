using quanLyLaoDong.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyLaoDong.DAO
{
    internal class CongTrinhDAO
    {
        private static CongTrinhDAO instance;

        public static CongTrinhDAO Instance
        {
            get { if (instance == null) instance = new CongTrinhDAO(); return instance; }
            set { instance = value; }
        }

        private CongTrinhDAO() { }

        public List<CongTrinh> LoadCongTrinh()
        {
            List<CongTrinh> congTrinhList = new List<CongTrinh>();

            string q = "select * from dbo.CongTrinh";
            DataTable dt = DataProvider.Instance.ExcuteQuery(q);

            foreach (DataRow item in dt.Rows)
            {
                CongTrinh congtrinh = new CongTrinh(item);
                congTrinhList.Add(congtrinh);
            }
            return congTrinhList;
        }
    }
}
