using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyLaoDong.DTO
{
    internal class PhongBan
    {
        private int maPhong;
        private string tenPhong;

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }

        public PhongBan(int id, string name)
        {
            this.maPhong = id;
            this.tenPhong = name;
        }

        public PhongBan(DataRow dt)
        {
            this.MaPhong = (int)dt["MaPhong"];
            this.TenPhong = dt["TenPhong"].ToString();
        }
    }
}
