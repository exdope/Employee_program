using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace IS_labor_protection
{

    public partial class AdditionalOrd : Form
    {
        string TemplateFileName = "";
        DataBase _database = new DataBase();
        string[] nameArr = new string[2];
        readonly string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public AdditionalOrd()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            
            string docName = textBox2.Text;

            var numb = textBox1.Text;
            var date = dateTimePicker1.Value.ToShortDateString();
            var orgName = textBox3.Text;
            var empName = textBox4.Text;
            var addOrder = textBox5.Text;
          

            var wordApp = new Word.Application();
            wordApp.Visible = false;
            int i = 0;
            try
            {
                if (numb != null && date != null && orgName != null && empName != null && addOrder != null && docName != null)
                {
                    PathFinder();
                    var wordDoc = wordApp.Documents.Open(TemplateFileName);
                    ReplaceWord("{Numb}", numb, wordDoc);
                    ReplaceWord("{date}", date, wordDoc);
                    ReplaceWord("{WorkOrg}", orgName, wordDoc);
                    ReplaceWord("{employee}", empName, wordDoc);
                    ReplaceWord("{additionalUpd}", addOrder, wordDoc);


                    wordDoc.SaveAs2($"{path}\\dox\\FinalDox\\{docName}.doc");
                    i = 1;
                    if(i == 1)
                        nameSplitter(empName);
                    MessageBox.Show("Файл успешно создан");
                    
                }
                else
                    MessageBox.Show("Заполните все строки");
            }

            catch (Exception ex) { MessageBox.Show(Convert.ToString(ex)); }
            finally
            {
               
                wordApp.Application.Quit();
               

            }
        }
        private void ReplaceWord(string stringToReplace, string text, Word.Document wordDoc)
        {
            var range = wordDoc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stringToReplace, ReplaceWith: text);


        }
        private void nameSplitter(string Fullnames) //оно впринципе работает но надо добавить заменение контрактов 
                                                    //таким же айди работника, тоесть если заключено доп соглашение
        {
            try
            {
                nameArr = Fullnames.Split(' ');
                string name = nameArr[0];
                string Secname = nameArr[1];
                string surname = nameArr[2];
                string querry = $"select employee_id from Employers where [Name] = '{name}' and Second_name = '{Secname}' and surname = '{surname}';";
                SqlCommand command = new SqlCommand(querry, _database.getConnection());
                _database.openConnection();
                int resultId = (int)command.ExecuteScalar();
                _database.CloseConnection();
                string TF= "";

                if (comboBox1.SelectedIndex == 0)
                    TF = "true";
                else
                    TF = "false";

                 string secQuerry = $"insert into EmploymentContracts (EmpContract,Addcontract,empId) values ('true','{TF}','{resultId}')";
                SqlCommand command1 = new SqlCommand(secQuerry, _database.getConnection());
                _database.openConnection();
                if (command1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные о договоре добавлены в базу");
                    _database.CloseConnection( );
                }
                else 
                    _database.CloseConnection( );
               
                
            }
            catch
            {
                MessageBox.Show("Ошибка разделения строки или обращения к базе данных");
            }
        }
        private string PathFinder()
        {

            if (comboBox1.SelectedIndex == 0)
                TemplateFileName = $"{path}\\dox\\ДопСогл.docx";
            if (comboBox1.SelectedIndex == 1)
                TemplateFileName = $"{path}\\dox\\ТрудДоговор.docx";
            return TemplateFileName;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}
