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
    class DAL_ThucUong
    {
        private static DAL_ThucUong _instance;
        public static DAL_ThucUong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_ThucUong();
                return _instance;
            }
        }
        public DataTable getDanhSach()
        {
            try
            {
                DataTable dt = new DataTable();

                string procedure = "THUCUONG_SELECTALL";
                dt = HandleDB.Instance.ExecuteQueryProcedure(procedure, null);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public DataTable getDanhSach(string Ten)
        {
            try
            {
                DataTable dt = new DataTable();
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "THUCUONG_SELECTBYNAME";
                param.Add("@Ten", Ten);

                dt = HandleDB.Instance.ExecuteQueryProcedure(procedure, null);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public string themThucUong(DTO_ThucUong tu)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "THUCUONG_INSERT";
                param.Add("@Ten", tu.TenThucUong);
                param.Add("@Gia", tu.Gia.ToString());
                param.Add("@GhiChu", tu.GhiChu);

                return HandleDB.Instance.ExecuteScalarProcedure(procedure, param).ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return "";
            }
        }
        public void capNhatThucUong(DTO_ThucUong tu)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "THUCUONG_UPDATE";
                param.Add("@MaTU", tu.MaThucUong);
                param.Add("@Ten", tu.TenThucUong);
                param.Add("@Gia", tu.Gia.ToString());
                param.Add("@GhiChu", tu.GhiChu);

                HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void xoaThucUong(string MaTU)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "THUCUONG_DELETE";
                param.Add("@MaTU", MaTU);

                HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

    }
}
