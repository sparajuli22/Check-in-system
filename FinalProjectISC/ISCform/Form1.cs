using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCform
{
    public partial class Form1 : Form
    {
        private const string V = "You have clicked me ! ";
        private const string Y = "You also have cliked me ! ";
        string email = " ";
        string name = " ";
        string ID = " " ;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            email = emailTextBox.Text;
            name = textBox2.Text;
            ID = textBox3.Text;
            label1.Text = $"Hello, {email.ToString()} , {name.ToString()} , {ID.ToString()}";

        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }
    }
}
