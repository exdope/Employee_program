using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_labor_protection
{
    public partial class Factorys : Form
    {
        DataBase _dataBase = new DataBase();
        public Factorys()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Factorys_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employer_dataBaseDataSet1.WorkPlaces". При необходимости она может быть перемещена или удалена.
            this.workPlacesTableAdapter.Fill(this.employer_dataBaseDataSet1.WorkPlaces);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string querry = $"select count(*) from WorkPlaces where type_of_facility = '{comboBox1.Text}'";
            SqlCommand command = new SqlCommand(querry,_dataBase.getConnection());
            _dataBase.openConnection();
            int result = (int)command.ExecuteScalar();
            _dataBase.CloseConnection();
            textBox1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

           string addres = "";
            if (comboBox2.SelectedIndex == 1)
                addres = "Караулова 26";
            if (comboBox2.SelectedIndex == 2)
                addres = "Апилово 52";
            if (comboBox2.SelectedIndex == 3)
                addres = "Рублево 15"; 
            if (comboBox2.SelectedIndex == 4)
                addres = "Котлово 12";
            string querry = $"insert into WorkPlaces (address,type_of_facility,Employe_Id,date_of_shifts) values ('{addres}','{comboBox2.Text}',{Convert.ToInt32(textBox2.Text)},'{comboBox3.Text}')";
            int check = EmpCheck(Convert.ToInt32(textBox2.Text));
            if (check == 1)
            {
                SqlCommand command = new SqlCommand(querry, _dataBase.getConnection());
                _dataBase.openConnection();
                try
                {
                    
                    
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Сотрудник прикреплен");
                        this.workPlacesTableAdapter.Fill(this.employer_dataBaseDataSet1.WorkPlaces);
                       _dataBase.CloseConnection();
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Сотрудник не прикреплен");
                }

            }
        }

        private int EmpCheck(int id)
        { 
            string querry = $"select employee_id from Employers where employee_id = {id}";
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(querry, _dataBase.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Такого сотрудника не существует");
                return 0;
            }
            else 
                return 1;
            
        }
    }
}
