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
    class BUS_ThucUong
    {
        public DataTable LayDanhSachThucUong()
        {
            return DAL_ThucUong.Instance.getDanhSach();
        }
        public DataTable LayDanhSachThucUong(string Ten)
        {
            return DAL_ThucUong.Instance.getDanhSach(Ten);
        }
        public void themThucUong(ref DTO_ThucUong tu, List<DTO_ChiTietThucUong> cttu)
        {
            tu.MaThucUong = DAL_ThucUong.Instance.themThucUong(tu);
            foreach(DTO_ChiTietThucUong ct in cttu)
            {
                ct.MaThucUong = tu.MaThucUong;
                DAL_ChiTietThucUong.Instance.themChiTietThucUong(ct);
            }    
        }
        public void capNhatThucUong(DTO_ThucUong tu)
        {
            DAL_ThucUong.Instance.capNhatThucUong(tu);
        }
        public void xoaThucUong(string MaTU)
        {
            DAL_ThucUong.Instance.xoaThucUong(MaTU);
        }
        public DataTable LayThongTinThucUong(string MaTU)
        {
            return DAL_ChiTietThucUong.Instance.getDanhSachVoiMaTU(MaTU);
        }
    }
}
