using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AdInterface : Form
    {
        public AdInterface()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MainMenu F = new MainMenu();
            F.Show();
            this.Close();
        }

        private void AdOrderMgmtButton_Click(object sender, EventArgs e)
        {
            AdOrderMgmt F = new AdOrderMgmt();
            F.Show();
            this.Hide();
        }

        private void PrCatMgmt_Click(object sender, EventArgs e)
        {
            AdProductCategoryMgmt F = new AdProductCategoryMgmt();
            F.Show();
            this.Hide();
        }

        private void ReviewModButton_Click(object sender, EventArgs e)
        {
            AdReviewMod F = new AdReviewMod();
            F.Show();
            this.Hide();
        }

        private void AdSellCust_Click(object sender, EventArgs e)
        {
            AdSellerCustomerMgmt F = new AdSellerCustomerMgmt();
            F.Show();
            this.Hide();
        }

        private void AdReportButton_Click(object sender, EventArgs e)
        {
            AdReports F = new AdReports();
            F.Show();
            this.Hide();
        }
    }
}
