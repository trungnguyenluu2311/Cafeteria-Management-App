using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO_QCQC;
using QuanLyQuanCafe.DAL_QLQC;
using System.Data;

namespace QuanLyQuanCafe.BUS_QLQC
{
    class BUS_HoaDon
    {
        public DataTable LayDanhSachHoaDon()
        {
            return DAL_HoaDon.Instance.getDanhSach();
        }

    }
}
