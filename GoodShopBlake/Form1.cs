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
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variables
                double Pepe, Spongegar, Datboi, Arthur, HST;
                double sum, product, difference;

                //Variable assignment
                Pepe = 3.99;
                Spongegar = 2.49;
                Datboi = 0.99;
                Arthur = 5.99;
                HST = .13;
            }
            catch
            {

            }
        }
    }
}
