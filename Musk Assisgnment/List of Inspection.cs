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
    public partial class List_of_Inspection : Form
    {
        public List_of_Inspection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //returns the object of the Connection class
            Connection SafetyAuditFormconn = Connection.getInstanceOfConnection();
            DataSet datasetSafetyAuditForm = SafetyAuditFormconn.getDataSet("SELECT * FROM SafetyAuditForm");
            dgvSAF.DataSource = datasetSafetyAuditForm.Tables[0];

        }
    }
}
