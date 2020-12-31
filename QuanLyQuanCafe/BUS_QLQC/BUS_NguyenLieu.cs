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
    class BUS_NguyenLieu
    {
        public void taoNguyenLieu(DTO_NguyenLieu nl)
        {
            DAL_NguyenLieu.Instance.taoNguyenLieu(nl);
        }
        public void themNguyenLieu(DTO_PhieuNhapNguyenLieu pnnl)
        {
            DAL_NguyenLieu.Instance.nhapNguyenLieu(pnnl);
        }
        public void capNhatNguyenLieu(DTO_NguyenLieu nl)
        {
            DAL_NguyenLieu.Instance.capNhatNguyenLieu(nl);
        }
        public DataTable LapDanhSachNguyenLieuCanNhap()
        {
            return DAL_NguyenLieu.Instance.getDanhSachNguyenLieuCanNhap();
        }
        public DataTable LapDanhSachCanKiemTra()
        {
            return DAL_NguyenLieu.Instance.getDanhSachNguyenLieuCanKiemTra();
        }
    }
}
