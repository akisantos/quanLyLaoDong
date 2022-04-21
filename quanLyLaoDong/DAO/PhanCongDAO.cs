using quanLyLaoDong.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyLaoDong.DAO
{
    internal class PhanCongDAO
    {
        private static PhanCongDAO instance;

        public static PhanCongDAO Instance
        {
            get { if (instance == null) instance = new PhanCongDAO(); return instance; }    
            set { instance = value; }
        }

        private PhanCongDAO() { }

        public List<PhanCong> LoadPhanCong()
        {
            List<PhanCong> pcList = new List<PhanCong>();
            string q = "select * from dbo.PhanCong";

            DataTable dt = DataProvider.Instance.ExcuteQuery(q);

            foreach (DataRow item in dt.Rows)
            {
                PhanCong pc = new PhanCong(item);
                pcList.Add(pc);
            }
            return pcList;


        }

        
    }
}
