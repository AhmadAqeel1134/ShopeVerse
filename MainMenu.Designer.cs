namespace Project
{
    partial class MainMenu
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
            this.AdminButton = new System.Windows.Forms.Button();
            this.LogisticsButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.SellerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.AutoEllipsis = true;
            this.AdminButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.AdminButton.Location = new System.Drawing.Point(91, 92);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(313, 111);
            this.AdminButton.TabIndex = 0;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // LogisticsButton
            // 
            this.LogisticsButton.AutoEllipsis = true;
            this.LogisticsButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogisticsButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.LogisticsButton.Location = new System.Drawing.Point(633, 353);
            this.LogisticsButton.Name = "LogisticsButton";
            this.LogisticsButton.Size = new System.Drawing.Size(313, 111);
            this.LogisticsButton.TabIndex = 1;
            this.LogisticsButton.Text = "Logistics";
            this.LogisticsButton.UseVisualStyleBackColor = true;
            this.LogisticsButton.Click += new System.EventHandler(this.LogisticsButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.AutoEllipsis = true;
            this.CustomerButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.CustomerButton.Location = new System.Drawing.Point(633, 92);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(313, 111);
            this.CustomerButton.TabIndex = 2;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // SellerButton
            // 
            this.SellerButton.AutoEllipsis = true;
            this.SellerButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.SellerButton.Location = new System.Drawing.Point(91, 353);
            this.SellerButton.Name = "SellerButton";
            this.SellerButton.Size = new System.Drawing.Size(313, 111);
            this.SellerButton.TabIndex = 3;
            this.SellerButton.Text = "Seller";
            this.SellerButton.UseVisualStyleBackColor = true;
            this.SellerButton.Click += new System.EventHandler(this.SellerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome To ShopVerse";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1032, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SellerButton);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.LogisticsButton);
            this.Controls.Add(this.AdminButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button LogisticsButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button SellerButton;
        private System.Windows.Forms.Label label1;
    }
}