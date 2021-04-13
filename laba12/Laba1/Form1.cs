using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = string.Format("Координаты: {0}, {1}", e.X, e.Y);
            textBoxE.Text = (e.X + e.Y).ToString();

            textBoxW.Text = (e.X + e.Y).ToString();


        }

        private void buttonСalculate_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                double g = Convert.ToDouble(textBoxG.Text);

                double q = Convert.ToDouble(textBoxQ.Text);

                double x = Convert.ToDouble(textBoxX.Text);

                double answer = Convert.ToDouble(textBoxW.Text) + (Math.Tan(g * q)/Math.Log10(20*x)) 
                    - (Convert.ToDouble(textBoxE.Text)/ Convert.ToDouble(textBoxW.Text)) 
                    + Math.Abs(Math.Sin(Convert.ToDouble(textBoxE.Text) 
                    + Math.Sqrt(Math.Abs(Convert.ToDouble(textBoxW.Text) - Convert.ToDouble(textBoxE.Text)))));

                this.Text = answer.ToString();
            }
            catch (Exception ) {
                this.Text = "ERROR";
            }
        }


    }
}
