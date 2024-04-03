using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch1_IntroProgramming
{
    public partial class IceCreamCost : Form
    {
        public IceCreamCost()
        {
            InitializeComponent();
        }

        private void btnComputeCost_Click(object sender, EventArgs e)
        {
            // Compute the total cost for an order of icecream; 

            // Declare variables to hold input data and computed results 
            int scoops;
            double unitPrice, cost;

            // The following initializations will cause errors: 
            // scoops = 1.5; 
            // Reason: assigning type decimal to type int 

            //cost = $3.95; 
            // Reason: using invalid characture, $

            //unitPrice = 1,575.50;
            // Reason: using invalid charature, a comma 

            //cost = "3.95"; 
            // Reason: assinging type string to type double 

            // Get input data from Text Boxes: 
            //scoops = int.Parse(txtScoops.Text);
            // The above line is similar to the following line. The following line is using the .NET Convert class
            scoops = Convert.ToInt32(txtScoops.Text);

            //unitPrice = double.Parse(txtUnitPrice.Text);
                // The above line is similar to the following line. The line below is using the .NET Convert class
            unitPrice = Convert.ToDouble(txtUnitPrice.Text);

            // Compute result 
            cost = unitPrice * scoops; 

            // Display Result 
            lblCost.Text = cost.ToString("C");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
