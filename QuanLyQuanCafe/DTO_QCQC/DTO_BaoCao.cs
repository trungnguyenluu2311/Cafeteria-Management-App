using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_QCQC
{
    class DTO_BaoCao
    {
        public string MaBaoCao;
        public string LoaiBaoCao;
        public DateTime NgayLapBaoCao;
        public string LinkFileBaoCao;

        public DTO_BaoCao(string maBaoCao, string loaiBaoCao, DateTime ngayLapBaoCao, string linkFileBaoCao)
        {
            MaBaoCao = maBaoCao;
            LoaiBaoCao = loaiBaoCao;
            NgayLapBaoCao = ngayLapBaoCao;
            LinkFileBaoCao = linkFileBaoCao;
        }
    }
}
