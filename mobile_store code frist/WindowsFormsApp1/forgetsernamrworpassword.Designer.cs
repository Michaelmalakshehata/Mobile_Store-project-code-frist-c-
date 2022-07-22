namespace main
{
    partial class forgetsernamrworpassword
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
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_securityanswer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_securityquestion = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancelation = new System.Windows.Forms.Button();
            this.btn_submitanswer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_confirm
            // 
            this.txt_confirm.Location = new System.Drawing.Point(325, 267);
            this.txt_confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.PasswordChar = '*';
            this.txt_confirm.Size = new System.Drawing.Size(240, 20);
            this.txt_confirm.TabIndex = 24;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(325, 232);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(240, 20);
            this.txt_pass.TabIndex = 22;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(325, 190);
            this.txt_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(240, 20);
            this.txt_user.TabIndex = 21;
            // 
            // txt_securityanswer
            // 
            this.txt_securityanswer.Location = new System.Drawing.Point(325, 129);
            this.txt_securityanswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_securityanswer.Multiline = true;
            this.txt_securityanswer.Name = "txt_securityanswer";
            this.txt_securityanswer.Size = new System.Drawing.Size(240, 42);
            this.txt_securityanswer.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Indigo;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(282, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Forget My Password";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(596, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "?";
            // 
            // txt_securityquestion
            // 
            this.txt_securityquestion.BackColor = System.Drawing.Color.White;
            this.txt_securityquestion.FormattingEnabled = true;
            this.txt_securityquestion.Items.AddRange(new object[] {
            "what is your first bit name ?",
            "what is your primary school name ?",
            "what is your uncle name ?",
            "what is your favorite hoppy ?",
            "what your favorite sport ?",
            "which type of movies you like ?"});
            this.txt_securityquestion.Location = new System.Drawing.Point(325, 97);
            this.txt_securityquestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_securityquestion.Name = "txt_securityquestion";
            this.txt_securityquestion.Size = new System.Drawing.Size(240, 21);
            this.txt_securityquestion.TabIndex = 19;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(599, 234);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged_1);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "New Password";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter Your Username";
            // 
            // btn_cancelation
            // 
            this.btn_cancelation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelation.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelation.Location = new System.Drawing.Point(168, 317);
            this.btn_cancelation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelation.Name = "btn_cancelation";
            this.btn_cancelation.Size = new System.Drawing.Size(165, 45);
            this.btn_cancelation.TabIndex = 26;
            this.btn_cancelation.Text = "Cansel";
            this.btn_cancelation.UseVisualStyleBackColor = true;
            this.btn_cancelation.Click += new System.EventHandler(this.Btn_cancelation_Click);
            // 
            // btn_submitanswer
            // 
            this.btn_submitanswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_submitanswer.BackColor = System.Drawing.Color.Indigo;
            this.btn_submitanswer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submitanswer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_submitanswer.Location = new System.Drawing.Point(414, 317);
            this.btn_submitanswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_submitanswer.Name = "btn_submitanswer";
            this.btn_submitanswer.Size = new System.Drawing.Size(169, 45);
            this.btn_submitanswer.TabIndex = 25;
            this.btn_submitanswer.Text = "Submit";
            this.btn_submitanswer.UseVisualStyleBackColor = false;
            this.btn_submitanswer.Click += new System.EventHandler(this.Btn_submitanswer_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter Your Answer";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Your Security Question";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 64);
            this.panel1.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 34);
            this.panel2.TabIndex = 65;
            // 
            // forgetsernamrworpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 403);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_securityanswer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_securityquestion);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancelation);
            this.Controls.Add(this.btn_submitanswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "forgetsernamrworpassword";
            this.Text = "forgetsernamrworpassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_confirm;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_securityanswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txt_securityquestion;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancelation;
        private System.Windows.Forms.Button btn_submitanswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}