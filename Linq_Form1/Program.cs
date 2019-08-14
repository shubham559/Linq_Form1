using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Linq_Form1
{
    static class Program
    {
        public static AboutForm aboutForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            aboutForm = new AboutForm();

            Application.Run(new Form1());
        }
    }
}
