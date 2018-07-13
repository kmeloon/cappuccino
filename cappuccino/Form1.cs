using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cappuccino
{
    //We have a database, and we can edit it... now we just need to find out how to get them to work through C# commands.
    public partial class Form1 : Form
    {
        double price = 0;
        double shots = 0;
        double sizeCost = 0;
        double basePrice=0;
        double total = 0;
   
        public Form1()
        {
            InitializeComponent();
           

        }
        
        private void checkShots()
        {
            //Check boxes for shots decisions.
            if (btnOneShot.Checked)
            {
                shots = .5;
            }
            else if (btnTwoShot.Checked)
            {
                shots = 1;
            }
            else if(btnThreeShot.Checked)
            {
                shots = 1.5;
            }
            else
            {
                shots = 0;
   
            }
            
        }
        private void checkSize()
        {
            //Check boxes for size decisions
            if (btnSmallSize.Checked == true)
            {
                sizeCost = 1.0;

            }
            else if (btnRegularSize.Checked == true)
            {
                sizeCost = 1.5;

            }
            else if (btnLargeSize.Checked == true)
            {
                sizeCost = 2.0;

            }
            

        }
        public void getPrice()
        {
            price = shots + sizeCost + basePrice;
            txtPrice.Text = string.Format("{0:c}", price);
        }
        private void giveDescription()
        {

            if (cappuccinoBtn.Checked)
            {
                basePrice = 1;
        

            }
            if (darkBtn.Checked)
            {
                basePrice = 1.5;


            }
            if (lightBtn.Checked)
            {
                basePrice = 1.5;
  

            }
            if (espressoBtn.Checked)
            {
                basePrice = .5;


            }
            if (frenchBtn.Checked)
            {
                basePrice = 2;


            }
            if (chocolateBtn.Checked)
            {
                basePrice = 2.5;
   

            }
            txtPrice.Text = string.Format("{0:c}", price);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkShots();
            checkSize();
            giveDescription();
            getPrice();
            txtPrice.Text = string.Format("{0:c}", price);
            string dayOfOrder = monthCalendar1.SelectionRange.Start.ToShortDateString();
            //  MessageBox.Show ($"Your price is {price},The order will be completed on {monthCalendar1.SelectionRange.Start.ToShortDateString()}.","Order Summary");
         
            total = total + price;
            txtTotal.Text = string.Format("{0:c}", total);
        //    MessageBox.Show(string.Format("Your total price will be {0:c} and your order is placed for {1}", total, dayOfOrder), "test");

        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {
         


        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {

        }

        private void groupBox2_VisibleChanged(object sender, EventArgs e)
        {
    
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Can use selected Index Changed to determine Price?
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (RadioButton radio in groupBox1.Controls.OfType<RadioButton>().ToList())
            {
                if (radio.Checked == true)
                {

                    radio.Checked = false;
                    break;
                }
            }
            foreach (RadioButton radio in groupBox2.Controls.OfType<RadioButton>().ToList())
            {
                if (radio.Checked == true)
                {
                    radio.Checked = false;
                    break;
                }
                price = 0.00;
                txtPrice.Text = string.Format("{0:c}", price);
                DrinkLabel.Text = null;
            }
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
           // txtPrice.Text = string.Format("{0:c}", price);
        }

        private void cappuccinoBtn_MouseClick(object sender, MouseEventArgs e)
        {
            DrinkLabel.Text = "Cappuccino";
            picBoxCoffee.ImageLocation = "https://www.merriam-webster.com/assets/mw/images/article/art-wap-article-main/cappuccino-2029-e80b7c6d318c7862df2c4c8623a11f99@1x.jpg";
        }

        private void darkBtn_MouseClick(object sender, MouseEventArgs e)
        {
            DrinkLabel.Text = "Dark Roast";
            picBoxCoffee.ImageLocation = "https://cdn.shopify.com/s/files/1/0378/3065/products/Dark_Roasted_600x450_2_f99504ce-9db4-4f97-b2f0-69816bc4dd86_1024x1024.jpg?v=1439011402";
        }

        private void lightBtn_MouseClick(object sender, MouseEventArgs e)
        {
            DrinkLabel.Text = "Light Roast";
            picBoxCoffee.ImageLocation = "https://mrgreenscoffeebeans.com/wp-content/uploads/2017/10/coffee-84624_1280.jpg";
        }

        private void espressoBtn_MouseClick(object sender, MouseEventArgs e)
        {
            DrinkLabel.Text = "Shot of Espresso";
            picBoxCoffee.ImageLocation = "https://www.rogersfamilyco.com/wp-content/uploads/2012/04/espresso-roast-coffee.jpg";
        }

        private void frenchBtn_MouseClick(object sender, MouseEventArgs e)
        {
            DrinkLabel.Text = "French Roast";
            picBoxCoffee.ImageLocation = "http://cdn3.volusion.com/cewyr.cpdzh/v/vspfiles/photos/0042-2T.jpg?1339873993";
        }

        private void chocolateBtn_MouseClick(object sender, MouseEventArgs e)
        {
            DrinkLabel.Text = "Hot Chocolate";
            picBoxCoffee.ImageLocation = "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2015/11/18/2/FNM_120115-Classic-Hot-Chocolate-Recipe_s4x3.jpg.rend.hgtvcom.616.462.suffix/1448314905572.jpeg";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string dayOfOrder = monthCalendar1.SelectionRange.Start.ToShortDateString();
            MessageBox.Show(string.Format("Your total price will be {0:c} and your order is placed for {1}", total, dayOfOrder), "test");
        }
    }
}