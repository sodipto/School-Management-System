namespace School_Management_System
{
    partial class ReturnBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Return_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Late_Fine_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Late_Days_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Return_On_Date_label = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Return_Date_label = new System.Windows.Forms.Label();
            this.Borrow_Date_label = new System.Windows.Forms.Label();
            this.Book_Title_label = new System.Windows.Forms.Label();
            this.Book_id_label = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Addmission_Id_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Addmission_id_Search = new System.Windows.Forms.TextBox();
            this.Return_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Return_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Return Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Reset_button);
            this.groupBox2.Controls.Add(this.Return_button);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Late_Fine_label);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Late_Days_label);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.Return_On_Date_label);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.Return_Date_label);
            this.groupBox2.Controls.Add(this.Borrow_Date_label);
            this.groupBox2.Controls.Add(this.Book_Title_label);
            this.groupBox2.Controls.Add(this.Book_id_label);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.Addmission_Id_label);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 476);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Information";
            // 
            // Reset_button
            // 
            this.Reset_button.FlatAppearance.BorderSize = 2;
            this.Reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_button.Location = new System.Drawing.Point(309, 425);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(93, 31);
            this.Reset_button.TabIndex = 11;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Return_button
            // 
            this.Return_button.FlatAppearance.BorderSize = 2;
            this.Return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return_button.Location = new System.Drawing.Point(179, 425);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(94, 31);
            this.Return_button.TabIndex = 11;
            this.Return_button.Text = "Return ";
            this.Return_button.UseVisualStyleBackColor = true;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "Borrow Date :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Late Fine :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Late Days :";
            // 
            // Late_Fine_label
            // 
            this.Late_Fine_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Late_Fine_label.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Late_Fine_label.ForeColor = System.Drawing.SystemColors.Window;
            this.Late_Fine_label.Location = new System.Drawing.Point(179, 375);
            this.Late_Fine_label.Name = "Late_Fine_label";
            this.Late_Fine_label.Size = new System.Drawing.Size(223, 29);
            this.Late_Fine_label.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Return  On Date :";
            // 
            // Late_Days_label
            // 
            this.Late_Days_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Late_Days_label.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Late_Days_label.ForeColor = System.Drawing.SystemColors.Window;
            this.Late_Days_label.Location = new System.Drawing.Point(179, 334);
            this.Late_Days_label.Name = "Late_Days_label";
            this.Late_Days_label.Size = new System.Drawing.Size(223, 29);
            this.Late_Days_label.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "Return Date :";
            // 
            // Return_On_Date_label
            // 
            this.Return_On_Date_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Return_On_Date_label.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_On_Date_label.ForeColor = System.Drawing.SystemColors.Window;
            this.Return_On_Date_label.Location = new System.Drawing.Point(179, 293);
            this.Return_On_Date_label.Name = "Return_On_Date_label";
            this.Return_On_Date_label.Size = new System.Drawing.Size(223, 29);
            this.Return_On_Date_label.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 23);
            this.label16.TabIndex = 6;
            this.label16.Text = "Book Title    :";
            // 
            // Return_Date_label
            // 
            this.Return_Date_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Return_Date_label.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_Date_label.ForeColor = System.Drawing.SystemColors.Window;
            this.Return_Date_label.Location = new System.Drawing.Point(179, 248);
            this.Return_Date_label.Name = "Return_Date_label";
            this.Return_Date_label.Size = new System.Drawing.Size(223, 29);
            this.Return_Date_label.TabIndex = 7;
            // 
            // Borrow_Date_label
            // 
            this.Borrow_Date_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Borrow_Date_label.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow_Date_label.ForeColor = System.Drawing.SystemColors.Window;
            this.Borrow_Date_label.Location = new System.Drawing.Point(179, 195);
            this.Borrow_Date_label.Name = "Borrow_Date_label";
            this.Borrow_Date_label.Size = new System.Drawing.Size(223, 29);
            this.Borrow_Date_label.TabIndex = 8;
            // 
            // Book_Title_label
            // 
            this.Book_Title_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Book_Title_label.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Title_label.ForeColor = System.Drawing.SystemColors.Window;
            this.Book_Title_label.Location = new System.Drawing.Point(179, 143);
            this.Book_Title_label.Name = "Book_Title_label";
            this.Book_Title_label.Size = new System.Drawing.Size(223, 29);
            this.Book_Title_label.TabIndex = 10;
            // 
            // Book_id_label
            // 
            this.Book_id_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Book_id_label.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_id_label.ForeColor = System.Drawing.SystemColors.Window;
            this.Book_id_label.Location = new System.Drawing.Point(179, 91);
            this.Book_id_label.Name = "Book_id_label";
            this.Book_id_label.Size = new System.Drawing.Size(223, 29);
            this.Book_id_label.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(18, 97);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 23);
            this.label21.TabIndex = 2;
            this.label21.Text = "Book Id       :";
            // 
            // Addmission_Id_label
            // 
            this.Addmission_Id_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Addmission_Id_label.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addmission_Id_label.ForeColor = System.Drawing.SystemColors.Window;
            this.Addmission_Id_label.Location = new System.Drawing.Point(179, 38);
            this.Addmission_Id_label.Name = "Addmission_Id_label";
            this.Addmission_Id_label.Size = new System.Drawing.Size(223, 29);
            this.Addmission_Id_label.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Addmission Id :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Addmission_id_Search);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(386, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admission Id Search";
            // 
            // Addmission_id_Search
            // 
            this.Addmission_id_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Addmission_id_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Addmission_id_Search.Location = new System.Drawing.Point(41, 28);
            this.Addmission_id_Search.Multiline = true;
            this.Addmission_id_Search.Name = "Addmission_id_Search";
            this.Addmission_id_Search.Size = new System.Drawing.Size(146, 29);
            this.Addmission_id_Search.TabIndex = 0;
            this.Addmission_id_Search.TextChanged += new System.EventHandler(this.Addmission_id_Search_TextChanged);
            // 
            // Return_dataGridView
            // 
            this.Return_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Return_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Return_dataGridView.Location = new System.Drawing.Point(492, 157);
            this.Return_dataGridView.Name = "Return_dataGridView";
            this.Return_dataGridView.Size = new System.Drawing.Size(421, 466);
            this.Return_dataGridView.TabIndex = 4;
            this.Return_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Return_dataGridView_CellClick);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(925, 655);
            this.Controls.Add(this.Return_dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Return_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Addmission_Id_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Book_id_label;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Return_Date_label;
        private System.Windows.Forms.Label Borrow_Date_label;
        private System.Windows.Forms.Label Book_Title_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Late_Fine_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Late_Days_label;
        private System.Windows.Forms.Label Return_On_Date_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Addmission_id_Search;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Return_button;
        private System.Windows.Forms.DataGridView Return_dataGridView;
    }
}