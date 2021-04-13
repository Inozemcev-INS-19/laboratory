using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (radioButton1.Checked)
                {
                    int N = Convert.ToInt32(textBoxN.Text);
                    double x = Convert.ToDouble(textBoxX.Text);
                    double answer = 0, chisl;
                    int znam = 1;
                    for (int z = 1; z <= N; z++)
                    {
                        znam = znam * (z + 1);

                        chisl = (z % 2 != 0) ? -Math.Pow(x, z) : Math.Pow(x, z);

                        answer += chisl / znam;
                    }


                    textBoxAnswer.Text = answer.ToString("0.000");
                }
                else if (radioButton2.Checked)
                {
                    int N = Convert.ToInt32(textBoxN.Text);
                    double a = Convert.ToDouble(comboBoxA.Text);
                    double b = Convert.ToDouble(comboBoxB.Text);
                    int R = Convert.ToInt32(textBoxR.Text);

                    double answer1 = 0;
                    for (int q = 1; q <= N; q++)
                    {
                        for (int p = 1; p <= R; p++)
                        {
                            answer1 += ((a * Math.Pow(q, 2)) / (Math.Pow(q, 3) + b * Math.Pow(p, 3)));
                        }
                    }
                    textBoxAnswer.Text = answer1.ToString("0.000");

                }
                else
                {
                    MessageBox.Show("Уравнение не выбрано", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                textBoxAnswer.Text = "Введены не все значения";
            }
        }
    }
}
