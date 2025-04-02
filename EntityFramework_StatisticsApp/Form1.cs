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

        }
    }
}
