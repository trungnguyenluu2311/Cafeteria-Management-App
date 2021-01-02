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
using System.Data;

namespace QuanLyQuanCafe
{
    public partial class frmThemNguyenLieuMoi: Form
    {
        BUS_NguyenLieu busnl = new BUS_NguyenLieu();
        BindingList<DTO_NguyenLieu> nlmoi = new BindingList<DTO_NguyenLieu>();
        BindingSource source = new BindingSource();
        public frmThemNguyenLieuMoi()
        {
            InitializeComponent();
            //dataGridView1.AutoGenerateColumns = true;
            source.DataSource = nlmoi;
            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string TenNL = textBox1.Text;
            string DonViTinh = textBox3.Text;
            long SoLuongToiThieu = Convert.ToInt64(textBox4.Text);
            int ThoiGianBaoQuan = Convert.ToInt32(textBox2.Text);
            string GhiChu = textBox5.Text;
            DTO_NguyenLieu nl = new DTO_NguyenLieu("", TenNL,DonViTinh,0,SoLuongToiThieu,ThoiGianBaoQuan,GhiChu);
            nlmoi.Add(nl);
            //source.DataSource = nlmoi;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nlmoi!=null&& dataGridView1.CurrentCell!=null)
                nlmoi.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DTO_NguyenLieu nl in nlmoi)
                busnl.taoNguyenLieu(nl);
            MessageBox.Show("Thêm nguyên liệu thành công");
            this.Close();
        }
    }
}
