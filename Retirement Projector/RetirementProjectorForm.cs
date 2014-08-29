using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retirement_Projector
{
    public partial class RetirementProjector : Form
    {
        public RetirementProjector()
        {
            InitializeComponent();
            
        }

        private void assumptionsButton_Click(object sender, EventArgs e)
        {
            RetirementSettings rs = new RetirementSettings();
            RetirementProperties.SelectedObject = rs;
            RetirementProperties.Visible = true;

            //ToDo: relocate
            Account account = new RothIRA(25000, 75000, 59.5, 0.08, "Vanguard Roth IRA", 458.33);
            MessageBox.Show(String.Format("Account Name:  {0}\nAccount Value:  {1}", account.AccountName.ToString(), account.AccountValue.ToString()));
        }

    }
}
