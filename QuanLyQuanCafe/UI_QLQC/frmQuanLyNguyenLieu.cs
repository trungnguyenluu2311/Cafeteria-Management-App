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
	public partial class frmQuanLyNguyenLieu : Form
	{
		BUS_NguyenLieu busNL = new BUS_NguyenLieu();
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

        private void frmQuanLyNguyenLieu_Load(object sender, EventArgs e)
        {
			dataGridView1.DataSource = busNL.LayDanhSachNguyenLieu();
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
			if(textBox1.Text != "" && textBox1.Text != "<Tên nguyên liệu>")
            {
				dataGridView1.DataSource = busNL.TimNguyenLieu(textBox1.Text);
            }
			else
				dataGridView1.DataSource = busNL.LayDanhSachNguyenLieu();
		}

        private void textBox1_Enter(object sender, EventArgs e)
        {
			if(textBox1.Text == "<Tên nguyên liệu>")
			textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
			if (textBox1.Text == "")
				textBox1.Text = "<Tên nguyên liệu>";
        }
    }
}
