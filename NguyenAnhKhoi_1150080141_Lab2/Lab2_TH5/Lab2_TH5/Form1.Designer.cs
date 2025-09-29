using System.Windows.Forms;
using System.Drawing;

namespace XuLyDaySoApp
{
    partial class frmDangNhap
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle, lblUser, lblPass;
        private TextBox txtUsername, txtPassword;
        private Button btnLogin, btnExit;
        private ErrorProvider err;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblUser = new Label();
            lblPass = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            err = new ErrorProvider(components);

            SuspendLayout();
            ClientSize = new Size(380, 210);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";

            lblTitle.Text = "ĐĂNG NHẬP";
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Location = new Point(15, 10);
            lblTitle.Size = new Size(350, 32);

            lblUser.Text = "Username:";
            lblUser.Location = new Point(25, 60);
            lblUser.Size = new Size(80, 23);

            txtUsername.Location = new Point(115, 58);
            txtUsername.Size = new Size(230, 27);

            lblPass.Text = "Password:";
            lblPass.Location = new Point(25, 95);
            lblPass.Size = new Size(80, 23);

            txtPassword.Location = new Point(115, 93);
            txtPassword.Size = new Size(230, 27);

            btnLogin.Text = "Đăng nhập";
            btnLogin.Location = new Point(115, 140);
            btnLogin.Size = new Size(110, 30);

            btnExit.Text = "Thoát";
            btnExit.Location = new Point(235, 140);
            btnExit.Size = new Size(110, 30);

            Controls.AddRange(new Control[] {
                lblTitle, lblUser, txtUsername, lblPass, txtPassword, btnLogin, btnExit
            });

            ((System.ComponentModel.ISupportInitialize)(err)).BeginInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
