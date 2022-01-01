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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
               
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Safety_Audit_Form sf = new Safety_Audit_Form();
            this.Hide();
            sf.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List_of_Inspection newListOfInspection = new List_of_Inspection();
            this.Hide();
            newListOfInspection.ShowDialog();
            this.Show();
        }
    }
}
