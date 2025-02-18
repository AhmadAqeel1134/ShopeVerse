namespace Project
{
    partial class CustomerReg
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.DOBTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SellerReg = new System.Windows.Forms.LinkLabel();
            this.CustomerLogin = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.SignCustReg = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PpTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddrTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MailTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FNameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Gender:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Date Of Birth:";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(302, 477);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(136, 21);
            this.GenderComboBox.TabIndex = 43;
            // 
            // DOBTimePicker
            // 
            this.DOBTimePicker.Location = new System.Drawing.Point(17, 478);
            this.DOBTimePicker.Name = "DOBTimePicker";
            this.DOBTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DOBTimePicker.TabIndex = 42;
            // 
            // SellerReg
            // 
            this.SellerReg.AutoSize = true;
            this.SellerReg.Location = new System.Drawing.Point(369, 569);
            this.SellerReg.Name = "SellerReg";
            this.SellerReg.Size = new System.Drawing.Size(88, 13);
            this.SellerReg.TabIndex = 41;
            this.SellerReg.TabStop = true;
            this.SellerReg.Text = "Sign Up as Seller";
            // 
            // CustomerLogin
            // 
            this.CustomerLogin.AutoSize = true;
            this.CustomerLogin.Location = new System.Drawing.Point(273, 569);
            this.CustomerLogin.Name = "CustomerLogin";
            this.CustomerLogin.Size = new System.Drawing.Size(57, 13);
            this.CustomerLogin.TabIndex = 40;
            this.CustomerLogin.TabStop = true;
            this.CustomerLogin.Text = "Login here";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 569);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Already have an Account?";
            // 
            // SignCustReg
            // 
            this.SignCustReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignCustReg.Location = new System.Drawing.Point(188, 534);
            this.SignCustReg.Name = "SignCustReg";
            this.SignCustReg.Size = new System.Drawing.Size(97, 32);
            this.SignCustReg.TabIndex = 38;
            this.SignCustReg.Text = "Sign Up";
            this.SignCustReg.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "Customer Registration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "State:";
            // 
            // StTxt
            // 
            this.StTxt.Location = new System.Drawing.Point(81, 407);
            this.StTxt.Name = "StTxt";
            this.StTxt.Size = new System.Drawing.Size(297, 20);
            this.StTxt.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Payment Preference:";
            // 
            // PpTxt
            // 
            this.PpTxt.Location = new System.Drawing.Point(81, 348);
            this.PpTxt.Name = "PpTxt";
            this.PpTxt.Size = new System.Drawing.Size(297, 20);
            this.PpTxt.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Address:";
            // 
            // AddrTxt
            // 
            this.AddrTxt.Location = new System.Drawing.Point(81, 284);
            this.AddrTxt.Name = "AddrTxt";
            this.AddrTxt.Size = new System.Drawing.Size(297, 20);
            this.AddrTxt.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Password:";
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(81, 226);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(297, 20);
            this.PassTxt.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Email:";
            // 
            // MailTxt
            // 
            this.MailTxt.Location = new System.Drawing.Point(81, 172);
            this.MailTxt.Name = "MailTxt";
            this.MailTxt.Size = new System.Drawing.Size(297, 20);
            this.MailTxt.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Last Name:";
            // 
            // LNameTxt
            // 
            this.LNameTxt.Location = new System.Drawing.Point(81, 122);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.Size = new System.Drawing.Size(297, 20);
            this.LNameTxt.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "First Name:";
            // 
            // FNameTxt
            // 
            this.FNameTxt.Location = new System.Drawing.Point(81, 70);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.Size = new System.Drawing.Size(297, 20);
            this.FNameTxt.TabIndex = 23;
            // 
            // CustomerReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 591);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.DOBTimePicker);
            this.Controls.Add(this.SellerReg);
            this.Controls.Add(this.CustomerLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SignCustReg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PpTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddrTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FNameTxt);
            this.Name = "CustomerReg";
            this.Text = "Customer Registration";
            this.Load += new System.EventHandler(this.CustomerReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.DateTimePicker DOBTimePicker;
        private System.Windows.Forms.LinkLabel SellerReg;
        private System.Windows.Forms.LinkLabel CustomerLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SignCustReg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PpTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddrTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MailTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FNameTxt;
    }
}