using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppUnitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateAdd_Click(object sender, EventArgs e)
        {
            RekenMachine rekenmachine = new RekenMachine();
            int result = rekenmachine.Add(int.Parse(txtFirstnum.Text), int.Parse(txtSecondnum.Text));
            lblResult.Text = result.ToString();
        }

        private void btnCalcSub_Click(object sender, EventArgs e)
        {
            RekenMachine rekenmachine = new RekenMachine();
            int result = rekenmachine.Sub(int.Parse(txtFirstnum.Text), int.Parse(txtSecondnum.Text));
            lblResult.Text = result.ToString();
        }

        private void btnCalcDiv_Click(object sender, EventArgs e)
        {
            RekenMachine rekenmachine = new RekenMachine();
            int result = rekenmachine.Div(int.Parse(txtFirstnum.Text), int.Parse(txtSecondnum.Text));
            lblResult.Text = result.ToString();
        }

        private void btnCalcMult_Click(object sender, EventArgs e)
        {
            RekenMachine rekenmachine = new RekenMachine();
            int result = rekenmachine.Mult(int.Parse(txtFirstnum.Text), int.Parse(txtSecondnum.Text));
            lblResult.Text = result.ToString();
        }
    }
}
