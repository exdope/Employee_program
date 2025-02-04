using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IS_labor_protection
{

    public partial class Form2 : Form
    {

        public static string userL = "";
        DataBase _dataBase = new DataBase();
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            ShowIcon = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.ShowDialog();
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var label = Class1.TextboxDesign();
            var label2 = Class1.TextboxDesign();
            textBox1.Controls.Add(label);
            textBox2.Controls.Add(label2);
            textBox2.PasswordChar = '•';
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            userL = loginUser.ToString();
            var passwordUser = textBox2.Text;
            string adminRights = "full";
            string EmployerRights = "Employer";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string rootquerry = $"select acces_rights from admins where acces_rights = '{adminRights}'";
            string querryString = $"select login,password from admins where login = '{loginUser}' and password = '{passwordUser}'";

            try
            {

                SqlCommand command = new SqlCommand(querryString, _dataBase.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы успешно авторизировались");
                    MainForm form = new MainForm();
                    SqlCommand command1 = new SqlCommand(rootquerry, _dataBase.getConnection());
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show($"Добро пожаловать {loginUser} c правами {adminRights}");
                        this.Close();
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show($"Добро пожаловать {loginUser} c правами {EmployerRights}");
                    }

                    
                }
                else
                {
                    MessageBox.Show("Такого аккаунта не существует");
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            var t = Task.Run(async delegate //создали асинхронную переменную для создания задержки
            {
                await Task.Delay(3000); //Установили значение задержки на 3 секунды 

            });
            t.Wait();
            textBox2.UseSystemPasswordChar = false;
        }
    }
}
