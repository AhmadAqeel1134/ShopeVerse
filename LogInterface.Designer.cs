namespace Project
{
    partial class LogInterface
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
            this.Logout = new System.Windows.Forms.Button();
            this.ShipmentTrackButton = new System.Windows.Forms.Button();
            this.TrackOrdersButton = new System.Windows.Forms.Button();
            this.NotifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(12, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ShipmentTrackButton
            // 
            this.ShipmentTrackButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipmentTrackButton.Location = new System.Drawing.Point(73, 277);
            this.ShipmentTrackButton.Name = "ShipmentTrackButton";
            this.ShipmentTrackButton.Size = new System.Drawing.Size(278, 45);
            this.ShipmentTrackButton.TabIndex = 9;
            this.ShipmentTrackButton.Text = "Track Shipment";
            this.ShipmentTrackButton.UseVisualStyleBackColor = true;
            // 
            // TrackOrdersButton
            // 
            this.TrackOrdersButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackOrdersButton.Location = new System.Drawing.Point(73, 201);
            this.TrackOrdersButton.Name = "TrackOrdersButton";
            this.TrackOrdersButton.Size = new System.Drawing.Size(278, 45);
            this.TrackOrdersButton.TabIndex = 8;
            this.TrackOrdersButton.Text = "Track Orders";
            this.TrackOrdersButton.UseVisualStyleBackColor = true;
            // 
            // NotifyButton
            // 
            this.NotifyButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotifyButton.Location = new System.Drawing.Point(73, 126);
            this.NotifyButton.Name = "NotifyButton";
            this.NotifyButton.Size = new System.Drawing.Size(278, 45);
            this.NotifyButton.TabIndex = 7;
            this.NotifyButton.Text = "Notification Panel";
            this.NotifyButton.UseVisualStyleBackColor = true;
            // 
            // LogInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ShipmentTrackButton);
            this.Controls.Add(this.TrackOrdersButton);
            this.Controls.Add(this.NotifyButton);
            this.Name = "LogInterface";
            this.Text = "Logistics Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button ShipmentTrackButton;
        private System.Windows.Forms.Button TrackOrdersButton;
        private System.Windows.Forms.Button NotifyButton;
    }
}