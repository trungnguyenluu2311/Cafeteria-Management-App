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
    class DAL_PhieuNhapNguyenLieu
    {
        private static DAL_PhieuNhapNguyenLieu _instance;
        public static DAL_PhieuNhapNguyenLieu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_PhieuNhapNguyenLieu();
                return _instance;
            }
        }
        public string themPhieuNhapNguyenLieu(DTO_PhieuNhapNguyenLieu pnnl)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "PHIEUNHAPNGUYENLIEU_INSERT";
                param.Add("@MaNV", pnnl.MaNV);
                param.Add("@NgayNhap", pnnl.NgayNhap.ToShortDateString());
                param.Add("@LinkAnh", pnnl.LinkHinhAnhHoaDon);

                return HandleDB.Instance.ExecuteScalarProcedure(procedure, param).ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return "";
            }
        }
    }
}
