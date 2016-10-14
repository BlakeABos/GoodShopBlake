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
        double subtotal, product, total, tendered, change;
        //Variable assignment
        const double PEPE_COST = 3.99;
        const double SPONGEGAR_COST = 2.49;
        const double DATBOI_COST = 0.99;
        const double ARTHUR_COST = 5.99;
        const double HST = .13;


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //declaring brushes
            Graphics formGraphics = memelordBox.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen drawPen = new Pen(Color.Black);
            Pen drawPen2 = new Pen(Color.White);
            Font drawFont = new Font("PT Serif", 16, FontStyle.Bold);
            memelordBox.Visible = false;
            formGraphics.DrawRectangle(drawPen2, 700, 30, 100, 200);
           

        }
 
        private void receiptButton_Click(object sender, EventArgs e)
        {

            //declaring brushes
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen drawPen = new Pen(Color.Black);
            Pen drawPen2 = new Pen(Color.White);
            Font drawFont = new Font("PT Serif", 16, FontStyle.Bold);
            memelordBox.Visible = false;
            formGraphics.DrawRectangle(drawPen2, 600, 30, 100, 200);



        }


        private void changeButton_Click(object sender, EventArgs e)
        {
            int tendered;
            tendered = Convert.ToInt32(tenderedBox.Text);
            change = tendered - total;
            changeOutcome.Text = change.ToString("C");
            total = product + subtotal;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                int pepe, spongegar, datboi,arthur;

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
