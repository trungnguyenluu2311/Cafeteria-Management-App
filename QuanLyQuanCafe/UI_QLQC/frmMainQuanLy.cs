using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QuanLyQuanCafe.DTO_QCQC;
using QuanLyQuanCafe.BUS_QLQC;

namespace QuanLyQuanCafe
{
	public partial class frmMainQuanLy : Form
	{
		public DTO_NhanVien nv;
		BUS_NhanVienQuanLy busnvql = new BUS_NhanVienQuanLy();
		public frmMainQuanLy()
		{
			InitializeComponent();
		}

        private Form activeform = null;
        private void OpenForm(Form form)
        {
            if (activeform != null)
                activeform.Close();

            activeform = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.BringToFront();
            form.Show();
        }

		private void buttonQuanLyNguyenLieu_Click(object sender, EventArgs e)
		{ 
			var qlnvform = new frmQuanLyNguyenLieu();
			qlnvform.nv = nv;
            OpenForm(qlnvform);
		}

		private void buttonBaoCao_Click(object sender, EventArgs e)
		{
			OpenForm(new frmBaoCao());
		}

		private void buttonQuanLyNhanVien_Click(object sender, EventArgs e)
		{
			OpenForm(new frmQuanLyNhanVien());
		}

		private void frmMain_Load(object sender, EventArgs e)
		{

		}

		private void buttonQuanLyMon_Click(object sender, EventArgs e)
		{
			OpenForm(new frmQuanLyMon());
		}
	}
}
