using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Musk_Assisgnment
{
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please enter the required fields!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into userregistration (FIRSTNAME, LASTNAME, USERNAME, EMAIL, PASSWORD, CONFIRM PASSWORD) VALUES (@FIRSTNAME,@LASTNAME,@USERNAME,@EMAIL,@PASSWORD,@CONFIRMPASSWORD)", con);
                    cmd.Parameters.AddWithValue("@FIRSTNAME", textBox1.Text);
                    cmd.Parameters.AddWithValue("@LASTNAME", textBox2.Text);
                    cmd.Parameters.AddWithValue("@USERNAME", textBox3.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", textBox4.Text);
                    cmd.Parameters.AddWithValue("@PASSWORD", textBox5.Text);
                    cmd.Parameters.AddWithValue("@CONFIRMPASSWORD", textBox6.Text);
                    con.Close();
                    MessageBox.Show("Sucessfully Created!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
