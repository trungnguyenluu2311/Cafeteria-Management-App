using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO_QCQC;

namespace QuanLyQuanCafe.DAL_QLQC
{
    class DAL_ChiTietPhieuNhap
    {
        private static DAL_ChiTietPhieuNhap _instance;
        public static DAL_ChiTietPhieuNhap Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_ChiTietPhieuNhap();
                return _instance;
            }
        }
        public void themChiTietPhieuNhap(DTO_ChiTietPhieuNhap ctpn)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "CHITIETPHIEUNHAP_INSERT";
                param.Add("@MaPNNL", ctpn.MaPhieuNhap);
                param.Add("@MaNL", ctpn.MaNguyenLieu);
                param.Add("@SoLuong", ctpn.SoLuong.ToString());

                HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
