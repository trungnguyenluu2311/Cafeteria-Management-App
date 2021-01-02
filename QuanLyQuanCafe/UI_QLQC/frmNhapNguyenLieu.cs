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
			comboBox1.DataSource = busNL.LayDanhSachNguyenLieu().DefaultView;
			comboBox1.DisplayMember = "TEN";
			comboBox1.BindingContext = this.BindingContext;
			//dataGridView1.DataSource = busNL.LayDanhSachNguyenLieu();
		}

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
			comboBox1.DataSource = busNL.LayDanhSachNguyenLieu().DefaultView;
			comboBox1.DisplayMember = "TEN";
			comboBox1.BindingContext = this.BindingContext;
		}

        private void button4_Click(object sender, EventArgs e)
        {
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Multiselect = false;
			dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
			if (dialog.ShowDialog() == DialogResult.OK)
				textBox2.Text = dialog.FileName;
        }
    }
}
