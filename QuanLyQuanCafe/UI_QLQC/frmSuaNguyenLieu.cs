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
	public partial class frmSuaNguyenLieu : Form
	{
		public DTO_NguyenLieu nl;
		BUS_NguyenLieu busnl = new BUS_NguyenLieu();
		public frmSuaNguyenLieu()
		{
			InitializeComponent();
		}

		private void frmSuaNguyenLieu_Load(object sender, EventArgs e)
		{
			textBox1.Text = nl.TenNguyenLieu;
			textBox2.Text = nl.ThoiGianBaoQuan.ToString();
			textBox3.Text = nl.DonViTinh.ToString();
			textBox4.Text = nl.SoLuongToiThieu.ToString();
			textBox5.Text = nl.GhiChu;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			nl.TenNguyenLieu = textBox1.Text;
			nl.ThoiGianBaoQuan = Convert.ToInt32(textBox2.Text);
			nl.DonViTinh = textBox3.Text;
			nl.SoLuongToiThieu = Convert.ToInt64(textBox4.Text);
			nl.GhiChu = textBox5.Text;
			if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin mới?", "Cập nhật thông tin", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				busnl.capNhatNguyenLieu(nl);
				MessageBox.Show("Cập nhật thành công.", "Thông báo");
				this.Close();
			}
		}
	}
}
