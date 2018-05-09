namespace School_Management_System
{
    partial class LibraryBookDetails
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Book_id_Search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Book_edition_textBox = new System.Windows.Forms.TextBox();
            this.Book_title_textBox = new System.Windows.Forms.TextBox();
            this.Book_id_textBox = new System.Windows.Forms.TextBox();
            this.Reset_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Insert_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.Book_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 693);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Book_dataGridView);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book Entry/Update";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Book_id_Search);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(594, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 68);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Id Search";
            // 
            // Book_id_Search
            // 
            this.Book_id_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Book_id_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Book_id_Search.Location = new System.Drawing.Point(45, 30);
            this.Book_id_Search.Multiline = true;
            this.Book_id_Search.Name = "Book_id_Search";
            this.Book_id_Search.Size = new System.Drawing.Size(147, 22);
            this.Book_id_Search.TabIndex = 0;
            this.Book_id_Search.TextChanged += new System.EventHandler(this.Book_id_Search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Book_edition_textBox);
            this.groupBox1.Controls.Add(this.Book_title_textBox);
            this.groupBox1.Controls.Add(this.Book_id_textBox);
            this.groupBox1.Controls.Add(this.Reset_button);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Delete_button);
            this.groupBox1.Controls.Add(this.Update_button);
            this.groupBox1.Controls.Add(this.Insert_button);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(18, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 306);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // Book_edition_textBox
            // 
            this.Book_edition_textBox.Location = new System.Drawing.Point(166, 149);
            this.Book_edition_textBox.Multiline = true;
            this.Book_edition_textBox.Name = "Book_edition_textBox";
            this.Book_edition_textBox.Size = new System.Drawing.Size(223, 29);
            this.Book_edition_textBox.TabIndex = 12;
            // 
            // Book_title_textBox
            // 
            this.Book_title_textBox.Location = new System.Drawing.Point(166, 100);
            this.Book_title_textBox.Multiline = true;
            this.Book_title_textBox.Name = "Book_title_textBox";
            this.Book_title_textBox.Size = new System.Drawing.Size(223, 29);
            this.Book_title_textBox.TabIndex = 12;
            // 
            // Book_id_textBox
            // 
            this.Book_id_textBox.Location = new System.Drawing.Point(166, 46);
            this.Book_id_textBox.Multiline = true;
            this.Book_id_textBox.Name = "Book_id_textBox";
            this.Book_id_textBox.Size = new System.Drawing.Size(223, 29);
            this.Book_id_textBox.TabIndex = 12;
            // 
            // Reset_button
            // 
            this.Reset_button.FlatAppearance.BorderSize = 2;
            this.Reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_button.Location = new System.Drawing.Point(355, 260);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(93, 31);
            this.Reset_button.TabIndex = 11;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(309, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.FlatAppearance.BorderSize = 2;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Location = new System.Drawing.Point(240, 260);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(109, 31);
            this.Delete_button.TabIndex = 11;
            this.Delete_button.Text = "Delete Book";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.FlatAppearance.BorderSize = 2;
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Location = new System.Drawing.Point(127, 260);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(105, 31);
            this.Update_button.TabIndex = 11;
            this.Update_button.Text = "Update Book";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Insert_button
            // 
            this.Insert_button.FlatAppearance.BorderSize = 2;
            this.Insert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_button.Location = new System.Drawing.Point(22, 260);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(94, 31);
            this.Insert_button.TabIndex = 11;
            this.Insert_button.Text = "Insert Book";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(179, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Return ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 23);
            this.label17.TabIndex = 6;
            this.label17.Text = "Book Title         :";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(18, 155);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(142, 23);
            this.label23.TabIndex = 2;
            this.label23.Text = "Book Edition     :";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(18, 49);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(129, 23);
            this.label25.TabIndex = 0;
            this.label25.Text = "Book Id             :";
            // 
            // Book_dataGridView
            // 
            this.Book_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Book_dataGridView.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.Book_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Book_dataGridView.Location = new System.Drawing.Point(508, 155);
            this.Book_dataGridView.Name = "Book_dataGridView";
            this.Book_dataGridView.RowHeadersWidth = 140;
            this.Book_dataGridView.Size = new System.Drawing.Size(395, 298);
            this.Book_dataGridView.TabIndex = 7;
            this.Book_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Book_dataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(919, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Entry";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LibraryBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 555);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "LibraryBookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryBookDetails";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Book_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Book_id_Search;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.TextBox Book_edition_textBox;
        private System.Windows.Forms.TextBox Book_title_textBox;
        private System.Windows.Forms.TextBox Book_id_textBox;
    }
}