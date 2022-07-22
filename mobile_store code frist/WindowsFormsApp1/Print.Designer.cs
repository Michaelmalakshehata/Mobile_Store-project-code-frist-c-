namespace main
{
    partial class Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.ldate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llname = new System.Windows.Forms.Label();
            this.lpphone = new System.Windows.Forms.Label();
            this.menubar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.gItems2 = new System.Windows.Forms.DataGridView();
            this.lldate = new System.Windows.Forms.Label();
            this.lpprice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gItems2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(359, 110);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(0, 13);
            this.lname.TabIndex = 1;
            // 
            // ldate
            // 
            this.ldate.AutoSize = true;
            this.ldate.Location = new System.Drawing.Point(359, 234);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(0, 13);
            this.ldate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(52, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer Phone";
            // 
            // llname
            // 
            this.llname.AutoSize = true;
            this.llname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llname.ForeColor = System.Drawing.Color.Black;
            this.llname.Location = new System.Drawing.Point(212, 80);
            this.llname.Name = "llname";
            this.llname.Size = new System.Drawing.Size(0, 24);
            this.llname.TabIndex = 10;
            // 
            // lpphone
            // 
            this.lpphone.AutoSize = true;
            this.lpphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpphone.ForeColor = System.Drawing.Color.Black;
            this.lpphone.Location = new System.Drawing.Point(217, 113);
            this.lpphone.Name = "lpphone";
            this.lpphone.Size = new System.Drawing.Size(0, 24);
            this.lpphone.TabIndex = 11;
            // 
            // menubar
            // 
            this.menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.menubar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel3,
            this.toolStripButton1});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(783, 27);
            this.menubar.Stretch = true;
            this.menubar.TabIndex = 14;
            this.menubar.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.toolStripLabel1.Image = global::main.Properties.Resources.printer;
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripLabel1.LinkColor = System.Drawing.Color.White;
            this.toolStripLabel1.LinkVisited = true;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 24);
            this.toolStripLabel1.Text = "Print";
            this.toolStripLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(669, 1, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // gItems2
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gItems2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gItems2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gItems2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gItems2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gItems2.BackgroundColor = System.Drawing.Color.White;
            this.gItems2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gItems2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gItems2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productname,
            this.quantity,
            this.Price});
            this.gItems2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gItems2.GridColor = System.Drawing.Color.Maroon;
            this.gItems2.Location = new System.Drawing.Point(56, 226);
            this.gItems2.Margin = new System.Windows.Forms.Padding(6);
            this.gItems2.Name = "gItems2";
            this.gItems2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gItems2.Size = new System.Drawing.Size(655, 478);
            this.gItems2.TabIndex = 0;
            this.gItems2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GItems2_CellContentClick_1);
            // 
            // lldate
            // 
            this.lldate.AutoSize = true;
            this.lldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lldate.ForeColor = System.Drawing.Color.Black;
            this.lldate.Location = new System.Drawing.Point(212, 185);
            this.lldate.Name = "lldate";
            this.lldate.Size = new System.Drawing.Size(0, 24);
            this.lldate.TabIndex = 18;
            // 
            // lpprice
            // 
            this.lpprice.AutoSize = true;
            this.lpprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpprice.ForeColor = System.Drawing.Color.Black;
            this.lpprice.Location = new System.Drawing.Point(212, 148);
            this.lpprice.Name = "lpprice";
            this.lpprice.Size = new System.Drawing.Size(0, 24);
            this.lpprice.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(52, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total Price";
            // 
            // productname
            // 
            this.productname.HeaderText = "Product_name                         ";
            this.productname.Name = "productname";
            this.productname.Width = 109;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity                           ";
            this.quantity.Name = "quantity";
            this.quantity.Width = 96;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price                                  ";
            this.Price.Name = "Price";
            this.Price.Width = 98;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 719);
            this.Controls.Add(this.lldate);
            this.Controls.Add(this.lpprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gItems2);
            this.Controls.Add(this.menubar);
            this.Controls.Add(this.lpphone);
            this.Controls.Add(this.llname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ldate);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Print_Load);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gItems2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label ldate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label llname;
        private System.Windows.Forms.Label lpphone;
        private System.Windows.Forms.ToolStrip menubar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView gItems2;
        private System.Windows.Forms.Label lldate;
        private System.Windows.Forms.Label lpprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}