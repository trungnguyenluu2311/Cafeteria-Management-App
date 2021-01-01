using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS_QLQC;
using QuanLyQuanCafe.DTO_QCQC;
namespace QuanLyQuanCafe
{
	public partial class frmNhapNguyenLieu : Form
	{
		BUS_NguyenLieu busNL = new BUS_NguyenLieu();
		public frmNhapNguyenLieu()
		{
			InitializeComponent();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form form = new frmThemNguyenLieuMoi();
			form.Show();
		}

        private void frmNhapNguyenLieu_Load(object sender, EventArgs e)
        {
			dataGridView1.DataSource = busNL.LayDanhSachNguyenLieu();
        }
    }
}
