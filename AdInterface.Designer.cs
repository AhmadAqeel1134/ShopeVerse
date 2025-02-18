namespace Project
{
    partial class AdInterface
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
            this.AdOrderMgmtButton = new System.Windows.Forms.Button();
            this.PrCatMgmt = new System.Windows.Forms.Button();
            this.ReviewModButton = new System.Windows.Forms.Button();
            this.AdReportButton = new System.Windows.Forms.Button();
            this.AdSellCust = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdOrderMgmtButton
            // 
            this.AdOrderMgmtButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdOrderMgmtButton.Location = new System.Drawing.Point(92, 73);
            this.AdOrderMgmtButton.Name = "AdOrderMgmtButton";
            this.AdOrderMgmtButton.Size = new System.Drawing.Size(278, 45);
            this.AdOrderMgmtButton.TabIndex = 0;
            this.AdOrderMgmtButton.Text = "Order Management";
            this.AdOrderMgmtButton.UseVisualStyleBackColor = true;
            this.AdOrderMgmtButton.Click += new System.EventHandler(this.AdOrderMgmtButton_Click);
            // 
            // PrCatMgmt
            // 
            this.PrCatMgmt.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrCatMgmt.Location = new System.Drawing.Point(92, 148);
            this.PrCatMgmt.Name = "PrCatMgmt";
            this.PrCatMgmt.Size = new System.Drawing.Size(278, 45);
            this.PrCatMgmt.TabIndex = 1;
            this.PrCatMgmt.Text = "Product and Category Management";
            this.PrCatMgmt.UseVisualStyleBackColor = true;
            // 
            // ReviewModButton
            // 
            this.ReviewModButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewModButton.Location = new System.Drawing.Point(92, 224);
            this.ReviewModButton.Name = "ReviewModButton";
            this.ReviewModButton.Size = new System.Drawing.Size(278, 45);
            this.ReviewModButton.TabIndex = 2;
            this.ReviewModButton.Text = "Review Moderation";
            this.ReviewModButton.UseVisualStyleBackColor = true;
            // 
            // AdReportButton
            // 
            this.AdReportButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdReportButton.Location = new System.Drawing.Point(92, 384);
            this.AdReportButton.Name = "AdReportButton";
            this.AdReportButton.Size = new System.Drawing.Size(278, 45);
            this.AdReportButton.TabIndex = 4;
            this.AdReportButton.Text = "Reports";
            this.AdReportButton.UseVisualStyleBackColor = true;
            // 
            // AdSellCust
            // 
            this.AdSellCust.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdSellCust.Location = new System.Drawing.Point(92, 306);
            this.AdSellCust.Name = "AdSellCust";
            this.AdSellCust.Size = new System.Drawing.Size(278, 45);
            this.AdSellCust.TabIndex = 5;
            this.AdSellCust.Text = "Seller and Customer Management";
            this.AdSellCust.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(13, 13);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AdInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(458, 514);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.AdSellCust);
            this.Controls.Add(this.AdReportButton);
            this.Controls.Add(this.ReviewModButton);
            this.Controls.Add(this.PrCatMgmt);
            this.Controls.Add(this.AdOrderMgmtButton);
            this.Name = "AdInterface";
            this.Text = "Admin Main";
            this.Load += new System.EventHandler(this.AdInterface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdOrderMgmtButton;
        private System.Windows.Forms.Button PrCatMgmt;
        private System.Windows.Forms.Button ReviewModButton;
        private System.Windows.Forms.Button AdReportButton;
        private System.Windows.Forms.Button AdSellCust;
        private System.Windows.Forms.Button Logout;
    }
}