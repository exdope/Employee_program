using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace IS_labor_protection
{
    public partial class Employers : Form
    {
        DataBase dataBase = new DataBase();
        public Employers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Employers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employer_dataBaseDataSet.Employers". При необходимости она может быть перемещена или удалена.
            this.employersTableAdapter.Fill(this.employer_dataBaseDataSet.Employers);
            

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string contacts = textBox2.Text;
            string job_tile = textBox3.Text;
            string name = textBox4.Text;
            string second_name = textBox6.Text;
            string surname = textBox5.Text;
            string querry = $"insert into Employers ([Contact_details],job_title,[Name],Second_name,surname) values ('{contacts}','{job_tile}','{name}','{second_name}','{surname}')";
            try
            {
                SqlCommand command = new SqlCommand(querry,dataBase.getConnection());
                dataBase.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные добавлены");
                    this.employersTableAdapter.Fill(this.employer_dataBaseDataSet.Employers);
                    dataBase.CloseConnection();
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка, Данные не добавлены");
                dataBase.CloseConnection();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int delId = Convert.ToInt32(textBox1.Text);
            string querry = $"delete from Employers where employee_id = {delId}";
            try
            {
                SqlCommand command = new SqlCommand(querry, dataBase.getConnection());
                dataBase.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные Удалены");
                    this.employersTableAdapter.Fill(this.employer_dataBaseDataSet.Employers);
                    dataBase.CloseConnection();
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка, Данные не удалены");
                dataBase.CloseConnection();
            }
        }



        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int idUpd = Convert.ToInt32(textBox7.Text);
            string querry = $"Update Employers set job_title = '{textBox8.Text}' where employee_id = {idUpd}";
           try
            {
                SqlCommand command = new SqlCommand(querry, dataBase.getConnection());
                dataBase.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные  Обновленны");
                    this.employersTableAdapter.Fill(this.employer_dataBaseDataSet.Employers);
                    dataBase.CloseConnection();
                }
            }
            catch
            {
                MessageBox.Show("Данные не Обновленны");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int updId = Convert.ToInt32(textBox9.Text);
            string contacts = textBox2.Text;
            string job_tile = textBox3.Text;
            string name = textBox4.Text;
            string second_name = textBox6.Text;
            string surname = textBox5.Text;
            string querry = $"Update Employers set [Contact_details] = '{contacts}',job_title = '{job_tile}',[Name] = '{name}',Second_name = '{second_name}',surname = '{surname}'  where employee_id = {updId}";
            SqlCommand command = new SqlCommand(querry, dataBase.getConnection());
            dataBase.openConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные  Обновленны");
                    this.employersTableAdapter.Fill(this.employer_dataBaseDataSet.Employers);
                    dataBase.CloseConnection();
                }
            }
            catch
            {
                MessageBox.Show("Данные не Обновленны");
                dataBase.CloseConnection();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2],ListSortDirection.Ascending);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void GraphicsMethod()
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black,3f);

            Point[] points = new Point[1000];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 100 + 200));
            }
            graphics.DrawLines(pen, points);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GraphicsMethod();
        }
    }
}
