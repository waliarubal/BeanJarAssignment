using System;
using System.Windows.Forms;

namespace BeanieApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// This application was developed to as a C# interview coding test.
        /// Rob Warner - FreedomVoice 2012
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BeanieForm());
        }
    }
}
