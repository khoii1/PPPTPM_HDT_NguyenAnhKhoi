using System.Windows.Forms;
using System.Drawing;

namespace NhaKhoa
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlBanner;
        private Label lblBanner;

        private Label lblTenKH;
        private TextBox txtTenKH;
        private ErrorProvider err;

        private GroupBox grpDichVu;
        private CheckBox chkLayCaoRang;
        private CheckBox chkTayTrangRang;
        private CheckBox chkHanRang;
        private CheckBox chkBeRang;
        private CheckBox chkBocRang;

        private Label lblGiaLayCao;
        private Label lblGiaTayTrang;
        private Label lblGiaHan;
        private Label lblGiaBe;
        private Label lblGiaBoc;

        private NumericUpDown nupHanRang;
        private NumericUpDown nupBeRang;
        private NumericUpDown nupBocRang;

        private GroupBox grpChucNang;
        private TextBox txtThanhTien;
        private Button btnTinhTien;
        private Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlBanner = new Panel();
            this.lblBanner = new Label();

            this.lblTenKH = new Label();
            this.txtTenKH = new TextBox();
            this.err = new ErrorProvider(this.components);

            this.grpDichVu = new GroupBox();
            this.chkLayCaoRang = new CheckBox();
            this.chkTayTrangRang = new CheckBox();
            this.chkHanRang = new CheckBox();
            this.chkBeRang = new CheckBox();
            this.chkBocRang = new CheckBox();

            this.lblGiaLayCao = new Label();
            this.lblGiaTayTrang = new Label();
            this.lblGiaHan = new Label();
            this.lblGiaBe = new Label();
            this.lblGiaBoc = new Label();

            this.nupHanRang = new NumericUpDown();
            this.nupBeRang = new NumericUpDown();
            this.nupBocRang = new NumericUpDown();

            this.grpChucNang = new GroupBox();
            this.txtThanhTien = new TextBox();
            this.btnTinhTien = new Button();
            this.btnThoat = new Button();

            // ===== Form =====
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Font = new Font("Segoe UI", 9F);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // ===== Banner =====
            this.pnlBanner.BackColor = Color.LimeGreen;
            this.pnlBanner.Dock = DockStyle.Top;
            this.pnlBanner.Height = 70;
            this.pnlBanner.Controls.Add(this.lblBanner);

            this.lblBanner.Dock = DockStyle.Fill;
            this.lblBanner.TextAlign = ContentAlignment.MiddleCenter;
            this.lblBanner.ForeColor = Color.White;
            this.lblBanner.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblBanner.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";

            // ===== Tên khách hàng =====
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new Point(20, 90);
            this.lblTenKH.Text = "Tên khách hàng:";

            this.txtTenKH.Location = new Point(150, 86);
            this.txtTenKH.Size = new Size(500, 27);
            this.txtTenKH.BackColor = Color.Gainsboro;

            this.err.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            this.err.ContainerControl = this;

            // ===== GroupBox Dịch vụ =====
            this.grpDichVu.Text = "Dịch vụ tại phòng khám:";
            this.grpDichVu.Location = new Point(20, 130);
            this.grpDichVu.Size = new Size(720, 220);

            // Checkboxes (cột trái)
            this.chkLayCaoRang.Location = new Point(20, 35);
            this.chkLayCaoRang.Size = new Size(150, 24);
            this.chkLayCaoRang.Text = "Lấy cao răng";

            this.chkTayTrangRang.Location = new Point(20, 67);
            this.chkTayTrangRang.Size = new Size(150, 24);
            this.chkTayTrangRang.Text = "Tẩy trắng răng";

            this.chkHanRang.Location = new Point(20, 100);
            this.chkHanRang.Size = new Size(150, 24);
            this.chkHanRang.Text = "Hàn răng";

            this.chkBeRang.Location = new Point(20, 131);
            this.chkBeRang.Size = new Size(150, 24);
            this.chkBeRang.Text = "Bẻ răng";

            this.chkBocRang.Location = new Point(20, 163);
            this.chkBocRang.Size = new Size(150, 24);
            this.chkBocRang.Text = "Bọc răng";

            // Giá (cột giữa)
            this.lblGiaLayCao.Location = new Point(250, 35);
            this.lblGiaLayCao.Size = new Size(180, 24);
            this.lblGiaLayCao.TextAlign = ContentAlignment.MiddleLeft;
            this.lblGiaLayCao.Text = "50.000đ/2 hàm";

            this.lblGiaTayTrang.Location = new Point(250, 67);
            this.lblGiaTayTrang.Size = new Size(180, 24);
            this.lblGiaTayTrang.TextAlign = ContentAlignment.MiddleLeft;
            this.lblGiaTayTrang.Text = "100.000đ/2 hàm";

            this.lblGiaHan.Location = new Point(250, 99);
            this.lblGiaHan.Size = new Size(180, 24);
            this.lblGiaHan.TextAlign = ContentAlignment.MiddleLeft;
            this.lblGiaHan.Text = "100.000đ/1 răng";

            this.lblGiaBe.Location = new Point(250, 131);
            this.lblGiaBe.Size = new Size(180, 24);
            this.lblGiaBe.TextAlign = ContentAlignment.MiddleLeft;
            this.lblGiaBe.Text = "10.000đ/1 răng";

            this.lblGiaBoc.Location = new Point(250, 163);
            this.lblGiaBoc.Size = new Size(180, 24);
            this.lblGiaBoc.TextAlign = ContentAlignment.MiddleLeft;
            this.lblGiaBoc.Text = "1.000.000đ/1 răng";

            // NumericUpDowns (cột phải)
            this.nupHanRang.Location = new Point(460, 99);
            this.nupHanRang.Size = new Size(60, 27);

            this.nupBeRang.Location = new Point(460, 131);
            this.nupBeRang.Size = new Size(60, 27);

            this.nupBocRang.Location = new Point(460, 163);
            this.nupBocRang.Size = new Size(60, 27);

            this.grpDichVu.Controls.AddRange(new Control[]
            {
                chkLayCaoRang, chkTayTrangRang, chkHanRang, chkBeRang, chkBocRang,
                lblGiaLayCao, lblGiaTayTrang, lblGiaHan, lblGiaBe, lblGiaBoc,
                nupHanRang, nupBeRang, nupBocRang
            });

            // ===== GroupBox Chức năng =====
            this.grpChucNang.Text = "Chức năng:";
            this.grpChucNang.Location = new Point(20, 360);
            this.grpChucNang.Size = new Size(720, 120);

            this.txtThanhTien.Location = new Point(170, 55);
            this.txtThanhTien.Size = new Size(300, 27);
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.TextAlign = HorizontalAlignment.Center;

            this.btnTinhTien.Location = new Point(30, 48);
            this.btnTinhTien.Size = new Size(110, 38);
            this.btnTinhTien.Text = "Tính tiền";

            this.btnThoat.Location = new Point(500, 48);
            this.btnThoat.Size = new Size(110, 38);
            this.btnThoat.Text = "Thoát";

            this.grpChucNang.Controls.Add(this.btnTinhTien);
            this.grpChucNang.Controls.Add(this.txtThanhTien);
            this.grpChucNang.Controls.Add(this.btnThoat);

            // ===== Add all to Form =====
            this.Controls.Add(this.pnlBanner);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.grpChucNang);

            ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
