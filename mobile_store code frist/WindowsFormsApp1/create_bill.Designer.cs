namespace main
{
    partial class Form1
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
            this.gItems = new System.Windows.Forms.DataGridView();
            this.lcart = new System.Windows.Forms.Label();
            this.BCheckout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combphones = new System.Windows.Forms.ComboBox();
            this.textbox1 = new WindowsFormsApp1.custom.textbox();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gItems
            // 
            this.gItems.BackgroundColor = System.Drawing.Color.White;
            this.gItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_phone,
            this.productname,
            this.quantity,
            this.price});
            this.gItems.Location = new System.Drawing.Point(1, 275);
            this.gItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gItems.Name = "gItems";
            this.gItems.Size = new System.Drawing.Size(983, 253);
            this.gItems.TabIndex = 0;
            // 
            // lcart
            // 
            this.lcart.AutoSize = true;
            this.lcart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcart.ForeColor = System.Drawing.Color.Black;
            this.lcart.Location = new System.Drawing.Point(13, 223);
            this.lcart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lcart.Name = "lcart";
            this.lcart.Size = new System.Drawing.Size(160, 33);
            this.lcart.TabIndex = 1;
            this.lcart.Text = "Cart Items";
            // 
            // BCheckout
            // 
            this.BCheckout.BackColor = System.Drawing.Color.White;
            this.BCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCheckout.ForeColor = System.Drawing.Color.Black;
            this.BCheckout.Location = new System.Drawing.Point(247, 563);
            this.BCheckout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BCheckout.Name = "BCheckout";
            this.BCheckout.Size = new System.Drawing.Size(288, 51);
            this.BCheckout.TabIndex = 2;
            this.BCheckout.Text = "Check Out";
            this.BCheckout.UseVisualStyleBackColor = false;
            this.BCheckout.Click += new System.EventHandler(this.BCheckout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(429, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Phone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter discount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(346, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "%";
            // 
            // combphones
            // 
            this.combphones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combphones.FormattingEnabled = true;
            this.combphones.Location = new System.Drawing.Point(571, 107);
            this.combphones.Name = "combphones";
            this.combphones.Size = new System.Drawing.Size(248, 23);
            this.combphones.TabIndex = 16;
            this.combphones.SelectedIndexChanged += new System.EventHandler(this.Combphones_SelectedIndexChanged);
            this.combphones.TextChanged += new System.EventHandler(this.Combphones_TextChanged);
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.textbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox1.BorderSize = 6;
            this.textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox1.ForeColor = System.Drawing.Color.Black;
            this.textbox1.Location = new System.Drawing.Point(216, 95);
            this.textbox1.Margin = new System.Windows.Forms.Padding(5);
            this.textbox1.Multiline = false;
            this.textbox1.Name = "textbox1";
            this.textbox1.Padding = new System.Windows.Forms.Padding(8);
            this.textbox1.PasswordChar = false;
            this.textbox1.Size = new System.Drawing.Size(122, 35);
            this.textbox1.TabIndex = 12;
            this.textbox1.Texts = "";
            this.textbox1.UnderlinedStyle = true;
            this.textbox1._TextChanged += new System.EventHandler(this.Textbox1__TextChanged);
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataSource = typeof(main.Bill);
            // 
            // customer_phone
            // 
            this.customer_phone.HeaderText = "customer_phone";
            this.customer_phone.Name = "customer_phone";
            // 
            // productname
            // 
            this.productname.HeaderText = "Product_name";
            this.productname.Name = "productname";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1016, 644);
            this.Controls.Add(this.combphones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BCheckout);
            this.Controls.Add(this.lcart);
            this.Controls.Add(this.gItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.gItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lcart;
        private System.Windows.Forms.Button BCheckout;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.BindingSource billBindingSource;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp1.custom.textbox textbox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox combphones;
        public System.Windows.Forms.DataGridView gItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

