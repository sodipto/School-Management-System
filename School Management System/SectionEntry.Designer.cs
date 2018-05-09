namespace School_Management_System
{
    partial class SectionEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionEntry));
            this.S_id = new System.Windows.Forms.TextBox();
            this.Section_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.New_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Section_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Section_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // S_id
            // 
            this.S_id.Location = new System.Drawing.Point(458, 20);
            this.S_id.Name = "S_id";
            this.S_id.Size = new System.Drawing.Size(50, 20);
            this.S_id.TabIndex = 7;
            // 
            // Section_dataGridView
            // 
            this.Section_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Section_dataGridView.ColumnHeadersHeight = 25;
            this.Section_dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Section_dataGridView.Location = new System.Drawing.Point(116, 318);
            this.Section_dataGridView.Name = "Section_dataGridView";
            this.Section_dataGridView.RowHeadersWidth = 100;
            this.Section_dataGridView.Size = new System.Drawing.Size(312, 183);
            this.Section_dataGridView.TabIndex = 6;
            this.Section_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Section_dataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Delete_button);
            this.panel1.Controls.Add(this.Update_button);
            this.panel1.Controls.Add(this.Save_button);
            this.panel1.Controls.Add(this.New_button);
            this.panel1.Location = new System.Drawing.Point(116, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 72);
            this.panel1.TabIndex = 5;
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.White;
            this.Delete_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Delete_button.FlatAppearance.BorderSize = 2;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Location = new System.Drawing.Point(236, 19);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(65, 30);
            this.Delete_button.TabIndex = 0;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.White;
            this.Update_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Update_button.FlatAppearance.BorderSize = 2;
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Location = new System.Drawing.Point(156, 19);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(74, 30);
            this.Update_button.TabIndex = 0;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.White;
            this.Save_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Save_button.FlatAppearance.BorderSize = 2;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Location = new System.Drawing.Point(85, 19);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(65, 30);
            this.Save_button.TabIndex = 0;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // New_button
            // 
            this.New_button.BackColor = System.Drawing.Color.White;
            this.New_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.New_button.FlatAppearance.BorderSize = 2;
            this.New_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_button.Location = new System.Drawing.Point(14, 19);
            this.New_button.Name = "New_button";
            this.New_button.Size = new System.Drawing.Size(65, 30);
            this.New_button.TabIndex = 0;
            this.New_button.Text = "New";
            this.New_button.UseVisualStyleBackColor = false;
            this.New_button.Click += new System.EventHandler(this.New_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.Section_textBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(116, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section Name";
            // 
            // Section_textBox
            // 
            this.Section_textBox.Location = new System.Drawing.Point(29, 39);
            this.Section_textBox.Name = "Section_textBox";
            this.Section_textBox.Size = new System.Drawing.Size(209, 26);
            this.Section_textBox.TabIndex = 0;
            // 
            // SectionEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 513);
            this.Controls.Add(this.S_id);
            this.Controls.Add(this.Section_dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SectionEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SectionEntry";
            ((System.ComponentModel.ISupportInitialize)(this.Section_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox S_id;
        private System.Windows.Forms.DataGridView Section_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button New_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Section_textBox;
    }
}