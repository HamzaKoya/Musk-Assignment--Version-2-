using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musk_Assisgnment
{
    public partial class Safety_Audit_Form_3 : Form
    {
 
        public Safety_Audit_Form_3()
        {
            InitializeComponent();
        }

        private void Safety_Audit_Form_3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Text box input from G.Miscellaneous

            string InterventionsCV = txtCV1.Text;
            string CommentCV = txtCV2.Text;
            string CompletedCV = txtCV3.Text;
            string ActionTakenCV = txtCV4.Text;

            string InterventionsFP = txtFP1.Text;
            string CommentFP = txtFP2.Text;
            string CompletedFP = txtFP3.Text;
            string ActionTakenFP = txtFP4.Text;

            string InterventionsWC = txtWC1.Text;
            string CommentWC = txtWC2.Text;
            string CompletedWC = txtWC3.Text;
            string ActionTakenWC = txtWC4.Text;

            //Text box input from Total Interventions

            string InterventionsWS = txtWS1.Text;
            string InterventionsQua = txtQ1.Text;
            string InterventionsSR = txtSR.Text;
            string InterventionsEnv = txtEnv1.Text;
            string InterventionsPOI = txtPro1.Text;
            string InterventionsTCO = txtTCO1.Text;
            string InterventionsMis = txtMis1.Text;

            

            
            PdfPTable table = new PdfPTable(5);

            //Creating a pdf file in specific path

            System.IO.FileStream fs = new FileStream(@"TempforTest9", FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            doc.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            //Open the PDF docuent
            doc.Open();
            // PdfWriter.GetInstance(doc, new FileStream(Server.MapPath("Sample-PDF-File.pdf"), FileMode.Create));


            Safety_Audit_Form sf = new Safety_Audit_Form();
            Safety_Audit_Form_2 sf2 = new Safety_Audit_Form_2();
            /*Safety_Audit_Form_3 sf3 = new Safety_Audit_Form_3();*/



            //Adding table
            table.AddCell(" ");
            table.AddCell("\b Interventions");
            table.AddCell("\bComment");
            table.AddCell("\bCompleted");
            table.AddCell("\bAction\nTaken\b");

            table.AddCell("\bA. Working Standards \b");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");

            table.AddCell("\b1. Work At Height\b");
            table.AddCell(SafetyAuditFormData.InterventionsWAH);
            table.AddCell(SafetyAuditFormData.CommentWAH);
            table.AddCell(SafetyAuditFormData.CompletedWAH);
            table.AddCell(SafetyAuditFormData.ActionTakenWAH);

            table.AddCell("\b2. Lifting Operations - Cranes, Fork Lift Truck, Hoists etc\b");
            table.AddCell(SafetyAuditFormData.InterventionsLO);
            table.AddCell(SafetyAuditFormData.CommentLO);
            table.AddCell(SafetyAuditFormData.CompletedLO);
            table.AddCell(SafetyAuditFormData.ActionTakenLO);

            table.AddCell("\b3. Certification-Daily Checksheets for MEWP and FLT");
            table.AddCell(SafetyAuditFormData.InterventionsCer);
            table.AddCell(SafetyAuditFormData.CommentCer);
            table.AddCell(SafetyAuditFormData.CompletedCer);
            table.AddCell(SafetyAuditFormData.ActionTakenCer);

            table.AddCell("\b4. Confined Space Work");
            table.AddCell(SafetyAuditFormData.InterventionsCSW);
            table.AddCell(SafetyAuditFormData.CommentCSW);
            table.AddCell(SafetyAuditFormData.CompletedCSW);
            table.AddCell(SafetyAuditFormData.ActionTakenCSW);

            table.AddCell("\b5. Electrical Work");
            table.AddCell(SafetyAuditFormData.InterventionsEW);
            table.AddCell(SafetyAuditFormData.CommentEW);
            table.AddCell(SafetyAuditFormData.CompletedEW);
            table.AddCell(SafetyAuditFormData.ActionTakenEW);

            table.AddCell("\b B. Quality ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");

            table.AddCell("\b 6. Site Set Up and Apperance, Signage");
            table.AddCell(SafetyAuditFormData.InterventionsSSA);
            table.AddCell(SafetyAuditFormData.CommentSSA);
            table.AddCell(SafetyAuditFormData.CompletedSSA);
            table.AddCell(SafetyAuditFormData.ActionTakenSSA);

            table.AddCell("\b 7. Paperwork ( Permits, Risk Assesments, Method Statements ");
            table.AddCell(SafetyAuditFormData.InterventionPap);
            table.AddCell(SafetyAuditFormData.CommentPap);
            table.AddCell(SafetyAuditFormData.CompletedPap);
            table.AddCell(SafetyAuditFormData.ActionTakentxtPap);

            table.AddCell("\b8. Certification- Training, Insurance Inspection, Induction Current ");
            table.AddCell(SafetyAuditFormData.InterventionQCer);
            table.AddCell(SafetyAuditFormData.CommentQCer);
            table.AddCell(SafetyAuditFormData.CompletedQCer);
            table.AddCell(SafetyAuditFormData.ActionTakenQCer);

            table.AddCell("\bC. Site Rules ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");

            table.AddCell("\b9. Hot Work ");
            table.AddCell(SafetyAuditFormData.InterventionsHW);
            table.AddCell(SafetyAuditFormData.CommentHW);
            table.AddCell(SafetyAuditFormData.CompletedHW);
            table.AddCell(SafetyAuditFormData.ActionTakenHW);

            table.AddCell("\b10. Isolation ");
            table.AddCell(SafetyAuditFormData.InterventionsIso);
            table.AddCell(SafetyAuditFormData.CommentIso);
            table.AddCell(SafetyAuditFormData.CompletedIso);
            table.AddCell(SafetyAuditFormData.ActionTakenIso);

            table.AddCell("\b11. Fire Exits and Escape Routes ");
            table.AddCell(SafetyAuditFormData.InterventionsFER);
            table.AddCell(SafetyAuditFormData.CommentFER);
            table.AddCell(SafetyAuditFormData.CompletedFER);
            table.AddCell(SafetyAuditFormData.ActionTakenFER);

            table.AddCell("\b12. Awareness- Fire Exit, Assembly Point ");
            table.AddCell(SafetyAuditFormData.InterventionAwa);
            table.AddCell(SafetyAuditFormData.CommentAwa);
            table.AddCell(SafetyAuditFormData.CompletedAwa);
            table.AddCell(SafetyAuditFormData.ActionTakenAwa);

            table.AddCell("\bD. Enviornmental ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");

            table.AddCell("\b13.Waste Management ");
            table.AddCell(SafetyAuditFormData.InterventionsWM);
            table.AddCell(SafetyAuditFormData.CommentWM);
            table.AddCell(SafetyAuditFormData.CompletedWM);
            table.AddCell(SafetyAuditFormData.ActionTakenWM);

            table.AddCell("\b14. Product Contamination ");
            table.AddCell(SafetyAuditFormData.InterventionsPM);
            table.AddCell(SafetyAuditFormData.CommentPM);
            table.AddCell(SafetyAuditFormData.CompletedPM);
            table.AddCell(SafetyAuditFormData.ActionTakenPM);

            table.AddCell("\b15. COSHH & Asbestos ");
            table.AddCell(SafetyAuditFormData.InterventionsCOH);
            table.AddCell(SafetyAuditFormData.CommentCOH);
            table.AddCell(SafetyAuditFormData.CompletedCOH);
            table.AddCell(SafetyAuditFormData.ActionTakenCOH);

            table.AddCell("\bE. Protection Of Individuals ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");

            table.AddCell("\b16. PPE ");
            table.AddCell(SafetyAuditFormData.InterventionsPPE);
            table.AddCell(SafetyAuditFormData.CommentPPE);
            table.AddCell(SafetyAuditFormData.CompletedPPE);
            table.AddCell(SafetyAuditFormData.ActionTakenPPE);

            table.AddCell("\b17. Manual Handling ");
            table.AddCell(SafetyAuditFormData.InterventionsMH);
            table.AddCell(SafetyAuditFormData.CommentMH);
            table.AddCell(SafetyAuditFormData.CompletedMH);
            table.AddCell(SafetyAuditFormData.ActionTakenMH);

            table.AddCell("\b18. Other Contractors ");
            table.AddCell(SafetyAuditFormData.InterventionsOC);
            table.AddCell(SafetyAuditFormData.CommentOC);
            table.AddCell(SafetyAuditFormData.CompletedOC);
            table.AddCell(SafetyAuditFormData.ActionTakenOC);

            table.AddCell("\bF. Tools, Cables and Other Equipment ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");

            table.AddCell("\b19. Power Tools, Cables and Other Equipment ");
            table.AddCell(SafetyAuditFormData.InterventionsPT);
            table.AddCell(SafetyAuditFormData.CommentPT);
            table.AddCell(SafetyAuditFormData.CompletedPT);
            table.AddCell(SafetyAuditFormData.ActionTakenPT);

            table.AddCell("\b20. Voltage Detector Checked ");
            table.AddCell(SafetyAuditFormData.InterventionsVDC);
            table.AddCell(SafetyAuditFormData.CommentVDC);
            table.AddCell(SafetyAuditFormData.CompletedVDC);
            table.AddCell(SafetyAuditFormData.ActionTakenVDC);

            table.AddCell("\b21. Tools Used Fit For Purpose ");
            table.AddCell(SafetyAuditFormData.InterventionsTUF);
            table.AddCell(SafetyAuditFormData.CommentTUF);
            table.AddCell(SafetyAuditFormData.CompletedTUF);
            table.AddCell(SafetyAuditFormData.ActionTakenTUF);

            table.AddCell("\bG. Miscellaneous ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");


            table.AddCell("\b22. Company Vechicles ");
            table.AddCell(InterventionsCV);
            table.AddCell(CommentCV);
            table.AddCell(CompletedCV);
            table.AddCell(ActionTakenCV);


            table.AddCell("\b23. Fire Precautions ");
            table.AddCell(InterventionsFP);
            table.AddCell(CommentFP);
            table.AddCell(CompletedFP);
            table.AddCell(ActionTakenCV);


            table.AddCell("\b24. Workshop Conditions ");
            table.AddCell(InterventionsWC);
            table.AddCell(CommentWC);
            table.AddCell(CompletedWC);
            table.AddCell(ActionTakenWC);
            //Total Interventions
            PdfPTable tableInt = new PdfPTable(2);

            tableInt.AddCell("\b Total Interventions By Section \b");
            tableInt.AddCell(" ");

            tableInt.AddCell("\bA. Working Standards ");
            tableInt.AddCell(InterventionsWS);

            tableInt.AddCell("\bB. Quality");
            tableInt.AddCell(InterventionsQua);

            tableInt.AddCell("\bC. Site Rules ");
            tableInt.AddCell(InterventionsSR);

            tableInt.AddCell("\bD. Enviornmental ");
            tableInt.AddCell(InterventionsEnv);

            tableInt.AddCell("\bE. Protection of Individuals ");
            tableInt.AddCell(InterventionsPOI);

            tableInt.AddCell("\bF. Tools, Cables & Other Equipment");
            tableInt.AddCell(InterventionsTCO);

            tableInt.AddCell("\bG. Miscellaneous ");
            tableInt.AddCell(InterventionsMis);

            tableInt.AddCell("\boverall");
            tableInt.AddCell(" ");


            //Add Content to PDF
            doc.Add(table);
            doc.Add(tableInt);
            //Close Document
            doc.Close();
            writer.Close();
            fs.Close();

            System.Diagnostics.Process.Start(@"TempforTest9");
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCV1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
