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
    {   //Table one
        public new string Site;
        public string Completed_by;
        public string Work_Area;
        public string Job_Description;
        public string Supervisor;
        public string Inspector;
        public string Date ;
        public string Type;

        //2nd table
      /*//  public string InterventionsWAH;
        public string CommentWAH ;
        public string CompletedWAH;
        public string ActionTakenWAH;

        public string InterventionsLO;
        public string CommentLO;
        public string CompletedLO;
        public string ActionTakenLO;

        public string InterventionsCer;
        public string CommentCer;
        public string CompletedCer;
        public string ActionTakenCer;

        public string InterventionsCSW;
        public string CommentCSW;
        public string CompletedCSW;
        public string ActionTakenCSW;

        public string InterventionsEW;
        public string CommentEW;
        public string CompletedEW;
        public string ActionTakenEW;

        public string InterventionsSSA;
        public string CommentSSA;
        public string CompletedSSA;
        public string ActionTakenSSA;

        public string InterventionPap;
        public string CommentPap;
        public string CompletedPap;
        public string ActionTakentxtPap;

        public string InterventionQCer;
        public string CommentQCer;
        public string CompletedQCer;
        public string ActionTakenQCer;
*/
        
        public Safety_Audit_Form()
        {
            InitializeComponent();
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Safety_Audit_Form_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
           Safety_Audit_Form_2 newSafetyAuditForm2 = new Safety_Audit_Form_2();
           this.Hide();
           newSafetyAuditForm2.Show();

           SafetyAuditFormData.InterventionsWAH = txtWAH1.Text;
            SafetyAuditFormData.CommentWAH = txtWAH2.Text;
            SafetyAuditFormData.CompletedWAH = txtWAH3.Text;
            SafetyAuditFormData.ActionTakenWAH = txtWAH4.Text;

            SafetyAuditFormData.InterventionsLO = txtLO1.Text;
            SafetyAuditFormData.CommentLO = txtLO2.Text;
            SafetyAuditFormData.CompletedLO = txtLO3.Text;
            SafetyAuditFormData.ActionTakenLO = txtLO4.Text;

            SafetyAuditFormData.InterventionsCer = txtCer1.Text;
            SafetyAuditFormData.CommentCer = txtCer2.Text;
            SafetyAuditFormData.CompletedCer = txtCer3.Text;
            SafetyAuditFormData.ActionTakenCer = txtCer4.Text;

            SafetyAuditFormData.InterventionsCSW = txtCSW1.Text;
            SafetyAuditFormData.CommentCSW = txtCSW2.Text;
            SafetyAuditFormData.CompletedCSW = txtCSW3.Text;
            SafetyAuditFormData.ActionTakenCSW = txtCSW4.Text;

            SafetyAuditFormData.InterventionsEW = txtEW1.Text;
            SafetyAuditFormData.CommentEW = txtEW2.Text;
            SafetyAuditFormData.CompletedEW = txtEW3.Text;
            SafetyAuditFormData.ActionTakenEW = txtEW4.Text;
            SafetyAuditFormData.InterventionsSSA = txtSSA1.Text;
            SafetyAuditFormData.CommentSSA = txtSSA2.Text;
            SafetyAuditFormData.CompletedSSA = txtSSA3.Text;
            SafetyAuditFormData.ActionTakenSSA = txtSSA4.Text;

            SafetyAuditFormData.InterventionPap = txtPap1.Text;
            SafetyAuditFormData.CommentPap = txtPap2.Text;
            SafetyAuditFormData.CompletedPap = txtPap3.Text;
            SafetyAuditFormData.ActionTakentxtPap = txtPap4.Text;
            SafetyAuditFormData.InterventionQCer = txtQCer1.Text;
            SafetyAuditFormData.CommentQCer = txtQCer2.Text;
            SafetyAuditFormData.CompletedQCer = txtQCer3.Text;
            SafetyAuditFormData.ActionTakenQCer = txtQCer4.Text;

           /* Connection SafetyAuditFormconn = Connection.GetInstanceOfConnection();
            SafetyAuditFormconn.SaveToDb2("INSERT INTO SafetyAuditForm_1 (Interventions, Comment, Completed, ActionTaken) Values (@Interventions, @Comment, @Completed, @ActionTaken)", InterventionsWAH,CommentWAH,CompletedWAH,ActionTakenWAH);*/
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
            Site = sitetxt.Text;
            Completed_by = completedtxt.Text;
            Work_Area = worktxt.Text;
            Job_Description = jobtxt.Text;
            Supervisor = supervisortxt.Text;
            Inspector = inspectortxt.Text;
            Date = datetxt.Text;
            Type = typetxt.Text;

            Connection SafetyAuditFormconn = Connection.GetInstanceOfConnection();
            SafetyAuditFormconn.SaveToDb("INSERT INTO SafetyAuditForm (Site, Completed_By, Work_Area, Job_Description, Supervisor, Inspector, Date, Type) Values (@Site, @Completed_By, @Work_Area, @Job_Description, @Supervisor, @Inspector, @Date, @Type)", Site, Completed_by, Work_Area, Job_Description, Supervisor, Inspector, Date, Type);

                     
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void sitetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
