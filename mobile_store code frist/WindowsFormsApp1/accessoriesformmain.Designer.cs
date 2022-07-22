namespace main
{
    partial class accessoriesformmain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menubar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnrefresh = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label16 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textsearch = new WindowsFormsApp1.custom.textbox();
            this.label2 = new System.Windows.Forms.Label();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.dataimages = new System.Windows.Forms.DataGridView();
            this.accessierimagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.griddatabase = new System.Windows.Forms.DataGridView();
            this.accessierdetaileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accessierimagesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accessierdetaileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrantyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productimg1DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productimg2DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productimg3DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.menubar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataimages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessierimagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessierdetaileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessierimagesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessierdetaileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menubar
            // 
            this.menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.menubar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btnrefresh});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(1186, 25);
            this.menubar.Stretch = true;
            this.menubar.TabIndex = 103;
            this.menubar.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(0, 22);
            // 
            // btnrefresh
            // 
            this.btnrefresh.ActiveLinkColor = System.Drawing.Color.White;
            this.btnrefresh.IsLink = true;
            this.btnrefresh.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnrefresh.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(58, 22);
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.ToolTipText = "refresh page";
            this.btnrefresh.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnrefresh.Click += new System.EventHandler(this.Btnrefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.textsearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.combocategory);
            this.panel2.Location = new System.Drawing.Point(12, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 70);
            this.panel2.TabIndex = 104;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Snow;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this.simpleButton1.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.simpleButton1.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.simpleButton1.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.AppearanceHovered.ForeColor = System.Drawing.Color.Silver;
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton1.AppearanceHovered.Options.UseFont = true;
            this.simpleButton1.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton1.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton1.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.simpleButton1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.AppearancePressed.ForeColor = System.Drawing.Color.Gray;
            this.simpleButton1.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton1.AppearancePressed.Options.UseFont = true;
            this.simpleButton1.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(329, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 35);
            this.simpleButton1.TabIndex = 93;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(3, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 21);
            this.label16.TabIndex = 40;
            this.label16.Text = "Enter Name :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Snow;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this.simpleButton2.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.simpleButton2.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.simpleButton2.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.AppearanceHovered.ForeColor = System.Drawing.Color.Silver;
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseFont = true;
            this.simpleButton2.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton2.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton2.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.simpleButton2.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.AppearancePressed.ForeColor = System.Drawing.Color.Gray;
            this.simpleButton2.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton2.AppearancePressed.Options.UseFont = true;
            this.simpleButton2.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(621, 23);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(80, 35);
            this.simpleButton2.TabIndex = 94;
            this.simpleButton2.Text = "Arrange";
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // textsearch
            // 
            this.textsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.textsearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textsearch.BorderFocusColor = System.Drawing.Color.Purple;
            this.textsearch.BorderSize = 6;
            this.textsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textsearch.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearch.ForeColor = System.Drawing.Color.Black;
            this.textsearch.Location = new System.Drawing.Point(94, 10);
            this.textsearch.Margin = new System.Windows.Forms.Padding(4);
            this.textsearch.Multiline = true;
            this.textsearch.Name = "textsearch";
            this.textsearch.Padding = new System.Windows.Forms.Padding(7);
            this.textsearch.PasswordChar = false;
            this.textsearch.Size = new System.Drawing.Size(228, 46);
            this.textsearch.TabIndex = 43;
            this.textsearch.Texts = "";
            this.textsearch.UnderlinedStyle = true;
            this.textsearch._TextChanged += new System.EventHandler(this.Textsearch__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(415, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Select :";
            // 
            // combocategory
            // 
            this.combocategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Items.AddRange(new object[] {
            "name",
            "price",
            "quantity",
            "date"});
            this.combocategory.Location = new System.Drawing.Point(494, 37);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(121, 21);
            this.combocategory.TabIndex = 37;
            // 
            // dataimages
            // 
            this.dataimages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataimages.AutoGenerateColumns = false;
            this.dataimages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataimages.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataimages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataimages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataimages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameproductDataGridViewTextBoxColumn,
            this.productimg1DataGridViewImageColumn,
            this.productimg2DataGridViewImageColumn,
            this.productimg3DataGridViewImageColumn});
            this.dataimages.DataSource = this.accessierimagesBindingSource;
            this.dataimages.Location = new System.Drawing.Point(601, 128);
            this.dataimages.Name = "dataimages";
            this.dataimages.RowHeadersWidth = 30;
            this.dataimages.Size = new System.Drawing.Size(573, 526);
            this.dataimages.TabIndex = 106;
            // 
            // accessierimagesBindingSource
            // 
            this.accessierimagesBindingSource.DataSource = typeof(main.accessierimages);
            // 
            // griddatabase
            // 
            this.griddatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.griddatabase.AutoGenerateColumns = false;
            this.griddatabase.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.griddatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.warrantyDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.griddatabase.DataSource = this.accessierdetaileBindingSource1;
            this.griddatabase.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.griddatabase.Location = new System.Drawing.Point(12, 128);
            this.griddatabase.Name = "griddatabase";
            this.griddatabase.Size = new System.Drawing.Size(583, 526);
            this.griddatabase.TabIndex = 107;
            // 
            // accessierdetaileBindingSource1
            // 
            this.accessierdetaileBindingSource1.DataSource = typeof(main.accessierdetaile);
            // 
            // accessierimagesBindingSource1
            // 
            this.accessierimagesBindingSource1.DataSource = typeof(main.accessierimages);
            // 
            // accessierdetaileBindingSource
            // 
            this.accessierdetaileBindingSource.DataSource = typeof(main.accessierdetaile);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // warrantyDataGridViewTextBoxColumn
            // 
            this.warrantyDataGridViewTextBoxColumn.DataPropertyName = "warranty";
            this.warrantyDataGridViewTextBoxColumn.HeaderText = "warranty";
            this.warrantyDataGridViewTextBoxColumn.Name = "warrantyDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // nameproductDataGridViewTextBoxColumn
            // 
            this.nameproductDataGridViewTextBoxColumn.DataPropertyName = "nameproduct";
            this.nameproductDataGridViewTextBoxColumn.HeaderText = "Product_name";
            this.nameproductDataGridViewTextBoxColumn.Name = "nameproductDataGridViewTextBoxColumn";
            // 
            // productimg1DataGridViewImageColumn
            // 
            this.productimg1DataGridViewImageColumn.DataPropertyName = "productimg1";
            this.productimg1DataGridViewImageColumn.HeaderText = "image 1";
            this.productimg1DataGridViewImageColumn.Name = "productimg1DataGridViewImageColumn";
            // 
            // productimg2DataGridViewImageColumn
            // 
            this.productimg2DataGridViewImageColumn.DataPropertyName = "productimg2";
            this.productimg2DataGridViewImageColumn.HeaderText = "image 2";
            this.productimg2DataGridViewImageColumn.Name = "productimg2DataGridViewImageColumn";
            // 
            // productimg3DataGridViewImageColumn
            // 
            this.productimg3DataGridViewImageColumn.DataPropertyName = "productimg3";
            this.productimg3DataGridViewImageColumn.HeaderText = "image 3";
            this.productimg3DataGridViewImageColumn.Name = "productimg3DataGridViewImageColumn";
            // 
            // accessoriesformmain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 657);
            this.Controls.Add(this.griddatabase);
            this.Controls.Add(this.dataimages);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menubar);
            this.Name = "accessoriesformmain";
            this.Text = "accessoriesformmain";
            this.Load += new System.EventHandler(this.Accessoriesformmain_Load);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataimages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessierimagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessierdetaileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessierimagesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessierdetaileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menubar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel btnrefresh;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private WindowsFormsApp1.custom.textbox textsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.DataGridView dataimages;
        private System.Windows.Forms.BindingSource accessierimagesBindingSource;
        private System.Windows.Forms.BindingSource accessierimagesBindingSource1;
        private System.Windows.Forms.BindingSource accessierdetaileBindingSource;
        private System.Windows.Forms.BindingSource accessierdetaileBindingSource1;
        private System.Windows.Forms.DataGridView griddatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productimg1DataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn productimg2DataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn productimg3DataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}