using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation_clock
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Application.EnableVisualStyles(); // Prevents progress bar color changeing 
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HostForm());
        }
    }
}
