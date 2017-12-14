using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;

namespace WindowsFormsApplication1
{
    public partial class MoneyCreditCounterv : Form
    {
        //varible initialization
        int onep;
        int twop;
        int fivep;
        int tenp;
        int twentyp;
        int fiftyp;
        int onepound;
        int twopound;
        
        public MoneyCreditCounterv()
        {
            InitializeComponent();
         
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(CostPerCredit.Text);
            if (x <= 0)
            {
                MessageBox.Show("Please insert an interger above 0 in cost per credit", "Credit error",
    MessageBoxButtons.OK, MessageBoxIcon.Error); //error message if the text box has a interger less than or equal to 0
            }
            else
            {
                int coins = fivep++;//increases the interger by one
                string numofcoin = fivep.ToString();//turns interger into a string and then displays it in the label
                label4.Text = numofcoin;
                int total = Convert.ToInt32(textBox2.Text);
                total = total + 5;
                string totals = total.ToString();
                textBox2.Text = totals;


                // takes the new total and divides it by 100 and then turns the result into a decimal it then converts that to a string and prints it.
                decimal totalindec = (decimal)total / 100;
                string dec_total = totalindec.ToString();
                textBox1.Text = dec_total;


                //divids total with number of credits and then turns the answer into a string and then prints
                int credits = total / x;
                string Ncredits = credits.ToString();
                NumberCredits.Text = Ncredits;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(CostPerCredit.Text);
            if (x <= 0)
            {
                MessageBox.Show("Please insert an interger above 0 in cost per credit", "Credit error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);//error message if the text box has a interger less than or equal to 0
            }
            else
            {
                int coins = tenp++;//increases the interger by one
                string numofcoin = tenp.ToString();//turns interger into a string and then displays it in the label
                label5.Text = numofcoin;


                //takes the current string in the text box converts it to a string and then adds the apropriate number to the total then converts it back to a string n displays it.
                int total = Convert.ToInt32(textBox2.Text);
                total = total + 10;
                string totals = total.ToString();
                textBox2.Text = totals;
                
                // takes the new total and divides it by 100 and then turns the result into a decimal it then converts that to a string and prints it.
                decimal totalindec = (decimal)total / 100;
                string dec_total = totalindec.ToString();
                textBox1.Text = dec_total;


                //divids total with number of credits and then turns the answer into a string and then prints
                int credits = total / x;
                string Ncredits = credits.ToString();
                NumberCredits.Text = Ncredits;

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int x = int.Parse(CostPerCredit.Text);//takes the cost percredit and makes it an interger so that we can check if its less than or equal to 0
            if (x <= 0)
            {
                MessageBox.Show("Please insert an interger above 0 in cost per credit", "Credit error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);//error message if the text box has a interger less than or equal to 0
            }
            else
            {
                int coins = fiftyp++;//increases the interger by one
                string numofcoin = fiftyp.ToString();//turns interger into a string and then displays it in the label
                label7.Text = numofcoin;


                //takes the current string in the text box converts it to a string and then adds the apropriate number to the total then converts it back to a string n displays it.
                int total = Convert.ToInt32(textBox2.Text);
                total = total + 50;
                string totals = total.ToString();
                textBox2.Text = totals;


                // takes the new total and divides it by 100 and then turns the result into a decimal it then converts that to a string and prints it.
                decimal totalindec = (decimal)total / 100;
                string dec_total = totalindec.ToString();
                textBox1.Text = dec_total;


                //divids total with number of credits and then turns the answer into a string and then prints
                int credits = total / x;
                string Ncredits = credits.ToString();
                NumberCredits.Text = Ncredits;

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int x = int.Parse(CostPerCredit.Text);//takes the cost percredit and makes it an interger so that we can check if its less than or equal to 0
            if (x <= 0)
            {
                MessageBox.Show("Please insert an interger above 0 in cost per credit", "Credit error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);//error message if the text box has a interger less than or equal to 0
            }
            else
            {
                int coins = twentyp++;//increases the interger by one
                string numofcoin = twentyp.ToString();//turns interger into a string and then displays it in the label
                label6.Text = numofcoin;


                //takes the current string in the text box converts it to a string and then adds the apropriate number to the total then converts it back to a string n displays it.
                int total = Convert.ToInt32(textBox2.Text);
                total = total + 20;
                string totals = total.ToString();
                textBox2.Text = totals;


                // takes the new total and divides it by 100 and then turns the result into a decimal it then converts that to a string and prints it.
                decimal totalindec = (decimal)total / 100;
                string dec_total = totalindec.ToString();
                textBox1.Text = dec_total;


                //divids total with number of credits and then turns the answer into a string and then prints
                int credits = total / x;
                string Ncredits = credits.ToString();
                NumberCredits.Text = Ncredits;

            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            int x = int.Parse(CostPerCredit.Text);//takes the cost percredit and makes it an interger so that we can check if its less than or equal to 0
            if (x <= 0)
            {
                MessageBox.Show("Please insert an interger above 0 in cost per credit", "Credit error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);//error message if the text box has a interger less than or equal to 0
            }
            else
            {
                
                int coins = onep++;//increases the interger by one
                string numofcoin = onep.ToString();//turns interger into a string and then displays it in the label
                label2.Text = numofcoin;


                //takes the current string in the text box converts it to a string and then adds the apropriate number to the total then converts it back to a string n displays it.
                int total = Convert.ToInt32(textBox2.Text);
                total = total + 1;
                string totals = total.ToString();
                textBox2.Text = totals;


                // takes the new total and divides it by 100 and then turns the result into a decimal it then converts that to a string and prints it.
                decimal totalindec = (decimal)total / 100;
                string dec_total = totalindec.ToString();
                textBox1.Text = dec_total;


                //divids total with number of credits and then turns the answer into a string and then prints
                int credits = total / x;
                string Ncredits = credits.ToString();
                NumberCredits.Text = Ncredits;

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(CostPerCredit.Text);//takes the cost percredit and makes it an interger so that we can check if its less than or equal to 0
            if (x <= 0)
            {
                MessageBox.Show("Please insert an interger above 0 in cost per credit", "Credit error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);//error message if the text box has a interger less than or equal to 0
            }
            else
            {
                int coins = twop++;//increases the interger by one
                string numofcoin = twop.ToString();//turns interger into a string and then displays it in the label
                label3.Text = numofcoin;


                //takes the current string in the text box converts it to a string and then adds the apropriate number to the total then converts it back to a string n displays it.
                int total = Convert.ToInt32(textBox2.Text);
                total = total + 2;
                string totals = total.ToString();
                textBox2.Text = totals;


                // takes the new total and divides it by 100 and then turns the result into a decimal it then converts that to a string and prints it.
                decimal totalindec = (decimal)total / 100;
                string dec_total = totalindec.ToString();
                textBox1.Text = dec_total;


                //divids total with number of credits and then turns the answer into a string and then prints
                int credits = total / x;
                string Ncredits = credits.ToString();
                NumberCredits.Text = Ncredits;

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void CostPerCredit_TextChanged(object sender, EventArgs e)
        {
 
        
        }

        private void Pound_Click(object sender, EventArgs e)
        {
            int x = int.Parse(CostPerCredit.Text);//takes the cost percredit and makes it an interger so that we can check if its less than or equal to 0
            if (x <= 0)
            {
                MessageBox.Show("Please insert an interger above 0 in cost per credit", "Credit error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);//error message if the text box has a interger less than or equal to 0
            }
            else
            {
                int coins = onepound++;//increases the interger by one
                string numofcoin = onepound.ToString();//turns interger into a string and then displays it in the label
                label8.Text = numofcoin;


                //takes the current string in the text box converts it to a string and then adds the apropriate number to the total then converts it back to a string n displays it.
                int total = Convert.ToInt32(textBox2.Text);
                total = total + 100;
                string totals = total.ToString();
                textBox2.Text = totals;


                // takes the new total and divides it by 100 and then turns the result into a decimal it then converts that to a string and prints it.
                decimal totalindec = (decimal)total / 100;
                string dec_total = totalindec.ToString();
                textBox1.Text = dec_total;



                //divids total with number of credits and then turns the answer into a string and then prints
                int credits = total / x;
                string Ncredits = credits.ToString();
                NumberCredits.Text = Ncredits;

            }
        }

        private void twoPounds_Click(object sender, EventArgs e)
        {
            int x = int.Parse(CostPerCredit.Text);//takes the cost percredit and makes it an interger so that we can check if its less than or equal to 0
            if (x <= 0)
            {
                MessageBox.Show("Please insert an interger above 0 in cost per credit", "Credit error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);//error message if the text box has a interger less than or equal to 0
            }
            else
            {
                int coins = twopound++;//increases the interger by one
                string numofcoin = twopound.ToString();//turns interger into a string and then displays it in the label
                label9.Text = numofcoin;


                //takes the current string in the text box converts it to a string and then adds the apropriate number to the total then converts it back to a string n displays it.
                int total = Convert.ToInt32(textBox2.Text);
                total = total + 200;
                string totals = total.ToString();
                textBox2.Text = totals;


                // takes the new total and divides it by 100 and then turns the result into a decimal it then converts that to a string and prints it.
               decimal totalindec = (decimal)total / 100;
               string dec_total = totalindec.ToString();
                textBox1.Text = dec_total;



                //divids total with number of credits and then turns the answer into a string and then prints
                int credits = total / x;
                string Ncredits = credits.ToString();
                NumberCredits.Text = Ncredits;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Coins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumberCredits_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
