using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Recipe_Calculator
{
    public partial class RecipeCalculator : Form
    {
        public RecipeCalculator()
        {
            InitializeComponent();
        }

        private void RecipeCalculator_Load(object sender, EventArgs e)
        {

        }

        private void Hopper_Recipe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For a Hopper you need pizza");
        }

        /*private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }*/
    }
}
