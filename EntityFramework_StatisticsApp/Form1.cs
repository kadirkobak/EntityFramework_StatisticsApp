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
            // Category count statistics
            int categoryCount = db.TblCategory.Count();
            lblCategoryCount.Text = categoryCount.ToString();

            // Product count statistics
            int productCount = db.TblProduct.Count();
            lblProductCount.Text = productCount.ToString();

            // Customer count statistics
            int customerCount = db.TblCustomer.Count();
            lblCustomerCount.Text = customerCount.ToString();

            // Order count statistics
            int orderCount = db.TblOrder.Count();
            lblOrderCount.Text = orderCount.ToString();

            // Total product stock statistics
            var totalProductStockCount = db.TblProduct.Sum(x => x.ProductStock);
            lblTotalStockCount.Text = totalProductStockCount.ToString();

            // Average product price statistics
            var averageProductPrice = db.TblProduct.Average(x => x.ProductPrice);
            lblAverageProductPrice.Text = averageProductPrice.ToString();

            //Total fruits stock statistics
            var totalFruitsStock = db.TblProduct.Where(x => x.CategoryId == 4).Sum(x => x.ProductStock);
            lblTotalFruitsStock.Text = totalFruitsStock.ToString();

            // Headphones product turnover statistics
            var totalPriceByHeadphonesStock = db.TblProduct.Where(x => x.ProductName == "Kulaklık").Select(y => y.ProductStock).FirstOrDefault();
            var totalPriceByHeadphonesUnitPrice = db.TblProduct.Where(x => x.ProductName == "Kulaklık").Select(y => y.ProductPrice).FirstOrDefault();
            var totalPriceByHeadphones = totalPriceByHeadphonesStock * totalPriceByHeadphonesUnitPrice;  
            lblHeadphonesTurnover.Text = totalPriceByHeadphones.ToString();

        }
    }
}
