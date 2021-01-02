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
    class DAL_NhanVien
    {
        private static DAL_NhanVien _instance;
        public static DAL_NhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_NhanVien();
                return _instance;
            }
        }
        public DataTable getDanhSach()
        {
            try
            {
                DataTable dt = new DataTable();

                string procedure = "NHANVIEN_SELECTALL";
                dt = HandleDB.Instance.ExecuteQueryProcedure(procedure, null);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public DataTable getDanhSach(string cmnd)
        {
            try
            {
                DataTable dt = new DataTable();
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "NHANVIEN_SELECTBYCMND";
                param.Add("@SoCMND", cmnd);

                dt = HandleDB.Instance.ExecuteQueryProcedure(procedure, param);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public DTO_NhanVien DangNhap(DTO_NhanVien nv)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "NHANVIEN_SELECT";
                param.Add("@Sdt", nv.SoDienThoai);
                param.Add("@MatKhau", nv.MatKhau);

                DataTable result = HandleDB.Instance.ExecuteQueryProcedure(procedure, param);
                if (result.Rows.Count != 0)
                {
                    DTO_NhanVien resultnv = new DTO_NhanVien();
                    resultnv.MaNhanVien = result.Rows[0]["MANV"].ToString();
                    resultnv.Ten = result.Rows[0]["TEN"].ToString();
                    resultnv.Ho = result.Rows[0]["HO"].ToString();
                    resultnv.SoCMND = result.Rows[0]["SOCMND"].ToString();
                    resultnv.DiaChi = result.Rows[0]["DIACHI"].ToString();
                    resultnv.SoDienThoai = result.Rows[0]["SDT"].ToString();
                    resultnv.NgayVaoLam = DateTime.Parse(result.Rows[0]["NGAYVAOLAM"].ToString());
                    resultnv.Luong = Convert.ToInt64(result.Rows[0]["LUONG"]);
                    resultnv.Loai = result.Rows[0]["LOAINV"].ToString();
                    return resultnv;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public bool themNhanVien(DTO_NhanVien nv)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "NHANVIEN_INSERT";
                param.Add("@Ten", nv.Ten);
                param.Add("@Ho", nv.Ho);
                param.Add("@SoCMND", nv.SoCMND);
                param.Add("@DiaChi", nv.DiaChi);
                param.Add("@Sdt", nv.SoDienThoai);
                param.Add("@NgayVaoLam", nv.NgayVaoLam.ToShortDateString());
                param.Add("@Luong", nv.Luong.ToString());
                param.Add("@MatKhau", nv.MatKhau);
                param.Add("@LoaiNV", nv.Loai);

                int result = HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
                if (result == 0)
                    return false;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public bool xoaNhanVien(string MaNhanVien)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "NHANVIEN_DELETE";
                param.Add("@MaNV", MaNhanVien);

                int result = HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
                if (result == 0)
                    return false;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public bool capNhatNhanVien(DTO_NhanVien nv)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "NHANVIEN_UPDATE";
                param.Add("@MaNV", nv.MaNhanVien);
                param.Add("@Ten", nv.Ten);
                param.Add("@Ho", nv.Ho);
                param.Add("@SoCMND", nv.SoCMND);
                param.Add("@DiaChi", nv.DiaChi);
                param.Add("@Sdt", nv.SoDienThoai);
                param.Add("@NgayVaoLam", nv.NgayVaoLam.ToShortDateString());
                param.Add("@Luong", nv.Luong.ToString());
                param.Add("@MatKhau", nv.MatKhau);
                param.Add("@LoaiNV", nv.Loai);

                int result = HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
                if (result == 0)
                    return false;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

    }
}
