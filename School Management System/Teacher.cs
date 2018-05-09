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
    public partial class Teacher : Form
    {
        string username_rcv;
        MySqlConnection cnn = new MySqlConnection("server=localhost;database=School_Management;uid=root;pwd=;");

        public Teacher()
        {
            InitializeComponent();
        }


        public Teacher(string username)
        {
            InitializeComponent();
           
            this.username_rcv = username;
            username_function();

           // user_name.Text = this.username_rcv;
        }


        public void username_function()
        {
            try
            {

                //  admission_id_label.Text = admission_id_textBox.Text;
                cnn.Open();

                MySqlCommand cmd = cnn.CreateCommand();
                MySqlDataReader r1;  //= new MySqlDataReader();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT s_name from teacher  where username='" + this.username_rcv + "'  ";

                r1 = cmd.ExecuteReader();

                while (r1.Read())
                {



                    user_name.Text = r1.GetString("S_name");






                }






                cnn.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void Profile_button_Click(object sender, EventArgs e)
        {
            UserTypeEntry s = new UserTypeEntry();
            // this.Hide();
            s.tabPage4.Parent = null;
            s.tabPage3.Parent = null;
            s.tabPage1.Parent = null;
            s.tabPage5.Parent = null;
            s.UpdateButton.Enabled = false;
            s.Update_comboBox.Enabled = false;

            s.admin_Information_Update(this.username_rcv);

            s.Show();
        }

        //
        private void Markbutton_Click(object sender, EventArgs e)
        {
            Marks m = new Marks();
            m.Show();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            Student_Details s = new Student_Details();
            this.Hide();
            s.tabPage6.Parent = null;
            s.Pass_textBox.Visible = false;
            s.pass_label.Visible = false;

            s.Show();
        }


        //All Result
        private void button1_Click(object sender, EventArgs e)
        {
            ResultShow r = new ResultShow();
            r.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClassRegistration cr = new ClassRegistration();
            cr.Show();
        }



    }
}
