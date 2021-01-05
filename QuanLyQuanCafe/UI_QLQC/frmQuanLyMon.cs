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
	public partial class frmQuanLyMon : Form
	{
		DataTable table = new DataTable();
		BUS_ThucUong busTU= new BUS_ThucUong();
		public frmQuanLyMon()
		{
			InitializeComponent();
		}

        private void frmQuanLyMon_Load(object sender, EventArgs e)
        {
			table = busTU.LayDanhSachThucUong();
			dataGridView1.DataSource = table;
        }
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" && textBox1.Text != "<Nhập tên món>")
			{
				table = busTU.LayDanhSachThucUong(textBox1.Text);
			}
			else
				table = busTU.LayDanhSachThucUong();
			dataGridView1.DataSource = table;
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			if (textBox1.Text == "<Nhập tên món>")
				textBox1.Text = "";
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
				textBox1.Text = "<Nhập tên món>";
		}
		private void button2_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc muốn xoá món?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				busTU.xoaThucUong(table.Rows[dataGridView1.CurrentCell.RowIndex]["MATHUCUONG"].ToString());
				MessageBox.Show("Xoá thành công.", "Thông báo");
				table = busTU.LayDanhSachThucUong();
				dataGridView1.DataSource = table;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string MaTU = table.Rows[dataGridView1.CurrentCell.RowIndex]["MATHUCUONG"].ToString();
			string Ten = table.Rows[dataGridView1.CurrentCell.RowIndex]["TEN"].ToString();
			long Gia = Convert.ToInt64(table.Rows[dataGridView1.CurrentCell.RowIndex]["GIA"]);
			string GhiChu = table.Rows[dataGridView1.CurrentCell.RowIndex]["GHICHU"].ToString();
			DTO_ThucUong thucUong = new DTO_ThucUong(MaTU, Ten, Gia, GhiChu);
			frmSuaMon frmSuaMon = new frmSuaMon(thucUong);
			frmSuaMon.Show();
		}

		private void buttonThemMon_Click(object sender, EventArgs e)
		{
			frmThemMon frmThemMon = new frmThemMon();
			frmThemMon.Show();
		}

    }
}
