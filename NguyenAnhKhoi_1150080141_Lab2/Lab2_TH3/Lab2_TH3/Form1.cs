using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SecurityPanel
{
    public partial class Form1 : Form
    {
        // Map password -> group
        private readonly Dictionary<string, string> _passToGroup =
            new Dictionary<string, string>
            {
                ["1496"] = "Phát triển công nghệ",
                ["2673"] = "Phát triển công nghệ",
                ["7462"] = "Nghiên cứu viên",
                ["8884"] = "Thiết kế mô hình",
                ["3842"] = "Thiết kế mô hình",
                ["3383"] = "Thiết kế mô hình"
            };

        public Form1()
        {
            InitializeComponent();
            txtPassword.MaxLength = 4;
            txtPassword.PasswordChar = '●';
            // gán cùng 1 handler cho tất cả nút số
            foreach (var btn in new[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 })
                btn.Click += Digit_Click;

            btnClear.Click += (s, e) => txtPassword.Clear();
            btnRing.Click += (s, e) => { SystemSounds.Beep.Play(); Log("Không có", "Chuông"); };
            btnEnter.Click += BtnEnter_Click;

            // chuẩn bị DataGridView
            dgvLog.AutoGenerateColumns = false;
            dgvLog.Columns.Clear();
            dgvLog.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày giờ", DataPropertyName = "Time", Width = 170 });
            dgvLog.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nhóm", DataPropertyName = "Group", Width = 240 });
            dgvLog.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Kết quả", DataPropertyName = "Result", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            dgvLog.DataSource = _items;
        }

        private class LogItem { public string Time { get; set; } public string Group { get; set; } public string Result { get; set; } }
        private readonly BindingSource _items = new BindingSource();

        private void Digit_Click(object sender, EventArgs e)
        {
            if (txtPassword.TextLength >= txtPassword.MaxLength) return;
            var btn = (Button)sender;
            txtPassword.Text += btn.Tag?.ToString() ?? btn.Text;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            var pwd = txtPassword.Text.Trim();
            if (pwd.Length == 0) return;

            if (_passToGroup.TryGetValue(pwd, out var group))
            {
                Log(group, "Chấp nhận!");
            }
            else
            {
                Log("Không có", "Từ chối!");
            }
            txtPassword.Clear();
        }

        private void Log(string group, string result)
        {
            _items.Add(new LogItem
            {
                Time = DateTime.Now.ToString("g"),
                Group = group,
                Result = result
            });
            dgvLog.FirstDisplayedScrollingRowIndex = dgvLog.RowCount - 1;
        }
    }
}
