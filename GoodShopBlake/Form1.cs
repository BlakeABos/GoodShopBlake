//Made By Blake Bos on Oct 12th 
//purpose is to simulate a cash register
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodShopBlake
{
    public partial class Form1 : Form
    {
        // global variables
        //declare variables
        double subtotal, product, total;
        //Variable assignment
        const double PEPE_COST = 3.99;
        const double SPONGEGAR_COST = 2.49;
        const double DATBOI = 0.99;
        const double ARTHUR = 5.99;
        const double HST = .13;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variables
                double subtotal, product, total;
                //Variable assignment
                const double PEPE_COST = 3.99;
                const double SPONGEGAR_COST = 2.49;
                const double DATBOI_COST = 0.99;
                const double ARTHUR_COST = 5.99;
                const double HST = .13;

                int pepe, spongegar, datboi,arthur,hst;

                pepe = Convert.ToInt32(pepeBox.Text);
                spongegar = Convert.ToInt32(spongeBox.Text);
                datboi = Convert.ToInt32(datboiBox.Text);
                arthur = Convert.ToInt32(arthurBox.Text);

                subtotal = PEPE_COST * pepe + SPONGEGAR_COST * spongegar +  DATBOI_COST * datboi + ARTHUR_COST * arthur;
                subtotalOutcome.Text = subtotal.ToString("C");

                product = subtotal * HST;
                taxOutcome.Text = product.ToString("C");

                total = product + subtotal;
                totalOutcome.Text = total.ToString("C");
            }
            catch
            {

            }
        }
    }
}
