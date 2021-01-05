using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    public class DTO_NguyenLieu
    {
        public string MaNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public string DonViTinh { get; set; }
        public long SoLuong { get; set; }
        public long SoLuongToiThieu { get; set; }
        public int ThoiGianBaoQuan { get; set; }
        public string GhiChu { get; set; }

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
