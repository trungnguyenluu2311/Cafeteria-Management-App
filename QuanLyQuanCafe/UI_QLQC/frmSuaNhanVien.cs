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
	public partial class frmSuaNhanVien : Form
	{
		public frmSuaNhanVien()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                // Code goes here
            }
        }


        // Validate
        private void txtTenNhanVien_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text))
            {
                e.Cancel = true;
                errorProvider_frmSuaNhanVien.SetError(txtTenNhanVien, "Không được để trống mục này!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmSuaNhanVien.SetError(txtTenNhanVien, "");
            }
        }
        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                e.Cancel = true;
                errorProvider_frmSuaNhanVien.SetError(txtDiaChi, "Không được để trống mục này!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmSuaNhanVien.SetError(txtDiaChi, "");
            }
        }
        private void txtSdt_Validating(object sender, CancelEventArgs e)
        {
            bool sdtHopLe = int.TryParse(txtSdt.Text, out int sdt);
            if (string.IsNullOrWhiteSpace(txtSdt.Text))
            {
                e.Cancel = true;
                errorProvider_frmSuaNhanVien.SetError(txtSdt, "Không được để trống mục này!");
            }
            else if (txtSdt.Text.Length != 10 || !sdtHopLe)
            {
                e.Cancel = true;
                errorProvider_frmSuaNhanVien.SetError(txtSdt, "Số điện thoại không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmSuaNhanVien.SetError(txtSdt, "");
            }
        }
        private void txtSoCmnd_Validating(object sender, CancelEventArgs e)
        {
            bool cmndHopLe = int.TryParse(txtSoCmnd.Text, out int cmnd);
            if (string.IsNullOrWhiteSpace(txtSoCmnd.Text))
            {
                e.Cancel = true;
                errorProvider_frmSuaNhanVien.SetError(txtSoCmnd, "Không được để trống mục này!");
            }
            else if (txtSoCmnd.Text.Length != 10 || !cmndHopLe)
            {
                e.Cancel = true;
                errorProvider_frmSuaNhanVien.SetError(txtSoCmnd, "Số CMND không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmSuaNhanVien.SetError(txtSoCmnd, "");
            }
        }
        private void txtLuong_Validating(object sender, CancelEventArgs e)
        {
            bool luongHopLe = int.TryParse(txtLuong.Text, out int l);
            if (string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                e.Cancel = true;
                errorProvider_frmSuaNhanVien.SetError(txtLuong, "Không được để trống mục này!");
            }
            else if (txtLuong.Text.Length != 10 || !luongHopLe)
            {
                e.Cancel = true;
                errorProvider_frmSuaNhanVien.SetError(txtLuong, "Số điện thoại không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmSuaNhanVien.SetError(txtLuong, "");
            }
        }
        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                e.Cancel = true;
                errorProvider_frmSuaNhanVien.SetError(txtMatKhau, "Không được để trống mục này!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmSuaNhanVien.SetError(txtMatKhau, "");
            }
        }

    }
}
