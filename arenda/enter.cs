using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arenda
{
    public partial class enter : Form
    {
        public enter()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "s";
            string password = "s";
            if (textBox1.Text == login && textBox2.Text == password)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("ок");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guest2 f4 = new guest2();
            f4.ShowDialog();
        }
    }
}
