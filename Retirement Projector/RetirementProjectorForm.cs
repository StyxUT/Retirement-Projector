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
            //ToDo: create class for "typical" retirement accounts
            //ToDo: create class for reverse mortgate
            //ToDo: create class for "typical" investment account

            AccountBase account = new RothIRA(25000, 75000, 59.5, 0.08, "Vanguard Roth IRA", 458.33);
            MessageBox.Show(String.Format("Account Name:  {0}\nAccount Value:  {1}", account.AccountName.ToString(), account.AccountValue.ToString()));

            AccountBase account2 = new InvestmentAccount(20000, 0, 0.14, "Lending Club", 160);
            MessageBox.Show(String.Format("Account Name:  {0}\nAccount Value:  {1}", account.AccountName.ToString(), account.AccountValue.ToString()));
        }

        private void ProjectRetirement_Click(object sender, EventArgs e)
        {
            Program.ProjectRetirement();
        }

    }
}
