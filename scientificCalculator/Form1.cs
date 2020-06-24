using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scientificCalculator
{
    public partial class Form1 : Form

    {
        double result = 0;
        char iOperation;
        string operation = "";
        bool enter_value = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 374;
            textBox1.Width = 325;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 704;
            textBox1.Width = 666;
        }

        private void tempConvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width= 1174;
            textBox1.Width = 666;

        }

        private void unitConvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1174;
            textBox1.Width = 666;

        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1174;
            textBox1.Width = 666;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (enter_value))
                textBox1.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if(num.Text==".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + num.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text =="")
            {
                textBox1.Text = "0";
            }
        }

        private void Math_Op(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            operation = op.Text;
           
            result = double.Parse(textBox1.Text);
            textBox1.Text = "";
            label5.Text = operation;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result = result + double.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = result - double.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
                case "Mod":
                    textBox1.Text = (result % double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    double i = double.Parse(textBox1.Text);
                    double q;
                    q = (result);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();

                    break;
            }

        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.1465847645";

        }

        private void button29_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(textBox1.Text);
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double sqrt = double.Parse(textBox1.Text);
            sqrt= Math.Sqrt(sqrt);
            textBox1.Text = System.Convert.ToString(sqrt);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double qsinh = double.Parse(textBox1.Text);
            qsinh = Math.Sinh(qsinh);
            textBox1.Text = System.Convert.ToString(qsinh);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double qsin = double.Parse(textBox1.Text);
            qsin = Math.Sin(qsin);
            textBox1.Text = System.Convert.ToString(qsin);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double qcosh = double.Parse(textBox1.Text);
            qcosh = Math.Cosh(qcosh);
            textBox1.Text = System.Convert.ToString(qcosh);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double qcos = double.Parse(textBox1.Text);
            qcos = Math.Cos(qcos);
            textBox1.Text = System.Convert.ToString(qcos);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double qtansh = double.Parse(textBox1.Text);
            qtansh = Math.Tanh(qtansh);
            textBox1.Text = System.Convert.ToString(qtansh);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double qtan = double.Parse(textBox1.Text);
            qtan = Math.Tan(qtan);
            textBox1.Text = System.Convert.ToString(qtan);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 2);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            double a;
            a = Math.Pow(Convert.ToDouble(textBox1.Text), 2);
            textBox1.Text = System.Convert.ToString(a);

        }

        private void button39_Click(object sender, EventArgs e)
        {
            double a;
            a = Math.Pow(Convert.ToDouble(textBox1.Text), 3);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0/Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(textBox1.Text);
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text)/ Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }

      

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            iOperation = 'K';

        }

        private void button41_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'C':
                    float icelsuis = float.Parse(textBox2.Text);
                    textBox3.Text = ((((9 * icelsuis) / 5) + 32).ToString());
                    break;
                case 'F':
                    float ifah = float.Parse(textBox2.Text);
                    textBox3.Text = ((((ifah-32) * 5) / 9).ToString());
                    break;
                case 'K':
                    float ike = float.Parse(textBox2.Text);
                    textBox3.Text = ((((9 * ike) / 5) + 32).ToString());
                    break;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Text = "";
            radioButton3.Checked = false;
            radioButton2.Checked = false;
            radioButton1.Checked = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
