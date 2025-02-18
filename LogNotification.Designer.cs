namespace Project
{
    partial class LogNotification
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
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.DeliveryGridView = new System.Windows.Forms.DataGridView();
            this.NotifyButton = new System.Windows.Forms.Button();
            this.DeliveryStatusComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationLabel.Location = new System.Drawing.Point(314, 46);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(196, 27);
            this.NotificationLabel.TabIndex = 0;
            this.NotificationLabel.Text = "Notify Customers";
            // 
            // DeliveryGridView
            // 
            this.DeliveryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeliveryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeliveryGridView.Location = new System.Drawing.Point(0, 240);
            this.DeliveryGridView.Name = "DeliveryGridView";
            this.DeliveryGridView.Size = new System.Drawing.Size(800, 210);
            this.DeliveryGridView.TabIndex = 1;
            // 
            // NotifyButton
            // 
            this.NotifyButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotifyButton.Location = new System.Drawing.Point(515, 141);
            this.NotifyButton.Name = "NotifyButton";
            this.NotifyButton.Size = new System.Drawing.Size(75, 23);
            this.NotifyButton.TabIndex = 2;
            this.NotifyButton.Text = "Notify";
            this.NotifyButton.UseVisualStyleBackColor = true;
            this.NotifyButton.Click += new System.EventHandler(this.NotifyButton_Click);
            // 
            // DeliveryStatusComboBox
            // 
            this.DeliveryStatusComboBox.FormattingEnabled = true;
            this.DeliveryStatusComboBox.Location = new System.Drawing.Point(221, 143);
            this.DeliveryStatusComboBox.Name = "DeliveryStatusComboBox";
            this.DeliveryStatusComboBox.Size = new System.Drawing.Size(263, 21);
            this.DeliveryStatusComboBox.TabIndex = 3;
            this.DeliveryStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryStatusComboBox_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeliveryStatusComboBox);
            this.Controls.Add(this.NotifyButton);
            this.Controls.Add(this.DeliveryGridView);
            this.Controls.Add(this.NotificationLabel);
            this.Name = "LogNotification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.DataGridView DeliveryGridView;
        private System.Windows.Forms.Button NotifyButton;
        private System.Windows.Forms.ComboBox DeliveryStatusComboBox;
        private System.Windows.Forms.Button BackButton;
    }
}