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
    class DAL_ChiTietThucUong
    {
        private static DAL_ChiTietThucUong _instance;
        public static DAL_ChiTietThucUong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_ChiTietThucUong();
                return _instance;
            }
        }
        public DataTable getDanhSachVoiMaNL(string MaNL)
        {
            try
            {
                DataTable dt = new DataTable();
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "CHITIETTHUCUONG_SELECTBYMANL";
                param.Add("@MaNL", MaNL);

                dt = HandleDB.Instance.ExecuteQueryProcedure(procedure, null);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public DataTable getDanhSachVoiMaTU(string MaTU)
        {
            try
            {
                DataTable dt = new DataTable();
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "CHITIETTHUCUONG_SELECTBYMATU";
                param.Add("@MaTU", MaTU);

                dt = HandleDB.Instance.ExecuteQueryProcedure(procedure, param);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public void themChiTietThucUong(DTO_ChiTietThucUong cttu)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "CHITIETTHUCUONG_INSERT";
                param.Add("@MaTU", cttu.MaThucUong);
                param.Add("@MaNL", cttu.MaNguyenLieu);
                param.Add("@SoLuong", cttu.SoLuong.ToString());

                HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void capNhatChiTietThucUong(DTO_ChiTietThucUong cttu)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "CHITIETTHUCUONG_UPDATE";
                param.Add("@MaCTTU", cttu.MaCTTU);
                param.Add("@MaTU", cttu.MaThucUong);
                param.Add("@MaNL", cttu.MaNguyenLieu);
                param.Add("@SoLuong", cttu.SoLuong.ToString());

                HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void xoaThucUong(string MaCTTU)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "CHITIETTHUCUONG_DELETE";
                param.Add("@MaCTTU", MaCTTU);

                HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
