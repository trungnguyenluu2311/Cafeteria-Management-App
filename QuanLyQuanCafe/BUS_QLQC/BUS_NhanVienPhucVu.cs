using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO_QCQC;
using QuanLyQuanCafe.DAL_QLQC;

namespace QuanLyQuanCafe.BUS_QLQC
{
    class BUS_NhanVienPhucVu
    {
        public bool DatMon(DTO_NhanVien nv, List<DTO_ChiTietHoaDon> cthd)
        {
            try
            {

                DTO_HoaDon hd = new DTO_HoaDon("", nv.MaNhanVien, DateTime.Now, 0, false);
                hd.MaHoaDon = DAL_HoaDon.Instance.themHoaDon(hd);
                foreach(DTO_ChiTietHoaDon ct in cthd)
                {
                    ct.MaHoaDon = hd.MaHoaDon;
                    DAL_ChiTietHoaDon.Instance.themChiTietHoaDon(ct);
                }
                DAL_HoaDon.Instance.tinhtongTienHoaDon(hd.MaHoaDon);
                
                return true;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool XoaHoaDon(string MaHD)
        {
            try
            {
                return DAL_HoaDon.Instance.xoaHoaDon(MaHD);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
}
