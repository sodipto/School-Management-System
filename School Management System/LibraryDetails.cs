using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class LibraryDetails : Form
    {

       
        int Total_Fine_ = 0;
        DataTable data; //datagridview Table data intilize

        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");

        public LibraryDetails()
        {
            InitializeComponent();
            BorrowBook_FillDataGridView();
            ReturnBook_FillDataGridView();
        }

        //all data from borrow book
        public void BorrowBook_FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from borrow_book";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Library_Details_dataGridView.DataSource = data;




            cnn.Close();

        }


        // with Textbox search bu admission id
        public void Borrow_Book_Search_FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select *from borrow_book where admission_id='"+Search_textBox.Text+"'";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Library_Details_dataGridView.DataSource = data;




            cnn.Close();

        }


        //all data from borrow book
        public void ReturnBook_FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from return_book_details";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Return_Book_dataGridView.DataSource = data;




            cnn.Close();

        }


        // with Textbox search bu admission id
        public void Return_Book_Search_FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select *from return_book_details where admission_id='" + ReturnBook_textBox.Text + "'";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Return_Book_dataGridView.DataSource = data;




            cnn.Close();

        }

        // value show textbox
        



        //
        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
           
            if (Search_textBox.Text == "")
            {

                BorrowBook_FillDataGridView();
            }


            else {

                Borrow_Book_Search_FillDataGridView();
            
            }


        }


        //return Book Datagrid view Serach by Admission Id
        private void ReturnBook_textBox_TextChanged(object sender, EventArgs e)
        {
            if (ReturnBook_textBox.Text == "")
            {

                ReturnBook_FillDataGridView();
            }


            else
            {

                Return_Book_Search_FillDataGridView();

            }
        }


        //Fine List View
        private void Fine_Search_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Fine_Search_textBox.Text=="")
            {

                Fine_listView.Items.Clear();
                Total_Fine_ = 0;

                Student_name_label.Text = "";
                admission_id_label.Text ="";
                Email_label.Text = "";
                Gender_label.Text ="";
                pictureBox1.Image = null;
            }

            //this block ar stdent information show
            try
            {

                //  admission_id_label.Text = admission_id_textBox.Text;
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r1;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT *from student  where admission_id='" + Fine_Search_textBox.Text + "'  ";

                r1 = cmd.ExecuteReader();

                while (r1.Read())
                {


                    byte[] img = (byte[])(r1["image"]);

                    if (img == null)
                    {

                        pictureBox1.Image = null;

                    }

                    else
                    {

                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = System.Drawing.Image.FromStream(ms);

                    }

                    Student_name_label.Text = r1.GetString("S_name");
                    admission_id_label.Text = r1.GetString("admission_id");
                    Email_label.Text = r1.GetString("s_email");
                    Gender_label.Text = r1.GetString("gender");

               
                 
                   


                }

                cnn.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // this block ar Fine show 
            try
            {
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select admission_id,Reurn_on_date,Late_fine from return_book_details where 	admission_id='" + Fine_Search_textBox.Text + "'";

                r = cmd.ExecuteReader();

                while (r.Read())
                {
                    //  string ename = r.GetString("student_mark");

                    ListViewItem item = new ListViewItem(r["admission_id"].ToString());

                    item.SubItems.Add(r["Reurn_on_date"].ToString());
                    item.SubItems.Add(r["Late_fine"].ToString());


                    Fine_listView.Items.Add(item);

                    Total_Fine_ += int.Parse(r.GetString("Late_fine"));   // Total marks calculate 
                   
                }

              

                Total_Fine.Text = Total_Fine_.ToString();

                if (Fine_Search_textBox.Text != admission_id_label.Text)
                {

                    Fine_listView.Items.Clear();
                    Total_Fine_ = 0;

                    Student_name_label.Text = "";
                    admission_id_label.Text = "";
                    Email_label.Text = "";
                    Gender_label.Text = "";
                    pictureBox1.Image = null;

                    Total_Fine.Text = "";

                }

                cnn.Close();


            }


                 

                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

     




        }

        private void button1_Click(object sender, EventArgs e)
        { 
            /*
            Student_Details s = new Student_Details();
            this.Hide();
            s.tabPage6.Parent = null;
            s.Show();
             */
        }

     //
    }
}
