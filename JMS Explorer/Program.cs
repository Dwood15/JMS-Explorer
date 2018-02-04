using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JMS_Explorer;

namespace WindowsFormsApplication1
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
            Application.Run(new JMS_Explorer.Selector());
        }
    }
}
