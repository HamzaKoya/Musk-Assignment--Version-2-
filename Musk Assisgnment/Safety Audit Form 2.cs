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
    public partial class Safety_Audit_Form_2 : Form
    {
        public string InterventionsHW;
        public string CommentHW;
        public string CompletedHW;
        public string ActionTakenHW;

        public string InterventionsIso;
        public string CommentIso;
        public string CompletedIso;
        public string ActionTakenIso;

        public string InterventionsFER;
        public string CommentFER;
        public string CompletedFER;
        public string ActionTakenFER;

        public string InterventionsAwa;
        public string CommentAwa;
        public string CompletedAwa ;
        public string ActionTakenAwa;

        //Text box input from D.Enviornment
        public string InterventionsWM ;
        public string CommentWM;
        public string CompletedWM;
        public string ActionTakenWM;

        public string InterventionsPM;
        public string CommentPM;
        public string CompletedPM;
        public string ActionTakenPM;

        public string InterventionsCOH;
        public string CommentCOH;
        public string CompletedCOH;
        public string ActionTakenCOH;

        public string InterventionsPPE;
        public string CommentPPE;
        public string CompletedPPE;
        public string ActionTakenPPE;

        public string InterventionsMH;
        public string CommentMH;
        public string CompletedMH;
        public string ActionTakenMH;

        public string InterventionsOC;
        public string CommentOC;
        public string CompletedOC;
        public string ActionTakenOC;

        public string InterventionsPT;
        public string CommentPT;
        public string CompletedPT;
        public string ActionTakenPT;

        public string InterventionsVDC;
        public string CommentVDC;
        public string CompletedVDC;
        public string ActionTakenVDC;

        public string InterventionsTUF;
        public string CommentTUF;
        public string CompletedTUF;
        public string ActionTakenTUF;
        public Safety_Audit_Form_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Safety_Audit_Form_3 newSafetyAuditForm3 = new Safety_Audit_Form_3();
            this.Hide();
            newSafetyAuditForm3.ShowDialog();


            //Text box input from C.Site Rules
            SafetyAuditFormData.InterventionsHW = txtHW1.Text;
            SafetyAuditFormData.CommentHW = txtHW4.Text;
            SafetyAuditFormData.CompletedHW = txtHW4.Text;
            SafetyAuditFormData.ActionTakenHW = txtHW4.Text;

            SafetyAuditFormData.InterventionsIso = txtIso1.Text;
            SafetyAuditFormData.CommentIso = txtIso2.Text;
            SafetyAuditFormData.CompletedIso = txtIso3.Text;
            SafetyAuditFormData.ActionTakenIso = txtIso4.Text;

            SafetyAuditFormData.InterventionsFER = txtFER1.Text;
            SafetyAuditFormData.CommentFER = txtFER2.Text;
            SafetyAuditFormData.CompletedFER = txtFER3.Text;
            SafetyAuditFormData.ActionTakenFER = txtFER4.Text;

            SafetyAuditFormData.InterventionAwa = txtAwa1.Text;
            SafetyAuditFormData.CommentAwa = txtAwa2.Text;
            SafetyAuditFormData.CompletedAwa = txtAwa2.Text;
            SafetyAuditFormData.ActionTakenAwa = txtAwa3.Text;

            //Text box input from D.Enviornment
            SafetyAuditFormData.InterventionsWM = txtWM1.Text;
            SafetyAuditFormData.CommentWM = txtWM2.Text;
            SafetyAuditFormData.CompletedWM = txtWM3.Text;
            SafetyAuditFormData.ActionTakenWM = txtWM4.Text;

            SafetyAuditFormData.InterventionsPM = txtPM1.Text;
            SafetyAuditFormData.CommentPM = txtPM2.Text;
            SafetyAuditFormData.CompletedPM = txtPM3.Text;
            SafetyAuditFormData.ActionTakenPM = txtPM4.Text;

            SafetyAuditFormData.InterventionsCOH = txtCOH1.Text;
            SafetyAuditFormData.CommentCOH = txtCOH2.Text;
            SafetyAuditFormData.CompletedCOH = txtCOH3.Text;
            SafetyAuditFormData.ActionTakenCOH = txtCOH4.Text;

            SafetyAuditFormData.InterventionsPPE = txtPPE1.Text;
            SafetyAuditFormData.CommentPPE = txtPPE2.Text;
            SafetyAuditFormData.CompletedPPE = txtPPE3.Text;
            SafetyAuditFormData.ActionTakenPPE = txtPPE4.Text;

            SafetyAuditFormData.InterventionsMH = txtMH1.Text;
            SafetyAuditFormData.CommentMH = txtMH2.Text;
            SafetyAuditFormData.CompletedMH = txtMH3.Text;
            SafetyAuditFormData.ActionTakenMH = txtMH4.Text;

            SafetyAuditFormData.InterventionsOC = txtOC1.Text;
            SafetyAuditFormData.CommentOC = txtOC2.Text;
            SafetyAuditFormData.CompletedOC = txtOC3.Text;
            SafetyAuditFormData.ActionTakenOC = txtOC4.Text;

            SafetyAuditFormData.InterventionsPT = txtPT1.Text;
            SafetyAuditFormData.CommentPT = txtPT2.Text;
            SafetyAuditFormData.CompletedPT = txtPT3.Text;
            SafetyAuditFormData.ActionTakenPT = txtPT4.Text;

            SafetyAuditFormData.InterventionsVDC = txtVDC1.Text;
            SafetyAuditFormData.CommentVDC = txtVDC2.Text;
            SafetyAuditFormData.CompletedVDC = txtVDC3.Text;
            SafetyAuditFormData.ActionTakenVDC = txtVDC4.Text;

            SafetyAuditFormData.InterventionsTUF = txtTUF1.Text;
            SafetyAuditFormData.CommentTUF = txtTUF2.Text;
            SafetyAuditFormData.CompletedTUF = txtTUF3.Text;
            SafetyAuditFormData.ActionTakenTUF = txtTUF4.Text;
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Safety_Audit_Form_2_Load(object sender, EventArgs e)
        {

        }
    }
}
