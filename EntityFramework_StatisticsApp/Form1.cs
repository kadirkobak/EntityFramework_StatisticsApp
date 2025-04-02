using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_StatisticsApp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbStatisticsProjectEntities db = new DbStatisticsProjectEntities();


        private void Form1_Load(object sender, EventArgs e)
        {
            int categoryCount = db.TblCategory.Count();
            lblCategoryCount.Text = categoryCount.ToString();

            int productCount = db.TblProduct.Count();
            lblProductCount.Text = productCount.ToString();

            int customerCount = db.TblCustomer.Count();
            lblCustomerCount.Text = customerCount.ToString();

            int orderCount = db.TblOrder.Count();
            lblOrderCount.Text = orderCount.ToString();

            var totalProductStockCount = db.TblProduct.Sum(x => x.ProductStock);
            lblTotalStockCount.Text = totalProductStockCount.ToString();
        }
    }
}
