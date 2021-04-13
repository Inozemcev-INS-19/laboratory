using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace laba_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            buttonColor.Click += buttonColor_Click;
            colorDialog1.FullOpen = true;
            colorDialog1.Color = this.BackColor;

            textBoxAnswer.Click += button1_Click;
            fontDialog1.ShowColor = true;

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            textBoxAnswer.Font = fontDialog1.Font;
            textBoxAnswer.ForeColor = fontDialog1.Color;

            textBoxN.Font = fontDialog1.Font;
            textBoxN.ForeColor = fontDialog1.Color;

            textBoxX.Font = fontDialog1.Font;
            textBoxX.ForeColor = fontDialog1.Color;            
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            this.BackColor = colorDialog1.Color;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBoxN.Text);
            int c = 0;
            double answer = 0;
            double x = Convert.ToDouble(textBoxX.Text);
            for (int i = 1; i <= N; i++) {
                c += i;
                
                if (i % 2 != 0)
                    answer -= (Math.Pow(x, c)) / (c * (c + 1) * (c + 2));
                else answer += (Math.Pow(x, c)) / (c * (c + 1) * (c + 2));
                
                c = i;
            }
            textBoxAnswer.Text = answer.ToString("0.00");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            File.WriteAllText(filename, textBoxAnswer.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            string filename = openFileDialog1.FileName;

            string Answer = File.ReadAllText(filename);

            richTextBoxOpenFile.Text = Answer;
            MessageBox.Show("Open");


           

        }
    }
}
