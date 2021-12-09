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
          InterventionsHW = txtHW1.Text;
          CommentHW = txtHW4.Text;
          CompletedHW = txtHW4.Text;
          ActionTakenHW = txtHW4.Text;

          InterventionsIso = txtIso1.Text;
          CommentIso = txtIso2.Text;
          CompletedIso = txtIso3.Text;
          ActionTakenIso = txtIso4.Text;
          
          InterventionsFER = txtFER1.Text;
          CommentFER = txtFER2.Text;
          CompletedFER = txtFER3.Text;
          ActionTakenFER = txtFER4.Text;

          InterventionsAwa = txtAwa1.Text;
          CommentAwa = txtAwa2.Text;
          CompletedAwa = txtAwa2.Text;
          ActionTakenAwa = txtAwa3.Text;

          //Text box input from D.Enviornment
          InterventionsWM = txtWM1.Text;
          CommentWM = txtWM2.Text;
          CompletedWM = txtWM3.Text;
          ActionTakenWM = txtWM4.Text;

          InterventionsPM = txtPM1.Text;
          CommentPM = txtPM2.Text;
          CompletedPM = txtPM3.Text;
          ActionTakenPM = txtPM4.Text;
          
          InterventionsCOH = txtCOH1.Text;
          CommentCOH = txtCOH2.Text;
          CompletedCOH = txtCOH3.Text;
          ActionTakenCOH = txtCOH4.Text;
          
          InterventionsPPE = txtPPE1.Text;
          CommentPPE = txtPPE2.Text;
          CompletedPPE = txtPPE3.Text;
          ActionTakenPPE = txtPPE4.Text;
            
          InterventionsMH = txtMH1.Text;
          CommentMH = txtMH2.Text;
          CompletedMH = txtMH3.Text;
          ActionTakenMH = txtMH4.Text;

          InterventionsOC = txtOC1.Text;
          CommentOC = txtOC2.Text;
          CompletedOC = txtOC3.Text;
          ActionTakenOC = txtOC4.Text;
            
          InterventionsPT = txtPT1.Text;
          CommentPT = txtPT2.Text;
          CompletedPT = txtPT3.Text;
          ActionTakenPT = txtPT4.Text;
            
          InterventionsVDC = txtVDC1.Text;
          CommentVDC = txtVDC2.Text;
          CompletedVDC = txtVDC3.Text;
          ActionTakenVDC = txtVDC4.Text;
            
          InterventionsTUF = txtTUF1.Text;
          CommentTUF = txtTUF2.Text;
          CompletedTUF = txtTUF3.Text;
          ActionTakenTUF = txtTUF4.Text;
            
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
