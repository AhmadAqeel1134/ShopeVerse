namespace Project
{
    partial class SellerReg
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
            this.CustomerReg = new System.Windows.Forms.LinkLabel();
            this.SellerLogin = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
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
            // CustomerReg
            // 
            this.CustomerReg.AutoSize = true;
            this.CustomerReg.Location = new System.Drawing.Point(310, 424);
            this.CustomerReg.Name = "CustomerReg";
            this.CustomerReg.Size = new System.Drawing.Size(106, 13);
            this.CustomerReg.TabIndex = 37;
            this.CustomerReg.TabStop = true;
            this.CustomerReg.Text = "Sign Up as Customer";
            this.CustomerReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CustomerReg_LinkClicked);
            // 
            // SellerLogin
            // 
            this.SellerLogin.AutoSize = true;
            this.SellerLogin.Location = new System.Drawing.Point(243, 356);
            this.SellerLogin.Name = "SellerLogin";
            this.SellerLogin.Size = new System.Drawing.Size(57, 13);
            this.SellerLogin.TabIndex = 36;
            this.SellerLogin.TabStop = true;
            this.SellerLogin.Text = "Login here";
            this.SellerLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SellerLogin_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Already have an Account?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(158, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Seller Registration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password:";
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(61, 270);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(297, 20);
            this.PassTxt.TabIndex = 25;
            this.PassTxt.TextChanged += new System.EventHandler(this.PassTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email:";
            // 
            // MailTxt
            // 
            this.MailTxt.Location = new System.Drawing.Point(61, 216);
            this.MailTxt.Name = "MailTxt";
            this.MailTxt.Size = new System.Drawing.Size(297, 20);
            this.MailTxt.TabIndex = 23;
            this.MailTxt.TextChanged += new System.EventHandler(this.MailTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last Name:";
            // 
            // LNameTxt
            // 
            this.LNameTxt.Location = new System.Drawing.Point(61, 166);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.Size = new System.Drawing.Size(297, 20);
            this.LNameTxt.TabIndex = 21;
            this.LNameTxt.TextChanged += new System.EventHandler(this.LNameTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "First Name:";
            // 
            // FNameTxt
            // 
            this.FNameTxt.Location = new System.Drawing.Point(61, 114);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.Size = new System.Drawing.Size(297, 20);
            this.FNameTxt.TabIndex = 19;
            this.FNameTxt.TextChanged += new System.EventHandler(this.FNameTxt_TextChanged);
            // 
            // SellerReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(428, 446);
            this.Controls.Add(this.CustomerReg);
            this.Controls.Add(this.SellerLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FNameTxt);
            this.Name = "SellerReg";
            this.Text = "Seller Registration";
            this.Load += new System.EventHandler(this.SellerReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel CustomerReg;
        private System.Windows.Forms.LinkLabel SellerLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
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