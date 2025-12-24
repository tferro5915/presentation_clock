using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace presentation_clock
{

    public static class Program
    {
        [DllImport("uxtheme.dll")]
        private static extern int SetWindowTheme(IntPtr hWnd, string appname, string idlist);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // Application.EnableVisualStyles();  // Prevents progress bar color changeing 
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HostForm());
        }


        /// <summary>
        /// The secondary entry point for the application when called from PowerPoint.
        /// </summary>
        [STAThread]
        public static void Main_from_ppt()
        {
            HostForm host = new HostForm();
            //SetWindowTheme(host.Handle, "", "");
            host.Show();
        }
    }

}
