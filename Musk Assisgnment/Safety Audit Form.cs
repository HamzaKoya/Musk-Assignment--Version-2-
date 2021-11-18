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
    public partial class Safety_Audit_Form : Form
    {
        public Safety_Audit_Form()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Safety_Audit_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Safety_Audit_Form_2 newSafetyAuditForm2 = new Safety_Audit_Form_2();
            this.Hide();
            newSafetyAuditForm2.ShowDialog();
            this.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string site = sitetxt.Text;
            string completedby = completedtxt.Text;
            string workarea = worktxt.Text;
            string jobdescription = jobtxt.Text;
            string supervisor = supervisortxt.Text;
            string inspector = inspectortxt.Text;
            string date = datetxt.Text;
            string type = typetxt.Text;

            Connection SafetyAuditFormconn = Connection.getInstanceOfConnection();
            SafetyAuditFormconn.saveToDb("INSERT INTO SafetyAuditForm (Site, Completed By, Work Area, Job Description, Supervisor, Inspector, Date, Type) Values (@Site, @CompletedBy, @WorkArea, @JobDescription, @Supervisor, @Inspector, @Date, @Type)", site, completedby, workarea, jobdescription, supervisor, inspector, date, type);

                     
        }
    }
}
