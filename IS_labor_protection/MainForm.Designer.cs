namespace IS_labor_protection
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.employer_dataBaseDataSet3 = new IS_labor_protection.employer_dataBaseDataSet();
            this.employersTableAdapter3 = new IS_labor_protection.employer_dataBaseDataSetTableAdapters.EmployersTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employerdataBaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employer_dataBaseDataSet4 = new IS_labor_protection.employer_dataBaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employer_dataBaseDataSet3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerdataBaseDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employer_dataBaseDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // employersBindingSource3
            // 
            this.employersBindingSource3.DataMember = "Employers";
            this.employersBindingSource3.DataSource = this.employer_dataBaseDataSet3;
            // 
            // employer_dataBaseDataSet3
            // 
            this.employer_dataBaseDataSet3.DataSetName = "employer_dataBaseDataSet";
            this.employer_dataBaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employersTableAdapter3
            // 
            this.employersTableAdapter3.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(733, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Завершить сеанс";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(45, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 450);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 92);
            this.label3.TabIndex = 6;
            this.label3.Text = "Нажмите на\r\n необходимую иконку";
            this.label3.UseWaitCursor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::IS_labor_protection.Properties.Resources.icons8_loupe_50__1_;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(0, 241);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::IS_labor_protection.Properties.Resources.icons8_document_50__1_;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(0, 167);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::IS_labor_protection.Properties.Resources.pngaaa_com_3787139__1_;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(0, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::IS_labor_protection.Properties.Resources.free_icon_settings_4873245__1_;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 409);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::IS_labor_protection.Properties.Resources.icons8_человек_30;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // employersBindingSource
            // 
            this.employersBindingSource.DataMember = "Employers";
            // 
            // employersBindingSource2
            // 
            this.employersBindingSource2.DataMember = "Employers";
            // 
            // employersBindingSource1
            // 
            this.employersBindingSource1.DataMember = "Employers";
            // 
            // employer_dataBaseDataSet4
            // 
            this.employer_dataBaseDataSet4.DataSetName = "employer_dataBaseDataSet";
            this.employer_dataBaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox5);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employer_dataBaseDataSet3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerdataBaseDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employer_dataBaseDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private employer_dataBaseDataSet employer_dataBaseDataSet;
        private System.Windows.Forms.BindingSource employersBindingSource;
        private employer_dataBaseDataSetTableAdapters.EmployersTableAdapter employersTableAdapter;
        private employer_dataBaseDataSet employer_dataBaseDataSet1;
        private System.Windows.Forms.BindingSource employersBindingSource1;
        private employer_dataBaseDataSetTableAdapters.EmployersTableAdapter employersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactdetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employerdataBaseDataSet2BindingSource;
        private employer_dataBaseDataSet employer_dataBaseDataSet2;
        private System.Windows.Forms.BindingSource employersBindingSource2;
        private employer_dataBaseDataSetTableAdapters.EmployersTableAdapter employersTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private employer_dataBaseDataSet employer_dataBaseDataSet3;
        private System.Windows.Forms.BindingSource employersBindingSource3;
        private employer_dataBaseDataSetTableAdapters.EmployersTableAdapter employersTableAdapter3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private employer_dataBaseDataSet employer_dataBaseDataSet4;
    }
}