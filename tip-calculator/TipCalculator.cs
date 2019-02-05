/*
 * Grading ID: M5477
 * Lab: 2
 * Due Date: Feb 4 2019
 * Course Section: 01
 * Description: A GUI application that helps a user calculate a tip based on their input.
 */
 
using System;
using System.Windows.Forms;

namespace tip_calculator
{
    public partial class TipCalculator : Form
    {
        // Initializes the form
        public TipCalculator()
        {
            InitializeComponent();
        }

        // Handler for when a user clicks our button
        private void calcTipBtn_Click(object sender, EventArgs e)
        {
            const double LOW_TIP = .15, MID_TIP = .18, HIGH_TIP = .20; // Constant values for tip percentages in decimal format
            double lowTipRec, midTipRec, highTipRec; // Undeclared variables that will store the tip recommendations based on tip percentage
            double cost; // Undeclared variable that will be set when the price is grabbed from the mealPrice object

            cost = Convert.ToDouble(mealPrice.Text);

            lowTipRec = cost * LOW_TIP;
            midTipRec = cost * MID_TIP;
            highTipRec = cost * HIGH_TIP;

            lowTipAmt.Text = $"{lowTipRec:C}";
            midTipAmt.Text = $"{midTipRec:C}";
            highTipAmt.Text = $"{highTipRec:C}";

            lowTipAmt.Visible = true;
            midTipAmt.Visible = true;
            highTipAmt.Visible = true;
        }
    }
}
