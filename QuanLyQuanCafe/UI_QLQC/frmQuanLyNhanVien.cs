using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class frmQuanLyNhanVien : Form
	{
		public frmQuanLyNhanVien()
		{
			InitializeComponent();
		}

		private void buttonThemNhanVien_Click(object sender, EventArgs e)
		{
			Form form = new frmThemNhanVien();
			form.Show();
		}

		private void buttonSua_Click(object sender, EventArgs e)
		{
			frmSuaNhanVien frmSuaNhanVien = new frmSuaNhanVien();
			frmSuaNhanVien.Show();
		}
	}
}
