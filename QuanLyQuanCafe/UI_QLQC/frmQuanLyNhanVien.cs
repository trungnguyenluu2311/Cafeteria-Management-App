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
	public partial class frmQuanLyNhanVien : Form
	{
        BUS_NhanVienQuanLy busNvql = new BUS_NhanVienQuanLy();
        DataTable table = new DataTable();
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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Bạn có chắc muốn xoá nhân viên?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				busNvql.xoaNhanVien(table.Rows[dataGridView1.CurrentCell.RowIndex]["MANHANVIEN"].ToString());
				MessageBox.Show("Xoá thành công.", "Thông báo");
				this.Close();
			}
		}

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            table = busNvql.xemDanhSachNhanVien();
            dataGridView1.DataSource = table;
        }
		private void textBox1_Enter(object sender, EventArgs e)
		{
			if (textBox1.Text == "<Nhập tên nhân viên>")
				textBox1.Text = "";
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
				textBox1.Text = "<Nhập tên nhân viên>";
		}

		private void pictureBox1_Click(object sender, EventArgs e)
        {
			if (textBox1.Text != "" && textBox1.Text != "<Nhập tên nguyên liệu>")
			{
				table = busNvql.timNhanVien(textBox1.Text);
			}
			else
				table = busNvql.xemDanhSachNhanVien();
			dataGridView1.DataSource = table;
		}
    }
}
