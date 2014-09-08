﻿using System;
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
            RetirementProperties.Visible = !RetirementProperties.Visible;
        }

        private void ProjectRetirement_Click(object sender, EventArgs e)
        {
            Program.ProjectRetirement();
        }

        RetirementSettings settings;
        private void RetirementProjector_Load(object sender, EventArgs e)
        {
            settings = new RetirementSettings();
            RetirementProperties.SelectedObject = settings;
        }
    }
}
