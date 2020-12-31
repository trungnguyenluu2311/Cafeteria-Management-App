using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    class DTO_ChiTietPhieuNhap
    {
        public string MaCTPN;
        public string MaPhieuNhap;
        public string MaNguyenLieu;
        public long SoLuong;

        public DTO_ChiTietPhieuNhap(string maCTPN, string maPhieuNhap, string maNguyenLieu, long soLuong)
        {
            MaCTPN = maCTPN;
            MaPhieuNhap = maPhieuNhap;
            MaNguyenLieu = maNguyenLieu;
            SoLuong = soLuong;
        }
    }
}
