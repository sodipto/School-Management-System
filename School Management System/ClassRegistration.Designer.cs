namespace School_Management_System
{
    partial class ClassRegistration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Class_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Section_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Year_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.S_name = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Roll_textBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Search_admission_id = new System.Windows.Forms.Button();
            this.aid_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Class_Registration = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Location = new System.Drawing.Point(13, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 324);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Next Class Registration";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Class_comboBox);
            this.groupBox4.Location = new System.Drawing.Point(15, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 76);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CLASS";
            // 
            // Class_comboBox
            // 
            this.Class_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Class_comboBox.FormattingEnabled = true;
            this.Class_comboBox.Location = new System.Drawing.Point(29, 33);
            this.Class_comboBox.Name = "Class_comboBox";
            this.Class_comboBox.Size = new System.Drawing.Size(133, 23);
            this.Class_comboBox.TabIndex = 0;
            this.Class_comboBox.Text = "Select Class";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Section_comboBox);
            this.groupBox6.Location = new System.Drawing.Point(15, 234);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 76);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SECTION";
            // 
            // Section_comboBox
            // 
            this.Section_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Section_comboBox.FormattingEnabled = true;
            this.Section_comboBox.Location = new System.Drawing.Point(33, 36);
            this.Section_comboBox.Name = "Section_comboBox";
            this.Section_comboBox.Size = new System.Drawing.Size(133, 23);
            this.Section_comboBox.TabIndex = 0;
            this.Section_comboBox.Text = "Select Section";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Year_comboBox);
            this.groupBox7.Location = new System.Drawing.Point(243, 234);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 76);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "YEAR";
            // 
            // Year_comboBox
            // 
            this.Year_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_comboBox.FormattingEnabled = true;
            this.Year_comboBox.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.Year_comboBox.Location = new System.Drawing.Point(29, 36);
            this.Year_comboBox.Name = "Year_comboBox";
            this.Year_comboBox.Size = new System.Drawing.Size(133, 23);
            this.Year_comboBox.TabIndex = 0;
            this.Year_comboBox.Text = "Select Year";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.S_name);
            this.groupBox2.Location = new System.Drawing.Point(243, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 76);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STUDENT NAME";
            // 
            // S_name
            // 
            this.S_name.Location = new System.Drawing.Point(17, 33);
            this.S_name.Name = "S_name";
            this.S_name.Size = new System.Drawing.Size(160, 22);
            this.S_name.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Roll_textBox);
            this.groupBox3.Location = new System.Drawing.Point(243, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 76);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ROLL";
            // 
            // Roll_textBox
            // 
            this.Roll_textBox.Location = new System.Drawing.Point(17, 33);
            this.Roll_textBox.Name = "Roll_textBox";
            this.Roll_textBox.Size = new System.Drawing.Size(160, 22);
            this.Roll_textBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Search_admission_id);
            this.groupBox5.Controls.Add(this.aid_textBox);
            this.groupBox5.Location = new System.Drawing.Point(15, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 76);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ADMISSION ID";
            // 
            // Search_admission_id
            // 
            this.Search_admission_id.BackColor = System.Drawing.Color.Honeydew;
            this.Search_admission_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_admission_id.Location = new System.Drawing.Point(29, 47);
            this.Search_admission_id.Name = "Search_admission_id";
            this.Search_admission_id.Size = new System.Drawing.Size(64, 23);
            this.Search_admission_id.TabIndex = 1;
            this.Search_admission_id.Text = "Search";
            this.Search_admission_id.UseVisualStyleBackColor = false;
            this.Search_admission_id.Click += new System.EventHandler(this.Search_admission_id_Click);
            // 
            // aid_textBox
            // 
            this.aid_textBox.Location = new System.Drawing.Point(29, 21);
            this.aid_textBox.Name = "aid_textBox";
            this.aid_textBox.Size = new System.Drawing.Size(133, 22);
            this.aid_textBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Class_Registration);
            this.panel2.Controls.Add(this.Reset_button);
            this.panel2.Location = new System.Drawing.Point(117, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 71);
            this.panel2.TabIndex = 5;
            // 
            // Class_Registration
            // 
            this.Class_Registration.BackColor = System.Drawing.Color.White;
            this.Class_Registration.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Class_Registration.FlatAppearance.BorderSize = 2;
            this.Class_Registration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Class_Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Class_Registration.Location = new System.Drawing.Point(17, 21);
            this.Class_Registration.Name = "Class_Registration";
            this.Class_Registration.Size = new System.Drawing.Size(93, 30);
            this.Class_Registration.TabIndex = 2;
            this.Class_Registration.Text = "Registration";
            this.Class_Registration.UseVisualStyleBackColor = false;
            this.Class_Registration.Click += new System.EventHandler(this.Class_Registration_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.Reset_button.FlatAppearance.BorderSize = 2;
            this.Reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_button.Location = new System.Drawing.Point(127, 21);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(96, 30);
            this.Reset_button.TabIndex = 1;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // ClassRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(558, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ClassRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassRegistration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Class_comboBox;
        private System.Windows.Forms.ComboBox Section_comboBox;
        private System.Windows.Forms.ComboBox Year_comboBox;
        private System.Windows.Forms.TextBox S_name;
        private System.Windows.Forms.TextBox aid_textBox;
        private System.Windows.Forms.TextBox Roll_textBox;
        private System.Windows.Forms.Button Search_admission_id;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Class_Registration;
    }
}