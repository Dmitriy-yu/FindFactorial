using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindFactorial
{
    public partial class Form1 : Form
    { 
       long a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          textBox1.Text = "Введите число";
          textBox2.Text = "Результат";
            button1.Enabled = false;
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text=="Введите число")
            {
                textBox1.Clear();
                textBox2.Clear();
                button1.Enabled = true;
            }
            else
            {
                textBox1.Text = "Введите число";
                textBox2.Text = "Результат";
                button1.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long result = 1;
          long a = Convert.ToInt64(textBox1.Text);
            for (long i = 1; i <= a; i++)
            {
                result *= i;

            }
            textBox2.Text = result. ToString();
            textBox2.ForeColor=System.Drawing. Color.Red;
            
        }

    
    }
}

