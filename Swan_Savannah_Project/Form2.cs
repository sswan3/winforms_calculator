using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swan_Savannah_Project
{
        class Calculate : Calculator
        {
            private int num1 { get; set; }
            private int num2 { get; set; }

            public Calculate(int num1, int num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }
        }
        class Calculator
        {

            public int add(int num1, int num2)
            {
                return num1 + num2;
            }
            public int subtract(int num1, int num2)
            {
                return num1 - num2;
            }
            public int divide(int num1, int num2)
            {
                return num1 / num2;
            }
            public int multiply(int num1, int num2)
            {
                return num1 * num2;
            }
        }

    

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
}
}
