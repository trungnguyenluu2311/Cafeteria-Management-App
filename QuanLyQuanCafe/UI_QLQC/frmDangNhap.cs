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
using QuanLyQuanCafe.BUS_QLQC;
using QuanLyQuanCafe.DTO_QCQC;
namespace QuanLyQuanCafe
{
	public partial class frmDangNhap : Form
	{
		BUS_NhanVien busnv = new BUS_NhanVien();
		public frmDangNhap()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DTO_NhanVien nv = busnv.DangNhap(new DTO_NhanVien("", "", "", "", "", textBox1.Text, DateTime.Now, 0, textBox2.Text, ""));
			if (nv != null)
			{
				this.Hide();
				if(nv.Loai == "Quản lý")
                {
					frmMainQuanLy form = new frmMainQuanLy();
					form.nv = nv;
					form.Show();
				}					
				else
                {
					frmMainPhucVu form = new frmMainPhucVu();
					form.nv = nv;
					form.Show();
				}					
			}
			else
				MessageBox.Show("Sai tài khoản hoặc mật khẩu");
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel1.Hide();
			textBox1.Clear();
			textBox2.Clear();

		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel1.Show();
			textBox6.Clear();
			textBox5.Clear();
			textBox4.Clear();
			textBox3.Clear();
		}
	}
}
