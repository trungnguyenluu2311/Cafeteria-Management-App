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
    class DAL_HoaDon
    {
        private static DAL_HoaDon _instance;
        public static DAL_HoaDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_HoaDon();
                return _instance;
            }
        }
        public DataTable getDanhSach()
        {
            try
            {
                DataTable dt = new DataTable();
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "HOADON_SELECTALL";

                dt = HandleDB.Instance.ExecuteQueryProcedure(procedure, null);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public string themHoaDon(DTO_HoaDon hd)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "HOADON_INSERT";
                param.Add("@MaNV", hd.MaNV);
                param.Add("@NgayLap", hd.NgayLap.ToShortDateString());
                param.Add("@TongTien", hd.TongTien.ToString());

                return HandleDB.Instance.ExecuteScalarProcedure(procedure, param).ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return "";
            }
        }
        public bool xoaHoaDon(string MaHoaDon)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "HOADON_DELETE";
                param.Add("@MaHoaDon", MaHoaDon);

                int result = HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
                if (result > 0)
                    return true;
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public void tinhtongTienHoaDon(string MaHoaDon)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "HOADON_TINHTONGTIEN";
                param.Add("@MaHoaDon", MaHoaDon);

                HandleDB.Instance.ExecuteScalar(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
