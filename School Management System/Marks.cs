using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace School_Management_System
{
    public partial class Marks : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");

        int b;
        public Marks()
        {
            InitializeComponent();
            Roll_textBox.Enabled = false;      //Class ROLL text box not wirte readonly
            Subject_textBox.Enabled = false;  //subject text box not wirte readonly
            Grade_textBox.Enabled = false;   //Grade text box not wirte readonly
            S_name.Enabled = false;         //Student name text box not wirte readonly
            ClassCombo();
            SectionCombo();

            //all comboBox dissable
            Year_comboBox.Enabled = false;
            Section_comboBox.Enabled = false;
            Class_comboBox.Enabled = false;
            
            

           
        }

        public void Clear() {

            admission_id_textBox.Text = "";
            S_name.Text = "";
            Year_comboBox.Text = "";
            Class_comboBox.Text = "";
            Section_comboBox.Text = "";
            Roll_textBox.Text = "";
            Student_mark_textbox.Text = "";
            Grade_textBox.Text = "";
            Subject_code_comboBox.Text = "";
            Subject_textBox.Text = "";
            Exam_comboBox.Text = "";
           Subject_code_comboBox.Items.Clear(); //item clear when all clear

            admission_id_textBox.Enabled = true;
            Search_admission_id.Enabled = true;

            if (Class_comboBox.Text == "") {

                Subject_code_comboBox.Text = "";
            
            }
        
        }


        //fill up the Class combo
        public void ClassCombo()
        {
            try
            {

                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from class_entry";

                MySqlDataReader myreader;

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {

                    string Class_Name = myreader.GetString("ClassName");
                    Class_comboBox.Items.Add(Class_Name);


                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        //fill up the Section combo
        public void SectionCombo()
        {
            try
            {

                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from section_entry";

                MySqlDataReader myreader;

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {

                    string Section_Name = myreader.GetString("SectionName");
                    Section_comboBox.Items.Add(Section_Name);


                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        //Mark Entry Check
        public bool Marks_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from marks_entry where admission_id='" + admission_id_textBox.Text + "' AND class='" + Class_comboBox.Text + "' AND year='" + Year_comboBox.Text + "' AND exam_type='" + Exam_comboBox.Text + "' AND subject_code='" + Subject_code_comboBox.Text + "'", con);
           
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("This Admission ID  marks on this subject parpus are upload");
                return true;
            }
            else
            {
                return false;
            }
        } 


        //class combobox select class ,all the subject code in this selection class show subject code combobox
        private void Class_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conn = "server=localhost;database=School_Management;uid=root;pwd=;";

            string query = "select *from subject_entry  where class='" + Class_comboBox.Text + "' ";

            MySqlConnection connect = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, connect);
            MySqlDataReader myreader;


            try
            {

                connect.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    string ename = myreader.GetString("subject_code");

                    // comboBox2.Text = myreader.GetString("id");
                    Subject_code_comboBox.Items.Add(ename);
                    // name.Text = myreader.GetString("name");
                    // password.Text = myreader.GetString("password");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Class_comboBox.Enabled = false;
            Section_comboBox.Enabled = true ;

        }


        //subject code selectd subject name show textbox
        private void Subject_code_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conn = "server=localhost;database=School_Management;uid=root;pwd=;";

            string query = "select *from subject_entry  where subject_code='" + Subject_code_comboBox.Text + "' ";

            MySqlConnection connect = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, connect);
            MySqlDataReader myreader;


            try
            {

                connect.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {


                    Subject_textBox.Text = myreader.GetString("subject_name");
                    

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        /*
         private void admission_id_textBox_TextChanged(object sender, EventArgs e)
         {
              

             if (admission_id_textBox.Text == "")
             {


              S_name.Text = "";
             

             }


             string conn = "server=localhost;database=School_Management;uid=root;pwd=;";

             string query = "SELECT student.s_name FROM student INNER JOIN class_registration ON student.admission_id =class_registration.admission_id  where class_registration.admission_id='" + admission_id_textBox.Text + "' ";

             MySqlConnection connect = new MySqlConnection(conn);
             MySqlCommand cmd = new MySqlCommand(query, connect);
             MySqlDataReader myreader;


             try
             {

                 connect.Open();

                 myreader = cmd.ExecuteReader();

                 while (myreader.Read())
                 {

                     S_name.Text = myreader.GetString("S_name");
                     admission_id_textBox.Enabled = false;

                 }


             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

          
            
             Year_comboBox.Enabled = true;

        

            

         }
         
          */

        //section select show roll for student

        private void Section_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            string conn = "server=localhost;database=School_Management;uid=root;pwd=;";

            string query = "SELECT  roll FROM class_registration WHERE admission_id='" + admission_id_textBox.Text + "' AND class='" + Class_comboBox.Text + "' AND section='" + Section_comboBox.Text + "' AND year='" + Year_comboBox.Text + "' ";

            MySqlConnection connect = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, connect);
            MySqlDataReader myreader;


            try
            {

                connect.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {


                    Roll_textBox.Text = myreader.GetString("roll");


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Section_comboBox.Enabled = false;


        }


        //Reset button
        private void button5_Click(object sender, EventArgs e)
        {

        

            admission_id_textBox.Text = "";

            admission_id_textBox.Enabled = true;
          
            S_name.Text = "";
            Roll_textBox.Text ="";
            if (admission_id_textBox.Enabled == true)
            {
                Year_comboBox.Text = "";
                Year_comboBox.Enabled = false;
                Section_comboBox.Text = "";
                Section_comboBox.Enabled = false;
                Class_comboBox.Text = "";
                Class_comboBox.Enabled = false;


            }
            Search_admission_id.Enabled = true;
            Student_mark_textbox.Text = "";
            Grade_textBox.Text = "";
            Subject_code_comboBox.Text = "";
            Subject_textBox.Text = "";
            Exam_comboBox.Text = "";
            Subject_code_comboBox.Items.Clear();


        }


        //year combobox when click value dissable 
        private void Year_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Year_comboBox.Enabled = false;
            Class_comboBox.Enabled = true;

            
        }

        private void Search_admission_id_Click(object sender, EventArgs e)
        {

            if (admission_id_textBox.Text == "")
            {


                S_name.Text = "";


            }


            string conn = "server=localhost;database=School_Management;uid=root;pwd=;";

            string query = "SELECT student.s_name FROM student INNER JOIN class_registration ON student.admission_id =class_registration.admission_id  where class_registration.admission_id='" + admission_id_textBox.Text + "' ";

            MySqlConnection connect = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, connect);
            MySqlDataReader myreader;


            try
            {

                connect.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    S_name.Text = myreader.GetString("S_name");
                    
                    

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (S_name.Text != "")
            {
                admission_id_textBox.Enabled = false;
                Search_admission_id.Enabled = false;
                Year_comboBox.Enabled = true;
            }
            else {

                admission_id_textBox.Enabled = true;
                Search_admission_id.Enabled = true;
                Year_comboBox.Enabled = false;
            
            
            }
           

            
           
        }


        //mark input grade automatic show
        private void Student_mark_textbox_TextChanged(object sender, EventArgs e)
        {

            if (Student_mark_textbox.Text=="")
            {


                Grade_textBox.Text = "";
           

            }


            else
            {

                try
                {
                    b = int.Parse(Student_mark_textbox.Text);

                    if (b >= 33 && b <= 39)
                    {

                        Grade_textBox.Text = "D";

                    }

                    else if (b >= 40 && b <= 49)
                    {

                        Grade_textBox.Text = "C";

                    }
                    else if (b >= 50 && b <= 59)
                    {

                        Grade_textBox.Text = "B";

                    }

                    else if (b >= 60 && b <= 69)
                    {

                        Grade_textBox.Text = "A-";

                    }

                    else if (b >= 70 && b <= 79)
                    {

                        Grade_textBox.Text = "A";

                    }

                    else if (b >= 80 && b < 101)
                    {

                        Grade_textBox.Text = "A+";

                    }

                    else if (b > 100)
                    {

                        Grade_textBox.Text = "Invalid";

                    }




                    else
                    {
                        Grade_textBox.Text = "f";

                    }

                    // total = b;

                    //Total_num.Text = total.ToString();

                }

                catch (Exception e1)
                {

                    MessageBox.Show(e1.Message);

                }



            }





        }

        //save mark to data base
        private void Save_mark_button_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you really want to marks Entry?", "EXIT",
               MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (! Marks_check())
                {
                    try
                    {    //image insert code 


                       
                        //end code


                        cnn.Open();
                        //  MessageBox.Show("Connection Open ! ");
                        MySqlCommand cmd = cnn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into marks_entry (admission_id,year,class,section,class_roll,subject_code,subject_name,exam_type,student_mark,student_grade) values ('" + admission_id_textBox.Text + "','" + Year_comboBox.Text + "','" + Class_comboBox.Text + "','" + Section_comboBox.Text + "','" + Roll_textBox.Text + "','" + Subject_code_comboBox.Text + "','" + Subject_textBox.Text + "','" + Exam_comboBox.Text + "','" + Student_mark_textbox.Text + "','" + Grade_textBox.Text + "')";
                      
                        // MySqlDataReader dr =  //data excute variable

                        cmd.ExecuteReader();




                        cnn.Close();
                        MessageBox.Show("insert successfully");
                        admission_id_textBox.Enabled = true;
                        Clear();






                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

               }
            }

            else if (dialog == DialogResult.No)
            {
                //do something else
                Clear();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //
        }

       
      



        //
    }
}
