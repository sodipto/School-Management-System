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
    public partial class LibraryBookDetails : Form
    {
        DataTable data; //datagridview Table data intilize

        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");


        public LibraryBookDetails()
        {
            InitializeComponent();
            BookList_FillDataGridView();
        }


        //Clear Function
           public void Clear(){
           
              Book_id_textBox.Text="";
              Book_edition_textBox.Text = "";
              Book_title_textBox.Text = "";
              Book_id_Search.Text="";
              Book_id_textBox.Enabled = true;
           
           
           }


        public void BookList_FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from book_list";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Book_dataGridView.DataSource = data;




            cnn.Close();

        }

        //Searchh by Book Id
        public void Search_BookList_FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from book_list where Book_id='"+Book_id_Search.Text+"'";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Book_dataGridView.DataSource = data;




            cnn.Close();

        }

        //Book Id check
        public bool Book_ID_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from book_list where Book_id='" + Book_id_textBox.Text + "' ", con);

            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("This Book Id Already exist");
                return true;
            }
            else
            {
                return false;
            }
        } 


        //Search TextBook Search value show Datagrid view
        private void Book_id_Search_TextChanged(object sender, EventArgs e)
        {
            if (Book_id_Search.Text == "")
            {

                BookList_FillDataGridView();
            }


            else
            {

                Search_BookList_FillDataGridView();

            }
        }

        //Book Insert
        private void Insert_button_Click(object sender, EventArgs e)
        {
            if (Book_id_textBox.Text != "" && Book_title_textBox.Text != "" && Book_edition_textBox.Text != "")
            {
                
              
            DialogResult dialog = MessageBox.Show("Do you really want to Book Entry?", "EXIT",
               MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (!Book_ID_check())
                {
                    try
                    {

                        //end code


                        cnn.Open();

                        //  MessageBox.Show("Connection Open ! ");
                        MySqlCommand cmd = cnn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into book_list (Book_id,Title,edition) values ('" + Book_id_textBox.Text + "','" + Book_title_textBox.Text + "','" + Book_edition_textBox.Text + "')";

                        // MySqlDataReader dr =  //data excute variable

                        cmd.ExecuteReader();




                        cnn.Close();
                        MessageBox.Show("Book Entry successfully");
                         Clear();//Clear function Call




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                } //end class name check condition 
               


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


             BookList_FillDataGridView(); //refresh datagridview

        }

        //Reset button 
        private void Reset_button_Click(object sender, EventArgs e)
        {
           Clear();
        }

        //Cell Clicl value Show TextBox And textBox Dissable
        private void Book_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.Book_dataGridView.Rows[e.RowIndex];



                Book_id_textBox.Text = row.Cells["Book_id"].Value.ToString();
                Book_title_textBox.Text = row.Cells["Title"].Value.ToString();
                Book_edition_textBox.Text = row.Cells["edition"].Value.ToString();


                Book_id_textBox.Enabled = false;
             


            }
        }

        //Update Book
        private void Update_button_Click(object sender, EventArgs e)
        {
            if (Book_id_textBox.Text != "" && Book_title_textBox.Text != "" && Book_edition_textBox.Text != "")
            {


                DialogResult dialog = MessageBox.Show("Do you really want to Update Book ?", "EXIT",
                   MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                      try
                        {

                        


                            cnn.Open();

                            //  MessageBox.Show("Connection Open ! ");
                            MySqlCommand cmd = cnn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update  book_list set Title='" + Book_title_textBox.Text + "', edition='" + Book_edition_textBox.Text + "' where Book_id='"+Book_id_textBox.Text+"' ";

                       

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("Update Book successfully");
                            Clear();//Clear function Call




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


            BookList_FillDataGridView(); //refresh datagridview
        }


        //Delete Book
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Book_id_textBox.Text != "" && Book_title_textBox.Text != "" && Book_edition_textBox.Text != "")
            {


                DialogResult dialog = MessageBox.Show("Do you really want to Update Book ?", "EXIT",
                   MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                      try
                        {

                        


                            cnn.Open();

                            //  MessageBox.Show("Connection Open ! ");
                            MySqlCommand cmd = cnn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "delete from  book_list  where Book_id='"+Book_id_textBox.Text+"' ";

                       

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("Delete Book successfully");
                            Clear();//Clear function Call




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


            BookList_FillDataGridView(); //refresh datagridview
        }
        



       


        //
    }
}
