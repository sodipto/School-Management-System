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
using System.IO;

namespace School_Management_System
{
    public partial class StudentEntry : Form
    {

        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");

        string picpath;

        public StudentEntry()
        {
            InitializeComponent();
    
        }

        private void ClearTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearTextBoxes(ctrl.Controls);
            }

            s_imagebox.Image = null;
            s_gender.Text = "";
            religion.Text = "";
        }
      

        //admission id check function
        public bool Admission_id_check()
        {

            string constring = "server=localhost;database=School_Management;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("Select * from student where admission_id='" + a_id.Text + "' ", con);
            cmd.Parameters.AddWithValue("@dmission_id", this.a_id.Text);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("This Admission ID Already exist");
                return true;
            }
            else
            {
                return false;
            }
        } 



        //student information insert button
        private void student_insert_button_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Insert?", "EXIT",
               MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (!Admission_id_check())
                {
                    try
                    {    //image insert code 


                        byte[] imageBt = null;
                        FileStream fstream = new FileStream(picpath, FileMode.Open, FileAccess.Read);

                        BinaryReader br = new BinaryReader(fstream);
                        imageBt = br.ReadBytes((int)fstream.Length);

                        //end code


                        cnn.Open();
                        //  MessageBox.Show("Connection Open ! ");
                        MySqlCommand cmd = cnn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into student (admission_id,password,s_name,admission_date,year,gender,religion,address,dob,s_phone,s_email,f_name,f_ocapation,f_phone,f_email,m_name,m_ocapation,m_phone,m_email,g_name,g_phone,g_address,g_email,g_ocapation,g_identity,image) values ('" + a_id.Text + "','" + password_textBox.Text + "','" + s_name.Text + "','" + a_date.Text + "','" + year.Text + "','" + s_gender.Text + "','" + religion.Text + "','" + address.Text + "','" + dob.Text + "','" + s_phone.Text + "','" + s_email.Text + "','" + f_name.Text + "','" + f_oca.Text + "','" + f_phone.Text + "','" + f_email.Text + "','" + m_name.Text + "','" + m_oca.Text + "','" + m_phone.Text + "','" + m_email.Text + "','" + g_name.Text + "','" + g_phone.Text + "','" + g_address.Text + "','" + g_email.Text + "','" + g_oca.Text + "','" + g_identy.Text + "',@IMG)";
                        cmd.Parameters.AddWithValue("@IMG", imageBt);
                        // MySqlDataReader dr =  //data excute variable

                        cmd.ExecuteReader();




                        cnn.Close();
                        MessageBox.Show("insert successfully");
                     //   Clear();




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }

            else if (dialog == DialogResult.No)
            {
                //do something else
            }
        }


//image choose button
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {

                picpath = open.FileName.ToString();

                s_imagebox.ImageLocation = picpath;
            }

        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }

        



//namespace and class end scope
    }
}
