using CS3020_Calculator.Calculations;

namespace CS3020_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.Text = "+";

            double Num1;
            double Num2;

            if (!double.TryParse(textBox1.Text, out Num1))
            {
                MessageBox.Show("First number is invalid.");
                return;
            }

            if (!double.TryParse(textBox2.Text, out Num2))
            {
                MessageBox.Show("Second number is invalid.");
                return;
            }

            var Add = new Addition();
            double result = Add.Calculate(Num1, Num2);
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.Text = "-";

            double Num1;
            double Num2;

            if (!double.TryParse(textBox1.Text, out Num1))
            {
                MessageBox.Show("First number is invalid.");
                return;
            }

            if (!double.TryParse(textBox2.Text, out Num2))
            {
                MessageBox.Show("Second number is invalid.");
                return;
            }

            var Sub = new Subtraction();
            double result = Sub.Calculate(Num1, Num2);
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.Text = "+";

            double Num1;
            double Num2;

            if (!double.TryParse(textBox1.Text, out Num1))
            {
                MessageBox.Show("First number is invalid.");
                return;
            }

            if (!double.TryParse(textBox2.Text, out Num2))
            {
                MessageBox.Show("Second number is invalid.");
                return;
            }

            var Div = new Division();
            try
            {
                double result = Div.Calculate(Num1, Num2);
                textBox3.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.Text = "-";

            double Num1;
            double Num2;

            if (!double.TryParse(textBox1.Text, out Num1))
            {
                MessageBox.Show("First number is invalid.");
                return;
            }

            if (!double.TryParse(textBox2.Text, out Num2))
            {
                MessageBox.Show("Second number is invalid.");
                return;
            }

            var Mult = new Multiplication();
            double result = Mult.Calculate(Num1, Num2);
            textBox3.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.Text = "+";

            double Num1;
            double Num2;

            if (!double.TryParse(textBox1.Text, out Num1))
            {
                MessageBox.Show("First number is invalid.");
                return;
            }

            if (!double.TryParse(textBox2.Text, out Num2))
            {
                MessageBox.Show("Second number is invalid.");
                return;
            }

            var Perc = new Percentage();
            try
            {
                double result = Perc.Calculate(Num1, Num2);
                textBox3.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
