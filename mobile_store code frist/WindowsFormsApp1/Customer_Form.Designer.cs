namespace main
{
    partial class Customer_Form
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
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.Add_customer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCustomerPhone = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.Add_Product = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.label16 = new System.Windows.Forms.Label();
            this.btnorder = new DevExpress.XtraEditors.SimpleButton();
            this.textsearch = new WindowsFormsApp1.custom.textbox();
            this.label7 = new System.Windows.Forms.Label();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.menubar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnrefresh = new System.Windows.Forms.ToolStripLabel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gridControl2 = new System.Windows.Forms.DataGridView();
            this.customerProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comtype = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.combomob = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnclear = new DevExpress.XtraEditors.SimpleButton();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.menubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(85, 217);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(255, 21);
            this.textAddress.TabIndex = 18;
            this.textAddress.TextChanged += new System.EventHandler(this.textAddress_TextChanged);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(85, 181);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(255, 21);
            this.textPhone.TabIndex = 17;
            this.textPhone.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(87, 144);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(253, 21);
            this.textName.TabIndex = 16;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // Add_customer
            // 
            this.Add_customer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Add_customer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_customer.ForeColor = System.Drawing.Color.Black;
            this.Add_customer.Location = new System.Drawing.Point(18, 254);
            this.Add_customer.Name = "Add_customer";
            this.Add_customer.Size = new System.Drawing.Size(321, 37);
            this.Add_customer.TabIndex = 15;
            this.Add_customer.Text = "Add";
            this.Add_customer.UseVisualStyleBackColor = false;
            this.Add_customer.Click += new System.EventHandler(this.Add_customer_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // textCustomerPhone
            // 
            this.textCustomerPhone.Location = new System.Drawing.Point(117, 475);
            this.textCustomerPhone.Name = "textCustomerPhone";
            this.textCustomerPhone.Size = new System.Drawing.Size(222, 21);
            this.textCustomerPhone.TabIndex = 30;
            this.textCustomerPhone.TextChanged += new System.EventHandler(this.textCustomerPhone_TextChanged);
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(117, 448);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(222, 21);
            this.textQuantity.TabIndex = 29;
            this.textQuantity.TextChanged += new System.EventHandler(this.textQuantity_TextChanged);
            // 
            // Add_Product
            // 
            this.Add_Product.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Add_Product.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Product.ForeColor = System.Drawing.Color.Black;
            this.Add_Product.Location = new System.Drawing.Point(19, 529);
            this.Add_Product.Name = "Add_Product";
            this.Add_Product.Size = new System.Drawing.Size(321, 39);
            this.Add_Product.TabIndex = 27;
            this.Add_Product.Text = "Add";
            this.Add_Product.UseVisualStyleBackColor = false;
            this.Add_Product.Click += new System.EventHandler(this.Add_Product_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Quantity";
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.Location = new System.Drawing.Point(28, 420);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(60, 19);
            this.Product.TabIndex = 24;
            this.Product.Text = "Product";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.btnorder);
            this.panel2.Controls.Add(this.textsearch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.combocategory);
            this.panel2.Location = new System.Drawing.Point(346, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 65);
            this.panel2.TabIndex = 97;
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.BackColor = System.Drawing.Color.Snow;
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.Options.UseBackColor = true;
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.AppearanceHovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsearch.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnsearch.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsearch.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.AppearanceHovered.ForeColor = System.Drawing.Color.Silver;
            this.btnsearch.AppearanceHovered.Options.UseBackColor = true;
            this.btnsearch.AppearanceHovered.Options.UseBorderColor = true;
            this.btnsearch.AppearanceHovered.Options.UseFont = true;
            this.btnsearch.AppearanceHovered.Options.UseForeColor = true;
            this.btnsearch.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnsearch.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsearch.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.AppearancePressed.ForeColor = System.Drawing.Color.Gray;
            this.btnsearch.AppearancePressed.Options.UseBackColor = true;
            this.btnsearch.AppearancePressed.Options.UseFont = true;
            this.btnsearch.AppearancePressed.Options.UseForeColor = true;
            this.btnsearch.Location = new System.Drawing.Point(237, 35);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(80, 22);
            this.btnsearch.TabIndex = 93;
            this.btnsearch.Text = "Search";
            this.btnsearch.Click += new System.EventHandler(this.Btnsearch_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(3, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 21);
            this.label16.TabIndex = 40;
            this.label16.Text = "Enter Phone :";
            // 
            // btnorder
            // 
            this.btnorder.Appearance.BackColor = System.Drawing.Color.Snow;
            this.btnorder.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.Appearance.Options.UseBackColor = true;
            this.btnorder.Appearance.Options.UseFont = true;
            this.btnorder.AppearanceHovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnorder.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnorder.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnorder.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.AppearanceHovered.ForeColor = System.Drawing.Color.Silver;
            this.btnorder.AppearanceHovered.Options.UseBackColor = true;
            this.btnorder.AppearanceHovered.Options.UseBorderColor = true;
            this.btnorder.AppearanceHovered.Options.UseFont = true;
            this.btnorder.AppearanceHovered.Options.UseForeColor = true;
            this.btnorder.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnorder.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnorder.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.AppearancePressed.ForeColor = System.Drawing.Color.Gray;
            this.btnorder.AppearancePressed.Options.UseBackColor = true;
            this.btnorder.AppearancePressed.Options.UseFont = true;
            this.btnorder.AppearancePressed.Options.UseForeColor = true;
            this.btnorder.Location = new System.Drawing.Point(534, 33);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(80, 23);
            this.btnorder.TabIndex = 94;
            this.btnorder.Text = "Arrange";
            this.btnorder.Click += new System.EventHandler(this.Btnorder_Click);
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
            this.textsearch.Location = new System.Drawing.Point(94, 11);
            this.textsearch.Margin = new System.Windows.Forms.Padding(4);
            this.textsearch.Multiline = true;
            this.textsearch.Name = "textsearch";
            this.textsearch.Padding = new System.Windows.Forms.Padding(7);
            this.textsearch.PasswordChar = false;
            this.textsearch.Size = new System.Drawing.Size(136, 46);
            this.textsearch.TabIndex = 43;
            this.textsearch.Texts = "";
            this.textsearch.UnderlinedStyle = true;
            this.textsearch._TextChanged += new System.EventHandler(this.Textsearch__TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(329, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Select :";
            // 
            // combocategory
            // 
            this.combocategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Items.AddRange(new object[] {
            "name",
            "phone"});
            this.combocategory.Location = new System.Drawing.Point(396, 35);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(121, 21);
            this.combocategory.TabIndex = 37;
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
            this.menubar.TabIndex = 98;
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
            this.simpleButton1.Location = new System.Drawing.Point(694, 375);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 22);
            this.simpleButton1.TabIndex = 101;
            this.simpleButton1.Text = "Arrange";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(489, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 19);
            this.label10.TabIndex = 100;
            this.label10.Text = "Select :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "name",
            "phone",
            "quantity"});
            this.comboBox1.Location = new System.Drawing.Point(556, 376);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 99;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(19, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 37);
            this.button1.TabIndex = 103;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.AutoGenerateColumns = false;
            this.gridControl2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridControl2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridControl2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn,
            this.typeproductDataGridViewTextBoxColumn});
            this.gridControl2.DataSource = this.customerProductBindingSource;
            this.gridControl2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridControl2.GridColor = System.Drawing.Color.DarkRed;
            this.gridControl2.Location = new System.Drawing.Point(346, 405);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(804, 252);
            this.gridControl2.TabIndex = 104;
            this.gridControl2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridControl2_CellContentClick);
            // 
            // customerProductBindingSource
            // 
            this.customerProductBindingSource.DataSource = typeof(main.CustomerProduct);
            // 
            // comtype
            // 
            this.comtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comtype.FormattingEnabled = true;
            this.comtype.Items.AddRange(new object[] {
            "mobile",
            "accessory"});
            this.comtype.Location = new System.Drawing.Point(118, 502);
            this.comtype.Name = "comtype";
            this.comtype.Size = new System.Drawing.Size(222, 21);
            this.comtype.TabIndex = 105;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(19, 574);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 37);
            this.button2.TabIndex = 107;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(18, 616);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(321, 29);
            this.btnupdate.TabIndex = 108;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // combomob
            // 
            this.combomob.FormattingEnabled = true;
            this.combomob.Location = new System.Drawing.Point(117, 421);
            this.combomob.Name = "combomob";
            this.combomob.Size = new System.Drawing.Size(222, 21);
            this.combomob.TabIndex = 109;
            this.combomob.SelectedIndexChanged += new System.EventHandler(this.Combomob_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 110;
            this.label8.Text = "Select Type :";
            // 
            // btnclear
            // 
            this.btnclear.Appearance.BackColor = System.Drawing.Color.Snow;
            this.btnclear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Appearance.Options.UseBackColor = true;
            this.btnclear.Appearance.Options.UseFont = true;
            this.btnclear.AppearanceHovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnclear.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclear.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnclear.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.AppearanceHovered.ForeColor = System.Drawing.Color.Silver;
            this.btnclear.AppearanceHovered.Options.UseBackColor = true;
            this.btnclear.AppearanceHovered.Options.UseBorderColor = true;
            this.btnclear.AppearanceHovered.Options.UseFont = true;
            this.btnclear.AppearanceHovered.Options.UseForeColor = true;
            this.btnclear.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnclear.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclear.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.AppearancePressed.ForeColor = System.Drawing.Color.Gray;
            this.btnclear.AppearancePressed.Options.UseBackColor = true;
            this.btnclear.AppearancePressed.Options.UseFont = true;
            this.btnclear.AppearancePressed.Options.UseForeColor = true;
            this.btnclear.Location = new System.Drawing.Point(353, 378);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(80, 22);
            this.btnclear.TabIndex = 111;
            this.btnclear.Text = "Clear All";
            this.btnclear.Click += new System.EventHandler(this.Btnclear_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(main.Customer);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(main.Customer);
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataSource = typeof(main.Customer);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.AutoGenerateColumns = false;
            this.gridControl1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridControl1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.gridControl1.DataSource = this.customerBindingSource1;
            this.gridControl1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridControl1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.gridControl1.Location = new System.Drawing.Point(346, 144);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(793, 191);
            this.gridControl1.TabIndex = 112;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // customerBindingSource3
            // 
            this.customerBindingSource3.DataSource = typeof(main.Customer);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 22);
            this.label9.TabIndex = 113;
            this.label9.Text = "Enter customer detailes :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(117, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 22);
            this.label11.TabIndex = 114;
            this.label11.Text = "Enter customer products :";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "Customer_Phone";
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            // 
            // typeproductDataGridViewTextBoxColumn
            // 
            this.typeproductDataGridViewTextBoxColumn.DataPropertyName = "typeproduct";
            this.typeproductDataGridViewTextBoxColumn.HeaderText = "product_type";
            this.typeproductDataGridViewTextBoxColumn.Name = "typeproductDataGridViewTextBoxColumn";
            // 
            // Customer_Form
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 657);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combomob);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comtype);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menubar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textCustomerPhone);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.Add_Product);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.Add_customer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Form";
            this.Load += new System.EventHandler(this.Customer_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button Add_customer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCustomerPhone;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Button Add_Product;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.SimpleButton btnorder;
        private WindowsFormsApp1.custom.textbox textsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.ToolStrip menubar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel btnrefresh;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridControl2;
        private System.Windows.Forms.BindingSource customerProductBindingSource;
        private System.Windows.Forms.ComboBox comtype;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox combomob;
        private DevExpress.XtraEditors.SimpleButton btnclear;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.DataGridView gridControl1;
        private System.Windows.Forms.BindingSource customerBindingSource3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeproductDataGridViewTextBoxColumn;
    }
}