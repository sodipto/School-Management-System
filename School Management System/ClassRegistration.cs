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
    public partial class ClassRegistration : Form
    {
        DataTable data; //datagridview Table data intilize

        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");

        public ClassRegistration()
        {
            InitializeComponent();
          
            S_name.Enabled = false;
            ClassCombo(); //show all class name
            SectionCombo(); //show all Section name
        }



        public void Clear() {

            aid_textBox.Enabled = true;
            aid_textBox.Text = "";
            Search_admission_id.Enabled = true;
            S_name.Text = "";
            Roll_textBox.Text = "";
            Class_comboBox.Text = "";
            Section_comboBox.Text = "";
            Year_comboBox.Text = "";

        
        
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

        //Class Registration Check
        public bool Registration_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from class_registration where admission_id='" + aid_textBox.Text + "' AND class='" + Class_comboBox.Text + "' AND year='" + Year_comboBox.Text + "' ", con);
          //  cmd.Parameters.AddWithValue("@admission_id", this.aid_textBox.Text);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("This Admission ID Already exist in this Class");
                return true;
            }
            else
            {
                return false;
            }
        } 


        //Search button  click value show student name
        private void Search_admission_id_Click(object sender, EventArgs e)
        {
            if (aid_textBox.Text == "")
            {


                S_name.Text = "";


            }


            try
            {

                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from student where admission_id='" + aid_textBox.Text + "'";

                MySqlDataReader myreader;

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {

                    S_name.Text = myreader.GetString("s_name");


                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //when search id match and show name dissable button and textbox of admission id search
            if (S_name.Text != "")
            {
                aid_textBox.Enabled = false;
                Search_admission_id.Enabled = false;

            }
            else {

                aid_textBox.Enabled = true;
                Search_admission_id.Enabled = true;
            
            
            }

        }

         
        //Class Registration Button
        private void Class_Registration_Click(object sender, EventArgs e)
        {
            if (aid_textBox.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Insert?", "EXIT",
                   MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    if (!Registration_check())  //also check roll no
                    {
                        try
                        {

                            //end code


                            cnn.Open();

                            //  MessageBox.Show("Connection Open ! ");
                            MySqlCommand cmd = cnn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into class_registration (admission_id,roll,class,section,year) values ('" + aid_textBox.Text + "','" + Roll_textBox.Text + "','" + Class_comboBox.Text + "','" + Section_comboBox.Text + "','" + Year_comboBox.Text + "')";

                            // MySqlDataReader dr =  //data excute variable

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("insert successfully");
                         //   Section_textBox.Text = "";




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    } //end Section name check condition 

                    Clear();

                } //dialogbox condition



                else if (dialog == DialogResult.No)
                {
                    //do something else
                }



            } //end if condition when textbox is empty

            else
            {

                MessageBox.Show("Fillup the Admission id  Box");

            }

        }

        //Reset Button click all the reset in this form

        private void Reset_button_Click(object sender, EventArgs e)
        {

            Clear();   //call clear funcion

        }

       





      

        //last two scope
    }
}
