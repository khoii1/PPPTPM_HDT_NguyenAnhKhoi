using System.Drawing;
using System.Windows.Forms;

namespace XuLyDaySoApp
{
    partial class frmXuLySo
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlTitle;
        private Label lblTitle, lblNhap, lblList, lblFunc;
        private TextBox txtInput;
        private Button btnInput, btnTang2, btnChanDau, btnLeCuoi,
                       btnXoaChon, btnXoaDau, btnXoaCuoi, btnXoaDaySo, btnClose;
        private ListBox lsbDaySo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlTitle = new Panel();
            lblTitle = new Label();
            lblNhap = new Label();
            txtInput = new TextBox();
            btnInput = new Button();

            lblList = new Label();
            lblFunc = new Label();

            lsbDaySo = new ListBox();

            btnTang2 = new Button();
            btnChanDau = new Button();
            btnLeCuoi = new Button();
            btnXoaChon = new Button();
            btnXoaDau = new Button();
            btnXoaCuoi = new Button();

            btnClose = new Button();
            btnXoaDaySo = new Button();

            SuspendLayout();
            ClientSize = new Size(620, 430);
            Font = new Font("Segoe UI", 9F);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng dụng xử lý dãy số";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // Title
            pnlTitle.BackColor = Color.Teal;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Size = new Size(620, 60);
            lblTitle.Text = "Ứng dụng xử lý dãy số";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.AutoSize = false;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Dock = DockStyle.Fill;
            pnlTitle.Controls.Add(lblTitle);

            // Nhập
            lblNhap.Text = "Nhập số nguyên:";
            lblNhap.Location = new Point(20, 75);
            lblNhap.Size = new Size(120, 24);

            txtInput.Location = new Point(140, 72);
            txtInput.Size = new Size(180, 26);

            btnInput.Text = "Nhập số";
            btnInput.Location = new Point(330, 70);
            btnInput.Size = new Size(90, 30);

            // Labels cột
            lblList.Text = "lsbDaySo";
            lblList.Location = new Point(20, 110);
            lblFunc.Text = "Chức năng:";
            lblFunc.Location = new Point(340, 110);

            // ListBox
            lsbDaySo.Location = new Point(20, 130);
            lsbDaySo.Size = new Size(300, 230);
            lsbDaySo.SelectionMode = SelectionMode.MultiExtended;

            // Buttons chức năng (cột phải)
            int bx = 340, by = 130, bw = 240, bh = 32, gap = 8;

            btnTang2.Text = "Tăng mỗi phần tử lên 2";
            btnTang2.Location = new Point(bx, by);
            btnTang2.Size = new Size(bw, bh);

            btnChanDau.Text = "Chọn số chẵn đầu";
            btnChanDau.Location = new Point(bx, by + (bh + gap) * 1);
            btnChanDau.Size = new Size(bw, bh);

            btnLeCuoi.Text = "Chọn số lẻ cuối";
            btnLeCuoi.Location = new Point(bx, by + (bh + gap) * 2);
            btnLeCuoi.Size = new Size(bw, bh);

            btnXoaChon.Text = "Xóa phần tử đang chọn";
            btnXoaChon.Location = new Point(bx, by + (bh + gap) * 3);
            btnXoaChon.Size = new Size(bw, bh);

            btnXoaDau.Text = "Xóa phần tử đầu";
            btnXoaDau.Location = new Point(bx, by + (bh + gap) * 4);
            btnXoaDau.Size = new Size(bw, bh);

            btnXoaCuoi.Text = "Xóa phần tử cuối";
            btnXoaCuoi.Location = new Point(bx, by + (bh + gap) * 5);
            btnXoaCuoi.Size = new Size(bw, bh);

            // Nút dưới cùng
            btnClose.Text = "Kết thúc ứng dụng";
            btnClose.BackColor = Color.Firebrick;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(20, 375);
            btnClose.Size = new Size(180, 34);

            btnXoaDaySo.Text = "Xóa dãy số";
            btnXoaDaySo.BackColor = Color.DimGray;
            btnXoaDaySo.ForeColor = Color.White;
            btnXoaDaySo.Location = new Point(220, 375);
            btnXoaDaySo.Size = new Size(180, 34);

            // Add
            Controls.AddRange(new Control[] {
                pnlTitle, lblNhap, txtInput, btnInput, lblList, lblFunc, lsbDaySo,
                btnTang2, btnChanDau, btnLeCuoi, btnXoaChon, btnXoaDau, btnXoaCuoi,
                btnClose, btnXoaDaySo
            });

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
