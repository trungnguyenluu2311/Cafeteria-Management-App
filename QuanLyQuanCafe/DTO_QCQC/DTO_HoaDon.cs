using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    class DTO_HoaDon
    {
        public string MaHoaDon;
        public string MaNV;
        public DateTime NgayLap;
        public long TongTien;
        public bool DaXoa;

        public DTO_HoaDon(string maHoaDon, string maNV, DateTime ngayLap, long tongTien, bool daXoa)
        {
            MaHoaDon = maHoaDon;
            MaNV = maNV;
            NgayLap = ngayLap;
            TongTien = tongTien;
            DaXoa = daXoa;
        }
    }
}
