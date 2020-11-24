using System;
using System.Windows.Forms;

namespace Recruitment
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
            GlobalConfig.InitializeConnection();

            Application.Run(new Views.DashboardForm());
            //Application.Run(new Views.CreateHeaderForm());
        }
    }
}
