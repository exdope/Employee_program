using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IS_labor_protection
{
    public partial class Search : Form
    {
        DataBase _database = new DataBase();
        public Search()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            string querry = $"select * from Employers where [Name] = '{textBox1.Text}'";
            OpnClsCon(querry);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string querry = $"select * from Employers where [job_title] = '{textBox2.Text}'";
            OpnClsCon(querry);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string querry = $"select * from Employers where [second_name] = '{textBox3.Text}'";
            OpnClsCon(querry);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string querry = $"select * from Employers inner join WorkPlaces on WorkPlaces.Employe_Id = Employers.employee_id where [Name] = '{textBox4.Text}' and type_of_facility = '{textBox6.Text}' and Employe_Id = employee_id and Second_name = '{textBox5.Text}' and job_title = '{textBox7.Text}';";
            OpnClsCon(querry);
        }
        private void OpnClsCon(string querry)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(querry, _database.getConnection());
            try
            {
                _database.openConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                _database.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

      
    }
}
