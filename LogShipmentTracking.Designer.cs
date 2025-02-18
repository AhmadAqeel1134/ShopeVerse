namespace Project
{
    partial class LogShipmentTracking
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
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AssignedToComboBox = new System.Windows.Forms.ComboBox();
            this.EstimatedDeliveryPicker = new System.Windows.Forms.DateTimePicker();
            this.AssignButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShipmentsGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ActualDeliveryPicker = new System.Windows.Forms.DateTimePicker();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentsGridView)).BeginInit();
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
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AssignButton);
            this.tabPage1.Controls.Add(this.EstimatedDeliveryPicker);
            this.tabPage1.Controls.Add(this.AssignedToComboBox);
            this.tabPage1.Controls.Add(this.OrdersGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order Assignment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrdersGridView.Location = new System.Drawing.Point(3, 184);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.Size = new System.Drawing.Size(786, 237);
            this.OrdersGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.UpdateButton);
            this.tabPage2.Controls.Add(this.ActualDeliveryPicker);
            this.tabPage2.Controls.Add(this.StatusComboBox);
            this.tabPage2.Controls.Add(this.ShipmentsGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shipment Tracking";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AssignedToComboBox
            // 
            this.AssignedToComboBox.FormattingEnabled = true;
            this.AssignedToComboBox.Items.AddRange(new object[] {
            "TCS",
            "Leopard\'s Courier",
            "FedEx",
            "M&P",
            "DHL"});
            this.AssignedToComboBox.Location = new System.Drawing.Point(162, 55);
            this.AssignedToComboBox.Name = "AssignedToComboBox";
            this.AssignedToComboBox.Size = new System.Drawing.Size(121, 21);
            this.AssignedToComboBox.TabIndex = 1;
            // 
            // EstimatedDeliveryPicker
            // 
            this.EstimatedDeliveryPicker.Location = new System.Drawing.Point(554, 56);
            this.EstimatedDeliveryPicker.Name = "EstimatedDeliveryPicker";
            this.EstimatedDeliveryPicker.Size = new System.Drawing.Size(213, 20);
            this.EstimatedDeliveryPicker.TabIndex = 2;
            // 
            // AssignButton
            // 
            this.AssignButton.Location = new System.Drawing.Point(355, 124);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(75, 23);
            this.AssignButton.TabIndex = 3;
            this.AssignButton.Text = "Assign";
            this.AssignButton.UseVisualStyleBackColor = true;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Delivery Partner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose Estimated Delivery Date:";
            // 
            // ShipmentsGridView
            // 
            this.ShipmentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShipmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShipmentsGridView.Location = new System.Drawing.Point(3, 231);
            this.ShipmentsGridView.Name = "ShipmentsGridView";
            this.ShipmentsGridView.Size = new System.Drawing.Size(786, 190);
            this.ShipmentsGridView.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choose Actual Delivery Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(350, 157);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ActualDeliveryPicker
            // 
            this.ActualDeliveryPicker.Location = new System.Drawing.Point(526, 89);
            this.ActualDeliveryPicker.Name = "ActualDeliveryPicker";
            this.ActualDeliveryPicker.Size = new System.Drawing.Size(213, 20);
            this.ActualDeliveryPicker.TabIndex = 7;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Shipped",
            "Delivered",
            "Cancelled"});
            this.StatusComboBox.Location = new System.Drawing.Point(134, 88);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 6;
            // 
            // ShipmentTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ShipmentTracking";
            this.Text = "ShipmentTracking";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.DateTimePicker EstimatedDeliveryPicker;
        private System.Windows.Forms.ComboBox AssignedToComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ShipmentsGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DateTimePicker ActualDeliveryPicker;
        private System.Windows.Forms.ComboBox StatusComboBox;
    }
}