using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyLaoDong.DTO
{
    internal class NhanVien
    {
        private int id;
        private string tenNV;
        private string ngaySinh;
        private bool gioiTinh;
        private string diaChi;
        private int maPhong;

        public int Id { get => id; set => id = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int MaPhong { get => maPhong; set => maPhong = value; }

        public NhanVien(int id, string tenNV, string ngaySinh, bool gioiTinh, string diaChi, int maPhong)
        {
            this.Id = id;
            this.TenNV = tenNV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.MaPhong = maPhong;
        }

        public NhanVien(DataRow data)
        {

            this.Id = (int)data["MaNhanVien"];
            this.TenNV = data["HoTen"].ToString();
            this.NgaySinh = data["NgaySinh"].ToString();
            this.GioiTinh = (bool)data["GioiTinh"];
            this.DiaChi = data["DiaChi"].ToString(); ;
            this.MaPhong = (int)data["MaPhong"];

        }
    }
}
