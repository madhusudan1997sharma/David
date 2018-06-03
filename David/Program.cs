using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Jerry
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
            Form1 frm3 = new Form1();
            frm3.Show();
            Application.Run();
        }
    }
}
