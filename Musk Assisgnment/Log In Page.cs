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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void username_label(object sender, EventArgs e)
        {

        }

        private void password_label(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogIn_Button(object sender, EventArgs e)
        {
          //  SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Z:\Musk Assignment V2\Musk Assisgnment\Database1.mdf;Integrated Security=True");
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username = '" + usernameTextBox.Text + "' and password= '" + passwordTextBox.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Dashboard mm = new Dashboard();
                mm.Show();
                //(new Dashboard()).Show(); 
            }
            else
            {
                MessageBox.Show("Please Enter correct username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void SignUp_Button(object sender, EventArgs e)
            {

            }

            private void ForgotPassword_labelLink(object sender, EventArgs e)
            {

            }

            private void button4_Click(object sender, EventArgs e)
            {
                this.Close();
            }
    }
}
