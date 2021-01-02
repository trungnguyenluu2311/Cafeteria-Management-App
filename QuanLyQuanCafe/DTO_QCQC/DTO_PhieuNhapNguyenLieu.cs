using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    class DTO_PhieuNhapNguyenLieu
    {
        public string MaPhieuNhap;
        public string MaNV; 
        public DateTime NgayNhap;
        public string LinkHinhAnhHoaDon;

        public DTO_PhieuNhapNguyenLieu(string maPhieuNhap, string maNV, DateTime ngayNhap, string linkHinhAnhHoaDon)
        {
            MaPhieuNhap = maPhieuNhap;
            MaNV = maNV;
            NgayNhap = ngayNhap;
            LinkHinhAnhHoaDon = linkHinhAnhHoaDon;
        }
    }
}
