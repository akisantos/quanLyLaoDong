using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyLaoDong.DTO
{
    internal class CongTrinh
    {
        private int id;
        private string name;
        private string diaDiem;
        private string ngayKhoiCong;
        private string ngayCapPhep;
        private string ngayHoanThanhDuKien;
        private int maPhongQL;


        public CongTrinh(int id, string name, string DiaDiem, string NgayKhoiCong, string NgayCapPhep, string NgayHoanThanhDuKien, int maPhongQL)
        {
            this.Id = id;  
            this.Name = name;
            this.DiaDiem = DiaDiem;
            this.NgayKhoiCong = NgayKhoiCong;
            this.NgayCapPhep = NgayCapPhep;
            this.NgayHoanThanhDuKien = NgayHoanThanhDuKien;
            this.MaPhongQL = maPhongQL;
        }

        public CongTrinh(DataRow data)
        {
            this.Id= (int)data["MaCongTrinh"];
            this.Name = data["TenGoi"].ToString();
            this.DiaDiem = data["DiaDiemCongTrinh"].ToString();
            this.NgayKhoiCong = data["NgayKhoiCong"].ToString();
            this.NgayCapPhep = data["NgayCapPhep"].ToString(); ;
            this.NgayHoanThanhDuKien = data["NgayHoanThanhDuKien"].ToString();
            this.MaPhongQL = (int)data["MaPhong"];

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        public string NgayKhoiCong { get => ngayKhoiCong; set => ngayKhoiCong = value; }
        public string NgayCapPhep { get => ngayCapPhep; set => ngayCapPhep = value; }
        public string NgayHoanThanhDuKien { get => ngayHoanThanhDuKien; set => ngayHoanThanhDuKien = value; }
        public int MaPhongQL { get => maPhongQL; set => maPhongQL = value; }


    }
}
