using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace IS_labor_protection
{
    public partial class MainForm : Form
    {
        private Form active;
        public MainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = $"Приветсвтуем,{Form2.userL}!";


        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            this.MaximizeBox = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var label = Class1.ActiveButtonDesign();
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.Controls.Add(label);

            pictureBox3.Controls.Clear();
            pictureBox3.BackColor = Color.SlateGray;
            pictureBox2.Controls.Clear();
            pictureBox2.BackColor = Color.SlateGray;
            pictureBox5.Controls.Clear();
            pictureBox5.BackColor = Color.SlateGray;
            pictureBox4.Controls.Clear();
            pictureBox4.BackColor = Color.SlateGray;
            panelForm(new Employers());
            label3.Visible = false; 
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            var label = Class1.ActiveButtonDesign();
            pictureBox2.BackColor = Color.LightSteelBlue;
            pictureBox2.Controls.Add(label);

            pictureBox3.Controls.Clear();
            pictureBox3.BackColor = Color.SlateGray;
            pictureBox1.Controls.Clear();
            pictureBox1.BackColor = Color.SlateGray;
            pictureBox5.Controls.Clear();
            pictureBox5.BackColor = Color.SlateGray;
            pictureBox4.Controls.Clear();
            pictureBox4.BackColor = Color.SlateGray;
            panelForm(new Settings());
            label3.Visible = false;


        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var label = Class1.ActiveButtonDesign();
            pictureBox3.BackColor = Color.LightSteelBlue;
            pictureBox3.Controls.Add(label);

            pictureBox2.Controls.Clear();
            pictureBox2.BackColor = Color.SlateGray;
            pictureBox1.Controls.Clear();
            pictureBox1.BackColor = Color.SlateGray;
            pictureBox5.Controls.Clear();
            pictureBox5.BackColor = Color.SlateGray;
            pictureBox4.Controls.Clear();
            pictureBox4.BackColor = Color.SlateGray;
            panelForm(new Factorys());
            label3.Visible = false;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var label = Class1.ActiveButtonDesign();
            pictureBox4.BackColor = Color.LightSteelBlue;
            pictureBox4.Controls.Add(label);

            pictureBox2.Controls.Clear();
            pictureBox2.BackColor = Color.SlateGray;
            pictureBox1.Controls.Clear();
            pictureBox1.BackColor = Color.SlateGray;
            pictureBox5.Controls.Clear();
            pictureBox5.BackColor = Color.SlateGray;
            pictureBox3.Controls.Clear();
            pictureBox3.BackColor = Color.SlateGray;
            panelForm(new Documents());
            label3.Visible = false;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var label = Class1.ActiveButtonDesign();
            pictureBox5.BackColor = Color.LightSteelBlue;
            pictureBox5.Controls.Add(label);

            pictureBox2.Controls.Clear();
            pictureBox2.BackColor = Color.SlateGray;
            pictureBox1.Controls.Clear();
            pictureBox1.BackColor = Color.SlateGray;
            pictureBox3.Controls.Clear();
            pictureBox3.BackColor = Color.SlateGray;
            pictureBox4.Controls.Clear();
            pictureBox4.BackColor = Color.SlateGray;
            panelForm(new Search());
            label3.Visible = false;

        }
        private void panelForm(Form fm)
        {
            if (active != null)
                active.Close();
            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fm);
            this.panel3.Tag = fm;
            fm.BringToFront();
            fm.Show();

        }


        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
