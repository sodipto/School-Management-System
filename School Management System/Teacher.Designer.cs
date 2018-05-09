namespace School_Management_System
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.Profile_button = new System.Windows.Forms.Button();
            this.user_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentButton = new System.Windows.Forms.Button();
            this.Markbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Profile_button
            // 
            this.Profile_button.BackColor = System.Drawing.Color.Silver;
            this.Profile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_button.Location = new System.Drawing.Point(339, 19);
            this.Profile_button.Name = "Profile_button";
            this.Profile_button.Size = new System.Drawing.Size(90, 32);
            this.Profile_button.TabIndex = 11;
            this.Profile_button.Text = "Your Profile";
            this.Profile_button.UseVisualStyleBackColor = false;
            this.Profile_button.Click += new System.EventHandler(this.Profile_button_Click);
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.Color.Silver;
            this.user_name.Location = new System.Drawing.Point(134, 19);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(189, 32);
            this.user_name.TabIndex = 10;
            this.user_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcom to :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentButton
            // 
            this.StudentButton.BackColor = System.Drawing.Color.White;
            this.StudentButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.StudentButton.FlatAppearance.BorderSize = 0;
            this.StudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StudentButton.Image = ((System.Drawing.Image)(resources.GetObject("StudentButton.Image")));
            this.StudentButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StudentButton.Location = new System.Drawing.Point(92, 153);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(130, 120);
            this.StudentButton.TabIndex = 0;
            this.StudentButton.Text = "Student Details";
            this.StudentButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StudentButton.UseVisualStyleBackColor = false;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // Markbutton
            // 
            this.Markbutton.BackColor = System.Drawing.Color.White;
            this.Markbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Markbutton.FlatAppearance.BorderSize = 0;
            this.Markbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Markbutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Markbutton.Image = ((System.Drawing.Image)(resources.GetObject("Markbutton.Image")));
            this.Markbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Markbutton.Location = new System.Drawing.Point(247, 153);
            this.Markbutton.Name = "Markbutton";
            this.Markbutton.Size = new System.Drawing.Size(130, 120);
            this.Markbutton.TabIndex = 0;
            this.Markbutton.Text = "Marks Entry";
            this.Markbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Markbutton.UseVisualStyleBackColor = false;
            this.Markbutton.Click += new System.EventHandler(this.Markbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(403, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 120);
            this.button1.TabIndex = 12;
            this.button1.Text = "ALL Result";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(559, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 120);
            this.button5.TabIndex = 13;
            this.button5.Text = "Registration";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 492);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Markbutton);
            this.Controls.Add(this.StudentButton);
            this.Controls.Add(this.Profile_button);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Profile_button;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button Markbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}