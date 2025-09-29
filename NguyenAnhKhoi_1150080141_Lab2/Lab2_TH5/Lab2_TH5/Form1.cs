using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace XuLyDaySoApp
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
            CancelButton = btnExit;
            txtPassword.UseSystemPasswordChar = true;

            // validate khi rời control
            txtUsername.Validating += NotEmpty_Validating;
            txtPassword.Validating += NotEmpty_Validating;

            btnLogin.Click += (s, e) =>
            {
                if (!ValidateChildren(ValidationConstraints.Enabled)) return;
                // Yêu cầu chỉ kiểm tra không trống → mở form chính
                var f = new frmXuLySo();
                this.Hide();
                f.FormClosed += (s2, e2) => this.Close();
                f.Show();
            };

            btnExit.Click += (s, e) => Close();
        }

        private void NotEmpty_Validating(object sender, CancelEventArgs e)
        {
            var tb = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                e.Cancel = true;
                err.SetError(tb, "Không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(tb, null);
            }
        }
    }
}
