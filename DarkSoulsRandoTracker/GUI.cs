using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using System.Xml;

namespace DSItemTracker
{
    public partial class GUI : Form
    {
        public ItemLayout Layout;
        public DS1Hook Hook = new DS1Hook();
        public static int RefreshRate = 125;
        public System.Timers.Timer Timer = new System.Timers.Timer(RefreshRate);
        public Dictionary<int, KeyDisplay> Display = new Dictionary<int, KeyDisplay>();
        public Dictionary<int, string> KeyNames = new Dictionary<int, string>();
        public Dictionary<int, string> RingNames = new Dictionary<int, string>();

        public GUI()
        {
            InitializeComponent();
                
            if (File.Exists("Default.xml")) ReadLayoutFromXMLFile("Default.xml");

            Timer.AutoReset = true;
            Timer.Interval = RefreshRate;
            Timer.Elapsed += Refresh;
            Timer.Start();

            void Refresh(object sender, ElapsedEventArgs e)
            {
                Hook.Refresh();
                if (!Hook.Hooked)
                {
                    StatusLabel.Text = "Ready";
                    foreach (var v in Display.Values) v.SetFound(false);
                    return;
                }
                StatusLabel.Text = "Active - " + (Hook.Is64Bit ? "Dark Souls Remastered" : "Dark Souls");
                var items = Hook.GetInventoryItems().Where(i => i.Quantity > 0);
                var keys = items.Where(i => i.Category == 4 && KeyNames.Keys.Contains(i.ID));
                var rings = items.Where(i => i.Category == 2 && RingNames.Keys.Contains(i.ID));
                var itemIDs = keys.Concat(rings).Select(i => i.ID);
                foreach (int i in Display.Keys)
                {
                    if (!Display[i].Collected)
                        Display[i].SetFound(itemIDs.Contains(i));
                }
            }

            RingNames[138] = "Covenant of Artorias";
            RingNames[139] = "Orange Charred Ring";
            RingNames[149] = "Darkmoon Seance Ring";

            KeyNames[118] = "Purple Coward's Crystal";
            KeyNames[384] = "Peculiar Doll";
            KeyNames[2001] = "Basement Key";
            KeyNames[2002] = "Crest of Artorias";
            KeyNames[2003] = "Cage Key";
            KeyNames[2004] = "Archive Cell Key";
            KeyNames[2005] = "Archive Giant Door Key";
            KeyNames[2006] = "Archive Giant Cell Key";
            KeyNames[2007] = "Blighttown Key";
            KeyNames[2008] = "Key to New Londo Ruins";
            KeyNames[2009] = "Annex Key";
            KeyNames[2010] = "Dungeon Cell Key";
            KeyNames[2011] = "Big Pilgrim's Key";
            KeyNames[2012] = "Undead Asylum F2 East Key";
            KeyNames[2013] = "Key to the Seal";
            KeyNames[2014] = "Key to Depths";
            KeyNames[2016] = "Undead Asylum F2 West Key";
            KeyNames[2017] = "Mystery Key";
            KeyNames[2018] = "Sewer Chamber Key";
            KeyNames[2019] = "Watchtower Basement Key";
            KeyNames[2020] = "Archive Prison Extra Key";
            KeyNames[2021] = "Residence Key";
            KeyNames[2022] = "Crest Key";
            KeyNames[2500] = "Lord Soul (Nito)";
            KeyNames[2501] = "Lord Soul (Chaos)";
            KeyNames[2502] = "Lord Soul Shard (Kings)";
            KeyNames[2503] = "Lord Soul Shard (Seath)";
            KeyNames[2510] = "Lordvessel";
            KeyNames[2520] = "Broken Pendant";
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var config = new Configure();
            var k = KeyNames.Concat(RingNames).Cast<KeyValuePair<int, string>>().OrderBy(item => item.Value).ToList();
            if (Layout == null)
            {
                foreach (var x in k) config.UntrackedBox.Items.Add(x);
            } else
            {
                config.CompactBox.Checked = Layout.Compact;
                config.ColumnBtn.Checked = Layout.Columns;
                config.RowBtn.Checked = !Layout.Columns;

                config.BackgroundColor = Layout.BackColor;
                config.BackColorBtn.BackColor = Layout.BackColor;

                config.ForeColorFound = Layout.ForeColorFound;
                config.ForeColorFoundBtn.BackColor = Layout.ForeColorFound;

                config.ForeColorMissing = Layout.ForeColorMissing;
                config.ForeColorMissingBtn.BackColor = Layout.ForeColorMissing;

                foreach (var item in Layout.Untracked) config.UntrackedBox.Items.Add(item);
                for (int i = 0; i < Layout.Groups.Count; i++)
                {
                    var list = Layout.Groups[i].Select(kd => new KeyValuePair<int, string>(kd.ID, kd.Name)).ToList();
                    foreach (var kv in list) config.boxes[i + 1].Items.Add(kv);
                }
            }

            if (config.ShowDialog() == DialogResult.OK)
            {
                KeyGroupPanel.Controls.Clear();
                Layout = new ItemLayout(config, this);
            }
        }

        public void WriteLayoutToXML(bool def = false)
        {
            if (Layout == null) return;
            var doc = new XmlDocument();
            var oNode = doc.CreateElement("Options");
            oNode.SetAttribute("Columns", Layout.Columns.ToString());
            oNode.SetAttribute("Compact", Layout.Compact.ToString());
            oNode.SetAttribute("ForeColorFound", Layout.ForeColorFound.ToArgb().ToString());
            oNode.SetAttribute("ForeColorMissing", Layout.ForeColorMissing.ToArgb().ToString());
            oNode.SetAttribute("BackColor", Layout.BackColor.ToArgb().ToString());

            var groupsNode = doc.CreateElement("Groups");
            foreach (var group in Layout.Groups)
            {
                var groupNode = doc.CreateElement("Group");
                foreach (KeyDisplay kd in group)
                {
                    var node = doc.CreateElement("Item");
                    node.SetAttribute("ID", kd.ID + "");
                    node.SetAttribute("Name", kd.Name);
                    groupNode.AppendChild(node);
                }
                groupsNode.AppendChild(groupNode);
            }

            var untrackedNode = doc.CreateElement("Untracked");
            foreach (var kv in Layout.Untracked)
            {
                var node = doc.CreateElement("Item");
                node.SetAttribute("ID", kv.Key + "");
                node.SetAttribute("Name", kv.Value);
                untrackedNode.AppendChild(node);
            }

            XmlElement root = doc.CreateElement("ItemLayout");
            XmlElement rootNode = doc.CreateElement("Layout");
            root.AppendChild(rootNode);
            root.AppendChild(oNode);
            root.AppendChild(groupsNode);
            root.AppendChild(untrackedNode);
            doc.AppendChild(root);

            if (def)
            {
                doc.Save("Default.xml");
                return;
            }

            var sfd = new SaveFileDialog();
            sfd.Title = "Save XML File";
            sfd.InitialDirectory = Directory.GetCurrentDirectory();
            sfd.Filter = "XML Files|*.xml";
            sfd.DefaultExt = "xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (!sfd.FileName.ToLower().EndsWith(".xml")) sfd.FileName += ".xml";
                try { doc.Save(sfd.FileName);}
                catch (Exception ex) {MessageBox.Show(ex.ToString());}
            }
        }

        public class ItemLayout
        {
            private Configure cfg;
            public bool Compact = false;
            public List<List<KeyDisplay>> Groups = new List<List<KeyDisplay>>();
            public SortedList<int, string> Untracked = new SortedList<int, string>();
            public bool Columns = true;
            public Dictionary<int, KeyDisplay> Display;
            public Color ForeColorFound;
            public Color ForeColorMissing;
            public Color BackColor;

            public ItemLayout(Configure c, GUI g)
            {
                g.KeyGroupPanel.Controls.Clear();
                Display = g.Display;
                Display.Clear();
                cfg = c;
                Columns = c.ColumnBtn.Checked;
                Compact = c.CompactBox.Checked;
                Untracked = c.Untracked;
                if (Columns) g.KeyGroupPanel.FlowDirection = FlowDirection.LeftToRight;
                else g.KeyGroupPanel.FlowDirection = FlowDirection.TopDown;

                ForeColorFound = c.ForeColorFound;
                ForeColorMissing = c.ForeColorMissing;
                BackColor = c.BackgroundColor;

                g.KeyGroupPanel.BackColor = BackColor;

                List<KeyDisplay>[] lists = { cfg.GroupA, cfg.GroupB, cfg.GroupC, cfg.GroupD };
                foreach (var list in lists.Where(l => l != null))
                {
                    Groups.Add(list);
                    var p = PanelFromList(list);
                    p.AutoSize = true;
                    p.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    p.FlowDirection = Columns ? FlowDirection.TopDown : FlowDirection.LeftToRight;
                    g.KeyGroupPanel.Controls.Add(p);
                }
            }

            private FlowLayoutPanel PanelFromList(List<KeyDisplay> list)
            {
                var p = new FlowLayoutPanel();
                p.Margin = new Padding(0);
                p.Padding = new Padding(0);
                foreach (var c in list)
                {
                    Display[c.ID] = c;
                    if (Compact)
                    {
                        c.Margin = new Padding(0);
                        c.Padding = new Padding(0);
                        c.KeyName.Visible = false;
                        c.Height = 90;
                        c.Width = 80;
                        c.KeyPic.Height = 80;
                        c.KeyPic.Width = 80;
                    }
                    else
                    {
                        c.Margin = new Padding(0);
                        c.Padding = new Padding(0);
                        c.KeyName.Visible = true;
                        c.Height = 121;
                        c.Width = 90;
                        c.KeyPic.Width = 120;
                        c.KeyName.Width = 120;
                    }
                    p.Controls.Add(c);
                }
                return p;
            }
        }

        public void ReadLayoutFromXMLFile(string file)
        {
            var config = new Configure();
            var doc = new XmlDocument();
            try
            {
                void NodeToBox(XmlNode groupNode, ListBox box, bool sorted = false)
                {
                    var items = groupNode.ChildNodes;
                    var list = new List<KeyValuePair<int, string>>();
                    foreach (XmlNode node in items)
                    {
                        int ID = int.Parse(node.Attributes["ID"].Value);
                        string Name = node.Attributes["Name"].Value;
                        list.Add(new KeyValuePair<int, string>(ID, Name));
                    }
                    if (sorted) list = list.Cast<KeyValuePair<int, string>>().OrderBy(item => item.Value).ToList();
                    foreach (var item in list) box.Items.Add(item);
                }

                doc.LoadXml(File.ReadAllText(file));
                var groups = doc.GetElementsByTagName("Group");
                for (int i = 0; i < groups.Count; i++) NodeToBox(groups[i], config.boxes[i + 1]);
                NodeToBox(doc.GetElementsByTagName("Untracked")[0], config.UntrackedBox, true);

                var options = doc.GetElementsByTagName("Options")[0];
                bool columns = bool.Parse(options.Attributes["Columns"].Value);
                config.ColumnBtn.Checked = columns;
                config.RowBtn.Checked = !columns;

                config.CompactBox.Checked = bool.Parse(options.Attributes["Compact"].Value);
                config.BackgroundColor = Color.FromArgb(int.Parse(options.Attributes["BackColor"].Value));
                config.ForeColorFound = Color.FromArgb(int.Parse(options.Attributes["ForeColorFound"].Value));
                config.ForeColorMissing = Color.FromArgb(int.Parse(options.Attributes["ForeColorMissing"].Value));

                config.OutputData();
                config.SortUntracked();
                Layout = new ItemLayout(config, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ReadLayoutFromXML()
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Select XML File";
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            ofd.DefaultExt = "xml";
            ofd.Filter = "XML Files|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ReadLayoutFromXMLFile(ofd.FileName);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteLayoutToXML();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadLayoutFromXML();
        }

        private void restartTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var items = Hook.GetInventoryItems().Where(i => i.Quantity > 0);
            var keys = items.Where(i => i.Category == 4 && KeyNames.Keys.Contains(i.ID));
            var rings = items.Where(i => i.Category == 2 && RingNames.Keys.Contains(i.ID));
            var itemIDs = keys.Concat(rings).Select(i => i.ID);
            foreach (int i in Display.Keys) Display[i].SetFound(false);
        }

        private void setWindowSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WindowSize(this).ShowDialog();
        }

        private void saveAsDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                WriteLayoutToXML(true);
                MessageBox.Show("Default layout saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
