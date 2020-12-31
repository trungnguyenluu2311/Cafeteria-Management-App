using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO_QCQC;
using QuanLyQuanCafe.DAL_QLQC;
namespace QuanLyQuanCafe.BUS_QLQC
{
    class BUS_NhanVien
    {
        public bool DangNhap(DTO_NhanVien nv)
        {
            return DAL_NhanVien.Instance.isHaveNV(nv);
        }
        public bool ThayDoiMatKhau(DTO_NhanVien nv)
        {
            return DAL_NhanVien.Instance.capNhatNhanVien(nv);
        }
    }
}
