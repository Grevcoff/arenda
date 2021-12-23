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
    public partial class Form1 : Form
    {
        static string constr = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
        string sql = "SELECT [Выданные автомобили].Код_проката, Клиенты.ФИО, Автомобили.Госномер, [Выданные автомобили].Дата_выдачи, [Выданные автомобили].Количество_дней, [Выданные автомобили].Ожидаемая_дата_возрата, [Система скидок].Наименование_скидки, [Выданные автомобили].Сумма, [Штрафы по прокату].Наименование_штрафа , [Выданные автомобили].Итоговая_сумма FROM [Выданные автомобили] JOIN Клиенты on Клиенты.Код_клиента = [Выданные автомобили].Код_клиента JOIN Автомобили on Автомобили.Код_авто = [Выданные автомобили].Код_авто JOIN[Система скидок] on [Система скидок].Код_скидки = [Выданные автомобили].Наименование_скидки JOIN [Штрафы по прокату] on [Штрафы по прокату].Код_штрафа = [Выданные автомобили].Штрафы";
        DataContext cont = new DataContext(constr);
        SqlConnection cod = new SqlConnection();
        SqlCommand cmt = new SqlCommand();
        public Form1()
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
            string sql = "Insert into [Выданные автомобили] ([Код_клиента], [Код_авто], [Дата_выдачи], [Количество_дней], [Ожидаемая_дата_возрата], [Наименование_скидки], [Сумма], [Штрафы], [Итоговая_сумма])  values ( '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox10.Text + "','" + textBox11.Text + "' )";
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
            string connecionString = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
            string sql = "SELECT [Выданные автомобили].Код_проката, Клиенты.ФИО, Автомобили.Госномер, [Выданные автомобили].Дата_выдачи, [Выданные автомобили].Количество_дней, [Выданные автомобили].Ожидаемая_дата_возрата, [Система скидок].Наименование_скидки, [Выданные автомобили].Сумма, [Штрафы по прокату].Наименование_штрафа , [Выданные автомобили].Итоговая_сумма FROM [Выданные автомобили] JOIN Клиенты on Клиенты.Код_клиента = [Выданные автомобили].Код_клиента JOIN Автомобили on Автомобили.Код_авто = [Выданные автомобили].Код_авто JOIN[Система скидок] on [Система скидок].Код_скидки = [Выданные автомобили].Наименование_скидки JOIN [Штрафы по прокату] on [Штрафы по прокату].Код_штрафа = [Выданные автомобили].Штрафы";
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
                    string constring = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
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
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void производстваToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ингредиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
            string sql = "SELECT [Выданные автомобили].Код_проката, Клиенты.ФИО, Автомобили.Госномер, [Выданные автомобили].Дата_выдачи, [Выданные автомобили].Количество_дней, [Выданные автомобили].Ожидаемая_дата_возрата, [Система скидок].Наименование_скидки, [Выданные автомобили].Сумма, [Штрафы по прокату].Наименование_штрафа , [Выданные автомобили].Итоговая_сумма FROM [Выданные автомобили] JOIN Клиенты on Клиенты.Код_клиента = [Выданные автомобили].Код_клиента JOIN Автомобили on Автомобили.Код_авто = [Выданные автомобили].Код_авто JOIN[Система скидок] on [Система скидок].Код_скидки = [Выданные автомобили].Наименование_скидки JOIN [Штрафы по прокату] on [Штрафы по прокату].Код_штрафа = [Выданные автомобили].Штрафы";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox9.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                        dataGridView1.Rows[i].Selected = false;
                    }

                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
            string sql = "SELECT * from [Выданные автомобили] where Итоговая_сумма like N'%" + textBox1.Text + "%'";
            using (SqlConnection connection = new SqlConnection(constring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
