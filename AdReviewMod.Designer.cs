namespace Project
{
    partial class AdReviewMod
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
            this.ReviewGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxReviewStatus = new System.Windows.Forms.ComboBox();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.txtRejectionReason = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReviewGridView
            // 
            this.ReviewGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReviewGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ReviewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReviewGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReviewGridView.Location = new System.Drawing.Point(0, 358);
            this.ReviewGridView.Name = "ReviewGridView";
            this.ReviewGridView.Size = new System.Drawing.Size(1037, 215);
            this.ReviewGridView.TabIndex = 0;
            this.ReviewGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReviewGridView_CellContentClick);
            // 
            // comboBoxReviewStatus
            // 
            this.comboBoxReviewStatus.FormattingEnabled = true;
            this.comboBoxReviewStatus.Location = new System.Drawing.Point(411, 51);
            this.comboBoxReviewStatus.Name = "comboBoxReviewStatus";
            this.comboBoxReviewStatus.Size = new System.Drawing.Size(218, 21);
            this.comboBoxReviewStatus.TabIndex = 1;
            this.comboBoxReviewStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxReviewStatus_SelectedIndexChanged);
            // 
            // ApproveButton
            // 
            this.ApproveButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveButton.Location = new System.Drawing.Point(411, 131);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(218, 37);
            this.ApproveButton.TabIndex = 2;
            this.ApproveButton.Text = "Approve";
            this.ApproveButton.UseVisualStyleBackColor = true;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click_1);
            // 
            // RejectButton
            // 
            this.RejectButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejectButton.Location = new System.Drawing.Point(411, 174);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(218, 37);
            this.RejectButton.TabIndex = 3;
            this.RejectButton.Text = "Reject";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click_1);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(411, 217);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(218, 37);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // txtRejectionReason
            // 
            this.txtRejectionReason.Location = new System.Drawing.Point(670, 184);
            this.txtRejectionReason.Name = "txtRejectionReason";
            this.txtRejectionReason.Size = new System.Drawing.Size(203, 20);
            this.txtRejectionReason.TabIndex = 5;
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.Location = new System.Drawing.Point(411, 88);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(218, 37);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(411, 260);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(218, 37);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AdReviewMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1037, 573);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.txtRejectionReason);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.comboBoxReviewStatus);
            this.Controls.Add(this.ReviewGridView);
            this.Name = "AdReviewMod";
            this.Text = "AdReviewMod";
            this.Load += new System.EventHandler(this.AdReviewMod_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ReviewGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReviewGridView;
        private System.Windows.Forms.ComboBox comboBoxReviewStatus;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox txtRejectionReason;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button SaveButton;
    }
}