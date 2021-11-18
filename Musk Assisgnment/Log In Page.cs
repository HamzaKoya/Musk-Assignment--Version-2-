using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Dashboard newdashboard = new Dashboard();
            this.Hide();
            newdashboard.ShowDialog();
            this.Show();
            //(new Dashboard()).Show();
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
