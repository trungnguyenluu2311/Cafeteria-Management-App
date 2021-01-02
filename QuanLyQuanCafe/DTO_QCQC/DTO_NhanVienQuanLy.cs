using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    class DTO_NhanVienQuanLy : DTO_NhanVien
    {
        public DTO_NhanVienQuanLy(string maNhanVien,
            string ten,
            string ho,
            string soCMND,
            string diaChi,
            string soDienThoai,
            DateTime ngayVaoLam,
            long luong,
            string matKhau) : base(maNhanVien, ten, ho, soCMND, diaChi, soDienThoai, ngayVaoLam, luong, matKhau, "Quản lý") { }
    }
}
