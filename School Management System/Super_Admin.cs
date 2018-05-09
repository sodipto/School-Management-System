using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Super_Admin : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");

        string username_rcv;
        public Super_Admin()
        {
            InitializeComponent();
        }


        public Super_Admin(string username)
        {
            InitializeComponent();
           
            this.username_rcv = username;
            username_function();

           // user_name.Text = this.username_rcv;
        }

        public void username_function()
        {
            try
            {

                //  admission_id_label.Text = admission_id_textBox.Text;
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r1;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT s_name from admin  where username='" + this.username_rcv + "'  ";

                r1 = cmd.ExecuteReader();

                while (r1.Read())
                {



                    user_name.Text = r1.GetString("S_name");






                }






                cnn.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void Profile_button_Click(object sender, EventArgs e)
        {

            UserTypeEntry s = new UserTypeEntry();
            // this.Hide();
            s.tabPage4.Parent = null;
            s.tabPage3.Parent = null;
            s.tabPage1.Parent = null;
            s.tabPage5.Parent = null;
            s.UpdateButton.Enabled = true;
            s.Update_comboBox.Enabled = false;
            
            s.admin_Information_Update(this.username_rcv);

            s.Show();
        }

        //admin
        private void Admin_button_Click(object sender, EventArgs e)
        {
            UserTypeEntry admin = new UserTypeEntry();
            admin.Show();
        }
        //student
        private void Student_Entry_Click(object sender, EventArgs e)
        {
            StudentEntry s1 = new StudentEntry();
            s1.Show();

        }

        //Teacher
        private void Teacher_Button_Click(object sender, EventArgs e)
        {
            UserTypeEntry teacher = new UserTypeEntry();
            teacher.Show();
        }

        //Librian
        private void Librian_button_Click(object sender, EventArgs e)
        {
              UserTypeEntry librian = new UserTypeEntry();
             librian.Show();
        }

        //Subject
        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectEntry s1 = new SubjectEntry();
            s1.Show();
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassEntry c = new ClassEntry();
            c.Show();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SectionEntry s = new SectionEntry();
            s.Show();
        }

        private void feeCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeTypes f = new FeeTypes();
            f.Show();
        }

        private void feeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeEntry f1 = new FeeEntry();
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClassRegistration c1 = new ClassRegistration();
            c1.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResultShow r1 = new ResultShow();
            r1.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LibraryBookDetails lb = new LibraryBookDetails();
            lb.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marks m = new Marks();
            m.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Details s2 = new Student_Details();
            s2.Show();
        }

        private void librianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibraryDetails l1 = new LibraryDetails();
            l1.Show();
        }


        //Exit
        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



          

            




       //
    }
}
