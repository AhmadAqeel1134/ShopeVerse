namespace Project
{
    partial class SellerInterface
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
            this.AddPr = new System.Windows.Forms.Button();
            this.UpdPr = new System.Windows.Forms.Button();
            this.DelPr = new System.Windows.Forms.Button();
            this.Inv = new System.Windows.Forms.Button();
            this.ViewOrders = new System.Windows.Forms.Button();
            this.OrderStat = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPr
            // 
            this.AddPr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPr.Location = new System.Drawing.Point(74, 65);
            this.AddPr.Name = "AddPr";
            this.AddPr.Size = new System.Drawing.Size(174, 29);
            this.AddPr.TabIndex = 0;
            this.AddPr.Text = "Add Products";
            this.AddPr.UseVisualStyleBackColor = true;
            this.AddPr.Click += new System.EventHandler(this.AddPr_Click);
            // 
            // UpdPr
            // 
            this.UpdPr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdPr.Location = new System.Drawing.Point(74, 109);
            this.UpdPr.Name = "UpdPr";
            this.UpdPr.Size = new System.Drawing.Size(174, 29);
            this.UpdPr.TabIndex = 1;
            this.UpdPr.Text = "Update Products";
            this.UpdPr.UseVisualStyleBackColor = true;
            this.UpdPr.Click += new System.EventHandler(this.UpdPr_Click);
            // 
            // DelPr
            // 
            this.DelPr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelPr.Location = new System.Drawing.Point(74, 153);
            this.DelPr.Name = "DelPr";
            this.DelPr.Size = new System.Drawing.Size(174, 29);
            this.DelPr.TabIndex = 2;
            this.DelPr.Text = "Delete Products";
            this.DelPr.UseVisualStyleBackColor = true;
            this.DelPr.Click += new System.EventHandler(this.DelPr_Click);
            // 
            // Inv
            // 
            this.Inv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inv.Location = new System.Drawing.Point(74, 197);
            this.Inv.Name = "Inv";
            this.Inv.Size = new System.Drawing.Size(174, 29);
            this.Inv.TabIndex = 3;
            this.Inv.Text = "Inventory";
            this.Inv.UseVisualStyleBackColor = true;
            this.Inv.Click += new System.EventHandler(this.Inv_Click);
            // 
            // ViewOrders
            // 
            this.ViewOrders.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewOrders.Location = new System.Drawing.Point(74, 241);
            this.ViewOrders.Name = "ViewOrders";
            this.ViewOrders.Size = new System.Drawing.Size(174, 29);
            this.ViewOrders.TabIndex = 4;
            this.ViewOrders.Text = "View Orders";
            this.ViewOrders.UseVisualStyleBackColor = true;
            this.ViewOrders.Click += new System.EventHandler(this.ViewOrders_Click);
            // 
            // OrderStat
            // 
            this.OrderStat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderStat.Location = new System.Drawing.Point(74, 285);
            this.OrderStat.Name = "OrderStat";
            this.OrderStat.Size = new System.Drawing.Size(174, 29);
            this.OrderStat.TabIndex = 5;
            this.OrderStat.Text = "Update Order Status";
            this.OrderStat.UseVisualStyleBackColor = true;
            this.OrderStat.Click += new System.EventHandler(this.OrderStat_Click);
            // 
            // Report
            // 
            this.Report.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.Location = new System.Drawing.Point(74, 330);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(174, 29);
            this.Report.TabIndex = 6;
            this.Report.Text = "Reports";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(13, 13);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SellerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 391);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.OrderStat);
            this.Controls.Add(this.ViewOrders);
            this.Controls.Add(this.Inv);
            this.Controls.Add(this.DelPr);
            this.Controls.Add(this.UpdPr);
            this.Controls.Add(this.AddPr);
            this.Name = "SellerInterface";
            this.Text = "Seller Interface";
            this.Load += new System.EventHandler(this.SellerInterface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddPr;
        private System.Windows.Forms.Button UpdPr;
        private System.Windows.Forms.Button DelPr;
        private System.Windows.Forms.Button Inv;
        private System.Windows.Forms.Button ViewOrders;
        private System.Windows.Forms.Button OrderStat;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button LogoutButton;
    }
}