using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetirementProjector
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RetirementSettings settings = new RetirementSettings();
            RetirementProjectorForm form  = new RetirementProjectorForm(settings);
            Application.Run(form);
        }

    }
}
