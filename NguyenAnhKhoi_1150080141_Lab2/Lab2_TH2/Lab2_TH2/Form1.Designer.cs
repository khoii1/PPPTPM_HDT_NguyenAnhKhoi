namespace ApDung1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpNhap;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;

        private System.Windows.Forms.GroupBox grpChon;
        private System.Windows.Forms.RadioButton radUSCLN;
        private System.Windows.Forms.RadioButton radBSCNN;

        private System.Windows.Forms.GroupBox grpKQ;
        private System.Windows.Forms.TextBox txtKetQua;

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpNhap = new System.Windows.Forms.GroupBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();

            this.grpChon = new System.Windows.Forms.GroupBox();
            this.radUSCLN = new System.Windows.Forms.RadioButton();
            this.radBSCNN = new System.Windows.Forms.RadioButton();

            this.grpKQ = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();

            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            // --- Form ---
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(640, 260);
            this.Text = "Tìm USCLN và BSCNN của số nguyên a và b";
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            // --- grpNhap ---
            this.grpNhap.Text = "Nhập dữ liệu:";
            this.grpNhap.BackColor = System.Drawing.Color.Honeydew;
            this.grpNhap.Location = new System.Drawing.Point(12, 12);
            this.grpNhap.Size = new System.Drawing.Size(380, 110);

            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Text = "Số nguyên a:";
            this.lblA.Location = new System.Drawing.Point(20, 30);

            // lblB
            this.lblB.AutoSize = true;
            this.lblB.Text = "Số nguyên b:";
            this.lblB.Location = new System.Drawing.Point(20, 70);

            // txtA
            this.txtA.Name = "txtA";
            this.txtA.Location = new System.Drawing.Point(130, 27);
            this.txtA.Size = new System.Drawing.Size(220, 22);

            // txtB
            this.txtB.Name = "txtB";
            this.txtB.Location = new System.Drawing.Point(130, 67);
            this.txtB.Size = new System.Drawing.Size(220, 22);

            this.grpNhap.Controls.Add(this.lblA);
            this.grpNhap.Controls.Add(this.lblB);
            this.grpNhap.Controls.Add(this.txtA);
            this.grpNhap.Controls.Add(this.txtB);

            // --- grpChon ---
            this.grpChon.Text = "Tùy chọn:";
            this.grpChon.BackColor = System.Drawing.Color.Gainsboro;
            this.grpChon.Location = new System.Drawing.Point(408, 12);
            this.grpChon.Size = new System.Drawing.Size(210, 110);

            // radUSCLN
            this.radUSCLN.Name = "radUSCLN";
            this.radUSCLN.AutoSize = true;
            this.radUSCLN.Text = "USCLN";
            this.radUSCLN.Location = new System.Drawing.Point(20, 35);

            // radBSCNN
            this.radBSCNN.Name = "radBSCNN";
            this.radBSCNN.AutoSize = true;
            this.radBSCNN.Text = "BSCNN";
            this.radBSCNN.Location = new System.Drawing.Point(20, 70);

            this.grpChon.Controls.Add(this.radUSCLN);
            this.grpChon.Controls.Add(this.radBSCNN);

            // --- grpKQ ---
            this.grpKQ.Text = "Kết quả:";
            this.grpKQ.Location = new System.Drawing.Point(12, 130);
            this.grpKQ.Size = new System.Drawing.Size(500, 80);

            // txtKetQua
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Location = new System.Drawing.Point(20, 35);
            this.txtKetQua.Size = new System.Drawing.Size(460, 22);

            this.grpKQ.Controls.Add(this.txtKetQua);

            // --- btnTim ---
            this.btnTim.Name = "btnTim";
            this.btnTim.Text = "Tìm";
            this.btnTim.Location = new System.Drawing.Point(520, 150);
            this.btnTim.Size = new System.Drawing.Size(98, 28);
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            // --- btnThoat ---
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(520, 190);
            this.btnThoat.Size = new System.Drawing.Size(98, 28);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // Add controls
            this.Controls.Add(this.grpNhap);
            this.Controls.Add(this.grpChon);
            this.Controls.Add(this.grpKQ);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);

            this.ResumeLayout(false);
        }
    }
}
