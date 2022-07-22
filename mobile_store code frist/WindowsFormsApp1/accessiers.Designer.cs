namespace main
{
    partial class accessiers
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
            this.menubar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnrefresh = new System.Windows.Forms.ToolStripLabel();
            this.reset = new System.Windows.Forms.ToolStripLabel();
            this.menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menubar
            // 
            this.menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.menubar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.btnrefresh,
            this.reset});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(1198, 25);
            this.menubar.Stretch = true;
            this.menubar.TabIndex = 3;
            this.menubar.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.toolStripLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripLabel1.LinkColor = System.Drawing.Color.White;
            this.toolStripLabel1.LinkVisited = true;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(143, 22);
            this.toolStripLabel1.Text = "Accessories Detailes";
            this.toolStripLabel1.ToolTipText = "Detailes";
            this.toolStripLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click_1);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ActiveLinkColor = System.Drawing.Color.White;
            this.toolStripLabel2.BackColor = System.Drawing.Color.White;
            this.toolStripLabel2.IsLink = true;
            this.toolStripLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripLabel2.LinkColor = System.Drawing.Color.White;
            this.toolStripLabel2.LinkVisited = true;
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(141, 22);
            this.toolStripLabel2.Text = "Accessories  Images";
            this.toolStripLabel2.ToolTipText = "images";
            this.toolStripLabel2.VisitedLinkColor = System.Drawing.Color.White;
            this.toolStripLabel2.Click += new System.EventHandler(this.ToolStripLabel2_Click_1);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.BackColor = System.Drawing.Color.White;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(0, 22);
            // 
            // btnrefresh
            // 
            this.btnrefresh.ActiveLinkColor = System.Drawing.Color.White;
            this.btnrefresh.BackColor = System.Drawing.Color.White;
            this.btnrefresh.IsLink = true;
            this.btnrefresh.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnrefresh.LinkColor = System.Drawing.Color.White;
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(58, 22);
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.ToolTipText = "refresh page";
            this.btnrefresh.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnrefresh.Click += new System.EventHandler(this.Btnrefresh_Click_1);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.White;
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.IsLink = true;
            this.reset.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.reset.LinkColor = System.Drawing.Color.White;
            this.reset.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(45, 22);
            this.reset.Text = "Reset";
            this.reset.ToolTipText = "reset page";
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // accessiers
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1198, 756);
            this.Controls.Add(this.menubar);
            this.Name = "accessiers";
            this.Text = "Accessiers";
            this.Load += new System.EventHandler(this.Accessiers_Load);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menubar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel btnrefresh;
        private System.Windows.Forms.ToolStripLabel reset;
    }
}