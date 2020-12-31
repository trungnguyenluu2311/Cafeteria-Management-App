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
	public partial class frmQuanLyNguyenLieu : Form
	{
		public frmQuanLyNguyenLieu()
		{
			InitializeComponent();
		}


		private void buttonNhapNguyenLieu_Click(object sender, EventArgs e)
		{
			Form form = new frmNhapNguyenLieu();
			form.Show();
		}

		private void textBox1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}
	}
}
