using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO_QCQC;

namespace QuanLyQuanCafe.DAL_QLQC
{
    class DAL_NguyenLieu
    {
        private static DAL_NguyenLieu _instance;
        public static DAL_NguyenLieu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_NguyenLieu();
                return _instance;
            }
        }
        public DataTable getDanhSach()
        {
            try
            {
                DataTable dt = new DataTable();

                string procedure = "NGUYENLIEU_SELECTALL";
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

                string procedure = "NGUYENLIEU_SELECTBYNAME";
                param.Add("@Ten", Ten);

                dt = HandleDB.Instance.ExecuteQueryProcedure(procedure, param);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public DataTable getDanhSachNguyenLieuCanNhap()
        {
            try
            {
                DataTable dt = new DataTable();

                string procedure = "NGUYENLIEU_SELECTNEEDTOIMPORT";
                dt = HandleDB.Instance.ExecuteQueryProcedure(procedure, null);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public DataTable getDanhSachNguyenLieuCanKiemTra()
        {
            try
            {
                DataTable dt = new DataTable();

                string procedure = "NGUYENLIEU_SELECTBAD";
                dt = HandleDB.Instance.ExecuteQueryProcedure(procedure, null);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public void taoNguyenLieu(DTO_NguyenLieu nl)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "NGUYENLIEU_INSERT";
                param.Add("@Ten", nl.TenNguyenLieu);
                param.Add("@SoLuong", nl.SoLuong.ToString());
                param.Add("@SoLuongToiThieu", nl.SoLuongToiThieu.ToString());
                param.Add("@Dvt", nl.DonViTinh);
                param.Add("@ThoiGianBaoQuan", nl.ThoiGianBaoQuan.ToString());
                param.Add("@GhiChu", nl.GhiChu);

                HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void capNhatNguyenLieu(DTO_NguyenLieu nl)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "NGUYENLIEU_UPDATE";
                param.Add("@MaNguyenLieu", nl.MaNguyenLieu);
                param.Add("@Ten", nl.TenNguyenLieu);
                param.Add("@SoLuong", nl.SoLuong.ToString());
                param.Add("@SoLuongToiThieu", nl.SoLuongToiThieu.ToString());
                param.Add("@Dvt", nl.DonViTinh);
                param.Add("@ThoiGianBaoQuan", nl.ThoiGianBaoQuan.ToString());
                param.Add("@GhiChu", nl.GhiChu);

                HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void nhapNguyenLieu(DTO_PhieuNhapNguyenLieu pnnl)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "NGUYENLIEU_IMPORT";
                param.Add("@MaPNNL",pnnl.MaPhieuNhap);

                HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void xoaNguyenLieu(string MaNL)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "NGUYENLIEU_DELETE";
                param.Add("@MaNL", MaNL);

                HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
