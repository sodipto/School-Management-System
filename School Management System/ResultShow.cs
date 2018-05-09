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
    public partial class ResultShow : Form
    {
        int mark=0,MarkFirstTerm=0,MarkSecondTerm=0,MarkFinalTerm=0;
        int Subject_Count = 0, Subject_count1st=0,Subject_count2nd = 0, Subject_count_final = 0;
        double avg=0,avg1st=0,avg2nd=0,avgFinal=0;

        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");

        public ResultShow()
        {
            InitializeComponent();
            class_combobox();
        }

        //Class name show
        public void class_combobox()
        {
            try
            {
                cnn.Open();
                //  MessageBox.Show("Connection Open ! ");
                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r;//= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from class_entry ";
                cmd.ExecuteNonQuery();
                r = cmd.ExecuteReader();

                while (r.Read())
                {

                    string ename = r.GetString("ClassName");
                    Class_comboBox.Items.Add(ename);

                    
                }

                cnn.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //enable/disable combobox and button function

        public void Control_Search() {

            admission_id_textBox.Enabled = false;
            Class_comboBox.Enabled = false;
            Year_comboBox.Enabled = false;
            Exam_comboBox.Enabled = false;
            Search_button.Enabled = false;
            
        
        
        }

        //Reset / clear function
        public void Clear() {

            admission_id_textBox.Enabled = true;
            admission_id_textBox.Text = "";
            Class_comboBox.Enabled = true;
            Class_comboBox.Text = "";
            Year_comboBox.Enabled = true;
            Year_comboBox.Text = "";
            Exam_comboBox.Enabled = true;
            Exam_comboBox.Text = "";

            Result_listView.Items.Clear();
            First_Term_listView.Items.Clear();
            Second_Term_listView.Items.Clear();
            Final_Term_listView.Items.Clear();
            //panel component clear
            Total_mark.Text = "";
            Total_Grade.Text = "";
            Average.Text = "";

            //student info clear

            admission_id_label.Text = "";
            Student_name_label.Text = "";
            Class_label.Text = "";
            Class_Roll_label.Text = "";
            Section_label.Text = "";
            Exam_type_label.Text = "";
            Year_label.Text = "";

            //Search button Enable

            Search_button.Enabled = true;

            //allterm result field clear

            Total_Mark_1stTerm.Text = "";
            avg_1stTerm.Text = "";
            Total_Grade1.Text = "";

            Second_term_total.Text = "";
            Second_Term_avg.Text = "";
            Second_Term_Grade.Text = "";

            Final_Term_total.Text = "";
            Final_Term_avg.Text = "";
            Final_Term_Grade.Text = "";


            //value 0 when reset button click
            mark = 0; MarkFirstTerm = 0; MarkSecondTerm = 0; MarkFinalTerm = 0;
            Subject_Count = 0; Subject_count1st = 0; Subject_count2nd = 0; Subject_count_final = 0;
            avg = 0; avg1st = 0; avg2nd = 0; avgFinal = 0;
        
        }

        //Search Button for result
        private void Search_button_Click(object sender, EventArgs e)
        {

            //this block ar stdent information show
            try {

              //  admission_id_label.Text = admission_id_textBox.Text;
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r1;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  student.s_name,class_registration.admission_id,class_registration.class,class_registration.roll,class_registration.section,class_registration.year  FROM student INNER JOIN class_registration ON student.admission_id =class_registration.admission_id  where class_registration.admission_id='" + admission_id_textBox.Text + "' AND class_registration.year='" + Year_comboBox.Text + "' AND class_registration.class='" + Class_comboBox.Text + "' ";

                r1 = cmd.ExecuteReader();

                while (r1.Read())
                {

                    Student_name_label.Text = r1.GetString("S_name");
                    admission_id_label.Text = r1.GetString("admission_id");
                    Class_label.Text = r1.GetString("class");
                    Class_Roll_label.Text = r1.GetString("roll");
                    Section_label.Text = r1.GetString("section");
                    Exam_type_label.Text = Exam_comboBox.Text;
                    Year_label.Text = r1.GetString("year");


              
                }

                cnn.Close();
            
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        //this block ar result show 
            try
            {
                cnn.Open();
               
                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select subject_code,subject_name,student_mark,student_grade from marks_entry where 	admission_id='" + admission_id_textBox.Text + "' AND class='" + Class_comboBox.Text + "'  AND year='" + Year_comboBox.Text + "' AND exam_type='" + Exam_comboBox.Text + "'";
             
                r = cmd.ExecuteReader();

                while (r.Read())
                {
                  //  string ename = r.GetString("student_mark");
                  
                    ListViewItem item = new ListViewItem(r["subject_code"].ToString());
                    
                    item.SubItems.Add(r["subject_name"].ToString());
                    item.SubItems.Add(r["student_mark"].ToString());
                    item.SubItems.Add(r["student_grade"].ToString());

                    Result_listView.Items.Add(item);

                    mark += int.Parse(r.GetString("student_mark"));   // Total marks calculate 
                    Subject_Count++;
                }

                avg = mark / Subject_Count;
                Total_mark.Text = mark.ToString();
                Average.Text = avg.ToString();


                if (Total_mark.Text == "")
                {


                    Total_Grade.Text = "";


                }


                else
                {


                  //  b = int.Parse(Student_mark_textbox.Text);

                    if (avg >= 33 && avg <= 39)
                    {

                        Total_Grade.Text = "D";

                    }

                    else if (avg >= 40 && avg <= 49)
                    {

                        Total_Grade.Text = "C";

                    }
                    else if (avg >= 50 && avg <= 59)
                    {

                        Total_Grade.Text = "B";

                    }

                    else if (avg >= 60 && avg <= 69)
                    {

                        Total_Grade.Text = "A-";

                    }

                    else if (avg >= 70 && avg <= 79)
                    {

                        Total_Grade.Text = "A";

                    }

                    else if (avg >= 80 && avg < 101)
                    {

                        Total_Grade.Text = "A+";

                    }

                    else if (avg > 100)
                    {

                        Total_Grade.Text = "Invalid";

                    }




                    else
                    {
                        Total_Grade.Text = "f";

                    }


                }




                cnn.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show("Search data not found");
            }



            //this block use for 1st term result show

            try
            {
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select subject_code,subject_name,student_mark,student_grade from marks_entry where 	admission_id='" + admission_id_textBox.Text + "' AND class='" + Class_comboBox.Text + "'  AND year='" + Year_comboBox.Text + "' AND exam_type='1st Term'  ";

                r = cmd.ExecuteReader();

                while (r.Read())
                {
                    //  string ename = r.GetString("student_mark");

                    ListViewItem item = new ListViewItem(r["subject_code"].ToString());

                    item.SubItems.Add(r["subject_name"].ToString());
                    item.SubItems.Add(r["student_mark"].ToString());
                    item.SubItems.Add(r["student_grade"].ToString());

                    First_Term_listView.Items.Add(item);

                    MarkFirstTerm += int.Parse(r.GetString("student_mark"));   // Total marks calculate 
                    Subject_count1st++;
                }

                avg1st = mark / Subject_count1st;
                Total_Mark_1stTerm.Text = mark.ToString();
                avg_1stTerm.Text = avg.ToString();


                if (Total_Mark_1stTerm.Text == "")
                {


                    Total_Grade1.Text = "";


                }


                else
                {


                    //  b = int.Parse(Student_mark_textbox.Text);

                    if (avg1st >= 33 && avg1st <= 39)
                    {

                        Total_Grade1.Text = "D";

                    }

                    else if (avg1st >= 40 && avg1st <= 49)
                    {

                        Total_Grade1.Text = "C";

                    }
                    else if (avg1st >= 50 && avg1st <= 59)
                    {

                        Total_Grade1.Text = "B";

                    }

                    else if (avg1st >= 60 && avg1st <= 69)
                    {

                        Total_Grade1.Text = "A-";

                    }

                    else if (avg1st >= 70 && avg1st <= 79)
                    {

                        Total_Grade1.Text = "A";

                    }

                    else if (avg1st >= 80 && avg1st < 101)
                    {

                        Total_Grade1.Text = "A+";

                    }

                    else if (avg1st > 100)
                    {

                        Total_Grade1.Text = "Invalid";

                    }




                    else
                    {
                        Total_Grade1.Text = "f";

                    }


                }




                cnn.Close();





            }
            catch (Exception ex1)
            {
                //MessageBox.Show(ex1.Message);
            }

            //this block use for 2nd Term result show

            try
            {
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select subject_code,subject_name,student_mark,student_grade from marks_entry  where 	admission_id='" + admission_id_textBox.Text + "' AND class='" + Class_comboBox.Text + "'  AND year='" + Year_comboBox.Text + "' AND exam_type='2nd Term'  ";

                r = cmd.ExecuteReader();

                while (r.Read())
                {
                    //  string ename = r.GetString("student_mark");

                    ListViewItem item = new ListViewItem(r["subject_code"].ToString());

                    item.SubItems.Add(r["subject_name"].ToString());
                    item.SubItems.Add(r["student_mark"].ToString());
                    item.SubItems.Add(r["student_grade"].ToString());

                   Second_Term_listView.Items.Add(item);

                   MarkSecondTerm += int.Parse(r.GetString("student_mark"));   // Total marks calculate 
                    Subject_count2nd++;
                }

                avg2nd = MarkSecondTerm / Subject_count2nd;
                Second_term_total.Text = MarkSecondTerm.ToString();
                Second_Term_avg.Text = avg2nd.ToString();


                if (Second_term_total.Text == "")
                {


                    Second_Term_Grade.Text = "";


                }


                else
                {


                    //  b = int.Parse(Student_mark_textbox.Text);

                    if (avg2nd >= 33 && avg2nd <= 39)
                    {

                        Second_Term_Grade.Text = "D";

                    }

                    else if (avg2nd >= 40 && avg2nd <= 49)
                    {

                        Second_Term_Grade.Text = "C";

                    }
                    else if (avg2nd >= 50 && avg2nd <= 59)
                    {

                        Second_Term_Grade.Text = "B";

                    }

                    else if (avg2nd >= 60 && avg2nd <= 69)
                    {

                        Second_Term_Grade.Text = "A-";

                    }

                    else if (avg2nd >= 70 && avg2nd <= 79)
                    {

                        Second_Term_Grade.Text = "A";

                    }

                    else if (avg2nd >= 80 && avg2nd < 101)
                    {

                        Second_Term_Grade.Text = "A+";

                    }

                    else if (avg2nd > 100)
                    {

                        Second_Term_Grade.Text = "Invalid";

                    }




                    else
                    {
                        Second_Term_Grade.Text = "f";

                    }


                }




                cnn.Close();





            }
            catch (Exception ex1)
            {
              //  MessageBox.Show(ex1.Message);
            }




            //this block use for Final Term result show

            try
            {
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select subject_code,subject_name,student_mark,student_grade from marks_entry  where 	admission_id='" + admission_id_textBox.Text + "' AND class='" + Class_comboBox.Text + "'  AND year='" + Year_comboBox.Text + "' AND exam_type='Final Term'  ";

                r = cmd.ExecuteReader();

                while (r.Read())
                {
                    //  string ename = r.GetString("student_mark");

                    ListViewItem item = new ListViewItem(r["subject_code"].ToString());

                    item.SubItems.Add(r["subject_name"].ToString());
                    item.SubItems.Add(r["student_mark"].ToString());
                    item.SubItems.Add(r["student_grade"].ToString());

                    Final_Term_listView.Items.Add(item);

                    MarkFinalTerm += int.Parse(r.GetString("student_mark"));   // Total marks calculate 
                    Subject_count_final++;
                }

                avgFinal = MarkFinalTerm / Subject_count_final;
                Final_Term_total.Text = MarkFinalTerm.ToString();
                Final_Term_avg.Text = avgFinal.ToString();


                if (Final_Term_total.Text == "")
                {


                    Final_Term_Grade.Text = "";


                }


                else
                {


                    //  b = int.Parse(Student_mark_textbox.Text);

                    if (avgFinal >= 33 && avgFinal <= 39)
                    {

                        Final_Term_Grade.Text = "D";

                    }

                    else if (avgFinal >= 40 && avgFinal <= 49)
                    {

                        Final_Term_Grade.Text = "C";

                    }
                    else if (avgFinal >= 50 && avgFinal <= 59)
                    {

                        Final_Term_Grade.Text = "B";

                    }

                    else if (avgFinal >= 60 && avgFinal <= 69)
                    {

                        Final_Term_Grade.Text = "A-";

                    }

                    else if (avgFinal >= 70 && avgFinal <= 79)
                    {

                        Final_Term_Grade.Text = "A";

                    }

                    else if (avgFinal >= 80 && avgFinal < 101)
                    {

                        Final_Term_Grade.Text = "A+";

                    }

                    else if (avgFinal > 100)
                    {

                        Final_Term_Grade.Text = "Invalid";

                    }




                    else
                    {
                        Final_Term_Grade.Text = "f";

                    }


                }




                cnn.Close();





            }
            catch (Exception ex1)
            {
                //  MessageBox.Show(ex1.Message);
            }

   

         //
            Control_Search();
       //     label17.Text = admission_id_textBox.Text;
           

        }


        //Reset button
        private void Reset_button_Click(object sender, EventArgs e)
        {

            Clear();
            cnn.Close();
            

        
        }


        //ResultShow_FormClosing
        private void ResultShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


      




        //last Two end Scope
    }
}
