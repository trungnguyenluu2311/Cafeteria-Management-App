using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO_QCQC;
using QuanLyQuanCafe.DAL_QLQC;
using System.Data;

namespace QuanLyQuanCafe.BUS_QLQC
{
    class BUS_NhanVienQuanLy :  BUS_NhanVien
    {
        public bool themNhanVien(DTO_NhanVien nv)
        {
            return DAL_NhanVien.Instance.themNhanVien(nv);
        }
        public bool xoaNhanVien(string MaNV)
        {
            return DAL_NhanVien.Instance.xoaNhanVien(MaNV);
        }
        public DataTable xemDanhSachNhanVien()
        {
            return DAL_NhanVien.Instance.getDanhSach();
        }
        public DataTable timNhanVien(string cmnd)
        {
            return DAL_NhanVien.Instance.getDanhSach(cmnd);
        }
    }
}
