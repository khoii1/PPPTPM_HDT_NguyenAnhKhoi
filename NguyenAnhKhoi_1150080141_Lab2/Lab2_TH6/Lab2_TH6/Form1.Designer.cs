using System.Drawing;
using System.Windows.Forms;

namespace ChuyenListBox
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox grpLeft;
        private GroupBox grpRight;
        private ListBox lstMatHang;
        private ListBox lstDaChon;
        private Button btnRight;
        private Button btnAllRight;
        private Button btnLeft;
        private Button btnAllLeft;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            grpLeft = new GroupBox();
            grpRight = new GroupBox();
            lstMatHang = new ListBox();
            lstDaChon = new ListBox();
            btnRight = new Button();
            btnAllRight = new Button();
            btnLeft = new Button();
            btnAllLeft = new Button();

            // ===== Form =====
            SuspendLayout();
            ClientSize = new Size(760, 430);
            Font = new Font("Segoe UI", 9F);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "";
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // ===== Group Left =====
            grpLeft.Text = "Danh sách các mặt hàng";
            grpLeft.Location = new Point(12, 12);
            grpLeft.Size = new Size(320, 406);

            // ListBox Left
            lstMatHang.Location = new Point(12, 25);
            lstMatHang.Size = new Size(296, 368);
            lstMatHang.SelectionMode = SelectionMode.MultiExtended;
            grpLeft.Controls.Add(lstMatHang);

            // ===== Group Right =====
            grpRight.Text = "Các mặt hàng lựa chọn";
            grpRight.Location = new Point(428, 12);
            grpRight.Size = new Size(320, 406);

            // ListBox Right
            lstDaChon.Location = new Point(12, 25);
            lstDaChon.Size = new Size(296, 368);
            lstDaChon.SelectionMode = SelectionMode.MultiExtended;
            grpRight.Controls.Add(lstDaChon);

            // ===== Buttons giữa (toạ độ tuyệt đối) =====
            // dùng các số đã tính sẵn thay vì bx/bh/gap
            btnRight.Text = ">";
            btnRight.Location = new Point(350, 120);
            btnRight.Size = new Size(60, 36);

            btnAllRight.Text = ">>";
            btnAllRight.Location = new Point(350, 172); // 120 + (36 + 16)
            btnAllRight.Size = new Size(60, 36);

            btnLeft.Text = "<";
            btnLeft.Location = new Point(350, 224);     // 120 + 2*(36 + 16)
            btnLeft.Size = new Size(60, 36);

            btnAllLeft.Text = "<<";
            btnAllLeft.Location = new Point(350, 276);  // 120 + 3*(36 + 16)
            btnAllLeft.Size = new Size(60, 36);

            // Add controls
            Controls.Add(grpLeft);
            Controls.Add(grpRight);
            Controls.Add(btnRight);
            Controls.Add(btnAllRight);
            Controls.Add(btnLeft);
            Controls.Add(btnAllLeft);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
