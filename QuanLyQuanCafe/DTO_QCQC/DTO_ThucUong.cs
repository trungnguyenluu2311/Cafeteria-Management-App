using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    public class DTO_ThucUong
    {
        public string MaThucUong;
        public string TenThucUong;
        public long Gia;
        public string GhiChu;

        public DTO_ThucUong(string maThucUong, string tenThucUong, long gia, string ghiChu)
        {
            MaThucUong = maThucUong;
            TenThucUong = tenThucUong;
            Gia = gia;
            GhiChu = ghiChu;
        }
    }
}
