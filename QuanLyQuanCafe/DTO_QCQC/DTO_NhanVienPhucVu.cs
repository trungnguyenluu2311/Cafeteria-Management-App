using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    public class DTO_NhanVienPhucVu : DTO_NhanVien
    {
        public DTO_NhanVienPhucVu(string maNhanVien,
            string ten, 
            string ho, 
            string soCMND, 
            string diaChi, 
            string soDienThoai, 
            DateTime ngayVaoLam, 
            long luong, 
            string matKhau) : base(maNhanVien,ten,ho,soCMND,diaChi,soDienThoai,ngayVaoLam,luong,matKhau,"Phục vụ") { }

    }
}
