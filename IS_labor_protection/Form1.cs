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
using System.Diagnostics;
using System.Timers;
using System.Threading;

namespace IS_labor_protection
{

    public partial class Form1 : Form
    {
        DataBase _dataBase = new DataBase();
        Form2 form = new Form2();
        public Form1()
        {
            
            InitializeComponent();
            
            StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            ShowIcon = false;  
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var label = Class1.TextboxDesign();
            var label2 = Class1.TextboxDesign();
            var label3 = Class1.TextboxDesign();
            textBox2.Controls.Add(label);
            textBox1.Controls.Add(label2);
            textBox3.Controls.Add(label3);
            textBox2.PasswordChar = '•';
            textBox3.PasswordChar = '•';
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
            textBox3.MaxLength = 50;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var passwordUser = textBox2.Text;
            string pas = textBox2.Text;
            string repeatedPas = textBox3.Text;
            string querryString = $"insert into admins (login,password,acces_rights) values ('{loginUser}','{passwordUser}','full')";
           
            if (pas == repeatedPas)
            {
                try
                {
                    SqlCommand command = new SqlCommand(querryString,_dataBase.getConnection());
                    _dataBase.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Аккаунт создан, теперь авторизируйтесь");
                        _dataBase.CloseConnection();
                    }
                    
                
                }
                catch
                {
                    MessageBox.Show("Неизвестная ошибка!");
                }
            }
            else
                MessageBox.Show("Пароли не совпадают");

        }

        private async void pictureBox1_Click(object sender, EventArgs e)
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
