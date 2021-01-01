using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    class DTO_ChiTietPhaChe
    {
        public string MaCTPC;
        public string MaCTHD;
        public string MaNguyenLieu;
        public int SoLuong;

        public DTO_ChiTietPhaChe(string maCTPC, string maCTHD, string maNguyenLieu, int soLuong)
        {
            MaCTPC = maCTPC;
            MaCTHD = maCTHD;
            MaNguyenLieu = maNguyenLieu;
            SoLuong = soLuong;
        }
    }
}
