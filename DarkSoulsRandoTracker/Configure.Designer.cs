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
            this.MoveABtn = new System.Windows.Forms.Button();
            this.MoveBBtn = new System.Windows.Forms.Button();
            this.MoveCBtn = new System.Windows.Forms.Button();
            this.MoveDBtn = new System.Windows.Forms.Button();
            this.MoveUBtn = new System.Windows.Forms.Button();
            this.CompactBox = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UntrackedBox);
            this.groupBox2.Location = new System.Drawing.Point(223, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(176, 373);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Untracked";
            // 
            // UntrackedBox
            // 
            this.UntrackedBox.DisplayMember = "Value";
            this.UntrackedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UntrackedBox.FormattingEnabled = true;
            this.UntrackedBox.ItemHeight = 16;
            this.UntrackedBox.Location = new System.Drawing.Point(10, 25);
            this.UntrackedBox.Name = "UntrackedBox";
            this.UntrackedBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.UntrackedBox.Size = new System.Drawing.Size(156, 338);
            this.UntrackedBox.TabIndex = 6;
            this.UntrackedBox.ValueMember = "Key";
            this.UntrackedBox.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GroupA_Box);
            this.groupBox1.Location = new System.Drawing.Point(405, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(176, 373);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group A";
            // 
            // GroupA_Box
            // 
            this.GroupA_Box.DisplayMember = "Value";
            this.GroupA_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupA_Box.FormattingEnabled = true;
            this.GroupA_Box.ItemHeight = 16;
            this.GroupA_Box.Location = new System.Drawing.Point(10, 25);
            this.GroupA_Box.Name = "GroupA_Box";
            this.GroupA_Box.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.GroupA_Box.Size = new System.Drawing.Size(156, 338);
            this.GroupA_Box.TabIndex = 6;
            this.GroupA_Box.ValueMember = "Key";
            this.GroupA_Box.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GroupB_Box);
            this.groupBox3.Location = new System.Drawing.Point(587, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(176, 373);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Group B";
            // 
            // GroupB_Box
            // 
            this.GroupB_Box.DisplayMember = "Value";
            this.GroupB_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupB_Box.FormattingEnabled = true;
            this.GroupB_Box.ItemHeight = 16;
            this.GroupB_Box.Location = new System.Drawing.Point(10, 25);
            this.GroupB_Box.Name = "GroupB_Box";
            this.GroupB_Box.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.GroupB_Box.Size = new System.Drawing.Size(156, 338);
            this.GroupB_Box.TabIndex = 6;
            this.GroupB_Box.ValueMember = "Key";
            this.GroupB_Box.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GroupC_Box);
            this.groupBox4.Location = new System.Drawing.Point(769, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(176, 373);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Group C";
            // 
            // GroupC_Box
            // 
            this.GroupC_Box.DisplayMember = "Value";
            this.GroupC_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupC_Box.FormattingEnabled = true;
            this.GroupC_Box.ItemHeight = 16;
            this.GroupC_Box.Location = new System.Drawing.Point(10, 25);
            this.GroupC_Box.Name = "GroupC_Box";
            this.GroupC_Box.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.GroupC_Box.Size = new System.Drawing.Size(156, 338);
            this.GroupC_Box.TabIndex = 6;
            this.GroupC_Box.ValueMember = "Key";
            this.GroupC_Box.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.GroupD_Box);
            this.groupBox5.Location = new System.Drawing.Point(951, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox5.Size = new System.Drawing.Size(176, 373);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Group D";
            // 
            // GroupD_Box
            // 
            this.GroupD_Box.DisplayMember = "Value";
            this.GroupD_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupD_Box.FormattingEnabled = true;
            this.GroupD_Box.ItemHeight = 16;
            this.GroupD_Box.Location = new System.Drawing.Point(10, 25);
            this.GroupD_Box.Name = "GroupD_Box";
            this.GroupD_Box.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.GroupD_Box.Size = new System.Drawing.Size(156, 338);
            this.GroupD_Box.TabIndex = 6;
            this.GroupD_Box.ValueMember = "Key";
            this.GroupD_Box.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(12, 168);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(196, 45);
            this.OkBtn.TabIndex = 15;
            this.OkBtn.Tag = "";
            this.OkBtn.Text = "Save Layout";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RowBtn);
            this.groupBox6.Controls.Add(this.ColumnBtn);
            this.groupBox6.Location = new System.Drawing.Point(12, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(196, 59);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Display Type";
            // 
            // RowBtn
            // 
            this.RowBtn.AutoSize = true;
            this.RowBtn.Location = new System.Drawing.Point(118, 21);
            this.RowBtn.Name = "RowBtn";
            this.RowBtn.Size = new System.Drawing.Size(63, 21);
            this.RowBtn.TabIndex = 1;
            this.RowBtn.Text = "Rows";
            this.RowBtn.UseVisualStyleBackColor = true;
            // 
            // ColumnBtn
            // 
            this.ColumnBtn.AutoSize = true;
            this.ColumnBtn.Checked = true;
            this.ColumnBtn.Location = new System.Drawing.Point(29, 21);
            this.ColumnBtn.Name = "ColumnBtn";
            this.ColumnBtn.Size = new System.Drawing.Size(83, 21);
            this.ColumnBtn.TabIndex = 0;
            this.ColumnBtn.TabStop = true;
            this.ColumnBtn.Text = "Columns";
            this.ColumnBtn.UseVisualStyleBackColor = true;
            // 
            // MoveABtn
            // 
            this.MoveABtn.Location = new System.Drawing.Point(443, 401);
            this.MoveABtn.Name = "MoveABtn";
            this.MoveABtn.Size = new System.Drawing.Size(101, 45);
            this.MoveABtn.TabIndex = 17;
            this.MoveABtn.Tag = "";
            this.MoveABtn.Text = "Move Here";
            this.MoveABtn.UseVisualStyleBackColor = true;
            this.MoveABtn.Click += new System.EventHandler(this.MoveItemsHere);
            // 
            // MoveBBtn
            // 
            this.MoveBBtn.Location = new System.Drawing.Point(625, 401);
            this.MoveBBtn.Name = "MoveBBtn";
            this.MoveBBtn.Size = new System.Drawing.Size(101, 45);
            this.MoveBBtn.TabIndex = 18;
            this.MoveBBtn.Tag = "";
            this.MoveBBtn.Text = "Move Here";
            this.MoveBBtn.UseVisualStyleBackColor = true;
            this.MoveBBtn.Click += new System.EventHandler(this.MoveItemsHere);
            // 
            // MoveCBtn
            // 
            this.MoveCBtn.Location = new System.Drawing.Point(807, 401);
            this.MoveCBtn.Name = "MoveCBtn";
            this.MoveCBtn.Size = new System.Drawing.Size(101, 45);
            this.MoveCBtn.TabIndex = 19;
            this.MoveCBtn.Tag = "";
            this.MoveCBtn.Text = "Move Here";
            this.MoveCBtn.UseVisualStyleBackColor = true;
            this.MoveCBtn.Click += new System.EventHandler(this.MoveItemsHere);
            // 
            // MoveDBtn
            // 
            this.MoveDBtn.Location = new System.Drawing.Point(989, 401);
            this.MoveDBtn.Name = "MoveDBtn";
            this.MoveDBtn.Size = new System.Drawing.Size(101, 45);
            this.MoveDBtn.TabIndex = 20;
            this.MoveDBtn.Tag = "";
            this.MoveDBtn.Text = "Move Here";
            this.MoveDBtn.UseVisualStyleBackColor = true;
            this.MoveDBtn.Click += new System.EventHandler(this.MoveItemsHere);
            // 
            // MoveUBtn
            // 
            this.MoveUBtn.Location = new System.Drawing.Point(261, 401);
            this.MoveUBtn.Name = "MoveUBtn";
            this.MoveUBtn.Size = new System.Drawing.Size(101, 45);
            this.MoveUBtn.TabIndex = 21;
            this.MoveUBtn.Tag = "";
            this.MoveUBtn.Text = "Move Here";
            this.MoveUBtn.UseVisualStyleBackColor = true;
            this.MoveUBtn.Click += new System.EventHandler(this.MoveItemsHere);
            // 
            // CompactBox
            // 
            this.CompactBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CompactBox.Location = new System.Drawing.Point(22, 87);
            this.CompactBox.Name = "CompactBox";
            this.CompactBox.Size = new System.Drawing.Size(176, 24);
            this.CompactBox.TabIndex = 22;
            this.CompactBox.Text = "Enable Compact Mode";
            this.CompactBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CompactBox.UseVisualStyleBackColor = true;
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1149, 465);
            this.Controls.Add(this.CompactBox);
            this.Controls.Add(this.MoveUBtn);
            this.Controls.Add(this.MoveDBtn);
            this.Controls.Add(this.MoveCBtn);
            this.Controls.Add(this.MoveBBtn);
            this.Controls.Add(this.MoveABtn);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(1167, 512);
            this.MinimumSize = new System.Drawing.Size(1167, 512);
            this.Name = "Configure";
            this.Text = "Configure";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button MoveABtn;
        private System.Windows.Forms.Button MoveBBtn;
        private System.Windows.Forms.Button MoveCBtn;
        private System.Windows.Forms.Button MoveDBtn;
        private System.Windows.Forms.Button MoveUBtn;
        public System.Windows.Forms.CheckBox CompactBox;
    }
}