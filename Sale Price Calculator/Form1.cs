//Sabrina Turney
//C# I
//Sale Price Calculator Tutorial: 3-5
//Last edited: August 30, 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        //enter the constants for the cents here:
        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TEN_CENTS_VALUE = 0.10m;
        const decimal TWENTY_FIVE_CENTS_VALUE = 0.25m;
        const decimal FIFTY_CENTS_VALUE = 0.50m;

        //private decimal initialized early here to hold total:
        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Adds five cents to the total box, displays the total.
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIVE_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        //Adds ten cents to the total box, displays the total.
        private void TenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        //Adds twenty five cents to the total box, displays the total.
        private void TwentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TWENTY_FIVE_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        //Adds fifty cents to the total box, displays the total.
        private void FiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        //This is the exit button being called, closing the program.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
