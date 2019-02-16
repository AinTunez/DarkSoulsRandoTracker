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
        public List<KeyValuePair<int, string>> Untracked = new List<KeyValuePair<int, string>>();
        public List<KeyDisplay> GroupA;
        public List<KeyDisplay> GroupB;
        public List<KeyDisplay> GroupC;
        public List<KeyDisplay> GroupD;
        public ListBox[] boxes;


        public Configure()
        {
            InitializeComponent();
            AcceptButton = OkBtn;
            boxes = new ListBox[] { UntrackedBox, GroupA_Box, GroupB_Box, GroupC_Box, GroupD_Box };
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
                Untracked.Add((KeyValuePair<int, string>)item);
        }
        private static List<KeyDisplay> ListFromBox(ListBox box)
        {
            if (box.Items.Count == 0) return null;
            List<KeyDisplay> list = new List<KeyDisplay>();
            foreach (var item in box.Items)
            {
                var kv = (KeyValuePair<int, string>)item;
                var kd = new KeyDisplay(kv.Value, kv.Key, Image.FromFile("images/" + kv.Key + ".png"));
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

        private void MoveItemsHere(object sender, EventArgs e)
        {

            ListBox tgt;
            var btn = sender as Button;
            if (btn == MoveABtn) tgt = GroupA_Box;
            else if (btn == MoveBBtn) tgt = GroupB_Box;
            else if (btn == MoveCBtn) tgt = GroupC_Box;
            else if (btn == MoveDBtn) tgt = GroupD_Box;
            else tgt = UntrackedBox;
            foreach (var src in boxes)
            {
                if (src == tgt) continue;
                if (src.SelectedItems.Count > 0)
                {
                    var list = new List<object>();
                    foreach (var i in src.SelectedItems) list.Add(i);
                    foreach (var i in list)
                    {
                        tgt.Items.Add(i);
                        src.Items.Remove(i);
                    }
                    break;
                }
            }
        }
    }
}
