using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            //sum = num1 + num2;
           listBox1.Items.Add(num1 + num2);
            //  listBox1.Items.Add (sum.ToString());

            // listBox1.Items.Add("3+2=5");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sub;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            sub = num1 - num2;

            // textBox3.Text = sub.ToString();
            listBox1.Items.Add(num1 - num2);
            //listBox1.Items.Add();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            double mul = num1 * num2;

            //textBox3.Text = mul.ToString();
            listBox1.Items.Add(num1 * num2);
            // listBox1.Items.Add("3*2=6");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int num1;
                int num2;
                int div;
                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);
                div = num1 / num2;

                //textBox3.Text = div.ToString();
                listBox1.Items.Add(num1 / num2);
            }
            catch (DivideByZeroException ex1)
            {
                MessageBox.Show("Impossible to divide by zero ", ex1.Message);
            }
        }

      

     
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 helpForm = new Form2();
            helpForm.Show();
        }

        private void changeColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Lavender;
        }

        private void fIleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           this.BackColor= SystemColors.Control;
        }
    }
}
