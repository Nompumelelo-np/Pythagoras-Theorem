using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pythagoras_Theorem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A;
            double B;
            double C;
            

            A = double.Parse(textBox1.Text);
            B = double.Parse(textBox2.Text);

            C = Math.Pow(Math.Pow(A, 2) + Math.Pow(B, 2), 0.5);
            

            textBox3.Text = C.ToString();
        }
    }
}
