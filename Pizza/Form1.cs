using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double pizzaSizePrice = 0;
        double saucePrize = 0;
        double totalPrice = 0;
        double ingredientPrice01 = 0;
        double ingredientPrice02 = 0;
        double ingredientPrice03 = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Ketchup - 2.50$":
                    saucePrize = 2.50;
                    break;
                case "Mayo - 3.00$":
                    saucePrize = 3.00;
                    break;
                case "Mustard - 4.00$":
                    saucePrize = 4.00;
                    break;
                case "BBQ - 3.50$":
                    saucePrize = 3.50;
                    break;
                case "Garlic - 2.00$":
                    saucePrize = 2.00;
                    break;
                default:
                    saucePrize = 0;
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ingredientPrice01 = 0;
            ingredientPrice02 = 0;
            ingredientPrice03 = 0;
            textBox1.Text = "0.00$";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();

            comboBox3.Items.Add("Avocado - 4.00$");
            comboBox3.Items.Add("Tomatoes - 3.50$");
            comboBox3.Items.Add("Pickles - 2.40$");
            comboBox3.Items.Add("Nothing");

            comboBox4.Items.Add("Figs - 5.10$");
            comboBox4.Items.Add("Ananas - 4.20$");
            comboBox4.Items.Add("Banana - 3.10$");
            comboBox4.Items.Add("Nothing");

            comboBox5.Items.Add("Cheese - 5.00$");
            comboBox5.Items.Add("Mozzarella - 7.60$");
            comboBox5.Items.Add("Blue Cheese - 3.70$");
            comboBox5.Items.Add("Nothing");
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();

            comboBox3.Items.Add("Avocado - 4.00$");
            comboBox3.Items.Add("Tomatoes - 3.50$");
            comboBox3.Items.Add("Pickles - 2.40$");
            comboBox3.Items.Add("Nothing");

            comboBox4.Items.Add("Becon - 6.20$");
            comboBox4.Items.Add("Chicken - 5.70$");
            comboBox4.Items.Add("Peperoni - 6.40$");
            comboBox4.Items.Add("Nothing");

            comboBox5.Items.Add("Cheese - 5.00$");
            comboBox5.Items.Add("Mozzarella - 7.60$");
            comboBox5.Items.Add("Blue Cheese - 3.70$");
            comboBox5.Items.Add("Nothing");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Small - 10.50$":
                    pizzaSizePrice = 10.50;
                    break;
                case "Medium - 15.50$":
                    pizzaSizePrice = 15.50;
                    break;
                case "Large - 18.50$":
                    pizzaSizePrice = 18.50;
                    break;
                default:
                    pizzaSizePrice = 0;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalPrice = pizzaSizePrice + saucePrize + ingredientPrice01 + ingredientPrice02 + ingredientPrice03;
            //textBox1.Text = totalPrice.ToString() + "$";
            textBox1.Text = string.Format("{0:0.00}$", totalPrice);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.Text)
            {
                case "Avocado - 4.00$":
                    ingredientPrice01 = 4.00;
                    break;
                case "Tomatoes - 3.50$":
                    ingredientPrice01 = 3.50;
                    break;
                case "Pickles - 2.40$":
                    ingredientPrice01 = 2.40;
                    break;
                case "Nothing":
                    ingredientPrice01 = 0;
                    break;
                default:
                    ingredientPrice01 = 0;
                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.Text)
            {
                case "Figs - 5.10$":
                    ingredientPrice02 = 5.10;
                    break;
                case "Ananas - 4.20$":
                    ingredientPrice02 = 4.20;
                    break;
                case "Banana - 3.10$":
                    ingredientPrice02 = 3.10;
                    break;
                case "Becon - 6.20$":
                    ingredientPrice02 = 6.20;
                    break;
                case "Chicken - 5.70$":
                    ingredientPrice02 = 5.70;
                    break;
                case "Peperoni - 6.40$":
                    ingredientPrice02 = 6.40;
                    break;
                case "Nothing":
                    ingredientPrice02 = 0;
                    break;
                default:
                    ingredientPrice02 = 0;
                    break;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.Text)
            {
                case "Cheese - 5.00$":
                    ingredientPrice03 = 5.00;
                    break;
                case "Mozzarella - 7.60$":
                    ingredientPrice03 = 7.60;
                    break;
                case "Blue Cheese - 3.70$":
                    ingredientPrice03 = 3.70;
                    break;
                case "Nothing":
                    ingredientPrice03 = 0;
                    break;
                default:
                    ingredientPrice03 = 0;
                    break;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ingredientPrice01 = 0;
            ingredientPrice02 = 0;
            ingredientPrice03 = 0;
            textBox1.Text = "0.00$";
        }
    }
}
