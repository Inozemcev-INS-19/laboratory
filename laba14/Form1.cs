using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            ToolStripMenuItem CountItem = new ToolStripMenuItem("Посчиать");
            ToolStripMenuItem ExitItem = new ToolStripMenuItem("Выход");

            contextMenuStrip1.Items.AddRange(new[] { CountItem, ExitItem });

            button1.ContextMenuStrip = contextMenuStrip1;

            CountItem.Click += toolStripMenuItem5_Click;
            ExitItem.Click += toolStripMenuItem4_Click;

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(toolStripTextBoxX.Text);
                double y = Convert.ToDouble(toolStripTextBoxY.Text);
                double z = Convert.ToDouble(toolStripTextBoxZ.Text);
                double a = Convert.ToDouble(toolStripComboBoxA.Text);
                 

                double answer = a * x + y + Math.Sin(z);

                this.Text = answer.ToString();
            }
            catch (Exception)
            {
                this.Text = "ERROR!!! Введите все значения!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.ContextMenuStrip = contextMenuStrip1;
        }









        private void toolStripMenuItem6_MouseEnter(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;

            double z = x + y;
            toolStripStatusLabel1.Text = z.ToString();
        }

        private void toolStripMenuItem6_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "0";
        }



        private void toolStripMenuItem7_MouseEnter(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;

            double z = Math.Pow(x, 2) + Math.Pow(y, 2);
            toolStripStatusLabel1.Text = z.ToString();
        }

        private void toolStripMenuItem7_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "0";
        }


    }
}
