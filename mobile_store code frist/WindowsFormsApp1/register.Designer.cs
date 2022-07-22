namespace main
{
    partial class register
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
            this.label7 = new System.Windows.Forms.Label();
            this.txt_chkq = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.lab_ans = new System.Windows.Forms.Label();
            this.lab_chkq = new System.Windows.Forms.Label();
            this.txt_ans = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_conpass = new System.Windows.Forms.TextBox();
            this.lab_pass = new System.Windows.Forms.Label();
            this.lab_conpass = new System.Windows.Forms.Label();
            this.lab_phone = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Indigo;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(318, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Register";
            // 
            // txt_chkq
            // 
            this.txt_chkq.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_chkq.FormattingEnabled = true;
            this.txt_chkq.Items.AddRange(new object[] {
            "what is your first bit name ?",
            "what is your primary school name ?",
            "what is your uncle name ?",
            "what is your favorite hoppy ?",
            "what your favorite sport ?",
            "which type of movies you like ?"});
            this.txt_chkq.Location = new System.Drawing.Point(286, 231);
            this.txt_chkq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_chkq.Name = "txt_chkq";
            this.txt_chkq.Size = new System.Drawing.Size(207, 21);
            this.txt_chkq.TabIndex = 54;
            this.txt_chkq.SelectedIndexChanged += new System.EventHandler(this.Txt_chkq_SelectedIndexChanged_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(519, 166);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(589, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(589, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(655, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(589, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(589, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "*";
            // 
            // error
            // 
            this.error.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(589, 204);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(87, 13);
            this.error.TabIndex = 57;
            this.error.Text = "Invalid Password";
            // 
            // lab_ans
            // 
            this.lab_ans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_ans.AutoSize = true;
            this.lab_ans.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ans.Location = new System.Drawing.Point(117, 266);
            this.lab_ans.Name = "lab_ans";
            this.lab_ans.Size = new System.Drawing.Size(71, 23);
            this.lab_ans.TabIndex = 47;
            this.lab_ans.Text = "Answer";
            // 
            // lab_chkq
            // 
            this.lab_chkq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_chkq.AutoSize = true;
            this.lab_chkq.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_chkq.Location = new System.Drawing.Point(117, 227);
            this.lab_chkq.Name = "lab_chkq";
            this.lab_chkq.Size = new System.Drawing.Size(139, 23);
            this.lab_chkq.TabIndex = 43;
            this.lab_chkq.Text = "Check Question";
            // 
            // txt_ans
            // 
            this.txt_ans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ans.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_ans.Location = new System.Drawing.Point(225, 270);
            this.txt_ans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.Size = new System.Drawing.Size(268, 20);
            this.txt_ans.TabIndex = 55;
            this.txt_ans.TextChanged += new System.EventHandler(this.Txt_ans_TextChanged_1);
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_phone.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_phone.Location = new System.Drawing.Point(225, 129);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(268, 20);
            this.txt_phone.TabIndex = 50;
            this.txt_phone.TextChanged += new System.EventHandler(this.Txt_phone_TextChanged_1);
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_password.Location = new System.Drawing.Point(225, 164);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(268, 20);
            this.txt_password.TabIndex = 51;
            this.txt_password.TextChanged += new System.EventHandler(this.Txt_password_TextChanged_1);
            // 
            // txt_conpass
            // 
            this.txt_conpass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_conpass.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_conpass.Location = new System.Drawing.Point(286, 198);
            this.txt_conpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_conpass.Name = "txt_conpass";
            this.txt_conpass.PasswordChar = '*';
            this.txt_conpass.Size = new System.Drawing.Size(207, 20);
            this.txt_conpass.TabIndex = 53;
            this.txt_conpass.TextChanged += new System.EventHandler(this.Txt_conpass_TextChanged);
            // 
            // lab_pass
            // 
            this.lab_pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_pass.AutoSize = true;
            this.lab_pass.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pass.Location = new System.Drawing.Point(117, 161);
            this.lab_pass.Name = "lab_pass";
            this.lab_pass.Size = new System.Drawing.Size(88, 23);
            this.lab_pass.TabIndex = 46;
            this.lab_pass.Text = "Password";
            // 
            // lab_conpass
            // 
            this.lab_conpass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_conpass.AutoSize = true;
            this.lab_conpass.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_conpass.Location = new System.Drawing.Point(117, 195);
            this.lab_conpass.Name = "lab_conpass";
            this.lab_conpass.Size = new System.Drawing.Size(159, 23);
            this.lab_conpass.TabIndex = 45;
            this.lab_conpass.Text = "Confirm Password";
            // 
            // lab_phone
            // 
            this.lab_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_phone.AutoSize = true;
            this.lab_phone.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_phone.Location = new System.Drawing.Point(117, 126);
            this.lab_phone.Name = "lab_phone";
            this.lab_phone.Size = new System.Drawing.Size(62, 23);
            this.lab_phone.TabIndex = 44;
            this.lab_phone.Text = "Phone";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_name.Location = new System.Drawing.Point(225, 88);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(268, 20);
            this.txt_name.TabIndex = 49;
            this.txt_name.TextChanged += new System.EventHandler(this.Txt_name_TextChanged_1);
            // 
            // lab_name
            // 
            this.lab_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.Location = new System.Drawing.Point(117, 88);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(59, 23);
            this.lab_name.TabIndex = 48;
            this.lab_name.Text = "Name";
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register.BackColor = System.Drawing.Color.Indigo;
            this.btn_register.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_register.Location = new System.Drawing.Point(274, 326);
            this.btn_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(150, 38);
            this.btn_register.TabIndex = 56;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.Btn_register_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 63);
            this.panel1.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 34);
            this.panel2.TabIndex = 64;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 403);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_chkq);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.error);
            this.Controls.Add(this.lab_ans);
            this.Controls.Add(this.lab_chkq);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_conpass);
            this.Controls.Add(this.lab_pass);
            this.Controls.Add(this.lab_conpass);
            this.Controls.Add(this.lab_phone);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.btn_register);
            this.Name = "register";
            this.Text = "register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txt_chkq;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label lab_ans;
        private System.Windows.Forms.Label lab_chkq;
        private System.Windows.Forms.TextBox txt_ans;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_conpass;
        private System.Windows.Forms.Label lab_pass;
        private System.Windows.Forms.Label lab_conpass;
        private System.Windows.Forms.Label lab_phone;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}