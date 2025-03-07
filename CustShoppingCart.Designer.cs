﻿namespace Project
{
    partial class CustShoppingCart
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
            this.CartGridView = new System.Windows.Forms.DataGridView();
            this.RemoveButt = new System.Windows.Forms.Button();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.CheckoutButt = new System.Windows.Forms.Button();
            this.BackButt = new System.Windows.Forms.Button();
            this.PaymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShippingMethodComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CartGridView
            // 
            this.CartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGridView.Location = new System.Drawing.Point(16, 84);
            this.CartGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CartGridView.Name = "CartGridView";
            this.CartGridView.ReadOnly = true;
            this.CartGridView.RowHeadersWidth = 51;
            this.CartGridView.Size = new System.Drawing.Size(1035, 229);
            this.CartGridView.TabIndex = 0;
            this.CartGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartGridView_CellContentClick);
            // 
            // RemoveButt
            // 
            this.RemoveButt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButt.Location = new System.Drawing.Point(20, 343);
            this.RemoveButt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveButt.Name = "RemoveButt";
            this.RemoveButt.Size = new System.Drawing.Size(99, 28);
            this.RemoveButt.TabIndex = 1;
            this.RemoveButt.Text = "Remove";
            this.RemoveButt.UseVisualStyleBackColor = true;
            this.RemoveButt.Click += new System.EventHandler(this.RemoveButt_Click);
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLbl.Location = new System.Drawing.Point(829, 450);
            this.TotalPriceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(85, 19);
            this.TotalPriceLbl.TabIndex = 3;
            this.TotalPriceLbl.Text = "Total Price";
            this.TotalPriceLbl.Click += new System.EventHandler(this.TotalPriceLbl_Click);
            // 
            // CheckoutButt
            // 
            this.CheckoutButt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutButt.Location = new System.Drawing.Point(833, 474);
            this.CheckoutButt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckoutButt.Name = "CheckoutButt";
            this.CheckoutButt.Size = new System.Drawing.Size(200, 28);
            this.CheckoutButt.TabIndex = 5;
            this.CheckoutButt.Text = "Proceed To Checkout";
            this.CheckoutButt.UseVisualStyleBackColor = true;
            this.CheckoutButt.Click += new System.EventHandler(this.CheckoutButt_Click);
            // 
            // BackButt
            // 
            this.BackButt.Location = new System.Drawing.Point(37, 27);
            this.BackButt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButt.Name = "BackButt";
            this.BackButt.Size = new System.Drawing.Size(100, 28);
            this.BackButt.TabIndex = 6;
            this.BackButt.Text = "< Back";
            this.BackButt.UseVisualStyleBackColor = true;
            this.BackButt.Click += new System.EventHandler(this.BackButt_Click);
            // 
            // PaymentMethodComboBox
            // 
            this.PaymentMethodComboBox.FormattingEnabled = true;
            this.PaymentMethodComboBox.Items.AddRange(new object[] {
            "Credit Card",
            "PayPal",
            "Cash on Delivery"});
            this.PaymentMethodComboBox.Location = new System.Drawing.Point(16, 476);
            this.PaymentMethodComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PaymentMethodComboBox.Name = "PaymentMethodComboBox";
            this.PaymentMethodComboBox.Size = new System.Drawing.Size(160, 24);
            this.PaymentMethodComboBox.TabIndex = 7;
            this.PaymentMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.PaymentMethodComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 450);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payment Method:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 450);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Shipping Method:";
            // 
            // ShippingMethodComboBox
            // 
            this.ShippingMethodComboBox.FormattingEnabled = true;
            this.ShippingMethodComboBox.Items.AddRange(new object[] {
            "Standard",
            "Express",
            "Next-Day Delivery"});
            this.ShippingMethodComboBox.Location = new System.Drawing.Point(271, 476);
            this.ShippingMethodComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShippingMethodComboBox.Name = "ShippingMethodComboBox";
            this.ShippingMethodComboBox.Size = new System.Drawing.Size(173, 24);
            this.ShippingMethodComboBox.TabIndex = 9;
            this.ShippingMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.ShippingMethodComboBox_SelectedIndexChanged);
            // 
            // CustShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShippingMethodComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaymentMethodComboBox);
            this.Controls.Add(this.BackButt);
            this.Controls.Add(this.CheckoutButt);
            this.Controls.Add(this.TotalPriceLbl);
            this.Controls.Add(this.RemoveButt);
            this.Controls.Add(this.CartGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustShoppingCart";
            this.Text = "Shopping Cart";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CartGridView;
        private System.Windows.Forms.Button RemoveButt;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.Button CheckoutButt;
        private System.Windows.Forms.Button BackButt;
        private System.Windows.Forms.ComboBox PaymentMethodComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ShippingMethodComboBox;
    }
}