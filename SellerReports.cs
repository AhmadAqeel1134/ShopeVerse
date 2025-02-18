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
    public partial class SellerReports : Form
    {
        public SellerReports()
        {
            InitializeComponent();
        }

        private void SellerReports_Load(object sender, EventArgs e)
        {

            this.SalesReportViewer.RefreshReport();
        }

        private void SalesReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
