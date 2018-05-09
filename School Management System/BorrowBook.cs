
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
    public partial class BorrowBook : Form
    {

        string conn = "server=localhost;database=School_Management;uid=root;pwd=;";
        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");
        public BorrowBook()
        {
            InitializeComponent();
            Date();


        }

        public void Date() {

          


        string test = DateTime.Now.ToString("MM-dd-yyyy");
        string c = DateTime.Now.AddDays(7).ToString("MM-dd-yyyy");

        

           Borrow_Date_label.Text = test;
            Return_Date_label.Text = c;

            /*
            DateTime startdate;
            DateTime enddate;
            TimeSpan remaindate;
             
          startdate = DateTime.Parse(Borrow_Date_label.Text).Date;
          enddate = DateTime.Parse(Return_Date_label.Text).Date;
          remaindate = enddate - startdate;

          textBox1.Text = remaindate.TotalDays.ToString();
           */


        }

        //class item check
        public bool Book_Id_check()
        {

         //   string conn = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand("Select * from borrow_book where Book_id='" +Book_id_label.Text + "' ", con);
          
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("This Book Already Borrow");
                return true;
            }

            else
            {
                return false;
            }

        } 

        //Clear function
        public void Clear() {

            Addmission_Id_label.Text = "";
            Student_Class_label.Text = "";
            Student_name_label.Text = "";
            Student_Email_label.Text = "";


            Book_id_label.Text = "";
            Book_Edition_label.Text = "";
            Book_Title_label.Text = "";

           

            Addmission_id_Search.Text = "";
            Book_Id_textBox.Text = "";
           
        
        }
        


        //Search Book Id value show label
        private void Book_Id_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Book_Id_textBox.Text == "")
            {

                Book_id_label.Text = "";
                Book_Edition_label.Text = "";
                Book_Title_label.Text = "";
              

            }

        
            string query = "select *from book_list where Book_Id='" + Book_Id_textBox.Text + "'";

            MySqlConnection connect = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, connect);
            MySqlDataReader myreader;
           
         try
            {
                connect.Open();
                
               /*
            
                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader myreader;//= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from book_list where Book_Id='"+Book_Id_textBox.Text+"'";
                cmd.ExecuteNonQuery();
              */


                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    Book_id_label.Text = myreader.GetString("Book_Id");
                    Book_Title_label.Text = myreader.GetString("Title");
                    Book_Edition_label.Text = myreader.GetString("edition");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Addmission_id_Search_TextChanged(object sender, EventArgs e)
        {
            if (Addmission_id_Search.Text == "")
            {

                Addmission_Id_label.Text = "";
                Student_name_label.Text = "";
                Student_Email_label.Text = "";
                Student_Class_label.Text = "";


            }

           // string conn = "server=localhost;database=School_Management;uid=root;pwd=;";
            string query = "SELECT  student.s_name,class_registration.admission_id,student.s_email,class_registration.class,class_registration.roll,class_registration.section,class_registration.year  FROM student INNER JOIN class_registration ON student.admission_id =class_registration.admission_id  where student.admission_id='" + Addmission_id_Search.Text + "'  ";

            MySqlConnection connect = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, connect);
            MySqlDataReader myreader;

            try
            {
                connect.Open();


                myreader = cmd.ExecuteReader();

                    while (myreader.Read())
                    {
                        Addmission_Id_label.Text = myreader.GetString("admission_id");
                        Student_name_label.Text = myreader.GetString("s_name");
                        Student_Email_label.Text = myreader.GetString("s_email");
                        Student_Class_label.Text = myreader.GetString("class");

                    }




            


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

     
        


        }

        // Borrow Book 
        private void Borrow_Book_Click(object sender, EventArgs e)
        {
            if (Addmission_Id_label.Text != "" && Student_Class_label.Text != "" && Student_name_label.Text != "" && Student_Email_label.Text != "" && Book_id_label.Text != "" && Book_Edition_label.Text != "" && Book_Title_label.Text != "")
            
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Borrow Book?", "EXIT",
                   MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    if (!Book_Id_check())
                    {
                        try
                        {

                            //end code


                            cnn.Open();

                            //  MessageBox.Show("Connection Open ! ");
                            MySqlCommand cmd = cnn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into borrow_book (admission_id,student_name,student_class,student_email,Book_id,Book_title,Book_edition,Borrow_date,Return_date) values ('" + Addmission_Id_label.Text + "','" +Student_name_label.Text+"','" +Student_Class_label.Text +"','" +Student_Email_label.Text +"','" +Book_id_label.Text +"','" + Book_Title_label.Text+"','" + Book_Edition_label.Text+"','" +Borrow_Date_label.Text +"','" +Return_Date_label.Text +"')";

                        

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("Book Borrow successfully");
                            Clear();// Clear Function Call




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    } //end class name check condition 
                  //  Clear function Call Here


                } //dialogbox condition



                else if (dialog == DialogResult.No)
                {
                    //do something else
                }



            } //end if condition when textbox is empty

            else
            {

                MessageBox.Show("Miss The Fillup Text box");

            }


        }


        //Last
    }
}
