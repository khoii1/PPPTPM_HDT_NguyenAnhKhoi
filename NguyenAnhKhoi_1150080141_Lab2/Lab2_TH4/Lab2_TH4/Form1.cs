using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace NhaKhoa
{
    public partial class Form1 : Form
    {
        const int GIA_LAY_CAO = 50_000;
        const int GIA_TAY_TRANG = 100_000;
        const int GIA_HAN = 100_000;
        const int GIA_BE = 10_000;
        const int GIA_BOC = 1_000_000;

        readonly CultureInfo viVN = new CultureInfo("vi-VN");

        public Form1()
        {
            InitializeComponent();

            foreach (var n in new[] { nupHanRang, nupBeRang, nupBocRang })
            {
                n.Minimum = 1;
                n.Maximum = 100;
                n.Value = 1;
                n.Enabled = false;
            }

            chkHanRang.CheckedChanged += (s, e) => nupHanRang.Enabled = chkHanRang.Checked;
            chkBeRang.CheckedChanged += (s, e) => nupBeRang.Enabled = chkBeRang.Checked;
            chkBocRang.CheckedChanged += (s, e) => nupBocRang.Enabled = chkBocRang.Checked;

            txtTenKH.Validating += txtTenKH_Validating;
            btnTinhTien.Click += btnTinhTien_Click;
            btnThoat.Click += (s, e) => Close();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled)) return;

            double thanhTien = 0;
            if (chkLayCaoRang.Checked) thanhTien += GIA_LAY_CAO;
            if (chkTayTrangRang.Checked) thanhTien += GIA_TAY_TRANG;
            if (chkHanRang.Checked) thanhTien += (int)nupHanRang.Value * GIA_HAN;
            if (chkBeRang.Checked) thanhTien += (int)nupBeRang.Value * GIA_BE;
            if (chkBocRang.Checked) thanhTien += (int)nupBocRang.Value * GIA_BOC;

            txtThanhTien.Text = thanhTien.ToString("#,0", viVN) + " đ";
        }

        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                e.Cancel = true;
                err.SetError(txtTenKH, "Tên khách hàng không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTenKH, null);
            }
        }
    }
}
