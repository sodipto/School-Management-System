namespace School_Management_System
{
    partial class SubjectEntry
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
            this.SubjectList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.code_textBox = new System.Windows.Forms.TextBox();
            this.Class_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sub_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectList)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubjectList
            // 
            this.SubjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.SubjectList.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.SubjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectList.GridColor = System.Drawing.Color.DarkCyan;
            this.SubjectList.Location = new System.Drawing.Point(46, 277);
            this.SubjectList.Name = "SubjectList";
            this.SubjectList.RowHeadersWidth = 180;
            this.SubjectList.Size = new System.Drawing.Size(437, 178);
            this.SubjectList.TabIndex = 10;
            this.SubjectList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectList_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Reset_button);
            this.panel1.Controls.Add(this.Update_button);
            this.panel1.Controls.Add(this.Delete_button);
            this.panel1.Controls.Add(this.Save_button);
            this.panel1.Location = new System.Drawing.Point(527, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 160);
            this.panel1.TabIndex = 8;
            // 
            // Reset_button
            // 
            this.Reset_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_button.Location = new System.Drawing.Point(13, 125);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(89, 23);
            this.Reset_button.TabIndex = 0;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Location = new System.Drawing.Point(13, 50);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(89, 23);
            this.Update_button.TabIndex = 0;
            this.Update_button.Text = "UPDATE";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Location = new System.Drawing.Point(13, 15);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(89, 23);
            this.Save_button.TabIndex = 0;
            this.Save_button.Text = "SAVE";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sub_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.code_textBox);
            this.groupBox1.Controls.Add(this.Class_comboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "School Fee Info";
            // 
            // code_textBox
            // 
            this.code_textBox.Location = new System.Drawing.Point(161, 74);
            this.code_textBox.Multiline = true;
            this.code_textBox.Name = "code_textBox";
            this.code_textBox.Size = new System.Drawing.Size(232, 23);
            this.code_textBox.TabIndex = 4;
            // 
            // Class_comboBox
            // 
            this.Class_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Class_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Class_comboBox.FormattingEnabled = true;
            this.Class_comboBox.Location = new System.Drawing.Point(156, 26);
            this.Class_comboBox.Name = "Class_comboBox";
            this.Class_comboBox.Size = new System.Drawing.Size(237, 21);
            this.Class_comboBox.TabIndex = 3;
            this.Class_comboBox.SelectedIndexChanged += new System.EventHandler(this.FeeName_comboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Subject Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sub_textBox
            // 
            this.sub_textBox.Location = new System.Drawing.Point(156, 117);
            this.sub_textBox.Multiline = true;
            this.sub_textBox.Name = "sub_textBox";
            this.sub_textBox.Size = new System.Drawing.Size(237, 20);
            this.sub_textBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Subject";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Location = new System.Drawing.Point(13, 84);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(89, 23);
            this.Delete_button.TabIndex = 6;
            this.Delete_button.Text = "DELETE";
            this.Delete_button.UseVisualStyleBackColor = false;
            // 
            // SubjectEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(689, 521);
            this.Controls.Add(this.SubjectList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SubjectEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubjectEntry";
            ((System.ComponentModel.ISupportInitialize)(this.SubjectList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SubjectList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox code_textBox;
        private System.Windows.Forms.ComboBox Class_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.TextBox sub_textBox;
        private System.Windows.Forms.Label label2;
    }
}