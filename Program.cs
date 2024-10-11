using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using WMPLib;

namespace Booked
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

            using (Splashscreen splash = new Splashscreen())
            {
                splash.Show();
                Application.DoEvents();
                System.Threading.Thread.Sleep(3000);
                splash.Close();
            }
            Application.Run(new Form1());
        }
    }
}
