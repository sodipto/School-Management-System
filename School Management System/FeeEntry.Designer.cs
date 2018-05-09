namespace School_Management_System
{
    partial class FeeEntry
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
            this.Amount_textBox = new System.Windows.Forms.TextBox();
            this.Class_comboBox = new System.Windows.Forms.ComboBox();
            this.FeeName_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.FeeList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Fee_Entry_id = new System.Windows.Forms.TextBox();
            this.Search_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Amount_textBox);
            this.groupBox1.Controls.Add(this.Class_comboBox);
            this.groupBox1.Controls.Add(this.FeeName_comboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(83, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "School Fee Info";
            // 
            // Amount_textBox
            // 
            this.Amount_textBox.Location = new System.Drawing.Point(161, 106);
            this.Amount_textBox.Multiline = true;
            this.Amount_textBox.Name = "Amount_textBox";
            this.Amount_textBox.Size = new System.Drawing.Size(158, 23);
            this.Amount_textBox.TabIndex = 4;
            // 
            // Class_comboBox
            // 
            this.Class_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Class_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Class_comboBox.FormattingEnabled = true;
            this.Class_comboBox.Location = new System.Drawing.Point(161, 64);
            this.Class_comboBox.Name = "Class_comboBox";
            this.Class_comboBox.Size = new System.Drawing.Size(237, 21);
            this.Class_comboBox.TabIndex = 3;
            // 
            // FeeName_comboBox
            // 
            this.FeeName_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FeeName_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FeeName_comboBox.FormattingEnabled = true;
            this.FeeName_comboBox.Location = new System.Drawing.Point(161, 26);
            this.FeeName_comboBox.Name = "FeeName_comboBox";
            this.FeeName_comboBox.Size = new System.Drawing.Size(237, 21);
            this.FeeName_comboBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fee Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Reset_button);
            this.panel1.Controls.Add(this.Delete_button);
            this.panel1.Controls.Add(this.Update_button);
            this.panel1.Controls.Add(this.Save_button);
            this.panel1.Location = new System.Drawing.Point(564, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 160);
            this.panel1.TabIndex = 2;
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
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Location = new System.Drawing.Point(13, 86);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(89, 23);
            this.Delete_button.TabIndex = 0;
            this.Delete_button.Text = "DELETE";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
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
            // FeeList
            // 
            this.FeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.FeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeeList.GridColor = System.Drawing.Color.DarkCyan;
            this.FeeList.Location = new System.Drawing.Point(83, 280);
            this.FeeList.Name = "FeeList";
            this.FeeList.RowHeadersWidth = 112;
            this.FeeList.Size = new System.Drawing.Size(446, 210);
            this.FeeList.TabIndex = 3;
            this.FeeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeeList_CellClick);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fee_Entry_id
            // 
            this.Fee_Entry_id.Location = new System.Drawing.Point(616, 229);
            this.Fee_Entry_id.Name = "Fee_Entry_id";
            this.Fee_Entry_id.Size = new System.Drawing.Size(63, 20);
            this.Fee_Entry_id.TabIndex = 5;
            // 
            // Search_comboBox
            // 
            this.Search_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Search_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Search_comboBox.FormattingEnabled = true;
            this.Search_comboBox.Location = new System.Drawing.Point(383, 242);
            this.Search_comboBox.Name = "Search_comboBox";
            this.Search_comboBox.Size = new System.Drawing.Size(146, 21);
            this.Search_comboBox.TabIndex = 6;
            this.Search_comboBox.SelectedIndexChanged += new System.EventHandler(this.Search_comboBox_SelectedIndexChanged);
            // 
            // FeeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(689, 521);
            this.Controls.Add(this.Search_comboBox);
            this.Controls.Add(this.Fee_Entry_id);
            this.Controls.Add(this.FeeList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FeeEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fee Entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
       // private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox Amount_textBox;
        private System.Windows.Forms.ComboBox Class_comboBox;
        private System.Windows.Forms.ComboBox FeeName_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.DataGridView FeeList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fee_Entry_id;
        private System.Windows.Forms.ComboBox Search_comboBox;


    }
}