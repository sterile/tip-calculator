/*
 * Grading ID: M5477
 * Lab: 2
 * Due Date: Feb 4 2019
 * Course Section: 01
 * Description: A GUI application that helps a user calculate a tip based on their input.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip_calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
