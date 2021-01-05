using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO_QCQC;
using QuanLyQuanCafe.BUS_QLQC;
namespace QuanLyQuanCafe
{
	public partial class frmThemNhanVien : Form
	{
		BUS_NhanVienQuanLy busNvql = new BUS_NhanVienQuanLy();
		public frmThemNhanVien()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Bạn có chắc muốn thêm nhân viên?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				string LoaiNV = comboBox1.Text;
				string HoNV = textBox5.Text;
				string TenNV = textBox1.Text;
				string DiaChi = textBox2.Text;
				string Sdt = textBox3.Text;
				string Cmnd = textBox4.Text;
				long Luong = Convert.ToInt64(textBox6.Text);
				string MatKhau = textBox7.Text;
				DateTime NgayVaoLam = dateTimePicker1.Value;
				DTO_NhanVien nv = new DTO_NhanVien("", TenNV, HoNV, Cmnd, DiaChi, Sdt, NgayVaoLam, Luong, MatKhau, LoaiNV);
				busNvql.themNhanVien(nv);
				MessageBox.Show("Thêm thành công.", "Thông báo");
				this.Close();
			}

        }

        private void button2_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void frmThemNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
			if (MessageBox.Show("Bạn có chắc muốn huỷ bỏ thêm nhân viên?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}
    }
}
