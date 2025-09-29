using System;
using System.Numerics; 
using System.Windows.Forms;

namespace ApDung1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radUSCLN.Checked = true; 
        }

        private long USCLN(long a, long b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            if (a == 0) return b;
            if (b == 0) return a;
            while (b != 0)
            {
                long r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private long BSCNN(long a, long b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            if (a == 0 || b == 0) return 0; 
            long g = USCLN(a, b);
            checked { return (a / g) * b; } 
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtA.Text.Trim(), out long a) ||
                !long.TryParse(txtB.Text.Trim(), out long b))
            {
                MessageBox.Show("Vui lòng nhập hai số nguyên hợp lệ!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (radUSCLN.Checked)
                    txtKetQua.Text = $"USCLN({a}, {b}) = {USCLN(a, b)}";
                else
                    txtKetQua.Text = $"BSCNN({a}, {b}) = {BSCNN(a, b)}";
            }
            catch (OverflowException)
            {
                MessageBox.Show("Kết quả quá lớn, xảy ra tràn số!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
