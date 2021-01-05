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
			txtTenNguyenLieu.Text = nl.TenNguyenLieu;
            txtThoiGianBaoQuan.Text = nl.ThoiGianBaoQuan.ToString();
			txtDonviTinh.Text = nl.DonViTinh.ToString();
			textBox4.Text = nl.SoLuongToiThieu.ToString();
			textBox5.Text = nl.GhiChu;
		}

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                nl.TenNguyenLieu = txtTenNguyenLieu.Text;
                nl.ThoiGianBaoQuan = Convert.ToInt32(txtThoiGianBaoQuan.Text);
                nl.DonViTinh = txtDonviTinh.Text;
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

        // Validate
        private void txtTenNguyenLieu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNguyenLieu.Text))
            {
                e.Cancel = true;
                errorProvider_frmSuaNguyenLieu.SetError(txtTenNguyenLieu, "Không được để trống mục này!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmSuaNguyenLieu.SetError(txtTenNguyenLieu, "");
            }
        }
        private void txtDonviTinh_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonviTinh.Text))
            {
                e.Cancel = true;
                errorProvider_frmSuaNguyenLieu.SetError(txtDonviTinh, "Không được để trống mục này!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmSuaNguyenLieu.SetError(txtDonviTinh, "");
            }
        }
        private void txtThoiGianBaoQuan_Validating(object sender, CancelEventArgs e)
        {
            bool convert = int.TryParse(txtThoiGianBaoQuan.Text, out int tgbq);
            if (string.IsNullOrWhiteSpace(txtThoiGianBaoQuan.Text))
            {
                e.Cancel = true;
                errorProvider_frmSuaNguyenLieu.SetError(txtThoiGianBaoQuan, "Không được để trống mục này!");
            }
            else if (!convert)
            {
                e.Cancel = true;
                errorProvider_frmSuaNguyenLieu.SetError(txtThoiGianBaoQuan, "Thời gian bảo quản là số nguyên (ngày)");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmSuaNguyenLieu.SetError(txtThoiGianBaoQuan, "");
            }
        }
    }
}

