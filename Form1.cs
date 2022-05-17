namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double f, s;
        byte a = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "1");
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a!= 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "1");
                s = Convert.ToDouble(textBox1.Text);
            }

            }

            private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "2");
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a!= 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "2");
                s = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "3");
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a!= 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "3");
                s = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "4");
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a!= 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "4");
                s = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "5");
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a!= 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "5");
                s = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "6");
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a!= 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "6");
                s = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "7");
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a!= 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "7");
                s = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "8");
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a!=0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "8");
                s = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "9");
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a != 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "9");
                s = Convert.ToDouble(textBox1.Text);
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "0");
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a != 0)
            {
                textBox1.Text = String.Concat(textBox1.Text, "0");
                s = Convert.ToDouble(textBox1.Text);
            }
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            textBox1.Text= Convert.ToString(f*(-1));
        }

        private void plus_Click(object sender, EventArgs e)
        {
            a = 1;
            textBox1.Text = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            a = 2;
            textBox1.Text = "";
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            a = 3;
            textBox1.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            a = 4;
            textBox1.Text = "";
        }

        private void pwr_Click(object sender, EventArgs e)
        {
            a = 5;
            textBox1.Text = "";
        }

        private void buttonLOG_Click(object sender, EventArgs e)
        {
            a = 6;
            textBox1.Text = "";
        }

        private void SQR_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Sqrt(f));
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                textBox1.Text = Convert.ToString(f + s);
                f = Convert.ToDouble(textBox1.Text);
            }
            if(a == 2)
            {
                textBox1.Text = Convert.ToString(f - s);
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a == 3)
            {
                textBox1.Text = Convert.ToString(f * s);
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a == 4)
            {
                textBox1.Text = Convert.ToString(f / s);
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a == 5)
            {
                textBox1.Text = Convert.ToString(Math.Pow(f,s));
                f = Convert.ToDouble(textBox1.Text);
            }
            if (a == 6)
            {
                textBox1.Text = Convert.ToString(Math.Log(f, s));
                f = Convert.ToDouble(textBox1.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}