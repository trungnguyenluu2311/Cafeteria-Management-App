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
    class BUS_PhieuNhapNguyenLieu
    {
        public void themPhieuNhap(ref DTO_PhieuNhapNguyenLieu pnnl, List<DTO_ChiTietPhieuNhap> ctpns)
        {
            pnnl.MaPhieuNhap = DAL_PhieuNhapNguyenLieu.Instance.themPhieuNhapNguyenLieu(pnnl);
            foreach(DTO_ChiTietPhieuNhap ct in ctpns)
            {
                ct.MaPhieuNhap = pnnl.MaPhieuNhap;
                DAL_ChiTietPhieuNhap.Instance.themChiTietPhieuNhap(ct);
            }
        }
    }
}
