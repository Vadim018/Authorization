using System;
using System.Windows.Forms;

namespace lab_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }

        Form2 form2;
        string Login = "root";
        string Password = "vadcristal";

        private void button1_Click(object sender, EventArgs e)
        {
            string Log = textBox1.Text;
            string Pas = textBox2.Text;

            if (Log == Login && Pas == Password) {
                form2.Show();
            } else {
                MessageBox.Show("Невірний логін або пароль. Спробуйте ще раз!", "Помилка авторизації");
            }
        }
    }
}