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
    class DAL_ChiTietPhaChe
    {
        private static DAL_ChiTietPhaChe _instance;
        public static DAL_ChiTietPhaChe Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_ChiTietPhaChe();
                return _instance;
            }
        }
        public void themChiTietPhaChe(DTO_ChiTietPhaChe ctpc)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string procedure = "CHITIETPHACHE_INSERT";
                param.Add("@MaCTHD", ctpc.MaCTHD);
                param.Add("@MaNL", ctpc.MaNguyenLieu);
                param.Add("@SoLuong", ctpc.SoLuong.ToString());

                HandleDB.Instance.ExecuteNonQueryProcedure(procedure, param);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
