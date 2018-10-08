using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double cos(double x)
        {
            return (Math.Cos (x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
       

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double F = Convert.ToDouble(textBox1.Text);
                double A = Convert.ToDouble(textBox2.Text);
                double Fy = F * cos(A);
                label1.Text = Fy.ToString();
            }
           catch
            {
                MessageBox.Show("input needs to be a number!!!");
            }
            try
            {
                double F = Convert.ToDouble(textBox1.Text);
                double A = Convert.ToDouble(textBox2.Text);
                double Fx = F * sin(A);
                label4.Text = Fx.ToString();
            }
            catch
            {
                MessageBox.Show("input needs to be a umber!!!");
            }
        }
    }
}
