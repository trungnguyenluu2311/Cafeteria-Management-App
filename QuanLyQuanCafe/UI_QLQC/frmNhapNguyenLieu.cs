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
		List<DTO_ChiTietPhieuNhap> phieuNhaps = new List<DTO_ChiTietPhieuNhap>();
		DataTable table = new DataTable();
		BUS_NguyenLieu busNL = new BUS_NguyenLieu();
		BUS_PhieuNhapNguyenLieu busPNNL = new BUS_PhieuNhapNguyenLieu();
		public DTO_NhanVien nv;
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
			table = busNL.LayDanhSachNguyenLieu();
			comboBox1.DataSource = table;
			comboBox1.DisplayMember = "TEN";
			comboBox1.BindingContext = this.BindingContext;
			//dataGridView1.DataSource = phieuNhaps;
			dataGridView1.Columns.Add("TENNGUYENLIEU", "TENNGUYENLIEU");
			dataGridView1.Columns.Add("SOLUONG", "SOLUONG");

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

        private void button1_Click(object sender, EventArgs e)
        {
			DTO_ChiTietPhieuNhap pn = new DTO_ChiTietPhieuNhap("", "", table.Rows[comboBox1.SelectedIndex]["MANGUYENLIEU"].ToString(), Convert.ToInt64(textBox1.Text));
			phieuNhaps.Add(pn);
			dataGridView1.Rows.Add(table.Rows[comboBox1.SelectedIndex]["TEN"].ToString(), textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Bạn có chắc muốn nhập nguyên liệu?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				DTO_PhieuNhapNguyenLieu pnnl = new DTO_PhieuNhapNguyenLieu("", nv.MaNhanVien, DateTime.Now, textBox2.Text);
				busPNNL.themPhieuNhap(ref pnnl, phieuNhaps);
				MessageBox.Show("Cập nhật thành công.", "Thông báo");
				this.Close();
			}

        }

        private void button3_Click(object sender, EventArgs e)
        {
			if(dataGridView1.CurrentCell!=null)
            {
				phieuNhaps.RemoveAt(dataGridView1.CurrentCell.RowIndex);
				dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }				
        }
    }
}
