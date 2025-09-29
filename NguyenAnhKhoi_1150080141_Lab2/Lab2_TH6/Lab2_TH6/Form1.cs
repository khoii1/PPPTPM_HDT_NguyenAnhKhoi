using System;
using System.Linq;
using System.Windows.Forms;

namespace ChuyenListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lstMatHang.Items.AddRange(new object[]
            { "CPU", "MainBoard", "RAM", "Keyboard", "Mouse", "NIC", "FAN" });

            btnRight.Click += (s, e) => MoveSelected(lstMatHang, lstDaChon);
            btnAllRight.Click += (s, e) => MoveAll(lstMatHang, lstDaChon);
            btnLeft.Click += (s, e) => MoveSelected(lstDaChon, lstMatHang);
            btnAllLeft.Click += (s, e) => MoveAll(lstDaChon, lstMatHang);

            lstMatHang.DoubleClick += (s, e) => MoveSelected(lstMatHang, lstDaChon);
            lstDaChon.DoubleClick += (s, e) => MoveSelected(lstDaChon, lstMatHang);
        }

        private void MoveSelected(ListBox src, ListBox dst)
        {
            if (src.SelectedItems.Count == 0) return;

            var toMove = src.SelectedItems.Cast<object>().ToArray();
            dst.Items.AddRange(toMove);

            for (int i = src.SelectedIndices.Count - 1; i >= 0; i--)
                src.Items.RemoveAt(src.SelectedIndices[i]);
        }

        private void MoveAll(ListBox src, ListBox dst)
        {
            if (src.Items.Count == 0) return;
            dst.Items.AddRange(src.Items.Cast<object>().ToArray());
            src.Items.Clear();
        }
    }
}
