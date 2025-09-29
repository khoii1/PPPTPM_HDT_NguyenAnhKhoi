using System;
using System.Windows.Forms;

namespace Lab2_TH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm chuyển đổi số
        private double GetValue(TextBox txt)
        {
            double value = 0;
            if (!double.TryParse(txt.Text, out value))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }
            return value;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = GetValue(txtA);
            double b = GetValue(txtB);
            txtKetQua.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a = GetValue(txtA);
            double b = GetValue(txtB);
            txtKetQua.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a = GetValue(txtA);
            double b = GetValue(txtB);
            txtKetQua.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double a = GetValue(txtA);
            double b = GetValue(txtB);

            if (b == 0)
            {
                MessageBox.Show("Không thể chia cho 0!");
                return;
            }

            txtKetQua.Text = (a / b).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
