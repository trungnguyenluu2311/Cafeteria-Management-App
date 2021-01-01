using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    public class DTO_NhanVien
    {
        public string MaNhanVien { get; set; }
        public string Ten { get; set; }
        public string Ho { get; set; }
        public string SoCMND { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public long Luong { get; set; }
        public string MatKhau { get; set; }
        public string Loai { get; set; }

        public DTO_NhanVien(string maNhanVien, string ten, string ho, string soCMND, string diaChi, string soDienThoai, DateTime ngayVaoLam, long luong, string matKhau, string loai)
        {
            MaNhanVien = maNhanVien;
            Ten = ten;
            Ho = ho;
            SoCMND = soCMND;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            NgayVaoLam = ngayVaoLam;
            Luong = luong;
            MatKhau = matKhau;
            Loai = loai;
        }
    }
}
