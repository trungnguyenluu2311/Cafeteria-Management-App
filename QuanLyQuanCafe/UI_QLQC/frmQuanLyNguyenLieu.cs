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
		public DTO_NhanVien nv;
		DataTable table = new DataTable();
		BUS_NguyenLieu busNL = new BUS_NguyenLieu();
		public frmQuanLyNguyenLieu()
		{
			InitializeComponent();
			table = busNL.LayDanhSachNguyenLieu();
			dataGridView1.DataSource = table;
		}


		private void buttonNhapNguyenLieu_Click(object sender, EventArgs e)
		{
			var form = new frmNhapNguyenLieu();
			form.nv = nv;
			form.Show();
		}

		private void textBox1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}

        private void frmQuanLyNguyenLieu_Load(object sender, EventArgs e)
        {

			dataGridView1.Refresh();
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
			if(textBox1.Text != "" && textBox1.Text != "<Nhập tên nguyên liệu>")
            {
				table = busNL.TimNguyenLieu(textBox1.Text);
            }
			else
				table = busNL.LayDanhSachNguyenLieu();
			dataGridView1.DataSource = table;
		}

        private void textBox1_Enter(object sender, EventArgs e)
        {
			if(textBox1.Text == "<Nhập tên nguyên liệu>")
			textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
			if (textBox1.Text == "")
				textBox1.Text = "<Nhập tên nguyên liệu>";
		}
        private void button1_Click(object sender, EventArgs e)
		{
			string MaNL = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["MANGUYENLIEU"].Value.ToString();
			string TenNL = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["TEN"].Value.ToString();
			string DonViTinh = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DONVITINH"].Value.ToString();
			int SoLuong = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["SOLUONG"].Value);
			long SoLuongTT = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["SOLUONGTOITHIEU"].Value);
			int ThoiGianBaoQuan = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["THOIGIANBAOQUAN"].Value);
			string GhiChu = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["GHICHU"].Value.ToString();
			frmSuaNguyenLieu frmSuaNguyenLieu = new frmSuaNguyenLieu();
			frmSuaNguyenLieu.nl = new DTO_NguyenLieu(MaNL, TenNL, DonViTinh, SoLuong, SoLuongTT, ThoiGianBaoQuan, GhiChu);
			frmSuaNguyenLieu.Show();
		}
	}
}
