using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    class DTO_ChiTietHoaDon
    {
        public string MaCTHD;
        public string MaHoaDon;
        public string MaThucUong;
        public int SoLuong;

        public DTO_ChiTietHoaDon(string maCTHD, string maHoaDon, string maThucUong, int soLuong)
        {
            MaCTHD = maCTHD;
            MaHoaDon = maHoaDon;
            MaThucUong = maThucUong;
            SoLuong = soLuong;
        }
    }
}
