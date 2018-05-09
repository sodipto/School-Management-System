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
    public partial class UserTypeEntry : Form
    {
        
        string picpath;
        char char_detect;

        string admin_rcv;
        string teacher_rcv;


         MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");
         DataTable data;

        public UserTypeEntry()
        {
            InitializeComponent();
            AdminList_FillDataGridView();
            LibrianList();
            TeacherList();
            Dissible();

            username.Enabled = false;
            aid.Enabled = false;
            

            
        }

        //ALL Admin List
        public void AdminList_FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select username,password,s_name,admission_date,year,gender,religion,address,dob,s_phone,s_email from admin";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            admin_dataGridView.DataSource = data;




            cnn.Close();

        }

        //ALL Admin List Search
        public void AdminList_Search()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select username,password,s_name,admission_date,year,gender,religion,address,dob,s_phone,s_email from admin where username='"+admin_Search.Text+"'" ;
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            admin_dataGridView.DataSource = data;




            cnn.Close();

        }

        public void LibrianList()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select username,password,s_name,admission_date,year,gender,religion,address,dob,s_phone,s_email from librian";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            dataGridView1.DataSource = data;




            cnn.Close();

        }


        //Search Function
        public void LibrianList_Search()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select username,password,s_name,admission_date,year,gender,religion,address,dob,s_phone,s_email from librian where username='"+librian_Search_dataGridview.Text+"'";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            dataGridView1.DataSource = data;




            cnn.Close();

        }

        public void TeacherList()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select username,password,s_name,admission_date,year,gender,religion,address,dob,s_phone,s_email from teacher";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            teacher_datagridview.DataSource = data;




            cnn.Close();

        }

        public void TeacherList_Search()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select username,password,s_name,admission_date,year,gender,religion,address,dob,s_phone,s_email from teacher where username='" + teacher_Search_dataGridview.Text + "' ";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            teacher_datagridview.DataSource = data;




            cnn.Close();

        }


        //dissable function
        public void Dissible() {

            a_id.Enabled = false;
            s_name.Enabled = false;
            password.Enabled = false;
            a_date.Enabled = false;
            year.Enabled = false;
            s_gender.Enabled = false;
            religion.Enabled = false;
            address.Enabled = false;
            s_phone.Enabled = false;
            dob.Enabled = false;
            s_email.Enabled = false;
            Imagebutton.Enabled = false;
            User_insert_button.Enabled = false;


        }

        //enable function
        public void Enable()
        {

            a_id.Enabled = true;
            s_name.Enabled = true;
            password.Enabled = true;
            a_date.Enabled = true;
            year.Enabled = true;
            s_gender.Enabled = true;
            religion.Enabled = true;
            address.Enabled = true;
            s_phone.Enabled = true;
            dob.Enabled = true;
            s_email.Enabled = true;
            Imagebutton.Enabled = true;
            User_insert_button.Enabled = true;

        }

        public void Clear(){
        
             
            a_id.Text = "";
            s_name.Text = "";
            password.Text = "";
            a_date.Text = "";
            year.Text = "";
            s_gender.Text = "";
            religion.Text = "";
            address.Text = "";
            s_phone.Text = "";
            dob.Text = "";
            s_email.Text = "";
            Imagebutton.Image = null;
            user_comboBox.Text = "";

        
        
        }

        //clear the All Field
        public void Clear_Update()
        {

            sname.Text = "";
            aid.Text = "";
            semail.Text = "";
            Gender.Text = "";
            adate.Text = "";
            ayear.Text = "";
            Rel.Text = "";
            saddress.Text = "";
            D_ob.Text = "";
            sphone.Text = "";
            password_.Text = "";
            pictureBox1.Image = null;




        }

       

        //admin username check
        public bool admin_UserName_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from admin where username='" + a_id.Text + "' ", con);
          
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("This Username exist");
                return true;
            }
            else
            {
                return false;
            }
        }

        //Librian username check
        public bool Librian_UserName_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from librian where username='" + a_id.Text + "' ", con);

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

        //Teacher check

        public bool Teacher_UserName_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from Teacher where username='" + a_id.Text + "' ", con);

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

        //
        private void user_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (user_comboBox.Text == "Admin")
            {

                a_id.Text = "A-";


            }

            else if (user_comboBox.Text == "Teacher")
            {

                a_id.Text = "T-";
            
            }

            else {

                a_id.Text = "L-";
            
            }


            Enable();

        }

        //Librian update information textbox

        public void User_Information_Update()
        {



            try
            {

                //  admission_id_label.Text = admission_id_textBox.Text;
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r1;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT *from librian  where username='" + username.Text + "'  ";

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

                    sname.Text = r1.GetString("S_name");
                    aid.Text = r1.GetString("username");
                    password_.Text = r1.GetString("password");

                    semail.Text = r1.GetString("s_email");
                    Gender.Text = r1.GetString("gender");
                    adate.Text = r1.GetString("admission_date");
                    ayear.Text = r1.GetString("year");
                    Rel.Text = r1.GetString("religion");
                    saddress.Text = r1.GetString("address");
                    D_ob.Text = r1.GetString("dob");
                    sphone.Text = r1.GetString("s_phone");
                   





                }



                if (username.Text != aid.Text)
                {

                  Clear_Update();


                }




                cnn.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }
        //admin update information textbox

        public void admin_Information_Update(string value)
        {

            this.admin_rcv = value;
            username.Text = this.admin_rcv;
            try
            {

                //  admission_id_label.Text = admission_id_textBox.Text;
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r1;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT *from admin  where username='" + this.admin_rcv + "'  ";

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

                    sname.Text = r1.GetString("S_name");
                    aid.Text = r1.GetString("username");
                    password_.Text = r1.GetString("password");

                    semail.Text = r1.GetString("s_email");
                    Gender.Text = r1.GetString("gender");
                    adate.Text = r1.GetString("admission_date");
                    ayear.Text = r1.GetString("year");
                    Rel.Text = r1.GetString("religion");
                    saddress.Text = r1.GetString("address");
                    D_ob.Text = r1.GetString("dob");
                    sphone.Text = r1.GetString("s_phone");






                }



                if (username.Text != aid.Text)
                {

                    Clear_Update();


                }




                cnn.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }

        //teacher update information textbox

        public void Teacher_Information_Update(string value)
        {

            this.teacher_rcv = value;
            username.Text = this.teacher_rcv;
            try
            {

                //  admission_id_label.Text = admission_id_textBox.Text;
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r1;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT *from teacher  where username='" + this.teacher_rcv + "'  ";

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

                    sname.Text = r1.GetString("S_name");
                    aid.Text = r1.GetString("username");
                    password_.Text = r1.GetString("password");

                    semail.Text = r1.GetString("s_email");
                    Gender.Text = r1.GetString("gender");
                    adate.Text = r1.GetString("admission_date");
                    ayear.Text = r1.GetString("year");
                    Rel.Text = r1.GetString("religion");
                    saddress.Text = r1.GetString("address");
                    D_ob.Text = r1.GetString("dob");
                    sphone.Text = r1.GetString("s_phone");






                }



                if (username.Text != aid.Text)
                {

                    Clear_Update();


                }




                cnn.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }


        private void username_TextChanged(object sender, EventArgs e)
        {
            User_Information_Update();
            if (Update_comboBox.Text == "Admin")
            {

                admin_Information_Update(username.Text);

            }
            else {

                Teacher_Information_Update(username.Text);
            
            }
            


        }



        //Image buuton for Show image
        private void Imagebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {

                picpath = open.FileName.ToString();

                s_imagebox.ImageLocation = picpath;
            }
        }

        private void User_insert_button_Click(object sender, EventArgs e)
        {
            char_detect = a_id.Text[0];
            switch (char_detect)
            {

                case 'A':
                    //admin user insert  

                    if (a_id.Text != "")
                    {
                        DialogResult dialog = MessageBox.Show("Do you really want to Insert?", "EXIT",
                           MessageBoxButtons.YesNo);

                        if (dialog == DialogResult.Yes)
                        {
                            if (!admin_UserName_check())
                            {
                                try
                                {

                                    //image insert code 


                                    byte[] imageBt = null;
                                    FileStream fstream = new FileStream(picpath, FileMode.Open, FileAccess.Read);

                                    BinaryReader br = new BinaryReader(fstream);
                                    imageBt = br.ReadBytes((int)fstream.Length);

                                    //end code


                                    cnn.Open();


                                    MySqlCommand cmd = cnn.CreateCommand();
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = cmd.CommandText = "insert into admin (username,password,s_name,admission_date,year,gender,religion,address,dob,s_phone,s_email,image) values ('" + a_id.Text + "','" + password.Text + "','" + s_name.Text + "','" + a_date.Text + "','" + year.Text + "','" + s_gender.Text + "','" + religion.Text + "','" + address.Text + "','" + dob.Text + "','" + s_phone.Text + "','" + s_email.Text + "',@IMG)";

                                    cmd.Parameters.AddWithValue("@IMG", imageBt);

                                    cmd.ExecuteReader();




                                    cnn.Close();
                                    MessageBox.Show("Admin Insert successfully");
                                    Clear();
                                    Dissible();
                                  AdminList_FillDataGridView();




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

                        MessageBox.Show("Fillup the Class Name Box");

                    }



                    break;

                case 'L':

                    if (a_id.Text != "")
                    {
                        DialogResult dialog = MessageBox.Show("Do you really want to Insert?", "EXIT", MessageBoxButtons.YesNo);


                        if (dialog == DialogResult.Yes)
                        {
                            if (!Librian_UserName_check())
                            {
                                try
                                {

                                    //image insert code 


                                    byte[] imageBt = null;
                                    FileStream fstream = new FileStream(picpath, FileMode.Open, FileAccess.Read);

                                    BinaryReader br = new BinaryReader(fstream);
                                    imageBt = br.ReadBytes((int)fstream.Length);

                                    //end code


                                    cnn.Open();


                                    MySqlCommand cmd = cnn.CreateCommand();
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = cmd.CommandText = "insert into librian (username,password,s_name,admission_date,year,gender,religion,address,dob,s_phone,s_email,image) values ('" + a_id.Text + "','" + password.Text + "','" + s_name.Text + "','" + a_date.Text + "','" + year.Text + "','" + s_gender.Text + "','" + religion.Text + "','" + address.Text + "','" + dob.Text + "','" + s_phone.Text + "','" + s_email.Text + "',@IMG)";

                                    cmd.Parameters.AddWithValue("@IMG", imageBt);

                                    cmd.ExecuteReader();




                                    cnn.Close();
                                    MessageBox.Show("Librian Insert successfully");
                                    Clear();
                                    Dissible();
                                    LibrianList();




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

                    break;

                case 'T':

                    if (a_id.Text != "")
                    {
                        DialogResult dialog = MessageBox.Show("Do you really want to Insert?", "EXIT", MessageBoxButtons.YesNo);


                        if (dialog == DialogResult.Yes)
                        {
                            if (!Teacher_UserName_check())
                            {
                                try
                                {

                                    //image insert code 


                                    byte[] imageBt = null;
                                    FileStream fstream = new FileStream(picpath, FileMode.Open, FileAccess.Read);

                                    BinaryReader br = new BinaryReader(fstream);
                                    imageBt = br.ReadBytes((int)fstream.Length);

                                    //end code


                                    cnn.Open();


                                    MySqlCommand cmd = cnn.CreateCommand();
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = cmd.CommandText = "insert into teacher (username,password,s_name,admission_date,year,gender,religion,address,dob,s_phone,s_email,image) values ('" + a_id.Text + "','" + password.Text + "','" + s_name.Text + "','" + a_date.Text + "','" + year.Text + "','" + s_gender.Text + "','" + religion.Text + "','" + address.Text + "','" + dob.Text + "','" + s_phone.Text + "','" + s_email.Text + "',@IMG)";

                                    cmd.Parameters.AddWithValue("@IMG", imageBt);

                                    cmd.ExecuteReader();




                                    cnn.Close();
                                    MessageBox.Show("Teacher Insert successfully");
                                    Clear();
                                    Dissible();
                                   TeacherList();




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

                    break;

                default:

                    MessageBox.Show("Check the Combox Usertype Symbol");
                    break;





            }

        }

        //
        private void Reset_Button_Click(object sender, EventArgs e)
        {
            Clear();
            if (user_comboBox.Text == "")
            {

                Dissible();

            }
     
        }

        private void Update_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            username.Enabled = true;


            if (Update_comboBox.Text == "Admin")
            {

                username.Text = "A-";


            }

            else if (Update_comboBox.Text == "Librian")
            {

                username.Text = "L-";

            }

            else if (Update_comboBox.Text == "Teacher")
            {

                username.Text = "T-";

            }
        }

        //
       
        //datagridview
        private void librian_Search_dataGridview_TextChanged(object sender, EventArgs e)
        {
            if (librian_Search_dataGridview.Text== "")
            {

                LibrianList();
            }


            else
            {

                LibrianList_Search();

            }
        }


        //Admin Search

        private void admin_Search_TextChanged(object sender, EventArgs e)
        {
            if (admin_Search.Text == "")
            {

                 AdminList_FillDataGridView();
            }


            else
            {

                 AdminList_Search();

            }
        }

        private void Export_button_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet ds = new DataSet("New_DataSet");
                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;

                ds.Tables.Add(data);
                //  ExcelLibrary.DataSetHelper.CreateWorkbook("Badhan.xls", ds);﻿

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";//you can give it C: D: E: F: etc
                saveFileDialog1.Title = "Save As Excel File";
                saveFileDialog1.FileName = "Admin List";
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

            AdminList_FillDataGridView();

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            //tabepage3 load
        }

        private void ExportExcellButton_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet ds = new DataSet("New_DataSet");
                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;

                ds.Tables.Add(data);
                //  ExcelLibrary.DataSetHelper.CreateWorkbook("Badhan.xls", ds);﻿

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";//you can give it C: D: E: F: etc
                saveFileDialog1.Title = "Save As Excel File";
                saveFileDialog1.FileName = "Librian List";
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

            LibrianList();
        }


        //Update Button Click
        private void UpdateButton_Click(object sender, EventArgs e)
        {

            char_detect = aid.Text[0];
            switch (char_detect)
            {

                case 'A':
                    //admin user insert  

                    if (aid.Text != "")
                    {
                        DialogResult dialog = MessageBox.Show("Do you really want to Update?", "EXIT",
                           MessageBoxButtons.YesNo);

                        if (dialog == DialogResult.Yes)
                        {
                           
                                try
                                {

                                   

                                    cnn.Open();


                                    MySqlCommand cmd = cnn.CreateCommand();
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = "update admin set password='" + password_.Text + "',s_name='" + sname.Text + "',admission_date='" + adate.Text + "',gender='" + Gender.Text + "',religion='" + Rel.Text + "',address= '" + saddress.Text + "',dob='" + D_ob.Text + "',s_phone='" + sphone.Text + "',s_email='" + semail.Text + "' where username='" + aid.Text + "'";

                                

                                    cmd.ExecuteReader();




                                    cnn.Close();
                                    MessageBox.Show("Admin Update successfully");
                                    Clear_Update();
                                 
                                    AdminList_FillDataGridView();




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

                        MessageBox.Show("Fillup the  TextBox");

                    }



                    break;

                case 'L':

                    if (aid.Text != "")
                    {
                        DialogResult dialog = MessageBox.Show("Do you really want to Update?", "EXIT", MessageBoxButtons.YesNo);


                        if (dialog == DialogResult.Yes)
                        {
                           
                                try
                                {


                                    cnn.Open();


                                    MySqlCommand cmd = cnn.CreateCommand();
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = "update librian set password='" + password_.Text + "',s_name='" + sname.Text + "',admission_date='" + adate.Text + "',gender='" + Gender.Text + "',religion='" + Rel.Text + "',address= '" + saddress.Text + "',dob='" + D_ob.Text + "',s_phone='" + sphone.Text + "',s_email='" + semail.Text + "' where username='" + aid.Text + "'";

                                   

                                    cmd.ExecuteReader();




                                    cnn.Close();
                                    MessageBox.Show("Librian Update successfully");
                                   Clear_Update();
                               
                                    LibrianList();




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

                    break;

                case 'T':

                    if (aid.Text != "")
                    {
                        DialogResult dialog = MessageBox.Show("Do you really want to Update?", "EXIT", MessageBoxButtons.YesNo);


                        if (dialog == DialogResult.Yes)
                        {

                            try
                            {


                                cnn.Open();


                                MySqlCommand cmd = cnn.CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "update teacher set password='" + password_.Text + "',s_name='" + sname.Text + "',admission_date='" + adate.Text + "',gender='" + Gender.Text + "',religion='" + Rel.Text + "',address= '" + saddress.Text + "',dob='" + D_ob.Text + "',s_phone='" + sphone.Text + "',s_email='" + semail.Text + "' where username='" + aid.Text + "'";



                                cmd.ExecuteReader();




                                cnn.Close();
                                MessageBox.Show("Teacher Update successfully");
                                Clear_Update();

                                TeacherList();




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
                    break;

                default:

                    MessageBox.Show("Check the Combox Usertype Symbol");
                    break;





            }
        }

        private void teacher_Search_dataGridview_TextChanged(object sender, EventArgs e)
        {
            if (teacher_Search_dataGridview.Text == "")
            {

                TeacherList();
            }


            else
            {

                TeacherList_Search();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet ds = new DataSet("New_DataSet");
                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;

                ds.Tables.Add(data);
                //  ExcelLibrary.DataSetHelper.CreateWorkbook("Badhan.xls", ds);﻿

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";//you can give it C: D: E: F: etc
                saveFileDialog1.Title = "Save As Excel File";
                saveFileDialog1.FileName = "Teachert List";
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

            TeacherList();
        }

        //Last two scope
    }
}
