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
    public partial class ClassEntry : Form
    {
        DataTable data; //datagridview Table data intilize

        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");

        public ClassEntry()
        {
            InitializeComponent();
            FillDataGridView();
            c_id.Visible = false;
        }

//All class show in class_Datagridview

        public void FillDataGridView() {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select *from Class_entry";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Class_dataGridView.DataSource = data;
           



            cnn.Close();
        
        }
//class item check
        public bool Class_Name_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from Class_entry where ClassName='" + Class_textBox.Text + "' ", con);
           // cmd.Parameters.AddWithValue("@ClassName", this.Class_textBox.Text);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("This class Already exist");
                return true;
            }
            else
            {
                return false;
            }
        } 


  //class insert
        private void Save_button_Click(object sender, EventArgs e)
        {
          if (Class_textBox.Text != "")
            {
            DialogResult dialog = MessageBox.Show("Do you really want to Insert?", "EXIT",
               MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (!Class_Name_check())
                {
                    try
                    {

                        //end code


                        cnn.Open();

                        //  MessageBox.Show("Connection Open ! ");
                        MySqlCommand cmd = cnn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into Class_entry (ClassName) values ('" + Class_textBox.Text + "')";

                        // MySqlDataReader dr =  //data excute variable

                        cmd.ExecuteReader();




                        cnn.Close();
                        MessageBox.Show("insert successfully");
                        Class_textBox.Text = "";




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                } //end class name check condition 
                Class_textBox.Text = "";


            } //dialogbox condition
            
         

            else if (dialog == DialogResult.No)
            {
                //do something else
            }



            } //end if condition when textbox is empty

          else 
          {

              MessageBox.Show("Fillup the Class Name Box");

          }


            FillDataGridView(); //refresh dtagridview

        }

        //New class input

        private void New_button_Click(object sender, EventArgs e)
        {
            Class_textBox.Text = "";
        }


        //update class name

        private void Update_button_Click(object sender, EventArgs e)
        {

            if (Class_textBox.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Update?", "EXIT",
                   MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    if (!Class_Name_check())
                    {
                        try
                        {

                            //end code


                            cnn.Open();
                           

                            //  MessageBox.Show("Connection Open ! ");
                            MySqlCommand cmd = cnn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Class_entry set ClassName='" + Class_textBox.Text + "' where ClassId='" + c_id.Text + "'   ";

                            // MySqlDataReader dr =  //data excute variable

                           // c_id text CheckBox visiable false for Delete_button id

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("Update successfully");
                            Class_textBox.Text = "";




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    } //end class name check condition 
                    Class_textBox.Text = "";


                } //dialogbox condition



                else if (dialog == DialogResult.No)
                {
                    //do something else
                }



            } //end if condition when textbox is empty

            else
            {

                MessageBox.Show("Fillup the Class Name Box");

            }


           FillDataGridView(); //refresh dtagridview

        }

        //click grid view value show Textbox

        private void Class_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.Class_dataGridView.Rows[e.RowIndex];



                Class_textBox.Text = row.Cells["ClassName"].Value.ToString();
                c_id.Text = row.Cells["ClassId"].Value.ToString();


            }


        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Class_textBox.Text != "")
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
                            cmd.CommandText = "delete from Class_entry  where ClassId='" + c_id.Text + "' ";

                            // MySqlDataReader dr =  //data excute variable

                            // c_id text CheckBox visiable false for Delete_button id

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("Delete successfully");
                            Class_textBox.Text = "";




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

                MessageBox.Show("Fillup the Class Name Box");

            }


            FillDataGridView(); //refresh dtagridview
        }

      

     







        // button event end
    }
}
