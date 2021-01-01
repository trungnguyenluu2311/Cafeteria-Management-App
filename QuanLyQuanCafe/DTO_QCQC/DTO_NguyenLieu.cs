using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    class DTO_NguyenLieu
    {
        public string MaNguyenLieu;
        public string TenNguyenLieu;
        public string DonViTinh;
        public long SoLuong;
        public long SoLuongToiThieu;
        public int ThoiGianBaoQuan;
        public string GhiChu;

        public DTO_NguyenLieu(string maNguyenLieu, string tenNguyenLieu, string donViTinh, long soLuong, long soLuongToiThieu, int thoiGianBaoQuan, string ghiChu)
        {
            MaNguyenLieu = maNguyenLieu;
            TenNguyenLieu = tenNguyenLieu;
            DonViTinh = donViTinh;
            SoLuong = soLuong;
            SoLuongToiThieu = soLuongToiThieu;
            ThoiGianBaoQuan = thoiGianBaoQuan;
            GhiChu = ghiChu;
        }
    }
}
