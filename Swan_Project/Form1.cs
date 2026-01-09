namespace Swan_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string userinput = textBox1.Text;
            string userinput2 = textBox2.Text;

            double input = double.Parse(userinput);
            double input2 = double.Parse(userinput2);

            Calculate calc = new Calculate(input, input2);
            double sum = calc.add(input, input2);
            MessageBox.Show(sum.ToString());


        }

        private void subtract_Click(object sender, EventArgs e)
        {
            string userinput = textBox1.Text;
            string userinput2 = textBox2.Text;

            double input = double.Parse(userinput);
            double input2 = double.Parse(userinput2);

            Calculate calc = new Calculate(input, input2);
            double difference = calc.subtract(input, input2);
            MessageBox.Show(difference.ToString());
        }

        private void divide_Click(object sender, EventArgs e)
        {
            string userinput = textBox1.Text;
            string userinput2 = textBox2.Text;

            double input = double.Parse(userinput);
            double input2 = double.Parse(userinput2);

            Calculate calc = new Calculate(input, input2);
            if (input2 == 0)
            {
                MessageBox.Show("cannot divide by 0");
            }
            else
            {
                double divide = calc.divide(input, input2);
                MessageBox.Show(divide.ToString());
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            string userinput = textBox1.Text;
            string userinput2 = textBox2.Text;

            double input = double.Parse(userinput);
            double input2 = double.Parse(userinput2);

            Calculate calc = new Calculate(input, input2);
            double product = calc.multiply(input, input2);
            MessageBox.Show(product.ToString());
        }

    }
    class Calculate : Calculator
    {
        private double num1 { get; set; }
        private double num2 { get; set; }

        public Calculate(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
    }
    class Calculator
    {

        public double add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public double multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }

}
