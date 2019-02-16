namespace DSItemTracker
{
    partial class KeyDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KeyPic = new System.Windows.Forms.PictureBox();
            this.KeyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPic)).BeginInit();
            this.SuspendLayout();
            // 
            // KeyPic
            // 
            this.KeyPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyPic.Location = new System.Drawing.Point(4, 4);
            this.KeyPic.Name = "KeyPic";
            this.KeyPic.Size = new System.Drawing.Size(193, 90);
            this.KeyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KeyPic.TabIndex = 0;
            this.KeyPic.TabStop = false;
            // 
            // KeyName
            // 
            this.KeyName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KeyName.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyName.ForeColor = System.Drawing.Color.Silver;
            this.KeyName.Location = new System.Drawing.Point(0, 98);
            this.KeyName.Name = "KeyName";
            this.KeyName.Size = new System.Drawing.Size(200, 23);
            this.KeyName.TabIndex = 1;
            this.KeyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KeyName);
            this.Controls.Add(this.KeyPic);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.MaximumSize = new System.Drawing.Size(200, 121);
            this.Name = "KeyDisplay";
            this.Size = new System.Drawing.Size(200, 121);
            ((System.ComponentModel.ISupportInitialize)(this.KeyPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox KeyPic;
        public System.Windows.Forms.Label KeyName;
    }
}
