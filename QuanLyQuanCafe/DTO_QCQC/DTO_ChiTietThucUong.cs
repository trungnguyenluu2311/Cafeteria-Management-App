using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    class DTO_ChiTietThucUong
    {
        public string MaCTTU;
        public string MaThucUong;
        public string MaNguyenLieu;
        public int SoLuong;

        public DTO_ChiTietThucUong(string maCTTU, string maThucUong, string maNguyenLieu, int soLuong)
        {
            MaCTTU = maCTTU;
            MaThucUong = maThucUong;
            MaNguyenLieu = maNguyenLieu;
            SoLuong = soLuong;
        }
    }
}
