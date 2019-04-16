using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSItemTracker
{
    public partial class Configure : Form
    {
        public Color ForeColorFound = Color.White;
        public Color ForeColorMissing = Color.DarkRed;
        public Color BackgroundColor = Color.Black;
        public SortedList<int, string> Untracked = new SortedList<int, string>();
        public List<KeyDisplay> GroupA;
        public List<KeyDisplay> GroupB;
        public List<KeyDisplay> GroupC;
        public List<KeyDisplay> GroupD;
        public ListBox[] boxes;
        public ListBox focusedBox;


        public Configure()
        {
            InitializeComponent();
            AcceptButton = OkBtn;
            CancelButton = CancelBtn;
            boxes = new ListBox[] { UntrackedBox, GroupA_Box, GroupB_Box, GroupC_Box, GroupD_Box };
            ForeColorFoundBtn.BackColor = ForeColorFound;
            ForeColorMissingBtn.BackColor = ForeColorMissing;
            BackColorBtn.BackColor = BackgroundColor;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            OutputData();
            Close();
        }

        public void OutputData()
        {
            GroupA = ListFromBox(GroupA_Box);
            GroupB = ListFromBox(GroupB_Box);
            GroupC = ListFromBox(GroupC_Box);
            GroupD = ListFromBox(GroupD_Box);
            foreach (var item in UntrackedBox.Items)
            {
                var kv = (KeyValuePair<int, string>)item;
                Untracked[kv.Key] = kv.Value;
            }
        }

        private  List<KeyDisplay> ListFromBox(ListBox box)
        {
            if (box.Items.Count == 0) return null;
            List<KeyDisplay> list = new List<KeyDisplay>();
            foreach (var item in box.Items)
            {
                var kv = (KeyValuePair<int, string>)item;
                var kd = new KeyDisplay(kv.Value, kv.Key, Image.FromFile("images/" + kv.Key + ".png"), ForeColorFound, ForeColorMissing);
                list.Add(kd);
            }
            return list;
        }

        private void Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = sender as ListBox;
            if (box.SelectedItems.Count == 0) return;
            foreach (var b in boxes)
            {
                if (box != b) b.ClearSelected();
            }
        }

        public void SortUntracked()
        {
            var list = UntrackedBox.Items.Cast<KeyValuePair<int,string>>().OrderBy(item => item.Value).ToList();
            UntrackedBox.Items.Clear();
            foreach (var item in list) UntrackedBox.Items.Add(item);
        }

        private void ChooseColor(Color color)
        {
            var dialog = new ColorDialog();
            dialog.AllowFullOpen = false;
            dialog.AnyColor = true;
            if (color != null) dialog.Color = color;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }
        }
        
        private void moveItemsUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var box in boxes)
            {
                if (box != UntrackedBox && box.SelectedItems.Count > 0 && box.SelectedIndices[0] > 0)
                {
                    var list = box.SelectedIndices.Cast<int>().OrderBy(i => i).ToList();
                    foreach (int index in list)
                    {
                        var item = box.Items[index];
                        box.Items.RemoveAt(index);
                        box.Items.Insert(index - 1, item);
                        box.SetSelected(index - 1, true);
                    }
                    break;
                }
            }
        }

        private void moveItemsDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var box in boxes)
            {
                var idcs = box.SelectedIndices;
                if (box != UntrackedBox && box.SelectedItems.Count > 0 && idcs[idcs.Count - 1] != box.Items.Count - 1)
                {
                    var list = box.SelectedIndices.Cast<int>().OrderBy(i => i).ToList();
                    list.Reverse();
                    foreach (int index in list)
                    {
                        var item = box.Items[index];
                        box.Items.RemoveAt(index);
                        box.Items.Insert(index + 1, item);
                        box.SetSelected(index + 1, true);
                    }
                    break;
                }
            }
        }

        private bool MoveItems(ListBox src, ListBox tgt)
        {
            var idcs = src.SelectedIndices.Cast<int>().ToList();
            if (idcs.Count == 0) return false;

            idcs.Reverse();
            var items = new List<object>();
            foreach (var index in idcs)
            {
                var item = src.Items[index];
                items.Add(item);
                src.Items.Remove(item);
            }
            items.Reverse();
            foreach (var item in items)
            {
                tgt.Items.Add(item);
                int s = tgt.Items.IndexOf(item);
                if (tgt != UntrackedBox) tgt.SetSelected(s, true);
            }
            if (tgt == UntrackedBox)
            {
                SortUntracked();
                foreach (var item in items)
                {
                    int s = tgt.Items.IndexOf(item);
                    tgt.SetSelected(s, true);
                }
            }
            tgt.Focus();
            tgt.BackColor = SystemColors.Window;
            src.BackColor = SystemColors.ScrollBar;
            return true;
        }

        private void moveItemsLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                var src = boxes[i];
                var tgt = boxes[i - 1];
                if (MoveItems(src, tgt)) break;
            }
        }

        private void moveItemsRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                var src = boxes[i];
                var tgt = boxes[i + 1];
                if (MoveItems(src, tgt)) break;
            }
        }

        private void Configure_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                if (e.KeyCode == Keys.Left)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        if (boxes[i].Focused || boxes[i].ContainsFocus)
                        {
                            var tgt = boxes[i - 1];
                            tgt.Focus();
                            if (tgt.Items.Count > 0) tgt.SetSelected(0, true);
                            tgt.BackColor = SystemColors.Window;
                            boxes[i].BackColor = SystemColors.ScrollBar;
                            break;

                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                } else if (e.KeyCode == Keys.Right)
                {

                    for (int i = 0; i < 4; i++)
                    {
                        if (boxes[i].Focused || boxes[i].ContainsFocus)
                        {
                            var tgt = boxes[i + 1];
                            tgt.Focus();
                            if (tgt.Items.Count > 0) tgt.SetSelected(0, true);
                            tgt.BackColor = SystemColors.Window;
                            boxes[i].BackColor = SystemColors.ScrollBar;
                            break;

                        }
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void Configure_Load(object sender, EventArgs e)
        {
            if (UntrackedBox.Items.Count > 0) UntrackedBox.SetSelected(0, true);
        }

        private void ForeColorFoundBtn_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ForeColorFound = dialog.Color;
                ForeColorFoundBtn.BackColor = dialog.Color;

            }
        }

        private void ForeColorMissingBtn_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.Color = ForeColorFound;
            dialog.AllowFullOpen = false;
            dialog.AnyColor = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ForeColorMissing = dialog.Color;
                ForeColorMissingBtn.BackColor = dialog.Color;
            }
        }

        private void BackColorBtn_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.Color = BackgroundColor;
            dialog.AllowFullOpen = false;
            dialog.AnyColor = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BackgroundColor = dialog.Color;
                BackColorBtn.BackColor = dialog.Color;

            }
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
