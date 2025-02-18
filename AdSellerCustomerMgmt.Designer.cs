namespace Project
{
    partial class AdSellerCustomerMgmt
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.SellerGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StateText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailSeller = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LastNameSeller = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FirstNameSeller = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SaveButtonCust = new System.Windows.Forms.Button();
            this.SaveButtonSell = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SaveButtonCust);
            this.tabPage1.Controls.Add(this.StateText);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.AddressText);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.PaymentText);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.EmailText);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.LastNameText);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.FirstNameText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CustomerGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SaveButtonSell);
            this.tabPage2.Controls.Add(this.EmailSeller);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.LastNameSeller);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.FirstNameSeller);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.SellerGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Seller Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomerGridView.Location = new System.Drawing.Point(3, 212);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.Size = new System.Drawing.Size(786, 209);
            this.CustomerGridView.TabIndex = 0;
            this.CustomerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGridView_CellContentClick);
            // 
            // SellerGridView
            // 
            this.SellerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellerGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SellerGridView.Location = new System.Drawing.Point(3, 237);
            this.SellerGridView.Name = "SellerGridView";
            this.SellerGridView.Size = new System.Drawing.Size(786, 184);
            this.SellerGridView.TabIndex = 0;
            this.SellerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstNameText
            // 
            this.FirstNameText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameText.Location = new System.Drawing.Point(140, 19);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(160, 25);
            this.FirstNameText.TabIndex = 2;
            this.FirstNameText.TextChanged += new System.EventHandler(this.FirstNameText_TextChanged);
            // 
            // LastNameText
            // 
            this.LastNameText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameText.Location = new System.Drawing.Point(571, 19);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(160, 25);
            this.LastNameText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // EmailText
            // 
            this.EmailText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.Location = new System.Drawing.Point(140, 67);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(160, 25);
            this.EmailText.TabIndex = 6;
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PaymentText
            // 
            this.PaymentText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentText.Location = new System.Drawing.Point(571, 73);
            this.PaymentText.Name = "PaymentText";
            this.PaymentText.Size = new System.Drawing.Size(160, 25);
            this.PaymentText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Payment Preference:";
            // 
            // AddressText
            // 
            this.AddressText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.Location = new System.Drawing.Point(140, 125);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(160, 25);
            this.AddressText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address:";
            // 
            // StateText
            // 
            this.StateText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateText.Location = new System.Drawing.Point(571, 131);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(160, 25);
            this.StateText.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "State:";
            // 
            // EmailSeller
            // 
            this.EmailSeller.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailSeller.Location = new System.Drawing.Point(138, 93);
            this.EmailSeller.Name = "EmailSeller";
            this.EmailSeller.Size = new System.Drawing.Size(160, 25);
            this.EmailSeller.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email:";
            // 
            // LastNameSeller
            // 
            this.LastNameSeller.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameSeller.Location = new System.Drawing.Point(569, 45);
            this.LastNameSeller.Name = "LastNameSeller";
            this.LastNameSeller.Size = new System.Drawing.Size(160, 25);
            this.LastNameSeller.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(427, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Last Name:";
            // 
            // FirstNameSeller
            // 
            this.FirstNameSeller.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameSeller.Location = new System.Drawing.Point(138, 45);
            this.FirstNameSeller.Name = "FirstNameSeller";
            this.FirstNameSeller.Size = new System.Drawing.Size(160, 25);
            this.FirstNameSeller.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "First Name: ";
            // 
            // SaveButtonCust
            // 
            this.SaveButtonCust.Location = new System.Drawing.Point(42, 171);
            this.SaveButtonCust.Name = "SaveButtonCust";
            this.SaveButtonCust.Size = new System.Drawing.Size(110, 35);
            this.SaveButtonCust.TabIndex = 13;
            this.SaveButtonCust.Text = "Save";
            this.SaveButtonCust.UseVisualStyleBackColor = true;
            this.SaveButtonCust.Click += new System.EventHandler(this.SaveButtonCust_Click);
            // 
            // SaveButtonSell
            // 
            this.SaveButtonSell.Location = new System.Drawing.Point(53, 144);
            this.SaveButtonSell.Name = "SaveButtonSell";
            this.SaveButtonSell.Size = new System.Drawing.Size(110, 35);
            this.SaveButtonSell.TabIndex = 14;
            this.SaveButtonSell.Text = "Save";
            this.SaveButtonSell.UseVisualStyleBackColor = true;
            this.SaveButtonSell.Click += new System.EventHandler(this.SaveButtonSell_Click);
            // 
            // AdminManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminManage";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminManage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.DataGridView SellerGridView;
        private System.Windows.Forms.TextBox StateText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PaymentText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailSeller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LastNameSeller;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FirstNameSeller;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SaveButtonCust;
        private System.Windows.Forms.Button SaveButtonSell;
    }
}