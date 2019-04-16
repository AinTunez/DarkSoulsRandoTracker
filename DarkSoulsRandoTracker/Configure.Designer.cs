namespace DSItemTracker
{
    partial class Configure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UntrackedBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupA_Box = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupB_Box = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GroupC_Box = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.GroupD_Box = new System.Windows.Forms.ListBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RowBtn = new System.Windows.Forms.RadioButton();
            this.ColumnBtn = new System.Windows.Forms.RadioButton();
            this.CompactBox = new System.Windows.Forms.CheckBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackColorBtn = new System.Windows.Forms.Button();
            this.ForeColorMissingBtn = new System.Windows.Forms.Button();
            this.ForeColorFoundBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemsUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemsDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemsLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemsRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveCursorLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveCursorRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UntrackedBox);
            this.groupBox2.Location = new System.Drawing.Point(167, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox2.Size = new System.Drawing.Size(166, 303);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Untracked";
            // 
            // UntrackedBox
            // 
            this.UntrackedBox.BackColor = System.Drawing.SystemColors.Window;
            this.UntrackedBox.DisplayMember = "Value";
            this.UntrackedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UntrackedBox.FormattingEnabled = true;
            this.UntrackedBox.Location = new System.Drawing.Point(8, 21);
            this.UntrackedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UntrackedBox.Name = "UntrackedBox";
            this.UntrackedBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.UntrackedBox.Size = new System.Drawing.Size(150, 274);
            this.UntrackedBox.Sorted = true;
            this.UntrackedBox.TabIndex = 6;
            this.UntrackedBox.ValueMember = "Key";
            this.UntrackedBox.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            this.UntrackedBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Configure_KeyDown);
            this.UntrackedBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GroupA_Box);
            this.groupBox1.Location = new System.Drawing.Point(334, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox1.Size = new System.Drawing.Size(166, 303);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group A";
            // 
            // GroupA_Box
            // 
            this.GroupA_Box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GroupA_Box.DisplayMember = "Value";
            this.GroupA_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupA_Box.FormattingEnabled = true;
            this.GroupA_Box.Location = new System.Drawing.Point(8, 21);
            this.GroupA_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupA_Box.Name = "GroupA_Box";
            this.GroupA_Box.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.GroupA_Box.Size = new System.Drawing.Size(150, 274);
            this.GroupA_Box.TabIndex = 6;
            this.GroupA_Box.ValueMember = "Key";
            this.GroupA_Box.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            this.GroupA_Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Configure_KeyDown);
            this.GroupA_Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GroupB_Box);
            this.groupBox3.Location = new System.Drawing.Point(500, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox3.Size = new System.Drawing.Size(166, 303);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Group B";
            // 
            // GroupB_Box
            // 
            this.GroupB_Box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GroupB_Box.DisplayMember = "Value";
            this.GroupB_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupB_Box.FormattingEnabled = true;
            this.GroupB_Box.Location = new System.Drawing.Point(8, 21);
            this.GroupB_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupB_Box.Name = "GroupB_Box";
            this.GroupB_Box.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.GroupB_Box.Size = new System.Drawing.Size(150, 274);
            this.GroupB_Box.TabIndex = 6;
            this.GroupB_Box.ValueMember = "Key";
            this.GroupB_Box.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            this.GroupB_Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Configure_KeyDown);
            this.GroupB_Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GroupC_Box);
            this.groupBox4.Location = new System.Drawing.Point(667, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox4.Size = new System.Drawing.Size(166, 303);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Group C";
            // 
            // GroupC_Box
            // 
            this.GroupC_Box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GroupC_Box.DisplayMember = "Value";
            this.GroupC_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupC_Box.FormattingEnabled = true;
            this.GroupC_Box.Location = new System.Drawing.Point(8, 21);
            this.GroupC_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupC_Box.Name = "GroupC_Box";
            this.GroupC_Box.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.GroupC_Box.Size = new System.Drawing.Size(150, 274);
            this.GroupC_Box.TabIndex = 6;
            this.GroupC_Box.ValueMember = "Key";
            this.GroupC_Box.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            this.GroupC_Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Configure_KeyDown);
            this.GroupC_Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDown);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.GroupD_Box);
            this.groupBox5.Location = new System.Drawing.Point(833, 18);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox5.Size = new System.Drawing.Size(166, 303);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Group D";
            // 
            // GroupD_Box
            // 
            this.GroupD_Box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GroupD_Box.DisplayMember = "Value";
            this.GroupD_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupD_Box.FormattingEnabled = true;
            this.GroupD_Box.Location = new System.Drawing.Point(8, 21);
            this.GroupD_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupD_Box.Name = "GroupD_Box";
            this.GroupD_Box.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.GroupD_Box.Size = new System.Drawing.Size(150, 274);
            this.GroupD_Box.TabIndex = 6;
            this.GroupD_Box.ValueMember = "Key";
            this.GroupD_Box.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            this.GroupD_Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Configure_KeyDown);
            this.GroupD_Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDown);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(31, 283);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(50, 38);
            this.OkBtn.TabIndex = 15;
            this.OkBtn.TabStop = false;
            this.OkBtn.Tag = "";
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RowBtn);
            this.groupBox6.Controls.Add(this.ColumnBtn);
            this.groupBox6.Location = new System.Drawing.Point(9, 18);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(147, 48);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Display Type";
            // 
            // RowBtn
            // 
            this.RowBtn.AutoSize = true;
            this.RowBtn.Location = new System.Drawing.Point(88, 17);
            this.RowBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RowBtn.Name = "RowBtn";
            this.RowBtn.Size = new System.Drawing.Size(52, 17);
            this.RowBtn.TabIndex = 1;
            this.RowBtn.Text = "Rows";
            this.RowBtn.UseVisualStyleBackColor = true;
            // 
            // ColumnBtn
            // 
            this.ColumnBtn.AutoSize = true;
            this.ColumnBtn.Checked = true;
            this.ColumnBtn.Location = new System.Drawing.Point(22, 17);
            this.ColumnBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ColumnBtn.Name = "ColumnBtn";
            this.ColumnBtn.Size = new System.Drawing.Size(65, 17);
            this.ColumnBtn.TabIndex = 0;
            this.ColumnBtn.TabStop = true;
            this.ColumnBtn.Text = "Columns";
            this.ColumnBtn.UseVisualStyleBackColor = true;
            // 
            // CompactBox
            // 
            this.CompactBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CompactBox.Checked = true;
            this.CompactBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CompactBox.Location = new System.Drawing.Point(16, 71);
            this.CompactBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CompactBox.Name = "CompactBox";
            this.CompactBox.Size = new System.Drawing.Size(132, 20);
            this.CompactBox.TabIndex = 22;
            this.CompactBox.Text = "Enable Compact Mode";
            this.CompactBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CompactBox.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(85, 283);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(50, 38);
            this.CancelBtn.TabIndex = 23;
            this.CancelBtn.TabStop = false;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSize = true;
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.BackColorBtn);
            this.groupBox7.Controls.Add(this.ForeColorMissingBtn);
            this.groupBox7.Controls.Add(this.ForeColorFoundBtn);
            this.groupBox7.Location = new System.Drawing.Point(9, 96);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(147, 132);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Display Colors";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Background";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Text (Item Missing)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text (Item Found)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BackColorBtn
            // 
            this.BackColorBtn.Location = new System.Drawing.Point(114, 86);
            this.BackColorBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackColorBtn.Name = "BackColorBtn";
            this.BackColorBtn.Size = new System.Drawing.Size(26, 29);
            this.BackColorBtn.TabIndex = 5;
            this.BackColorBtn.UseVisualStyleBackColor = true;
            this.BackColorBtn.Click += new System.EventHandler(this.BackColorBtn_Click);
            // 
            // ForeColorMissingBtn
            // 
            this.ForeColorMissingBtn.Location = new System.Drawing.Point(114, 52);
            this.ForeColorMissingBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ForeColorMissingBtn.Name = "ForeColorMissingBtn";
            this.ForeColorMissingBtn.Size = new System.Drawing.Size(26, 29);
            this.ForeColorMissingBtn.TabIndex = 4;
            this.ForeColorMissingBtn.UseVisualStyleBackColor = true;
            this.ForeColorMissingBtn.Click += new System.EventHandler(this.ForeColorMissingBtn_Click);
            // 
            // ForeColorFoundBtn
            // 
            this.ForeColorFoundBtn.Location = new System.Drawing.Point(114, 18);
            this.ForeColorFoundBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ForeColorFoundBtn.Name = "ForeColorFoundBtn";
            this.ForeColorFoundBtn.Size = new System.Drawing.Size(26, 29);
            this.ForeColorFoundBtn.TabIndex = 3;
            this.ForeColorFoundBtn.UseVisualStyleBackColor = true;
            this.ForeColorFoundBtn.Click += new System.EventHandler(this.ForeColorFoundBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(9, 233);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(154, 45);
            this.textBox1.TabIndex = 25;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Use the arrow keys to navigate the boxes. Hold CTRL to rearrange items.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(862, 23);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // shortcutsToolStripMenuItem
            // 
            this.shortcutsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveItemsUpToolStripMenuItem,
            this.moveItemsDownToolStripMenuItem,
            this.moveItemsLeftToolStripMenuItem,
            this.moveItemsRightToolStripMenuItem,
            this.moveCursorLeftToolStripMenuItem,
            this.moveCursorRightToolStripMenuItem});
            this.shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
            this.shortcutsToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.shortcutsToolStripMenuItem.Text = "Shortcuts";
            // 
            // moveItemsUpToolStripMenuItem
            // 
            this.moveItemsUpToolStripMenuItem.Name = "moveItemsUpToolStripMenuItem";
            this.moveItemsUpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.moveItemsUpToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.moveItemsUpToolStripMenuItem.Text = "Move Items Up";
            this.moveItemsUpToolStripMenuItem.Click += new System.EventHandler(this.moveItemsUpToolStripMenuItem_Click);
            // 
            // moveItemsDownToolStripMenuItem
            // 
            this.moveItemsDownToolStripMenuItem.Name = "moveItemsDownToolStripMenuItem";
            this.moveItemsDownToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.moveItemsDownToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.moveItemsDownToolStripMenuItem.Text = "Move Items Down";
            this.moveItemsDownToolStripMenuItem.Click += new System.EventHandler(this.moveItemsDownToolStripMenuItem_Click);
            // 
            // moveItemsLeftToolStripMenuItem
            // 
            this.moveItemsLeftToolStripMenuItem.Name = "moveItemsLeftToolStripMenuItem";
            this.moveItemsLeftToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.moveItemsLeftToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.moveItemsLeftToolStripMenuItem.Text = "Move Items Left";
            this.moveItemsLeftToolStripMenuItem.Click += new System.EventHandler(this.moveItemsLeftToolStripMenuItem_Click);
            // 
            // moveItemsRightToolStripMenuItem
            // 
            this.moveItemsRightToolStripMenuItem.Name = "moveItemsRightToolStripMenuItem";
            this.moveItemsRightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.moveItemsRightToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.moveItemsRightToolStripMenuItem.Text = "Move Items Right";
            this.moveItemsRightToolStripMenuItem.Click += new System.EventHandler(this.moveItemsRightToolStripMenuItem_Click);
            // 
            // moveCursorLeftToolStripMenuItem
            // 
            this.moveCursorLeftToolStripMenuItem.Name = "moveCursorLeftToolStripMenuItem";
            this.moveCursorLeftToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.moveCursorLeftToolStripMenuItem.Text = "Move Cursor Left";
            // 
            // moveCursorRightToolStripMenuItem
            // 
            this.moveCursorRightToolStripMenuItem.Name = "moveCursorRightToolStripMenuItem";
            this.moveCursorRightToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.moveCursorRightToolStripMenuItem.Text = "Move Cursor Right";
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1010, 339);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CompactBox);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1026, 378);
            this.MinimumSize = new System.Drawing.Size(1026, 378);
            this.Name = "Configure";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Configure Layout";
            this.Load += new System.EventHandler(this.Configure_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Configure_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.ListBox UntrackedBox;
        public System.Windows.Forms.ListBox GroupA_Box;
        public System.Windows.Forms.ListBox GroupB_Box;
        public System.Windows.Forms.ListBox GroupC_Box;
        public System.Windows.Forms.ListBox GroupD_Box;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.RadioButton RowBtn;
        public System.Windows.Forms.RadioButton ColumnBtn;
        public System.Windows.Forms.CheckBox CompactBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortcutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveItemsUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveItemsDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveItemsLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveItemsRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveCursorLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveCursorRightToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BackColorBtn;
        public System.Windows.Forms.Button ForeColorMissingBtn;
        public System.Windows.Forms.Button ForeColorFoundBtn;
    }
}