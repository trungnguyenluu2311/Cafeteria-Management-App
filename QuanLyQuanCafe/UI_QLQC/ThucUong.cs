using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class ThucUong : UserControl
	{
		public ThucUong()
		{
			InitializeComponent();
		}

		private void panel1_Click(object sender, EventArgs e)
		{
			Form form = new frmChiTietDatMon();
			form.Show();
		}
	}
}
