using System;
using System.Windows.Forms;

namespace lab_14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (radioButton1.Checked == true) {
                points = points + 1;
            }

            if (radioButton5.Checked == true)
            {
                points = points + 1;
            }

            if (radioButton8.Checked == true)
            {
                points = points + 1;
            }

            label4.Text = "Результат: " + Convert.ToString(points);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}