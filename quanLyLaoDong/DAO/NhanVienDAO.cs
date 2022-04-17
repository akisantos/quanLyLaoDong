using quanLyLaoDong.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyLaoDong.DAO
{
    internal class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance { 
            get { if (instance == null) instance = new NhanVienDAO() ; return instance; } 
            set { instance = value; }
        }

        private NhanVienDAO() { }

        public List<NhanVien> LoadNhanVien(){


            List < NhanVien > nvList = new List<NhanVien> ();
            string q = "select * from dbo.NhanVien";

            DataTable dt = DataProvider.Instance.ExcuteQuery(q);

            foreach (DataRow item in dt.Rows)
            {
                NhanVien nv = new NhanVien(item);
                nvList.Add(nv);
            }
            return nvList;

           
        }

        public List<NhanVien> searchNhanVien(string query)
        {
            List<NhanVien> nvList = new List<NhanVien>();
            string q;
            if (query == "")
            {
                q = "select * from dbo.NhanVien";
            }
            else
            {
                int MaNhanVien;
                bool checker = int.TryParse(query, out MaNhanVien);
                if (checker) q = "select * from dbo.NhanVien where MaNhanvien=" + MaNhanVien;
                else q = "select * from dbo.NhanVien";

            }


            DataTable dt = DataProvider.Instance.ExcuteQuery(q);

            foreach (DataRow item in dt.Rows)
            {
                NhanVien nv = new NhanVien(item);
                nvList.Add(nv);
            }
            return nvList;
        }
    }
}
