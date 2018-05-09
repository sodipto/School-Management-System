
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
    public partial class FeeEntry : Form
    {

        DataTable data; //datagridview Table data intilize

        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");

        public FeeEntry()
        {
            InitializeComponent();
            FillDataGridView();
            ClassCombo();
            Fee_Name_Combo();

            Fee_Entry_id.Visible = false;    //Fee_Entry_id textbox dissable/hidden
            Search_ComboBox_Auto(); //automatci search class and click value show data grid view


        }

        public void FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select *from fee_entry";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            FeeList.DataSource = data;




            cnn.Close();

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

        //fill up the FeeName  combo
        public void Fee_Name_Combo()
        {
            try
            {

                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from feetypes";

                MySqlDataReader myreader;

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {

                    string Fee_Name = myreader.GetString("fee_name");
                    FeeName_comboBox.Items.Add(Fee_Name);


                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        //Fee types name item check
        public bool Fee_Name_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from fee_entry where Fee_Name='" + FeeName_comboBox.Text + "'  AND Class='"+Class_comboBox.Text+"'", con);
            // cmd.Parameters.AddWithValue("@ClassName", this.Class_textBox.Text);
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

        //Search ComboBox Auto
        public void Search_ComboBox_Auto()
        {

            Search_comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Search_comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

          //  string conn = "server=localhost;School_Management=c_sharp;uid=root;pwd=;";

            string query = "select ClassName from class_entry";

           // MySqlConnection connect = new MySqlConnection(cnn);
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader myreader;


            try
            {

                cnn.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    string ClassName = myreader.GetString("ClassName");
                    Search_comboBox.Items.Add(ClassName);
                    coll.Add(ClassName);
                    

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Search_comboBox.AutoCompleteCustomSource = coll;

        }
           

        //Save Button
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (FeeName_comboBox.Text!="" && Class_comboBox.Text!= "" && Amount_textBox.Text!="")
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
                            cmd.CommandText = "insert into fee_entry (Fee_Name,Class,Amount) values ('" + FeeName_comboBox.Text + "','" + Class_comboBox.Text + "','" + Amount_textBox.Text + "')";

                            // MySqlDataReader dr =  //data excute variable

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("insert successfully");
                            FeeName_comboBox.Text = "";
                            Class_comboBox.Text = "";
                            Amount_textBox.Text = "";




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    } //end class name check condition 
                    //Fee_textBox.Text = "";



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
        

        //Cell Click Value click
        private void FeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex>=0){

               
                DataGridViewRow row = this.FeeList.Rows[e.RowIndex];

                FeeName_comboBox.Text = row.Cells["Fee_Name"].Value.ToString();
                Class_comboBox.Text   = row.Cells["Class"].Value.ToString();
                Amount_textBox.Text   = row.Cells["Amount"].Value.ToString();
                Fee_Entry_id.Text     = row.Cells["Fee_Entry_id"].Value.ToString();

                FeeName_comboBox.Enabled = false;
                 Class_comboBox.Enabled = false;
            
            
            }



        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            FeeName_comboBox.Enabled = true;
            Class_comboBox.Enabled = true;
            Amount_textBox.Text = "";
            FeeName_comboBox.Text = "";
            Class_comboBox.Text = "";
        }

        //
        private void Update_button_Click(object sender, EventArgs e)
        {
             if (FeeName_comboBox.Text!="" && Class_comboBox.Text!= "" && Amount_textBox.Text!="")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to UPDATE?", "EXIT",
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
                            cmd.CommandText = "update fee_entry set Amount='" + Amount_textBox.Text + "' where Fee_Entry_id='" + Fee_Entry_id.Text + "' ";

                            // MySqlDataReader dr =  //data excute variable

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("Update successfully");
                            FeeName_comboBox.Text = "";
                            Class_comboBox.Text = "";
                            Amount_textBox.Text = "";
                            FeeName_comboBox.Enabled = true;
                            Class_comboBox.Enabled = true;




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    //end class name check condition 
                    //Fee_textBox.Text = "";



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

        //
        private void Delete_button_Click(object sender, EventArgs e)
        {

              if (FeeName_comboBox.Text!="" && Class_comboBox.Text!= "" && Amount_textBox.Text!="")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to DELETE?", "EXIT",
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
                            cmd.CommandText = "delete from fee_entry  where Fee_Entry_id='" + Fee_Entry_id.Text + "' ";

                            // MySqlDataReader dr =  //data excute variable

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("Delete successfully");
                            FeeName_comboBox.Text = "";
                            Class_comboBox.Text = "";
                            Amount_textBox.Text = "";
                            FeeName_comboBox.Enabled = true;
                            Class_comboBox.Enabled = true;




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    //end class name check condition 
                    //Fee_textBox.Text = "";



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

        //
        private void Search_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnn.Close(); //connection must be close first
            try
            {
                cnn.Open();
                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select *from fee_entry where Class='" + Search_comboBox.Text + "'";
                cmd.ExecuteNonQuery();

                data = new DataTable();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                adp.Fill(data);
                FeeList.DataSource = data;




                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        
        






        //Last two scope
    }
}
