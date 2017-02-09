using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //GENERAL STATEMENT FOR ALL

        double weight;                //The user's weight they input in the textbox
        string messageText;           // The first part of the result, which states "Your weight would be"
        string messageText2;          // The second part of the result, which would state the unit 
                                      //                                of measurement and planet "lbs on Mercury"


        private void btnMercury_Click(object sender, EventArgs e) //When someone clicks the Mercury button
        {
            try //This is going to test the code
            {
                double mercuryGravity = 0.37;

                messageText = "Your weight would be ";
                messageText2 = " lbs on Mercury";

                weight = double.Parse(textBox1.Text);

                // I'm using a boolean operator to make sure the person inputs a positive weight thats >= 1
                bool properWeight = true;
                properWeight = weight >= 1;


                if (properWeight == true)
                {
                    MessageBox.Show(messageText + ((weight * mercuryGravity).ToString("#.#")) + messageText2); 
                    //The "ToString("#.#")" is to make sure the weight gets rounded to 1 decimal place
                }

                else  //This will show up if you don't input your weight that is >= 1
                {
                    MessageBox.Show("Please input your proper weight in lbs that is >= 1");
                }

            }
            catch //If someone tries to input letters or symbols, this will show up
            {
                MessageBox.Show("Please input your weight in numbers");
            }
       
        }

        private void btnVenus_Click(object sender, EventArgs e)
        {
            try 
            {
                double venusGravity = 0.88;

                messageText = "Your weight would be ";
                messageText2 = " lbs on Venus";

                weight = double.Parse(textBox1.Text);

                bool properWeight = true;
                properWeight = weight >= 1;


                if (properWeight == true)
                {
                    MessageBox.Show(messageText + ((weight * venusGravity).ToString("#.#")) + messageText2);
                }
                else
                {
                    MessageBox.Show("Please input your proper weight in lbs that is >= 1");
                }
            }
            catch
            {
                MessageBox.Show("Please input your weight in numbers");
            }
        }

        private void btnMars_Click(object sender, EventArgs e)
        {
            try
            {
                double marsGravity = 0.38;

                messageText = "Your weight would be ";
                messageText2 = " lbs on Mars";

                weight = double.Parse(textBox1.Text);


                bool properWeight = true;
                properWeight = weight >= 1;


                if (properWeight == true)
                {
                    MessageBox.Show(messageText + ((weight * marsGravity).ToString("#.#")) + messageText2);
                }

                else
                {
                    MessageBox.Show("Please input your proper weight in lbs that is >= 1");
                }

            }
            catch
            {
                MessageBox.Show("Please input your weight in numbers");
            }
        }

        private void btnJupiter_Click(object sender, EventArgs e)
        {
            try
            {
                double jupiterGravity = 2.64;

                messageText = "Your weight would be ";
                messageText2 = " lbs on Jupiter";

                weight = double.Parse(textBox1.Text);

                bool properWeight = true;
                properWeight = weight >= 1;


                if (properWeight == true)
                {
                    MessageBox.Show(messageText + ((weight * jupiterGravity).ToString("#.#")) + messageText2);
                }
                else
                {
                    MessageBox.Show("Please input your proper weight in lbs that is >= 1");
                }
            }
            catch
            {
                MessageBox.Show("Please input your weight in numbers");
            }
        }

        private void btnSaturn_Click(object sender, EventArgs e)
        {
            try
            {
                double saturnGravity = 1.15;

                messageText = "Your weight would be ";
                messageText2 = " lbs on Saturn";

                weight = double.Parse(textBox1.Text);

                bool properWeight = true;
                properWeight = weight >= 1;


                if (properWeight == true)
                {
                    MessageBox.Show(messageText + ((weight * saturnGravity).ToString("#.#")) + messageText2);
                }
                else
                {
                    MessageBox.Show("Please input your proper weight in lbs that is >= 1");
                }
            }
            catch
            {
                MessageBox.Show("Please input your weight in numbers");
            }
        }

        private void btnUranus_Click(object sender, EventArgs e)
        {
            try
            {
                double uranusGravity = 1.15;

                messageText = "Your weight would be ";
                messageText2 = " lbs on Uranus";

                weight = double.Parse(textBox1.Text);

                bool properWeight = true;
                properWeight = weight >= 1;


                if (properWeight == true)
                {
                    MessageBox.Show(messageText + ((weight * uranusGravity).ToString("#.#")) + messageText2);
                }
                else
                {
                    MessageBox.Show("Please input your proper weight in lbs that is >= 1");
                }
            }
            catch
            {
                MessageBox.Show("Please input your weight in numbers");
            }
        }

        private void btnNeptune_Click(object sender, EventArgs e)
        {
            try
            {
                double neptuneGravity = 1.12;

                messageText = "Your weight would be ";
                messageText2 = " lbs on Neptune";

                weight = double.Parse(textBox1.Text);

                bool properWeight = true;
                properWeight = weight >= 1;


                if (properWeight == true)
                {
                    MessageBox.Show(messageText + ((weight * neptuneGravity).ToString("#.#")) + messageText2);
                }
                else
                {
                    MessageBox.Show("Please input your proper weight in lbs that is >= 1");
                }
            }
            catch
            {
                MessageBox.Show("Please input your weight in numbers");
            }
        }

        private void btnPluto_Click(object sender, EventArgs e)
        {
            try
            {
                double plutoGravity = 0.04;

                messageText = "Your weight would be ";
                messageText2 = " lbs on Pluto";

                weight = double.Parse(textBox1.Text);

                bool properWeight = true;
                properWeight = weight >= 1;


                if (properWeight == true)
                {
                    MessageBox.Show(messageText + ((weight * plutoGravity).ToString("#.#")) + messageText2);
                }
                else
                {
                    MessageBox.Show("Please input your proper weight in lbs that is >= 1");
                }
            }
            catch
            {
                MessageBox.Show("Please input your weight in numbers");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
