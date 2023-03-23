using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ferhenheight_Click(object sender, EventArgs e)
        {
            
        }

        private void kelvin_Click(object sender, EventArgs e)
        {

        }

        private void celcuis_Click(object sender, EventArgs e)
        {

        }

        private void btn_farhenheight_Click(object sender, EventArgs e)
        {

            Convertfromfarhenheight();
        }

        // new  class for the conversion from farhenheight below
        private void Convertfromfarhenheight()
        {
            float f = 0;
            try
            {
                f = float.Parse(txt_farhenheight.Text);
            }
            catch
            {
                MessageBox.Show("Enter Only numbers");
            }

            float c = 5.0f / 9 * (f - 32); // Farhenheight to celcius formula
            //float k = c +273; // Celcius to kelvin formula
            float k = 5.0f / 9 * (f - 32) + 273;// fahrenheight to kelvin


            //Displaying the values in the text box
            txt_celcius.Text = c.ToString();

            txt_kelvin.Text = k.ToString();
        }

        private void btn_celcius_Click(object sender, EventArgs e)
        {
            ConvertFromCelcius(); // it is called from below class
        }
        //class for celcius below

        private void ConvertFromCelcius()
        {
            float d = 0;
            try
            {
                d = float.Parse(txt_celcius.Text);
            }
            catch
            {
                MessageBox.Show("Enter only numbers");
            }
            float b = 9.0f / 5 * d + 32; // celcius to farhenheight
            float g = d + 273; // celcius to kelvin

            txt_farhenheight.Text = b.ToString();
            txt_kelvin.Text = g.ToString();
        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            ConvertFromKelvin();

        }    

        private void ConvertFromKelvin()
        {
            float k = 0;
            try
            {
                k = float.Parse(txt_kelvin.Text);
            }
            catch
            {
                MessageBox.Show("Enter only numbers");

            }

            float f = 9.0f / 5 * (k - 273) + 32; // kelvin to farhenheight
            float c = k - 273; // kelving to celcius

            txt_farhenheight.Text = f.ToString();
            txt_celcius.Text = c.ToString();

        }
    }
}
