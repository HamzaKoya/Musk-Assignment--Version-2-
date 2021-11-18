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
        public Safety_Audit_Form_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Safety_Audit_Form_3 newSafetyAuditForm3 = new Safety_Audit_Form_3();
            this.Hide();
            newSafetyAuditForm3.ShowDialog();
            this.Show();
        }
    }
}
