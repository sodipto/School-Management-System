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
//excel namespace

using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using System.Data.OleDb;

namespace School_Management_System
{
    public partial class Student_Details : Form
    {
       
      //  public System.Windows.Forms.TabPage tabPage1;

        DataTable data; //datagridview Table data intilize

        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");


        public Student_Details()
        {
            InitializeComponent();
            StudentList_FillDataGridView();
            // tabPage6.Parent = null;
            //tabControl1.TabPages.Remove(tabPage6);
            //tabPage6.Enabled = false; // this disables the controls on it
           // tabPage6.Visible = false; // this hides the controls on it.
            
            
        }


        public void StudentList_FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

             cmd.CommandText = "select admission_id,s_name,admission_date,year,gender,religion,address,dob,s_phone,s_email,f_name,f_ocapation,f_phone,f_email,m_name,m_ocapation,m_phone,m_email,g_name,g_phone,g_address,g_email,g_ocapation,g_identity from student";
          //  cmd.CommandText = "select *from admin";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Student_dataGridView.DataSource = data;




            cnn.Close();

        }

        //Search datagridview
        public void Search_StudentList_FillDataGridView()
        {


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from student where admission_id='" + admission_Search_dataGridview.Text + "'";
            cmd.ExecuteNonQuery();

            data = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(data);
            Student_dataGridView.DataSource = data;




            cnn.Close();

        }


        //clear the All Field
        public void Clear() { 
        
                    s_name.Text = "";
                    a_id.Text = "";
                    s_email.Text = "";
                    s_gender.Text = "";
                    a_date.Text ="";
                    year.Text ="";
                    religion.Text ="";
                    address.Text ="";
                    dob.Text ="";
                    s_phone.Text="";
                    f_name.Text ="";
                    f_oca.Text ="";
                    f_phone.Text=""; 
                    f_email.Text ="";
                    m_name.Text ="";
                    m_oca.Text ="";
                    m_phone.Text = "";
                    m_email.Text ="";
                    g_name.Text ="";
                    g_phone.Text ="";
                    g_address.Text ="";
                    g_email.Text ="";
                    g_oca.Text ="";
                    g_identy.Text = "";
                    s_imagebox.Image = null;
                    Pass_textBox.Text = "";
                    

           
        
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
            fname.Text = "";
            foca.Text = "";
            fphone.Text = "";
            femail.Text = "";
            mname.Text = "";
            moca.Text = "";
            mphone.Text = "";
            memail.Text = "";
            gname.Text = "";
            gphone.Text = "";
            gaddress.Text = "";
            gemail.Text = "";
            goca.Text = "";
            gidenty.Text = "";
            pictureBox1.Image = null;
            
           



        }

       

        public void Student_Information() {



            try
            {

                //  admission_id_label.Text = admission_id_textBox.Text;
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r1;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT *from student  where admission_id='" + admission_id_Search_textBox.Text + "'  ";

                r1 = cmd.ExecuteReader();

                while (r1.Read())
                {


                    byte[] img = (byte[])(r1["image"]);

                    if (img == null)
                    {

                        s_imagebox.Image = null;

                    }

                    else
                    {

                        MemoryStream ms = new MemoryStream(img);
                        s_imagebox.Image = System.Drawing.Image.FromStream(ms);

                    }

                    s_name.Text = r1.GetString("S_name");
                    Pass_textBox.Text = r1.GetString("password");
                    a_id.Text = r1.GetString("admission_id");
                    s_email.Text = r1.GetString("s_email");
                    s_gender.Text = r1.GetString("gender");
                    a_date.Text = r1.GetString("admission_date");
                    year.Text = r1.GetString("year");
                    religion.Text = r1.GetString("religion");
                    address.Text = r1.GetString("address");
                    dob.Text = r1.GetString("dob");
                    s_phone.Text = r1.GetString("s_phone");
                    f_name.Text = r1.GetString("f_name");
                    f_oca.Text = r1.GetString("f_ocapation");
                    f_phone.Text = r1.GetString("f_phone");
                    f_email.Text = r1.GetString("f_email");
                    m_name.Text = r1.GetString("m_name");
                    m_oca.Text = r1.GetString("m_ocapation");
                    m_phone.Text = r1.GetString("m_phone");
                    m_email.Text = r1.GetString("m_email");
                    g_name.Text = r1.GetString("g_name");
                    g_phone.Text = r1.GetString("g_phone");
                    g_address.Text = r1.GetString("g_address");
                    g_email.Text = r1.GetString("g_email");
                    g_oca.Text = r1.GetString("g_ocapation");
                    g_identy.Text = r1.GetString("g_identity");






                }


                if (admission_id_Search_textBox.Text != a_id.Text)
                {

                  Clear();
                

                }


                

                cnn.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        
        
        
        
        
        }



        //student update information textbox

        public void Student_Information_Update()
        {

           

            try
            {

                //  admission_id_label.Text = admission_id_textBox.Text;
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r1;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT *from student  where admission_id='" +Admission_id_update_textBox.Text+ "'  ";

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
                    Password_textBox.Text = r1.GetString("password");
                    aid.Text = r1.GetString("admission_id");
                    semail.Text = r1.GetString("s_email");
                    Gender.Text = r1.GetString("gender");
                    adate.Text = r1.GetString("admission_date");
                    ayear.Text = r1.GetString("year");
                    Rel.Text = r1.GetString("religion");
                    saddress.Text = r1.GetString("address");
                    D_ob.Text = r1.GetString("dob");
                    sphone.Text = r1.GetString("s_phone");
                    fname.Text = r1.GetString("f_name");
                    foca.Text = r1.GetString("f_ocapation");
                    fphone.Text = r1.GetString("f_phone");
                    femail.Text = r1.GetString("f_email");
                    mname.Text = r1.GetString("m_name");
                    moca.Text = r1.GetString("m_ocapation");
                    mphone.Text = r1.GetString("m_phone");
                    memail.Text = r1.GetString("m_email");
                    gname.Text = r1.GetString("g_name");
                    gphone.Text = r1.GetString("g_phone");
                    gaddress.Text = r1.GetString("g_address");
                    gemail.Text = r1.GetString("g_email");
                    goca.Text = r1.GetString("g_ocapation");
                    gidenty.Text = r1.GetString("g_identity");

                    



                }

                

                if (Admission_id_update_textBox.Text != aid.Text)
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



        // value show Text box
        private void admission_id_Search_textBox_TextChanged(object sender, EventArgs e)
        {
            Student_Information();
        }




        //update tab page Admission id Search
        private void Admission_id_update_textBox_TextChanged(object sender, EventArgs e)
        {
            Student_Information_Update();
            aid.Enabled = false;
            Gender.Enabled = false;
            Rel.Enabled = false;
            ayear.Enabled = false;
            
            
        }


        //Value Update
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Insert?", "EXIT",
              MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
              
                    try
                    {    


                        cnn.Open();
                       
                        MySqlCommand cmd = cnn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update student set password='"+Password_textBox.Text+"',s_name='" + sname.Text + "',admission_date='" + adate.Text + "',gender='" + Gender.Text + "',religion='" + Rel.Text + "',address= '" + saddress.Text + "',dob='" + D_ob.Text + "',s_phone='" + sphone.Text + "',s_email='" + semail.Text + "',f_name='" + fname.Text + "',f_ocapation='" + foca.Text + "',f_phone='" + fphone.Text + "',f_email='" + femail.Text + "',m_name='" + mname.Text + "',m_ocapation='" + moca.Text + "',m_phone='" + mphone.Text + "',m_email='" + memail.Text + "',g_name='" + gname.Text + "',g_phone='" + gphone.Text + "',g_address='" + gaddress.Text + "',g_email='" + gemail.Text + "',g_ocapation='" + goca.Text + "',g_identity='" + gidenty.Text + "' where admission_id='"+aid.Text+"'";
                      

                        cmd.ExecuteReader();




                        cnn.Close();
                        MessageBox.Show("Update successfully");

                        Student_Information_Update();



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                
            }

            else if (dialog == DialogResult.No)
            {
                //do something else
            }
        }


        //Gender text value show
        private void Gender_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Gender.Text = Gender_comboBox.Text;


        }

        private void Religion_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rel.Text = Religion_comboBox.Text;
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Clear_Update();
            Admission_id_update_textBox.Text = "";

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Clear();
            admission_id_Search_textBox.Text = "";
        }

        //
        private void admission_Search_dataGridview_TextChanged(object sender, EventArgs e)
        {
            if (admission_Search_dataGridview.Text == "")
            {

                StudentList_FillDataGridView();
            }


            else
            {

                Search_StudentList_FillDataGridView();

            }
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
                saveFileDialog1.FileName = "student List";
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

            StudentList_FillDataGridView();


        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

       










      

        //Last Two Scope
    }
}
