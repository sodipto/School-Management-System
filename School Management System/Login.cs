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
    public partial class Login : Form
    {
      
        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");
        char char_detect;
        public Login()
        {
            InitializeComponent();
        }

        



        //Application Exit
        private void Exit_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Login Button
        private void Login_button_Click(object sender, EventArgs e)
        {
       

            char_detect = username.Text[0];

             
  switch (char_detect){

      case 'A':

              try
               {
                cnn.Open();

                //  MessageBox.Show("Connection Open ! ");
                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                MySqlDataReader myreader;

                cmd.CommandText = "select *from admin  where username='" + username.Text + "' and password='" + password.Text + "' ";



                myreader=cmd.ExecuteReader();


                int count = 0;
                while (myreader.Read())
                {

                    count += 1;


                }


                if (count == 1)
                {

                    MessageBox.Show("Login Sucessfully");
                    this.Hide();
                    Super_Admin s = new Super_Admin(username.Text);
                    s.Show();
                    
                   


                  
                  

                }

                else
                {

                    MessageBox.Show("Username  or password  Incorrect");

                }



              

                cnn.Close();

           
              } catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

              break;

      case 'L':

              try
              {
                  cnn.Open();

                  //  MessageBox.Show("Connection Open ! ");
                  MySqlCommand cmd = cnn.CreateCommand();
                  cmd.CommandType = CommandType.Text;
                  MySqlDataReader myreader;

                  cmd.CommandText = "select *from librian  where username='" + username.Text + "' and password='" + password.Text + "' ";



                  myreader = cmd.ExecuteReader();


                  int count = 0;
                  while (myreader.Read())
                  {

                      count += 1;


                  }


                  if (count == 1)
                  {

                      MessageBox.Show("Login Sucessfully");
                      this.Hide();
                      Librian s1 = new Librian(username.Text);
                      s1.Show();







                  }

                  else
                  {

                      MessageBox.Show("Username  or password  Incorrect");

                  }





                  cnn.Close();


              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }

              break;

      case 'T':

              try
              {
                  cnn.Open();

                  //  MessageBox.Show("Connection Open ! ");
                  MySqlCommand cmd = cnn.CreateCommand();
                  cmd.CommandType = CommandType.Text;
                  MySqlDataReader myreader;

                  cmd.CommandText = "select *from teacher  where username='" + username.Text + "' and password='" + password.Text + "' ";



                  myreader = cmd.ExecuteReader();


                  int count = 0;
                  while (myreader.Read())
                  {

                      count += 1;


                  }


                  if (count == 1)
                  {

                      MessageBox.Show("Login Sucessfully");
                      this.Hide();
                      Teacher s1 = new Teacher(username.Text);
                      s1.Show();







                  }

                  else
                  {

                      MessageBox.Show("Username  or password  Incorrect");

                  }





                  cnn.Close();


              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }

              break;




             default:

              MessageBox.Show("This is the not Usertype Username");
              break;


        }
        

      }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }//button

       


        //
    }
}
