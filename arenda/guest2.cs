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
    public partial class guest2 : Form
    {
        public guest2()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zxclownDataSet.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter1.Fill(this.zxclownDataSet.Автомобили);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arendaDataSet.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.arendaDataSet.Автомобили);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            guest f3 = new guest();
            f3.ShowDialog();
        }
    }
}
