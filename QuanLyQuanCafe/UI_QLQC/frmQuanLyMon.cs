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
	public partial class frmQuanLyMon : Form
	{
		public frmQuanLyMon()
		{
			InitializeComponent();
		}

		
		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			frmSuaMon frmSuaMon = new frmSuaMon();
			frmSuaMon.Show();
		}

		private void buttonThemMon_Click(object sender, EventArgs e)
		{
			frmThemMon frmThemMon = new frmThemMon();
			frmThemMon.Show();
		}
	}
}
