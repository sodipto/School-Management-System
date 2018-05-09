namespace School_Management_System
{
    partial class LibraryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryDetails));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Library_Details_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Return_Book_dataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ReturnBook_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.Total_Fine = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Fine_Search_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Fine_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gender_label = new System.Windows.Forms.Label();
            this.Email_label = new System.Windows.Forms.Label();
            this.Student_name_label = new System.Windows.Forms.Label();
            this.admission_id_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Library_Details_dataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Return_Book_dataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 595);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Controls.Add(this.Search_textBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Library_Details_dataGridView);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Borrow Book";
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(669, 82);
            this.Search_textBox.Multiline = true;
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(136, 24);
            this.Search_textBox.TabIndex = 4;
            this.Search_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(588, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Library_Details_dataGridView
            // 
            this.Library_Details_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Library_Details_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Library_Details_dataGridView.Location = new System.Drawing.Point(7, 120);
            this.Library_Details_dataGridView.Name = "Library_Details_dataGridView";
            this.Library_Details_dataGridView.Size = new System.Drawing.Size(799, 369);
            this.Library_Details_dataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrow Book List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage2.Controls.Add(this.Return_Book_dataGridView);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ReturnBook_textBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ALL Return Book";
            // 
            // Return_Book_dataGridView
            // 
            this.Return_Book_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Return_Book_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Return_Book_dataGridView.Location = new System.Drawing.Point(10, 120);
            this.Return_Book_dataGridView.Name = "Return_Book_dataGridView";
            this.Return_Book_dataGridView.Size = new System.Drawing.Size(799, 369);
            this.Return_Book_dataGridView.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(809, 56);
            this.label4.TabIndex = 7;
            this.label4.Text = "Return Book List";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnBook_textBox
            // 
            this.ReturnBook_textBox.Location = new System.Drawing.Point(661, 79);
            this.ReturnBook_textBox.Multiline = true;
            this.ReturnBook_textBox.Name = "ReturnBook_textBox";
            this.ReturnBook_textBox.Size = new System.Drawing.Size(136, 24);
            this.ReturnBook_textBox.TabIndex = 6;
            this.ReturnBook_textBox.TextChanged += new System.EventHandler(this.ReturnBook_textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(580, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.Fine_listView);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(812, 569);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fine List ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.Total_Fine);
            this.panel1.Location = new System.Drawing.Point(612, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 41);
            this.panel1.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 19);
            this.label15.TabIndex = 1;
            this.label15.Text = "Total Fine :";
            // 
            // Total_Fine
            // 
            this.Total_Fine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Fine.Location = new System.Drawing.Point(103, 10);
            this.Total_Fine.Name = "Total_Fine";
            this.Total_Fine.Size = new System.Drawing.Size(68, 19);
            this.Total_Fine.TabIndex = 0;
            this.Total_Fine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Fine_Search_textBox);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Location = new System.Drawing.Point(268, 77);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(204, 73);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Admission Id Search";
            // 
            // Fine_Search_textBox
            // 
            this.Fine_Search_textBox.Location = new System.Drawing.Point(29, 33);
            this.Fine_Search_textBox.Multiline = true;
            this.Fine_Search_textBox.Name = "Fine_Search_textBox";
            this.Fine_Search_textBox.Size = new System.Drawing.Size(154, 22);
            this.Fine_Search_textBox.TabIndex = 0;
            this.Fine_Search_textBox.TextChanged += new System.EventHandler(this.Fine_Search_textBox_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(809, 56);
            this.label12.TabIndex = 8;
            this.label12.Text = "Fine List";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fine_listView
            // 
            this.Fine_listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fine_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Fine_listView.Location = new System.Drawing.Point(432, 190);
            this.Fine_listView.Name = "Fine_listView";
            this.Fine_listView.Size = new System.Drawing.Size(373, 327);
            this.Fine_listView.TabIndex = 5;
            this.Fine_listView.UseCompatibleStateImageBehavior = false;
            this.Fine_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Admisson Id";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Return On Date";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fine";
            this.columnHeader3.Width = 110;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.Gender_label);
            this.groupBox3.Controls.Add(this.Email_label);
            this.groupBox3.Controls.Add(this.Student_name_label);
            this.groupBox3.Controls.Add(this.admission_id_label);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Location = new System.Drawing.Point(6, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 327);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.ImageLocation = "25";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 160);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Gender_label
            // 
            this.Gender_label.BackColor = System.Drawing.Color.LightGray;
            this.Gender_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gender_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender_label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Gender_label.Location = new System.Drawing.Point(128, 292);
            this.Gender_label.Name = "Gender_label";
            this.Gender_label.Size = new System.Drawing.Size(211, 28);
            this.Gender_label.TabIndex = 1;
            this.Gender_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Email_label
            // 
            this.Email_label.AutoEllipsis = true;
            this.Email_label.BackColor = System.Drawing.Color.LightGray;
            this.Email_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Email_label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Email_label.Location = new System.Drawing.Point(128, 258);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(211, 28);
            this.Email_label.TabIndex = 1;
            this.Email_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Student_name_label
            // 
            this.Student_name_label.BackColor = System.Drawing.Color.LightGray;
            this.Student_name_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Student_name_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student_name_label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_name_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Student_name_label.Location = new System.Drawing.Point(128, 222);
            this.Student_name_label.Name = "Student_name_label";
            this.Student_name_label.Size = new System.Drawing.Size(211, 28);
            this.Student_name_label.TabIndex = 1;
            this.Student_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // admission_id_label
            // 
            this.admission_id_label.BackColor = System.Drawing.Color.LightGray;
            this.admission_id_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admission_id_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admission_id_label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admission_id_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.admission_id_label.Location = new System.Drawing.Point(128, 184);
            this.admission_id_label.Name = "admission_id_label";
            this.admission_id_label.Size = new System.Drawing.Size(211, 28);
            this.admission_id_label.TabIndex = 1;
            this.admission_id_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Gender           :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email                :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Student Name  :";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Admission ID  :";
            // 
            // LibraryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 593);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LibraryDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryDetails";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Library_Details_dataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Return_Book_dataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Library_Details_dataGridView;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReturnBook_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Return_Book_dataGridView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView Fine_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label Student_name_label;
        private System.Windows.Forms.Label admission_id_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Fine_Search_textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Total_Fine;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}