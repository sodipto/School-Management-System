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
    public partial class ReturnBook : Form
    {

        double LateFine_Taka = 10;
        double Late_day;
        double Late_Fine;
               
        DataTable data; //datagridview Table data intilize

        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");
        public ReturnBook()
        {
            InitializeComponent();
            Date_Today();
        }


        public void Date_Today() {

            string today = DateTime.Now.ToString("MM-dd-yyyy");

            Return_On_Date_label.Text = today.ToString();
        
        }

        public void FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select Book_id,Book_title,Borrow_date,Return_date from borrow_book where admission_id='" + Addmission_id_Search.Text + "' ";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Return_dataGridView.DataSource = data;



            
            cnn.Close();

        }

        public void Clear() {

            if (Addmission_id_Search.Text == "") {

                Addmission_Id_label.Text = "";

                Book_id_label.Text = "";
                Book_Title_label.Text = "";
                Borrow_Date_label.Text = "";
                Return_Date_label.Text = "";
                Late_Days_label.Text = "";
                Late_Fine_label.Text ="";
                //Return_dataGridView.Rows.Clear();
            
            
            }
        
        
        }





        //
        private void Addmission_id_Search_TextChanged(object sender, EventArgs e)
        {
             if (Addmission_id_Search.Text == "")
            {

                Addmission_Id_label.Text = "";
              //  Book_id_label.Text = "";
              //  Book_Title_label.Text = "";
          
               

               


            }

             string conn = "server=localhost;database=School_Management;uid=root;pwd=;";
             string query = "SELECT  admission_id  FROM borrow_book where admission_id='" + Addmission_id_Search.Text + "'  ";

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
                        

                    }


                    FillDataGridView();

            


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

     
        


        

        }

        //Cell Click Value show Label
        private void Return_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        

            if (e.RowIndex >= 0)
            {


                DataGridViewRow row = this.Return_dataGridView.Rows[e.RowIndex];



                Book_id_label.Text = row.Cells["Book_id"].Value.ToString();
                Book_Title_label.Text = row.Cells["Book_title"].Value.ToString();
                Borrow_Date_label.Text = row.Cells["Borrow_date"].Value.ToString();
                Return_Date_label.Text = row.Cells["Return_date"].Value.ToString();


                //Late days Late Fine Calculation

               

                DateTime startdate;
                DateTime enddate;
                TimeSpan remaindate;

                startdate = DateTime.Parse(Return_On_Date_label.Text).Date;
                enddate = DateTime.Parse(Return_Date_label.Text).Date;
                remaindate = startdate - enddate ;

                Late_day = remaindate.TotalDays;

                Late_Fine = Late_day * LateFine_Taka;

                if (Late_day <= 0)
                {

                    Late_Days_label.Text = 0.ToString();
                    Late_Fine_label.Text = 0.ToString();
                }

                else
                {
                    Late_Days_label.Text = Late_day.ToString();
                    Late_Fine_label.Text = Late_Fine.ToString();
                }
  

             


            }

        }

        //Retuen Book Button Action
        private void Return_button_Click(object sender, EventArgs e)
        {
            if (Addmission_Id_label.Text != "" && Book_id_label.Text != "" && Book_Title_label.Text != "" && Borrow_Date_label.Text != "" && Return_Date_label.Text != "" && Return_On_Date_label.Text != "" && Late_Days_label.Text != "" && Late_Fine_label.Text !="")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Return Book?", "EXIT",
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
                            cmd.CommandText = "insert into return_book_details (admission_id,Book_id,Book_title,Borrow_date,Return_date,Reurn_on_date,Late_days,Late_fine) values ('" + Addmission_Id_label.Text + "','" + Book_id_label.Text + "','" + Book_Title_label.Text + "','" + Borrow_Date_label.Text + "','" + Return_Date_label.Text + "','" + Return_On_Date_label.Text + "','" + Late_Days_label.Text + "','" + Late_Fine_label.Text + "')";



                            cmd.ExecuteReader();




                            cnn.Close();
                         //   MessageBox.Show("Return Book successfully" + "Your Fine "+ Late_Fine +" Taka");
                           // Clear();// Clear Function Call




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    //Another try catch function use for delete borrow book Data 
                        try
                        {

                            cnn.Open();

                            MySqlCommand cmd = cnn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "delete from borrow_book where admission_id='" + Addmission_Id_label.Text + "' and Book_id='" + Book_id_label.Text + "' ";



                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("Return Book successfully" + "Fine:" + Late_Fine_label.Text + " Taka");
                            Clear();  // Clear Function Call





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

                MessageBox.Show("Miss The Fillup Text box");

            }
        }

        //
        private void Reset_button_Click(object sender, EventArgs e)
        {
            Addmission_id_Search.Text = "";
            Clear();
        }


        //Last Two Scope
    }
}
