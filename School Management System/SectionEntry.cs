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

       public partial class SectionEntry : Form
    {

        DataTable data; //datagridview Table data intilize

        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");


        public SectionEntry()
        {
            InitializeComponent();
            FillDataGridView();
            S_id.Visible = false;
        }


        //All Section show in class_Datagridview

        public void FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select *from Section_entry";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Section_dataGridView.DataSource = data;




            cnn.Close();

        }
        //Section item check
        public bool Section_Name_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from Section_entry where SectionName='" + Section_textBox.Text + "' ", con);
            //cmd.Parameters.AddWithValue("@SectionName", this.Section_textBox.Text);
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



        //new section button
        private void New_button_Click(object sender, EventArgs e)
        {
            Section_textBox.Text = "";
        }


  //new Section Save 
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Section_textBox.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Insert?", "EXIT",
                   MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    if (!Section_Name_check())
                    {
                        try
                        {

                            //end code


                            cnn.Open();

                            //  MessageBox.Show("Connection Open ! ");
                            MySqlCommand cmd = cnn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into Section_entry (SectionName) values ('" + Section_textBox.Text + "')";

                            // MySqlDataReader dr =  //data excute variable

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("insert successfully");
                            Section_textBox.Text = "";




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    } //end Section name check condition 
                    Section_textBox.Text = "";


                } //dialogbox condition



                else if (dialog == DialogResult.No)
                {
                    //do something else
                }



            } //end if condition when textbox is empty

            else
            {

                MessageBox.Show("Fillup the Section Name Box");

            }


            FillDataGridView(); //refresh dtagridview
        }


        //update button
        private void Update_button_Click(object sender, EventArgs e)
        {

            if (Section_textBox.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Update?", "EXIT",
                   MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    if (!Section_Name_check())
                    {
                        try
                        {

                            //end code


                            cnn.Open();


                            //  MessageBox.Show("Connection Open ! ");
                            MySqlCommand cmd = cnn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Section_entry set SectionName='" + Section_textBox.Text + "' where SectionId='" + S_id.Text + "'   ";

                            // MySqlDataReader dr =  //data excute variable

                            // c_id text CheckBox visiable false for Delete_button id

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("Update successfully");
                            Section_textBox.Text = "";




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    } //end class name check condition 
                    Section_textBox.Text = "";


                } //dialogbox condition



                else if (dialog == DialogResult.No)
                {
                    //do something else
                }



            } //end if condition when textbox is empty

            else
            {

                MessageBox.Show("Fillup the Section Name Box");

            }


            FillDataGridView(); //refresh dtagridview
        }

        private void Section_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.Section_dataGridView.Rows[e.RowIndex];



                Section_textBox.Text = row.Cells["SectionName"].Value.ToString();
                S_id.Text = row.Cells["SectionId"].Value.ToString();


            }


        }

  //delete button
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Section_textBox.Text != "")
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
                        cmd.CommandText = "delete from Section_entry  where SectionId='" + S_id.Text + "' ";

                        // MySqlDataReader dr =  //data excute variable

                        // c_id text CheckBox visiable false for Delete_button id

                        cmd.ExecuteReader();




                        cnn.Close();
                        MessageBox.Show("Delete successfully");
                        Section_textBox.Text = "";




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

                MessageBox.Show("Fillup the Section Name Box");

            }


            FillDataGridView(); //refresh dtagridview
        }
    }
}
