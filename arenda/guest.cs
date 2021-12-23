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
    public partial class guest : Form
    {
        public guest()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arendaDataSet.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.arendaDataSet.Автомобили);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Добавить_Click(object sender, EventArgs e)
        {

        }
    }
}
