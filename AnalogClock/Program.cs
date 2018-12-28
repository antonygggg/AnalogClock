using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Checking if an instance of hte program already is running
            System.Threading.Mutex m = new System.Threading.Mutex(false, "Global\\AnalogClock");
            if (!m.WaitOne(0, false))
            {
                MessageBox.Show("Already running");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
