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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DTO_NhanVien nv = busnv.DangNhap(new DTO_NhanVien("", "", "", "", "", txtUsername.Text, DateTime.Now, 0, txtPassword.Text, ""));
                if (nv != null)
                {
                    this.Hide();
                    if (nv.Loai == "Quản lý")
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
        }

        private void llb_ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Hide();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Show();
            textBox6.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
        }

        // Validate
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider_frmDangNhap.SetError(txtUsername, "Tên đăng nhập không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmDangNhap.SetError(txtUsername, "");
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider_frmDangNhap.SetError(txtPassword, "Mật khẩu không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_frmDangNhap.SetError(txtPassword, "");
            }
        }
    }
}
