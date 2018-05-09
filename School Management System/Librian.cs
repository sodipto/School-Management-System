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
    public partial class Librian : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");

        string username_rcv;
        public Librian()
        {
            InitializeComponent();
        }

          public Librian(string username)
        {
            InitializeComponent();
           
            this.username_rcv = username;
            username_function();

           // user_name.Text = this.username_rcv;
        }

          public void username_function() {
              try
              {

                  //  admission_id_label.Text = admission_id_textBox.Text;
                  cnn.Open();

                  MySqlCommand cmd = cnn.CreateCommand();
                  MySqlDataReader r1;  //= new MySqlDataReader();
                  cmd.CommandType = CommandType.Text;
                  cmd.CommandText = "SELECT s_name from librian  where username='" + this.username_rcv + "'  ";

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
            

            


        //Borrow Book Button
        private void Borrow_Book_button_Click(object sender, EventArgs e)
        {
            BorrowBook b = new BorrowBook();
            b.Show();
        }

        //Return Book
        private void button1_Click(object sender, EventArgs e)
        {
            ReturnBook r = new ReturnBook();
            r.Show();
        }

        //
        private void Book_Entry_button_Click(object sender, EventArgs e)
        {
            LibraryBookDetails l = new LibraryBookDetails();
            l.Show();
        }

        //Details Button
        private void Details_button_Click(object sender, EventArgs e)
        {
            LibraryDetails l1 = new LibraryDetails();
            l1.Show();
        }

        private void Student_details_button_Click(object sender, EventArgs e)
        {
            Student_Details s = new Student_Details();
            this.Hide();
            s.tabPage6.Parent=null;
            s.pass_label.Visible = false;
            s.Pass_textBox.Visible = false;
        
            s.Show();
        }

        private void Profile_button_Click(object sender, EventArgs e)
        {
            UserTypeEntry s = new UserTypeEntry();
           // this.Hide();
            s.tabPage4.Parent = null;
            s.tabPage3.Parent = null;
            s.tabPage1.Parent = null;
            s.tabPage5.Parent = null;
            s.username.Text = this.username_rcv;
            s.UpdateButton.Enabled = false;
            s.Update_comboBox.Enabled = false;
            s.Show();
        }
    }
}
