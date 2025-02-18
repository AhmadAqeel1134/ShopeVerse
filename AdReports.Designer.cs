namespace Project
{
    partial class AdReports
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
            this.SandP = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.totalSale = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.averageOrderValue = new System.Windows.Forms.TabPage();
            this.bestSell = new System.Windows.Forms.TabPage();
            this.TopCat = new System.Windows.Forms.TabPage();
            this.Rev = new System.Windows.Forms.TabPage();
            this.CustInsights = new System.Windows.Forms.TabPage();
            this.PlatGrowth = new System.Windows.Forms.TabPage();
            this.DemographicReport = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SandP.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.totalSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SandP);
            this.tabControl1.Controls.Add(this.Rev);
            this.tabControl1.Controls.Add(this.CustInsights);
            this.tabControl1.Controls.Add(this.PlatGrowth);
            this.tabControl1.Controls.Add(this.DemographicReport);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // SandP
            // 
            this.SandP.Controls.Add(this.tabControl2);
            this.SandP.Location = new System.Drawing.Point(4, 22);
            this.SandP.Name = "SandP";
            this.SandP.Padding = new System.Windows.Forms.Padding(3);
            this.SandP.Size = new System.Drawing.Size(792, 424);
            this.SandP.TabIndex = 0;
            this.SandP.Text = "Sales and Performance";
            this.SandP.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.totalSale);
            this.tabControl2.Controls.Add(this.averageOrderValue);
            this.tabControl2.Controls.Add(this.bestSell);
            this.tabControl2.Controls.Add(this.TopCat);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(786, 418);
            this.tabControl2.TabIndex = 0;
            // 
            // totalSale
            // 
            this.totalSale.Controls.Add(this.reportViewer1);
            this.totalSale.Location = new System.Drawing.Point(4, 22);
            this.totalSale.Name = "totalSale";
            this.totalSale.Padding = new System.Windows.Forms.Padding(3);
            this.totalSale.Size = new System.Drawing.Size(778, 392);
            this.totalSale.TabIndex = 0;
            this.totalSale.Text = "Total Sales";
            this.totalSale.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project.TotalSales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(772, 386);
            this.reportViewer1.TabIndex = 0;
            // 
            // averageOrderValue
            // 
            this.averageOrderValue.Location = new System.Drawing.Point(4, 22);
            this.averageOrderValue.Name = "averageOrderValue";
            this.averageOrderValue.Padding = new System.Windows.Forms.Padding(3);
            this.averageOrderValue.Size = new System.Drawing.Size(778, 392);
            this.averageOrderValue.TabIndex = 1;
            this.averageOrderValue.Text = "Average Order Value";
            this.averageOrderValue.UseVisualStyleBackColor = true;
            // 
            // bestSell
            // 
            this.bestSell.Location = new System.Drawing.Point(4, 22);
            this.bestSell.Name = "bestSell";
            this.bestSell.Size = new System.Drawing.Size(778, 392);
            this.bestSell.TabIndex = 2;
            this.bestSell.Text = "Best-Selling Products";
            this.bestSell.UseVisualStyleBackColor = true;
            // 
            // TopCat
            // 
            this.TopCat.Location = new System.Drawing.Point(4, 22);
            this.TopCat.Name = "TopCat";
            this.TopCat.Size = new System.Drawing.Size(778, 392);
            this.TopCat.TabIndex = 3;
            this.TopCat.Text = "Top Categories";
            this.TopCat.UseVisualStyleBackColor = true;
            // 
            // Rev
            // 
            this.Rev.Location = new System.Drawing.Point(4, 22);
            this.Rev.Name = "Rev";
            this.Rev.Size = new System.Drawing.Size(792, 424);
            this.Rev.TabIndex = 3;
            this.Rev.Text = "Revenue";
            this.Rev.UseVisualStyleBackColor = true;
            // 
            // CustInsights
            // 
            this.CustInsights.Location = new System.Drawing.Point(4, 22);
            this.CustInsights.Name = "CustInsights";
            this.CustInsights.Padding = new System.Windows.Forms.Padding(3);
            this.CustInsights.Size = new System.Drawing.Size(792, 424);
            this.CustInsights.TabIndex = 1;
            this.CustInsights.Text = "Customer Insights";
            this.CustInsights.UseVisualStyleBackColor = true;
            // 
            // PlatGrowth
            // 
            this.PlatGrowth.Location = new System.Drawing.Point(4, 22);
            this.PlatGrowth.Name = "PlatGrowth";
            this.PlatGrowth.Size = new System.Drawing.Size(792, 424);
            this.PlatGrowth.TabIndex = 2;
            this.PlatGrowth.Text = "Platform Growth";
            this.PlatGrowth.UseVisualStyleBackColor = true;
            // 
            // DemographicReport
            // 
            this.DemographicReport.Location = new System.Drawing.Point(4, 22);
            this.DemographicReport.Name = "DemographicReport";
            this.DemographicReport.Size = new System.Drawing.Size(792, 424);
            this.DemographicReport.TabIndex = 4;
            this.DemographicReport.Text = "Demographics";
            this.DemographicReport.UseVisualStyleBackColor = true;
            // 
            // AdReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdReports";
            this.Text = "AdReports";
            this.Load += new System.EventHandler(this.AdReports_Load);
            this.tabControl1.ResumeLayout(false);
            this.SandP.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.totalSale.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SandP;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage totalSale;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage averageOrderValue;
        private System.Windows.Forms.TabPage bestSell;
        private System.Windows.Forms.TabPage TopCat;
        private System.Windows.Forms.TabPage Rev;
        private System.Windows.Forms.TabPage CustInsights;
        private System.Windows.Forms.TabPage PlatGrowth;
        private System.Windows.Forms.TabPage DemographicReport;
    }
}