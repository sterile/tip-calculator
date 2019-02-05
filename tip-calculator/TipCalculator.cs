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
            const double LOW_TIP = .15, // Constant values for low tip percentage in decimal format
                MID_TIP = .18, // Constant values for mid-level tip percentage in decimal format
                HIGH_TIP = .20; // Constant values for high tip percentage in decimal format

            double lowTipRec, // Undeclared variables that will store the low tip recommendation based on tip percentage
                midTipRec, // Undeclared variables that will store the mid-level tip recommendation based on tip percentage
                highTipRec; // Undeclared variables that will store the high tip recommendation based on tip percentage

            double cost; // Undeclared variable that will be set when the price is grabbed from the mealPrice object

            // Grab price from user
            cost = Convert.ToDouble(mealPrice.Text);

            // Calculate tips
            lowTipRec = cost * LOW_TIP;
            midTipRec = cost * MID_TIP;
            highTipRec = cost * HIGH_TIP;

            // Reflect changes in form
            lowTipAmt.Text = $"{lowTipRec:C}";
            midTipAmt.Text = $"{midTipRec:C}";
            highTipAmt.Text = $"{highTipRec:C}";

            // Make labels visible
            lowTipAmt.Visible = true;
            midTipAmt.Visible = true;
            highTipAmt.Visible = true;
        }
    }
}
