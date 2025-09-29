namespace SecurityPanel
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
        private System.Windows.Forms.Button btnClear, btnEnter, btnRing;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Label lblPwd, lblKb, lblLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblKb = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(820, 600);
            this.Text = "Security Panel";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Labels
            this.lblPwd.Text = "Password:";
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(20, 20);
            this.lblKb.Text = "Keyboard:";
            this.lblKb.AutoSize = true;
            this.lblKb.Location = new System.Drawing.Point(20, 90);
            this.lblLog.Text = "Login Log:";
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(20, 260);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(110, 16);
            this.txtPassword.Size = new System.Drawing.Size(520, 28);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.BackColor = System.Drawing.Color.Gainsboro;

            // keypad buttons (3x3)
            var left = 110; var top = 120; var w = 70; var h = 45; var gap = 12;
            System.Windows.Forms.Button[] nums = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            for (int i = 0; i < 9; i++)
            {
                nums[i].Size = new System.Drawing.Size(w, h);
                nums[i].Text = (i + 1).ToString();
                nums[i].Tag = (i + 1).ToString();
                nums[i].Location = new System.Drawing.Point(left + (i % 3) * (w + gap), top + (i / 3) * (h + gap));
                nums[i].Enabled = true;
                this.Controls.Add(nums[i]);
            }

            // Action buttons
            this.btnClear.Text = "Clear";
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(420, 120);
            this.btnClear.Size = new System.Drawing.Size(120, 45);

            this.btnEnter.Text = "Enter";
            this.btnEnter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnter.Location = new System.Drawing.Point(420, 177);
            this.btnEnter.Size = new System.Drawing.Size(120, 45);

            this.btnRing.Text = "RING";
            this.btnRing.BackColor = System.Drawing.Color.Red;
            this.btnRing.Location = new System.Drawing.Point(420, 234);
            this.btnRing.Size = new System.Drawing.Size(120, 45);

            // dgvLog
            this.dgvLog.Location = new System.Drawing.Point(20, 290);
            this.dgvLog.Size = new System.Drawing.Size(780, 290);
            this.dgvLog.ReadOnly = true;
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.RowHeadersVisible = false;

            // Add controls
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblKb);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnRing);
            this.Controls.Add(this.dgvLog);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
