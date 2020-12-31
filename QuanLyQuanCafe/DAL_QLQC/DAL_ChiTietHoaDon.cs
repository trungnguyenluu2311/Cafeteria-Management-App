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
    class DAL_ChiTietHoaDon
    {
        private static DAL_ChiTietHoaDon _instance;
        public static DAL_ChiTietHoaDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_ChiTietHoaDon();
                return _instance;
            }
        }
        public void themChiTietHoaDon(DTO_ChiTietHoaDon cthd)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "CHITIETHOADON_INSERT";
                param.Add("@MaHoaDon", cthd.MaHoaDon);
                param.Add("@MaTU", cthd.MaThucUong);
                param.Add("@SoLuong", cthd.SoLuong.ToString());

                HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
