using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyLaoDong.DTO
{
    internal class PhanCong
    {
        private int maPhanCong;
        private int maCongTrinh;
        private int maNV;
        private float soGio;

        public int MaPhanCong { get => maPhanCong; set => maPhanCong = value; }
        public int MaCongTrinh { get => maCongTrinh; set => maCongTrinh = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public float SoGio { get => soGio; set => soGio = value; }

        public PhanCong(int id, int maCt, int maNv, float soGio)
        {
            this.MaPhanCong = id;
            this.MaCongTrinh = maCt;
            this.MaNV = maNv;
            this.SoGio = soGio;
        }

        public PhanCong(DataRow dt)
        {
            this.MaPhanCong = int.Parse(dt["MaPhanCong"].ToString());
            this.MaCongTrinh = int.Parse(dt["MaCongTrinh"].ToString());
            this.MaNV = int.Parse(dt["MaNhanVien"].ToString());
            this.SoGio = float.Parse(dt["SoGio"].ToString());
        }
    }
}
