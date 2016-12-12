using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunescapeCal
{
    public partial class Form1 : Form
    {
        // <--  Global Vars for Prayer Page
        int xpRate = 0;
        string totalSum;
        int totalSumInt;
        int overAllSum;
        // <--! Global Vars for Prayer Page

        // <--  Global Vars for Herblore Page
        double herbXPrate = 0;
        string herbTotalSum;
        double herbTotalSumDouble;
        double herbOverAllSum;
        double herbOrgNumber = 0;
        // <--! Global Vars for Herblore Page

        public Form1()
        {
            InitializeComponent();
        }
        
                     

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
        }
        
        // <--Prayer Page--> //
        private void button1_Click_1(object sender, EventArgs e)
        {
            totalSum = textBox1.Text;
            if (int.TryParse(totalSum, out totalSumInt))
            { 
            totalSumInt = Int32.Parse(totalSum);
            }
            xpRate = 0;
            
            if (xpRate == 0 )
            {
                textBox3.Text = xpRate.ToString();
            }

            // Gilded Alter
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                xpRate += 180;
                textBox3.Text = xpRate.ToString();

            }

            // Incenses
            if (checkBox3.Checked && !checkBox4.Checked)
            {
                xpRate += 72;
                textBox3.Text = xpRate.ToString();

            }

            // Juju Potion
            if (checkBox5.Checked && !checkBox6.Checked)
            {
                xpRate += 12;
                textBox3.Text = xpRate.ToString();

            }

            if(xpRate > 0)
            {

            overAllSum = totalSumInt / xpRate;
            totalSum = overAllSum.ToString();
            textBox2.Text = totalSum;
            }
    }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox3.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox6.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox5.Checked = false;
            }
        }
        // <!--Prayer Page--> //       

        // <-- Herblore Page -->
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string potionPicked = comboBox1.SelectedItem.ToString();
            

            switch(potionPicked)
            {
                case "Attack potion Level 1":

                    herbXPrate = 0;
                    herbXPrate += 25;
                    herbOrgNumber += 25;

                    break;

                case "Ranging potion Level 3":

                    herbXPrate = 0;
                    herbXPrate += 30;
                    herbOrgNumber += 30;

                    break;

                case "Magic potion Level 5":

                    herbXPrate = 0;
                    herbXPrate += 35;
                    herbOrgNumber += 35;

                    break;

                case "Strength potion Level 7":

                    herbXPrate = 0;
                    herbXPrate += 40;
                    herbOrgNumber += 40;

                    break;

                case "Relicym's balm Level 8":

                    herbXPrate = 0;
                    herbXPrate += 40;
                    herbOrgNumber += 40;

                    break;

                case "Defence potion Level 9":

                    herbXPrate = 0;
                    herbXPrate += 45;
                    herbOrgNumber += 45;

                    break;

                case "Antipoison Level 13":

                    herbXPrate = 0;
                    herbXPrate += 50;
                    herbOrgNumber += 50;

                    break;

                case "Serum 207 Level 15":

                    herbXPrate = 0;
                    herbXPrate += 50;
                    herbOrgNumber += 50;

                    break;

                case "Guthix rest Level 18":

                    herbXPrate = 0;
                    herbXPrate += 59.5;
                    herbOrgNumber += 59.5;

                    break;

                case "Restore potion Level 22":

                    herbXPrate = 0;
                    herbXPrate += 62.5;
                    herbOrgNumber += 62.5;

                    break;

                case "Guthix balance Level 22":

                    herbXPrate = 0;
                    herbXPrate += 50;
                    herbOrgNumber += 50;

                    break;

                case "Energy potion Level 26":

                    herbXPrate = 0;
                    herbXPrate += 67.5;
                    herbOrgNumber += 67.5;

                    break;

                case "Agility potion Level 34":

                    herbXPrate = 0;
                    herbXPrate += 80;
                    herbOrgNumber += 80;

                    break;

                case "Combat potion Level 36":

                    herbXPrate = 0;
                    herbXPrate += 84;
                    herbOrgNumber += 84;

                    break;

                case "Prayer potion Level 38":

                    herbXPrate = 0;
                    herbXPrate += 87.5;
                    herbOrgNumber += 87.5;

                    break;

                case "Summoning potion Level 40":

                    herbXPrate = 0;
                    herbXPrate += 92;
                    herbOrgNumber += 92;

                    break;

                case "Crafting potion Level 42":

                    herbXPrate = 0;
                    herbXPrate += 95;
                    herbOrgNumber += 95;

                    break;

                case "Super attack Level 45":

                    herbXPrate = 0;
                    herbXPrate += 100;
                    herbOrgNumber += 100;

                    break;

                case "Super antipoison Level 48":

                    herbXPrate = 0;
                    herbXPrate += 106.3;
                    herbOrgNumber += 106.3;

                    break;

                case "Fishing potion Level 50":

                    herbXPrate = 0;
                    herbXPrate += 112.5;
                    herbOrgNumber += 112.5;

                    break;

                case "Super energy Level 52":

                    herbXPrate = 0;
                    herbXPrate += 117.5;
                    herbOrgNumber += 117.5;

                    break;

                case "Hunter potion Level 53":

                    herbXPrate = 0;
                    herbXPrate += 120;
                    herbOrgNumber += 120;

                    break;

                case "Super strength Level 55":

                    herbXPrate = 0;
                    herbXPrate += 125;
                    herbOrgNumber += 125;

                    break;

                case "Fletching potion Level 58":

                    herbXPrate = 0;
                    herbXPrate += 132;
                    herbOrgNumber += 132;

                    break;

                case "Weapon poison Level 60":

                    herbXPrate = 0;
                    herbXPrate += 137.5;
                    herbOrgNumber += 137.5;

                    break;

                case "Super restore Level 63":

                    herbXPrate = 0;
                    herbXPrate += 142.5;
                    herbOrgNumber += 142.5;

                    break;

                case "Sanfew serum Level 65":

                    herbXPrate = 0;
                    herbXPrate += 192;
                    herbOrgNumber += 192;

                    break;

                case "Super defence Level 66":

                    herbXPrate = 0;
                    herbXPrate += 150;
                    herbOrgNumber += 150;

                    break;

                case "Antipoison+ Level 68":

                    herbXPrate = 0;
                    herbXPrate += 155;
                    herbOrgNumber += 155;

                    break;

                case "Antifire Level 69":

                    herbXPrate = 0;
                    herbXPrate += 157.5;
                    herbOrgNumber += 157.5;

                    break;

                case "Super ranging potion Level 72":

                    herbXPrate = 0;
                    herbXPrate += 162.5;
                    herbOrgNumber += 162.5;

                    break;

                case "Weapon poison+ Level 73":

                    herbXPrate = 0;
                    herbXPrate += 165;
                    herbOrgNumber += 165;

                    break;

                case "Super magic potion Level 76":

                    herbXPrate = 0;
                    herbXPrate += 172.5;
                    herbOrgNumber += 172.5;

                    break;

                case "Zamorak brew Level 78":

                    herbXPrate = 0;
                    herbXPrate += 175;
                    herbOrgNumber += 175;

                    break;

                case "Antipoison++ Level 79":

                    herbXPrate = 0;
                    herbXPrate += 155;
                    herbOrgNumber += 155;

                    break;

                case "Saradomin brew Level 81":

                    herbXPrate = 0;
                    herbXPrate += 180;
                    herbOrgNumber += 180;

                    break;

                case "Weapon poison++ Level 82":

                    herbXPrate = 0;
                    herbXPrate += 190;
                    herbOrgNumber += 190;

                    break;

                case "Adrenaline potion Level 84":

                    herbXPrate = 0;
                    herbXPrate += 200;
                    herbOrgNumber += 200;

                    break;

                case "Super antifire Level 85":

                    herbXPrate = 0;
                    herbXPrate += 210;
                    herbOrgNumber += 210;

                    break;

                case "Extreme attack Level 88":

                    herbXPrate = 0;
                    herbXPrate += 220;
                    herbOrgNumber += 220;

                    break;

                case "Extreme strength Level 89":

                    herbXPrate = 0;
                    herbXPrate += 230;
                    herbOrgNumber += 230;

                    break;

                case "Extreme defence Level 90":

                    herbXPrate = 0;
                    herbXPrate += 240;
                    herbOrgNumber += 240;

                    break;

                case "Extreme magic Level 91":

                    herbXPrate = 0;
                    herbXPrate += 250;
                    herbOrgNumber += 250;

                    break;

                case "Extreme ranging Level 92":

                    herbXPrate = 0;
                    herbXPrate += 260;
                    herbOrgNumber += 260;

                    break;

                case "Super prayer Level 94":

                    herbXPrate = 0;
                    herbXPrate += 270;
                    herbOrgNumber += 270;

                    break;

                case "Prayer renewal Level 94":

                    herbXPrate = 0;
                    herbXPrate += 190;
                    herbOrgNumber += 190;

                    break;

                case "Overload Level 96":

                    herbXPrate = 0;
                    herbXPrate += 1000;
                    herbOrgNumber += 1000;

                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            herbTotalSum = textBox4.Text;
            if (double.TryParse(herbTotalSum, out herbTotalSumDouble))
            {
                herbTotalSumDouble = double.Parse(herbTotalSum);
            }

            if (checkBox7.Checked && !checkBox8.Checked)
            {
                if (herbXPrate <= herbOrgNumber)
                {
                    herbXPrate *= 1.10;
                    //textBox5.Text = herbXPrate.ToString();
                }

            }

            if (checkBox8.Checked && !checkBox7.Checked)
            {
                herbXPrate = herbOrgNumber;
                //textBox5.Text = herbXPrate.ToString();

            }

            if (herbXPrate > 0)
            {

                herbOverAllSum = herbTotalSumDouble / herbXPrate;
                herbTotalSum = herbOverAllSum.ToString().Split(',')[0];
                
                textBox5.Text = herbTotalSum;
            }

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox8.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox7.Checked = false;
            }
        }

        // <!-- Herblore Page -->
    }
}
