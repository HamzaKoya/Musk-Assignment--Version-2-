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

        private void Button4_Click(object sender, EventArgs e)
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

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string site = sitetxt.Text;
            string completedby = completedtxt.Text;
            string workarea = worktxt.Text;
            string jobdescription = jobtxt.Text;
            string supervisor = supervisortxt.Text;
            string inspector = inspectortxt.Text;
            string date = datetxt.Text;
            string type = typetxt.Text;

            Connection SafetyAuditFormconn = Connection.GetInstanceOfConnection();
            SafetyAuditFormconn.SaveToDb("INSERT INTO SafetyAuditForm (SiteName, CompletedBy, WorkArea, JobDescription, Supervisor, Inspector, InspectionDate, InspectionType) Values (@SiteName, @CompletedBy, @WorkArea, @JobDescription, @Supervisor, @Inspector, @InspectionDate, @InspectionType)", site, completedby, workarea, jobdescription, supervisor, inspector, date, type);

                     
        }
    }
}
