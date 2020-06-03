using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Port_Scanner
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
            Application.Run(new portScanner());
        }
    }
}
