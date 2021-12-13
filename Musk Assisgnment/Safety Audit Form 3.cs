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
        //Text box input from G.Miscellaneous

       /* public string InterventionsCV;
        public string CommentCV;
        public string CompletedCV;
        public string ActionTakenCV;

        public string InterventionsFP;
        public string CommentFP;
        public string CompletedFP;
        public string ActionTakenFP;

        public string InterventionsWC;
        public string CommentWC;
        public string CompletedWC;
        public string ActionTakenWC;

        //Text box input from Total Interventions

        public string InterventionsWS;
        public string InterventionsQua;
        public string InterventionsSR;
        public string InterventionsEnv;
        public string InterventionsPOI;
        public string InterventionsTCO;
        public string InterventionsMis;
*/
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

            System.IO.FileStream fs = new FileStream(@"TempforTest4", FileMode.Create, FileAccess.Write, FileShare.None);
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
            table.AddCell("\bAction\nTaken<b>");

            table.AddCell("\bA. Working Standards <b>");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");

            table.AddCell("\b1. Work At Height");
            table.AddCell(SafetyAuditFormData.InterventionsWAH);
            table.AddCell(sf.CommentWAH);
            table.AddCell(sf.CompletedWAH);
            table.AddCell(sf.ActionTakenWAH);

            table.AddCell("\b2. Lifting Operations - Cranes, Fork Lift Truck, Hoists etc");
            table.AddCell(sf.InterventionsLO);
            table.AddCell(sf.CommentLO);
            table.AddCell(sf.CompletedLO);
            table.AddCell(sf.ActionTakenLO);

            table.AddCell("\b3. Certification-Daily Checksheets for MEWP and FLT");
            table.AddCell(sf.InterventionsCer);
            table.AddCell(sf.CommentCer);
            table.AddCell(sf.CompletedCer);
            table.AddCell(sf.ActionTakenCer);

            table.AddCell("\b4. Confined Space Work");
            table.AddCell(sf.InterventionsCSW);
            table.AddCell(sf.CommentCSW);
            table.AddCell(sf.CompletedCSW);
            table.AddCell(sf.ActionTakenCSW);

            table.AddCell("\b5. Electrical Work");
            table.AddCell(sf.InterventionsEW);
            table.AddCell(sf.CommentEW);
            table.AddCell(sf.CompletedEW);
            table.AddCell(sf.ActionTakenEW);

            table.AddCell("\b B. Quality ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");

            table.AddCell("\b 6. Site Set Up and Apperance, Signage");
            table.AddCell(sf.InterventionsSSA);
            table.AddCell(sf.CommentSSA);
            table.AddCell(sf.CompletedSSA);
            table.AddCell(sf.ActionTakenSSA);

            table.AddCell("\b 7. Paperwork ( Permits, Risk Assesments, Method Statements ");
            table.AddCell(sf.InterventionPap);
            table.AddCell(sf.CommentPap);
            table.AddCell(sf.CompletedPap);
            table.AddCell(sf.ActionTakentxtPap);

            table.AddCell("\b8. Certification- Training, Insurance Inspection, Induction Current ");
            table.AddCell(sf.InterventionQCer);
            table.AddCell(sf.CommentQCer);
            table.AddCell(sf.CompletedQCer);
            table.AddCell(sf.ActionTakenQCer);

            table.AddCell("\b<b> C. Site Rules<b> ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");

            table.AddCell("\b9. Hot Work ");
            table.AddCell(sf2.InterventionsHW);
            table.AddCell(sf2.CommentHW);
            table.AddCell(sf2.CompletedHW);
            table.AddCell(sf2.ActionTakenHW);

            table.AddCell("\b10. Isolation ");
            table.AddCell(sf2.InterventionsIso);
            table.AddCell(sf2.CommentIso);
            table.AddCell(sf2.CompletedIso);
            table.AddCell(sf2.ActionTakenIso);

            table.AddCell("\b11. Fire Exits and Escape Routes ");
            table.AddCell(sf2.InterventionsFER);
            table.AddCell(sf2.CommentFER);
            table.AddCell(sf2.CompletedFER);
            table.AddCell(sf2.ActionTakenFER);

            table.AddCell("\b12. Awareness- Fire Exit, Assembly Point ");
            table.AddCell(sf2.ActionTakenAwa);
            table.AddCell(sf2.CommentAwa);
            table.AddCell(sf2.CompletedAwa);
            table.AddCell(sf2.ActionTakenAwa);

            table.AddCell("\bD. Enviornmental<b> ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");

            table.AddCell("\b13.Waste Management ");
            table.AddCell(sf2.InterventionsWM);
            table.AddCell(sf2.CommentWM);
            table.AddCell(sf2.CompletedWM);
            table.AddCell(sf2.ActionTakenWM);

            table.AddCell("\b14. Product Contamination ");
            table.AddCell(sf2.InterventionsPM);
            table.AddCell(sf2.CommentPM);
            table.AddCell(sf2.CompletedPM);
            table.AddCell(sf2.ActionTakenPM);

            table.AddCell("\b15. COSHH & Asbestos ");
            table.AddCell(sf2.InterventionsCOH);
            table.AddCell(sf2.CommentCOH);
            table.AddCell(sf2.CompletedCOH);
            table.AddCell(sf2.ActionTakenCOH);

            table.AddCell("\bE. Protection Of Individuals<b> ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");

            table.AddCell("\b16. PPE ");
            table.AddCell(sf2.InterventionsPPE);
            table.AddCell(sf2.CommentPPE);
            table.AddCell(sf2.CompletedPPE);
            table.AddCell(sf2.ActionTakenPPE);

            table.AddCell("\b17. Manual Handling ");
            table.AddCell(sf2.InterventionsMH);
            table.AddCell(sf2.CommentMH);
            table.AddCell(sf2.CompletedMH);
            table.AddCell(sf2.ActionTakenMH);

            table.AddCell("\b18. Other Contractors ");
            table.AddCell(sf2.InterventionsOC);
            table.AddCell(sf2.CommentMH);
            table.AddCell(sf2.CompletedMH);
            table.AddCell(sf2.ActionTakenMH);

            table.AddCell("\bF. Tools, Cables and Other Equipment ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");
            table.AddCell(" ");

            table.AddCell("\b19. Power Tools, Cables and Other Equipment ");
            table.AddCell(sf2.InterventionsPT);
            table.AddCell(sf2.CommentPT);
            table.AddCell(sf2.CompletedPT);
            table.AddCell(sf2.ActionTakenPT);

            table.AddCell("\b20. Voltage Detector Checked ");
            table.AddCell(sf2.InterventionsVDC);
            table.AddCell(sf2.CommentVDC);
            table.AddCell(sf2.CompletedVDC);
            table.AddCell(sf2.ActionTakenVDC);

            table.AddCell("\b21. Tools Used Fit For Purpose ");
            table.AddCell(sf2.InterventionsTUF);
            table.AddCell(sf2.CommentTUF);
            table.AddCell(sf2.CompletedTUF);
            table.AddCell(sf2.ActionTakenTUF);

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

            tableInt.AddCell("\b Total Interventions By Section <b>");
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

            System.Diagnostics.Process.Start(@"TempforTest4");
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
