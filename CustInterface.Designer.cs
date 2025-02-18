namespace Project
{
    partial class CustInterface
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
            this.ProfileMgmt = new System.Windows.Forms.Button();
            this.ReviewOrd = new System.Windows.Forms.Button();
            this.ViewCart = new System.Windows.Forms.Button();
            this.PrSearch = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProfileMgmt
            // 
            this.ProfileMgmt.CausesValidation = false;
            this.ProfileMgmt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileMgmt.Location = new System.Drawing.Point(146, 327);
            this.ProfileMgmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProfileMgmt.Name = "ProfileMgmt";
            this.ProfileMgmt.Size = new System.Drawing.Size(255, 73);
            this.ProfileMgmt.TabIndex = 10;
            this.ProfileMgmt.Text = "Manage Profile";
            this.ProfileMgmt.UseVisualStyleBackColor = true;
            this.ProfileMgmt.Click += new System.EventHandler(this.ProfileMgmt_Click);
            // 
            // ReviewOrd
            // 
            this.ReviewOrd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewOrd.Location = new System.Drawing.Point(146, 246);
            this.ReviewOrd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReviewOrd.Name = "ReviewOrd";
            this.ReviewOrd.Size = new System.Drawing.Size(255, 73);
            this.ReviewOrd.TabIndex = 9;
            this.ReviewOrd.Text = "Review Orders";
            this.ReviewOrd.UseVisualStyleBackColor = true;
            this.ReviewOrd.Click += new System.EventHandler(this.ReviewOrd_Click);
            // 
            // ViewCart
            // 
            this.ViewCart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCart.Location = new System.Drawing.Point(146, 165);
            this.ViewCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewCart.Name = "ViewCart";
            this.ViewCart.Size = new System.Drawing.Size(255, 73);
            this.ViewCart.TabIndex = 8;
            this.ViewCart.Text = "View Cart";
            this.ViewCart.UseVisualStyleBackColor = true;
            this.ViewCart.Click += new System.EventHandler(this.ViewCart_Click);
            // 
            // PrSearch
            // 
            this.PrSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrSearch.Location = new System.Drawing.Point(146, 84);
            this.PrSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrSearch.Name = "PrSearch";
            this.PrSearch.Size = new System.Drawing.Size(255, 73);
            this.PrSearch.TabIndex = 7;
            this.PrSearch.Text = "Product Search";
            this.PrSearch.UseVisualStyleBackColor = true;
            this.PrSearch.Click += new System.EventHandler(this.PrSearch_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LogOutButton.Location = new System.Drawing.Point(213, 463);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(103, 36);
            this.LogOutButton.TabIndex = 11;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // CustInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(547, 582);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ProfileMgmt);
            this.Controls.Add(this.ReviewOrd);
            this.Controls.Add(this.ViewCart);
            this.Controls.Add(this.PrSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustInterface";
            this.Text = "Customer Interface";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ProfileMgmt;
        private System.Windows.Forms.Button ReviewOrd;
        private System.Windows.Forms.Button ViewCart;
        private System.Windows.Forms.Button PrSearch;
        private System.Windows.Forms.Button LogOutButton;
    }
}