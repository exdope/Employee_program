using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using Application = System.Windows.Forms.Application;
namespace IS_labor_protection
{
    public partial class Documents : Form
    {
        private Form active;
        public Documents()
        {
 

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Documents_Load(object sender, EventArgs e)
        {
          
        }

        
       
        private void panelForm(Form fm)
        {
            if (active != null)
                active.Close();
            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fm);
            this.panel2.Tag = fm;
            fm.BringToFront();
            fm.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelForm(new AdditionalOrd());
        }
    }

    }

