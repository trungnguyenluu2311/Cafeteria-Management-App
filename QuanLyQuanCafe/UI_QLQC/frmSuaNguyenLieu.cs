using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class frmSuaNguyenLieu : Form
	{
		public frmSuaNguyenLieu()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

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
