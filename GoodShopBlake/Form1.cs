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
using System.Threading; 

namespace GoodShopBlake
{
    public partial class Form1 : Form
    {
        // global variables
        //declare variables
        double subtotal, product, total,tendered, change;
        //Variable assignment
        const double PEPE_COST = 3.99;
        const double SPONGEGAR_COST = 2.49;
        const double DATBOI_COST = 0.99;
        const double ARTHUR_COST = 5.99;
        const double HST = .13;

        int pepe, spongegar, datboi, arthur;

        int orderNum = 1;
       
         private void newButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen fillPen = new Pen(Color.White);
            formGraphics.DrawRectangle(fillPen, 450, 0, 500, 500);
            formGraphics.FillRectangle(drawBrush, 450, 0, 500, 500);
            pepeBox.Text = "0";
            spongeBox.Text = "0";
            arthurBox.Text = "0";
            datboiBox.Text = "0";
            subtotalOutcome.Text = "";
            taxOutcome.Text = "";
            totalOutcome.Text = "";
            tenderedBox.Text = "";
            changeOutcome.Text = "";

        }

        public Form1()
        {
            InitializeComponent();
            //making labels invisable for now
            codeBox.Visible = false;
            zeroLabel.Visible = false;
            newButton.Visible = false;
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //Wasnt Able to find any sounds ....
            //declaring brushes
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            SolidBrush fontBrush = new SolidBrush(Color.Black);
            Pen fillPen = new Pen(Color.White);
            Font titleFont = new Font("PT Serif", 14, FontStyle.Bold);
            Font otherFont = new Font("PT Serif", 10, FontStyle.Bold);

            memelordBox.Visible = false;
            newButton.Visible = true;
            
            //making the reciept
            formGraphics.DrawRectangle(fillPen, 450, 0, 500, 500);
            formGraphics.FillRectangle(drawBrush, 450, 0, 500, 500);

            //start of reciept 
            formGraphics.DrawString("Blake's Dank Meme Shop!", titleFont, fontBrush, 480, 30);
            Thread.Sleep(1000);
            formGraphics.DrawString("Order Number : " + orderNum, otherFont, fontBrush, 490, 60);
            Thread.Sleep(1000);
            formGraphics.DrawString("October 17th , 2016", otherFont, fontBrush, 490, 75);
            Thread.Sleep(1000);
            formGraphics.DrawString("Rare Pepe x" +pepe+ "@3.99", otherFont, fontBrush, 490, 110);
            Thread.Sleep(1000);
            formGraphics.DrawString("Spongegar x" + spongegar + "@2.49", otherFont, fontBrush, 490, 125);
            Thread.Sleep(1000);
            formGraphics.DrawString("Dat Boi x" + datboi + "@0.99", otherFont, fontBrush, 490, 140);
            Thread.Sleep(1000);
            formGraphics.DrawString("Arthur x" + arthur + "@5.99", otherFont, fontBrush, 490, 155);
            Thread.Sleep(1000);
            formGraphics.DrawString("Subtotal " + subtotal.ToString("C"), otherFont, fontBrush, 490, 190);
            Thread.Sleep(1000);
            formGraphics.DrawString("Tax " + product.ToString("C"), otherFont, fontBrush, 490, 205);
            Thread.Sleep(1000);
            formGraphics.DrawString("Total " + total.ToString("C"), otherFont, fontBrush, 490, 220);
            Thread.Sleep(1000);
            formGraphics.DrawString("Thanks For Shopping ,\nHope to see you again soon!", otherFont, fontBrush, 490, 250);

            orderNum++;

        }


        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //math for change
                double tendered;
                tendered = Convert.ToDouble(tenderedBox.Text);
                change = tendered - total;
                changeOutcome.Text = change.ToString("C");
                total = product + subtotal;
            }
            catch { zeroLabel.Text = "PLEASE ENTER A NUMBER IN THE CHANGE BOX!"; }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {  //the math
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
                //stopping from crashing
                zeroLabel.Visible = true;
                zeroLabel.Text = "Please enter a 0 in products you dont want";
            }
        }
    }
}
