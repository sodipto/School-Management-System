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
    public partial class SubjectEntry : Form
    {
        DataTable data; //datagridview Table data intilize

        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");
        public SubjectEntry()
        {
            InitializeComponent();
            ClassCombo();
            FillDataGridView();
          
        }

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

        //Data grid view Fill
        public void FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select *from subject_entry";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            SubjectList.DataSource = data;




            cnn.Close();

        }


        //Search Fill Data grid view

        public void FillDataGridView_Search()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select *from subject_entry where class='"+Class_comboBox.Text+"' ";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            SubjectList.DataSource = data;




            cnn.Close();

        }

        //Fee types name item check
        public bool Subject_Name_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from subject_entry where subject_code='" + code_textBox.Text + "'  AND class='" + Class_comboBox.Text + "'  AND subject_name='" + sub_textBox.Text + "'", con);
            
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("This  Already exist");
                return true;
            }
            else
            {
                return false;
            }
        } 


        private void FeeName_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGridView_Search();
        }


        //Subject Entry
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (sub_textBox.Text!="" && Class_comboBox.Text!= "" && code_textBox.Text!="")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Insert?", "EXIT",
                   MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    if (!Subject_Name_check())
                    {
                        try
                        {

                            //end code


                            cnn.Open();

                            //  MessageBox.Show("Connection Open ! ");
                            MySqlCommand cmd = cnn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into subject_entry (subject_code,Class,subject_name) values ('" + code_textBox.Text + "','" + Class_comboBox.Text + "','" + sub_textBox.Text + "')";

                            // MySqlDataReader dr =  //data excute variable

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show(" Subject insert successfully");
                            sub_textBox.Text = "";
                            Class_comboBox.Text = "";
                            code_textBox.Text = "";




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    } 



                } //dialogbox condition



                else if (dialog == DialogResult.No)
                {
                    //do something else
                }



            } //end if condition when textbox is empty

            else
            {

                MessageBox.Show("Fillup the TextBox");

            }


            FillDataGridView();
        }

        private void SubjectList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                DataGridViewRow row = this.SubjectList.Rows[e.RowIndex];

                code_textBox.Text = row.Cells["subject_code"].Value.ToString();
                sub_textBox.Text = row.Cells["subject_name"].Value.ToString();
                Class_comboBox.Text = row.Cells["class"].Value.ToString();
               
               

              


            }


        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (sub_textBox.Text != "" && Class_comboBox.Text != "" && code_textBox.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Insert?", "EXIT",
                   MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                       try
                        {

                            //end code


                            cnn.Open();

                            //  MessageBox.Show("Connection Open ! ");
                            MySqlCommand cmd = cnn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = " Update subject_entry set subject_code='" + code_textBox.Text + "', Class='" + Class_comboBox.Text + "', subject_name='" + sub_textBox.Text + "' where subject_code='" + code_textBox.Text + "' ";

                            // MySqlDataReader dr =  //data excute variable

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show(" Update successfully");
                            sub_textBox.Text = "";
                            Class_comboBox.Text = "";
                            code_textBox.Text = "";




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    


                } //dialogbox condition



                else if (dialog == DialogResult.No)
                {
                    //do something else
                }



            } //end if condition when textbox is empty

            else
            {

                MessageBox.Show("Fillup the TextBox");

            }


            FillDataGridView();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (sub_textBox.Text != "" && Class_comboBox.Text != "" && code_textBox.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Delete?", "EXIT",
                   MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    try
                    {

                        //end code


                        cnn.Open();

                        //  MessageBox.Show("Connection Open ! ");
                        MySqlCommand cmd = cnn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = " delete from subject_entry  where subject_code='" + code_textBox.Text + "' ";

                        // MySqlDataReader dr =  //data excute variable

                        cmd.ExecuteReader();




                        cnn.Close();
                        MessageBox.Show(" Update successfully");
                        sub_textBox.Text = "";
                        Class_comboBox.Text = "";
                        code_textBox.Text = "";




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }




                } //dialogbox condition



                else if (dialog == DialogResult.No)
                {
                    //do something else
                }



            } //end if condition when textbox is empty

            else
            {

                MessageBox.Show("Fillup the TextBox");

            }


            FillDataGridView();
        }



        //
    }
}
