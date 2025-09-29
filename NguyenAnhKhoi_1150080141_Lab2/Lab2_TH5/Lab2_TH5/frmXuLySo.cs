using System;
using System.Windows.Forms;

namespace XuLyDaySoApp
{
    public partial class frmXuLySo : Form
    {
        public frmXuLySo()
        {
            InitializeComponent();

            Load += (s, e) => lsbDaySo.Items.Clear();

            // chỉ cho nhập số nguyên (hỗ trợ dấu - ở đầu & Backspace)
            txtInput.KeyPress += (s, e) =>
            {
                if (char.IsControl(e.KeyChar)) return;
                if (char.IsDigit(e.KeyChar)) return;
                if (e.KeyChar == '-' && txtInput.SelectionStart == 0 && !txtInput.Text.Contains("-")) return;
                e.Handled = true;
            };

            // Enter để thêm
            txtInput.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { btnInput.PerformClick(); e.SuppressKeyPress = true; } };

            btnInput.Click += btnInput_Click;
            btnTang2.Click += btnTang2_Click;
            btnChanDau.Click += btnChanDau_Click;
            btnLeCuoi.Click += btnLeCuoi_Click;
            btnXoaChon.Click += btnXoaChon_Click;
            btnXoaDau.Click += btnXoaDau_Click;
            btnXoaCuoi.Click += btnXoaCuoi_Click;
            btnXoaDaySo.Click += (s, e) => lsbDaySo.Items.Clear();
            btnClose.Click += (s, e) =>
            {
                var result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Hỏi thoát!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) Close();
            };
            AcceptButton = btnInput;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text.Trim(), out int val))
            {
                lsbDaySo.Items.Add(val);
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Không phải số nguyên! Hãy nhập lại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Clear(); txtInput.Focus();
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus(); return;
            }
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
                lsbDaySo.Items[i] = (int)lsbDaySo.Items[i] + 2;
        }

        private void btnChanDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0) { EmptyWarn(); return; }
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
                if ((int)lsbDaySo.Items[i] % 2 == 0) { lsbDaySo.SelectedIndex = i; break; }
        }

        private void btnLeCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0) { EmptyWarn(); return; }
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
                if ((int)lsbDaySo.Items[i] % 2 != 0) { lsbDaySo.SelectedIndex = i; break; }
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0) { EmptyWarn(); return; }
            if (lsbDaySo.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn số cần xóa!", "Thông báo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            while (lsbDaySo.SelectedIndex != -1)
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0) { EmptyWarn(); return; }
            lsbDaySo.Items.RemoveAt(0);
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0) { EmptyWarn(); return; }
            lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }

        private void EmptyWarn()
        {
            MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtInput.Focus();
        }
    }
}
