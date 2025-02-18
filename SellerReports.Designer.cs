namespace Project
{
    partial class SellerReports
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
            this.SalesReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // SalesReportViewer
            // 
            this.SalesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesReportViewer.Location = new System.Drawing.Point(0, 0);
            this.SalesReportViewer.Name = "SalesReportViewer";
            this.SalesReportViewer.ServerReport.BearerToken = null;
            this.SalesReportViewer.Size = new System.Drawing.Size(800, 450);
            this.SalesReportViewer.TabIndex = 0;
            this.SalesReportViewer.Load += new System.EventHandler(this.SalesReportViewer_Load);
            // 
            // SellerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalesReportViewer);
            this.Name = "SellerReports";
            this.Text = "Seller Reports";
            this.Load += new System.EventHandler(this.SellerReports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer SalesReportViewer;
    }
}