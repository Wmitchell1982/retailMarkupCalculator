using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Program Name: Retail Markup Calculator Ver 1.0
 * Programers: William Mitchell and Kyle Cantor
 * Course: POS/409
 * Instructor: Dr Brad Purdy
 * Date: January 9, 2014
 * Description: Calculates retail price based on wholesale price and markup percentage
 * */
namespace RetailMarkupCalculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        //calculate retail function returns a decimal value
        private decimal calculateRetail(decimal wholesale, double percent)
        {
            decimal retail = wholesale * ((decimal)1.0 + ((decimal)percent / (decimal)100.00));
            return retail;
        }

        //takes user input and calculates and displays retail price
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal retailPrice = calculateRetail(decimal.Parse(this.tbWholsale.Text), double.Parse(this.tbMarkup.Text));
                this.lblResults.Text = "Item Retail cost is " + retailPrice.ToString("C"); 
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }


    }
}
