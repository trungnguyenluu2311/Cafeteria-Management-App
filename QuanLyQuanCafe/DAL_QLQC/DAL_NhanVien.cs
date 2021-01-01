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
        public bool isHaveNV(DTO_NhanVien nv)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "NHANVIEN_SELECT";
                param.Add("@Sdt", nv.SoDienThoai);
                param.Add("@MatKhau", nv.MatKhau);

                int result = Convert.ToInt32(HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param));
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
