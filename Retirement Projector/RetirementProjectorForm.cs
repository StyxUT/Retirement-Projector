using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetirementProjector
{
    public partial class RetirementProjectorForm : Form
    {

        RetirementSettings rs;

        public RetirementProjectorForm(RetirementSettings retirementSettings)
        {
            InitializeComponent();
            rs = retirementSettings;
            RetirementProperties.SelectedObject = rs;

            rs.CurentProjectionDate = DateTime.Today;
        }

        private void assumptionsButton_Click(object sender, EventArgs e)
        {
            RetirementProperties.Visible = !RetirementProperties.Visible;
        }

        private void ProjectRetirement_Click(object sender, EventArgs e)
        {
            RetirementProjectorProcessor rpp = new RetirementProjectorProcessor(rs);
            rpp.ProjectRetirement();
        }
    }
}
