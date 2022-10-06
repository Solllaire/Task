using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text.IndexOf(",") > 0 && b.Text == ",")
            {
                return;
            }
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length - 1 == 0)
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }
        String action, number1;


        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0"| textBox1.Text == "")
            {
                Button b = (Button)sender;
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + b.Text;
            }
            else
            {
                Button b = (Button)sender;
                action = b.Text;
                number1 = textBox1.Text;
                textBox1.Text = "";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
                if (action == "+")
                    textBox1.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(number1)).ToString();
                if (action == "-")
                    textBox1.Text = (Convert.ToDouble(number1) - Convert.ToDouble(textBox1.Text)).ToString();
                if (action == "*")
                    textBox1.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(number1)).ToString();
                if (action == "/")
                    textBox1.Text = (Convert.ToDouble(number1) / Convert.ToDouble(textBox1.Text)).ToString();
            action = "";

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
