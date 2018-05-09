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
   

    public partial class Payment : Form
    {
        int fine;
        int total;
        int f;
        int amount;
         DataTable data;
        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");

        public Payment()
        {
            InitializeComponent();
            FeetypesName();
            dissable_textbox();
            Payment_List();

          
        }


        //ALL Payment List
        public void Payment_List()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select *from payment";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Payment_datagridview.DataSource = data;




            cnn.Close();

        }

        //Payment List Search
        public void Payment_List_Search()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select *from payment where admission_id='" + payment_Search_dataGridview.Text + "'";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Payment_datagridview.DataSource = data;




            cnn.Close();

        }

        //Public void dissable Function
        public void dissable_textbox() {
            aid_textBox.Enabled = false;
            S_name.Enabled = false;
            Class_textbox.Enabled = false;
            Section_textBox.Enabled = false;
            Roll_textBox.Enabled = false;
            Year_textBox.Enabled = false;
            fee_name.Enabled = false;
            amount_textBox.Enabled = false;
            Total_textBox.Enabled = false;
        
        
        }

        //Clear Function 
        public void Clear() {

            aid_textBox.Text = "";
            S_name.Text = "";
            Class_textbox.Text = "";
            Section_textBox.Text = "";
            Roll_textBox.Text = "";
            Year_textBox.Text = "";
            fee_name.Text = "";
            amount_textBox.Text = "";
            fine_textBox.Text = "";
            Month_comboBox.Text = "";
            Total_textBox.Text = "";
            fine_textBox.Text = "0";
            paid_total.Text = "";
            aid_textBox.Text = "";

        
        }


        //ambigious check
        public bool Payment_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from payment where admission_id='" + aid_textBox.Text + "' AND Class='" + Class_textbox.Text + "' AND year='" + Year_textBox.Text + "'  AND Fee_Name='" + fee_name.Text + "' ", con);
         
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("This Admission ID and same class Fee name Already exist");
                return true;
            }
            else
            {
                return false;
            }
        } 


        //Feetypes name Combobox fillup

        public void FeetypesName()
        {
            try
            {

                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from feetypes ";

                MySqlDataReader myreader;

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {

                    string Fee_Name = myreader.GetString("fee_name");
                    Fee_types_comboBox.Items.Add(Fee_Name);


                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }



        //Student Information show
        private void aid_textBox_TextChanged(object sender, EventArgs e)
        {

            if (aid_Search_textBox.Text == "")
            {


                aid_textBox.Text = "";
                S_name.Text = "";
                Class_textbox.Text = "";
                Section_textBox.Text = "";
                Roll_textBox.Text = "";
                Year_textBox.Text = "";
                fee_name.Text = "";
                amount_textBox.Text = "";
                fine_textBox.Text = "";
                Month_comboBox.Text = "";
                Total_textBox.Text = "";
                paid_total.Text = "";


            }


          string conn = "server=localhost;database=School_Management;uid=root;pwd=;";

           string query = "SELECT student.s_name,class_registration.admission_id,class_registration.class,class_registration.roll,class_registration.section,class_registration.year FROM student INNER JOIN class_registration ON student.admission_id =class_registration.admission_id  where class_registration.admission_id='" + aid_Search_textBox.Text + "' ";

            MySqlConnection connect = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, connect);
            MySqlDataReader myreader;

         


            try
            {


                connect.Open();
               

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    aid_textBox.Text = myreader.GetString("admission_id");
                    S_name.Text = myreader.GetString("S_name");
                    Class_textbox.Text = myreader.GetString("class");
                    Section_textBox.Text = myreader.GetString("section");
                    Roll_textBox.Text = myreader.GetString("roll");
                    Year_textBox.Text = myreader.GetString("year");




                }
               
                if (aid_Search_textBox.Text != aid_textBox.Text)
                {

                    Clear();


                }
              
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

            

        }


        //value show Textbox
        private void Fee_types_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  fee_name.Text = Fee_types_comboBox.Text;
            try
            {

                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from fee_entry where Fee_Name='" + Fee_types_comboBox.Text + "' AND Class='" + Class_textbox.Text + "'";

                MySqlDataReader myreader;

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {

                    fee_name.Text = myreader.GetString("Fee_Name");
                     amount_textBox.Text = myreader.GetString("Amount");
                   


                }




                Total_textBox.Text = amount_textBox.Text;





                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            fine = int.Parse(fine_textBox.Text);
            amount = int.Parse(amount_textBox.Text);

            total = amount + fine;

            Total_textBox.Text = total.ToString();
        }




        //Insert into the Database
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (aid_textBox.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Payment?", "EXIT",
                   MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    if (!Payment_check())  //also check roll no
                    {
                        try
                        {

                            //end code


                            cnn.Open();

                            //  MessageBox.Show("Connection Open ! ");
                            MySqlCommand cmd = cnn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into payment (admission_id,Fee_Name,Class,section,Amount,fine,grand_total,paid_total,year,month,payment_date) values ('" + aid_textBox.Text + "','" + fee_name.Text + "','" + Class_textbox.Text + "','" + Section_textBox.Text + "','" + amount_textBox.Text + "','" + fine_textBox.Text + "','" + Total_textBox.Text + "','" + paid_total.Text + "','" + Year_textBox.Text + "','" + Month_comboBox.Text + "','" + date.Text + "')";

                            // MySqlDataReader dr =  //data excute variable

                            cmd.ExecuteReader();




                            cnn.Close();
                            MessageBox.Show("Payment successfully");
                            Payment_List();

                           Clear();



                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    } //end Section name check condition 

                   // Clear();

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


        //Search
        private void payment_Search_dataGridview_TextChanged(object sender, EventArgs e)
        {
            if (payment_Search_dataGridview.Text == "")
            {

                Payment_List();
            }


            else
            {

                Payment_List_Search();

            }
        }

        //export excell
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                DataSet ds = new DataSet("New_DataSet");
                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;

                ds.Tables.Add(data);
                

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";//you can give it C: D: E: F: etc
                saveFileDialog1.Title = "Save As Excel File";
                saveFileDialog1.FileName = "Payment List";
                saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx";
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    ExcelLibrary.DataSetHelper.CreateWorkbook(saveFileDialog1.FileName.ToString(), ds);
                }

            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);


            }

            Payment_List();
        }

        //Reset buton
        private void button3_Click(object sender, EventArgs e)
        {
            aid_Search_textBox.Text = "";
            aid_textBox.Text = "";
            S_name.Text = "";
            Class_textbox.Text = "";
            Section_textBox.Text = "";
            Roll_textBox.Text = "";
            Year_textBox.Text = "";
            fee_name.Text = "";
            amount_textBox.Text = "";
            fine_textBox.Text = "";
            Month_comboBox.Text = "";
            Total_textBox.Text = "";
            fine_textBox.Text = "0";
            paid_total.Text = "";
            aid_textBox.Text = "";
        }

      


      //Last two scope
    }
}
