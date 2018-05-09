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
    public partial class FeeTypes : Form
    {
        DataTable data; //datagridview Table data intilize

        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");


        public FeeTypes()
        {
            InitializeComponent();
            F_id.Visible = false;
            FillDataGridView();
        }


        public void FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select *from feetypes";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Fee_dataGridView.DataSource = data;




            cnn.Close();

        }

        //Fee types name item check
        public bool Fee_Name_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from feetypes where fee_name='" + Fee_textBox.Text + "' ", con);
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


        //new value insert 
        private void New_button_Click(object sender, EventArgs e)
        {
            Fee_textBox.Text = "";
         
        }



        //Save value in Database
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Fee_textBox.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Insert?", "EXIT",
                   MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    if (!Fee_Name_check())
                    {
                        try
                        {

                            //end code


                            cnn.Open();

                            //  MessageBox.Show("Connection Open ! ");
                            MySqlCommand cmd = cnn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into feetypes (fee_name) values ('" + Fee_textBox.Text + "')";

                            // MySqlDataReader dr =  //data excute variable

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("insert successfully");
                            Fee_textBox.Text = "";




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    } //end class name check condition 
                    Fee_textBox.Text = "";
                  


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


            FillDataGridView(); //refresh dtagridview
        }


         //  FeeTypes_FormClosing 

        private void FeeTypes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }


        //update button
        private void Update_button_Click(object sender, EventArgs e)
        {
            if (Fee_textBox.Text != "")
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
                            cmd.CommandText = "update feetypes set fee_name='" + Fee_textBox.Text + "' where Fee_id='" + F_id.Text + "'   ";

                            // MySqlDataReader dr =  //data excute variable

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("Update successfully");
                            Fee_textBox.Text = "";
                        




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


            FillDataGridView(); //refresh dtagridview
        }

        // datagridview Cell click value show Textbox
        private void Fee_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.Fee_dataGridView.Rows[e.RowIndex];



                Fee_textBox.Text = row.Cells["fee_name"].Value.ToString();
            
                F_id.Text = row.Cells["Fee_id"].Value.ToString();


            }
        }


        //Delete button
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Fee_textBox.Text != "")
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
                        cmd.CommandText = "delete from feetypes  where Fee_id='" + F_id.Text + "' ";

                        // MySqlDataReader dr =  //data excute variable

                        cmd.ExecuteReader();




                        cnn.Close();
                        MessageBox.Show("Delete successfully");
                        Fee_textBox.Text = "";
                    




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


            FillDataGridView(); //refresh dtagridview
        }



        //last two scope
    }
}
