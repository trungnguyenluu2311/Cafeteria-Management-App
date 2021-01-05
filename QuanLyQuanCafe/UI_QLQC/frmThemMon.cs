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
	public partial class frmThemMon : Form
	{
		List<DTO_ChiTietThucUong> chiTietThucUongs = new List<DTO_ChiTietThucUong>();
		DataTable table = new DataTable();
		BUS_NguyenLieu busNL = new BUS_NguyenLieu();
		BUS_ThucUong busTU = new BUS_ThucUong();
		BindingSource source = new BindingSource();
		public frmThemMon()
		{
			InitializeComponent();
		}

        private void frmThemMon_Load(object sender, EventArgs e)
        {
			table = busNL.LayDanhSachNguyenLieu();
			comboBox1.DataSource = table;
			comboBox1.DisplayMember = "TEN";
			comboBox1.BindingContext = this.BindingContext;
			dataGridView1.Columns.Add("TENNGUYENLIEU", "TENNGUYENLIEU");
			dataGridView1.Columns.Add("SOLUONG", "SOLUONG");
		}

        private void button1_Click(object sender, EventArgs e)
        {
			DTO_ChiTietThucUong cttu = new DTO_ChiTietThucUong("", "", table.Rows[comboBox1.SelectedIndex]["MANGUYENLIEU"].ToString(), Convert.ToInt32(textBox4.Text));
			chiTietThucUongs.Add(cttu);
			dataGridView1.Rows.Add(table.Rows[comboBox1.SelectedIndex]["TEN"].ToString(), textBox4.Text);

		}

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
			comboBox1.DataSource = busNL.LayDanhSachNguyenLieu().DefaultView;
			comboBox1.DisplayMember = "TEN";
			comboBox1.BindingContext = this.BindingContext;
		}

        private void button2_Click(object sender, EventArgs e)
        {
			if (dataGridView1.CurrentCell != null)
			{
				chiTietThucUongs.RemoveAt(dataGridView1.CurrentCell.RowIndex);
				dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
			}
		}

        private void button3_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Bạn có chắc muốn thêm món?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				DTO_ThucUong tu = new DTO_ThucUong("",textBox1.Text,Convert.ToInt64(textBox2.Text),textBox3.Text);
				busTU.themThucUong(ref tu, chiTietThucUongs);
				MessageBox.Show("Thêm thành công.", "Thông báo");
				this.Close();
			}
		}
    }
}
