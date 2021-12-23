using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;

namespace arenda
{
    public partial class mane : Form
    {
        static string constr = @"Data Source=DESKTOP-3OTEG9O;Initial Catalog=zxclown;Integrated Security=True";
        string sql = "SELECT [Выданные автомобили].Код_проката, Клиенты.ФИО, Автомобили.Госномер, [Выданные автомобили].Дата_выдачи, [Выданные автомобили].Количество_дней, [Выданные автомобили].Ожидаемая_дата_возрата, [Система скидок].Наименование_скидки, [Выданные автомобили].Сумма, [Выданные автомобили].Скидка, [Выданные автомобили].Итоговая_сумма FROM[Выданные автомобили] JOIN Клиенты on Клиенты.Код_клиента = [Выданные автомобили].Код_клиента JOIN Автомобили on Автомобили.Код_авто = [Выданные автомобили].Код_авто JOIN[Система скидок] on [Система скидок].Код_скидки = [Выданные автомобили].Наименование_скидки";
        DataContext cont = new DataContext(constr);
        SqlConnection cod = new SqlConnection();
        SqlCommand cmt = new SqlCommand();
        public mane()
        {
            enter f2 = new enter();
            f2.ShowDialog();
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=DESKTOP-3OTEG9O;Initial Catalog=zxclown;Integrated Security=True";
            string sql = "Insert into [Выданные автомобили] ([Код_клиента], [Код_авто], [Дата_выдачи], [Количество_дней], [Ожидаемая_дата_возрата], [Наименование_скидки], [Сумма], [Скидка],  [Итоговая_сумма])  values ( '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox11.Text + "' )";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables["[Выданные автомобили]"];

            }
            MessageBox.Show("Запись добавлена", "Добавлено");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=DESKTOP-3OTEG9O;Initial Catalog=zxclown;Integrated Security=True";
            string sql = "SELECT [Выданные автомобили].Код_проката, Клиенты.ФИО, Автомобили.Госномер, [Выданные автомобили].Дата_выдачи, [Выданные автомобили].Количество_дней, [Выданные автомобили].Ожидаемая_дата_возрата, [Система скидок].Наименование_скидки, [Выданные автомобили].Сумма, [Выданные автомобили].Скидка, [Выданные автомобили].Итоговая_сумма FROM[Выданные автомобили] JOIN Клиенты on Клиенты.Код_клиента = [Выданные автомобили].Код_клиента JOIN Автомобили on Автомобили.Код_авто = [Выданные автомобили].Код_авто JOIN[Система скидок] on [Система скидок].Код_скидки = [Выданные автомобили].Наименование_скидки";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string sql = "DELETE from [Выданные автомобили] where Код_проката= " + dataGridView1.CurrentRow.Cells[0].Value;
                    string constring = @"Data Source=DESKTOP-3OTEG9O;Initial Catalog=zxclown;Integrated Security=True";
                    using (SqlConnection col = new SqlConnection(constring))
                    {
                        col.Open();
                        SqlCommand cmdd = new SqlCommand(sql, col);
                        sql = "SELECT * from [Выданные автомобили]";
                        cmdd.ExecuteNonQuery();
                        DataSet ds = new DataSet();
                        SqlDataAdapter ad = new SqlDataAdapter(sql, constring);
                        ad.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        col.Close();
                    }
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 f7 = new Form5(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            f7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guest f3 = new guest();
            f3.ShowDialog();
        }

        private void производстваToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ингредиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=DESKTOP-3OTEG9O;Initial Catalog=zxclown;Integrated Security=True";
            string sql = "SELECT [Выданные автомобили].Код_проката, Клиенты.ФИО, Автомобили.Госномер, [Выданные автомобили].Дата_выдачи, [Выданные автомобили].Количество_дней, [Выданные автомобили].Ожидаемая_дата_возрата, [Система скидок].Наименование_скидки, [Выданные автомобили].Сумма, [Выданные автомобили].Скидка, [Выданные автомобили].Итоговая_сумма FROM[Выданные автомобили] JOIN Клиенты on Клиенты.Код_клиента = [Выданные автомобили].Код_клиента JOIN Автомобили on Автомобили.Код_авто = [Выданные автомобили].Код_авто JOIN[Система скидок] on [Система скидок].Код_скидки = [Выданные автомобили].Наименование_скидки";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
