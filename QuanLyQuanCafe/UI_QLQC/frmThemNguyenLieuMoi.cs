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
    public partial class frmThemNguyenLieuMoi : Form
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string TenNL = txtTenNguyenLieu.Text;
                string DonViTinh = txtDonviTinh.Text;
                long SoLuongToiThieu = Convert.ToInt64(txtSoLuongToiThieu.Text);
                int ThoiGianBaoQuan = Convert.ToInt32(txtThoiGianBaoQuan.Text);
                string GhiChu = this.txtGhiChu.Text;
                DTO_NguyenLieu nl = new DTO_NguyenLieu("", TenNL, DonViTinh, 0, SoLuongToiThieu, ThoiGianBaoQuan, GhiChu);
                nlmoi.Add(nl);
                //source.DataSource = nlmoi;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nlmoi != null && dataGridView1.CurrentCell != null)
                nlmoi.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (DTO_NguyenLieu nl in nlmoi)
                busnl.taoNguyenLieu(nl);
            MessageBox.Show("Thêm nguyên liệu thành công");
            this.Close();
        }




        private void txtThoiGianBaoQuan_Validating(object sender, CancelEventArgs e)
        {
            bool convert = int.TryParse(txtThoiGianBaoQuan.Text, out int tg);
            if (string.IsNullOrWhiteSpace(txtThoiGianBaoQuan.Text))
            {
                e.Cancel = true;
                errorProvider_frmThemNglieuMoi.SetError(txtThoiGianBaoQuan, "Không được để trống mục này!");
            }
            else if (!convert)
            {
                e.Cancel = true;
                errorProvider_frmThemNglieuMoi.SetError(txtThoiGianBaoQuan, "Thời gian bảo quản là số nguyên (ngày)");
            }
            {
                e.Cancel = false;
                errorProvider_frmThemNglieuMoi.SetError(txtThoiGianBaoQuan, "");
            }
        }
        private void txtTenNguyenLieu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNguyenLieu.Text))
            {
                e.Cancel = true;
                errorProvider_frmThemNglieuMoi.SetError(txtTenNguyenLieu, "Không được để trống mục này!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmThemNglieuMoi.SetError(txtTenNguyenLieu, "");
            }
        }
        private void txtSoLuongToiThieu_Validating(object sender, CancelEventArgs e)
        {
            bool convert = int.TryParse(txtSoLuongToiThieu.Text, out int tg);

            if (string.IsNullOrWhiteSpace(txtSoLuongToiThieu.Text))
            {
                e.Cancel = true;
                errorProvider_frmThemNglieuMoi.SetError(txtSoLuongToiThieu, "Không được để trống mục này!");
            }
            else if (!convert)
            {
                e.Cancel = true;
                errorProvider_frmThemNglieuMoi.SetError(txtSoLuongToiThieu, "Số lượng tối thiểu là số nguyên (đơn vị tính)");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmThemNglieuMoi.SetError(txtSoLuongToiThieu, "");
            }
        }
        private void txtDonviTinh_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonviTinh.Text))
            {
                e.Cancel = true;
                errorProvider_frmThemNglieuMoi.SetError(txtDonviTinh, "Không được để trống mục này!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmThemNglieuMoi.SetError(txtDonviTinh, "");
            }
        }
    }
}
