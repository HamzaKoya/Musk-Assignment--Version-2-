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
        private object FirstNametxt;

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

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = firstNametxt.Text;
            string lastName = lastNametxt.Text;
            string username = usernametxt.Text;
            string email = emailtxt.Text;
            string password = passwordtxt.Text;
            string confirmpassword = confirmpasswordtxt.Text;

            Connection UserRegistrationFormTableconn = Connection.GetInstanceOfConnection();
            UserRegistrationFormTableconn.SaveToDb1("INSERT INTO UserRegistrationFormTable(FirstName, LastName, Username, Email, Password, ConfirmPassword) Value (@Firstname, @Lastname, @Username, @Email, @Password, @ConfirmPassword)", firstName, lastName, username, email, password, confirmpassword);

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void UserRegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
