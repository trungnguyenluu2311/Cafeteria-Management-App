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
	public partial class frmMainPhucVu : Form
	{
		public DTO_NhanVien nv;
        BUS_NhanVienPhucVu busnvpv = new BUS_NhanVienPhucVu();
		public frmMainPhucVu()
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

		private void buttonDatMon_Click(object sender, EventArgs e)
		{
            var formDatMon = new frmDatMon();
            formDatMon.nv = nv;
            OpenForm(formDatMon);
		}


		private void frmMain_Load(object sender, EventArgs e)
		{

		}
	}
}
