using System;
using System.Windows.Forms;
using CarRental.Services;
using CarRental.Services.Config;
using CarRental.View.Mappings;

namespace CarRental.View
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
            ServiceLayerConfig.Configure();
            AutoMapperConfiguration.Configure();
            Bootstrap.Run();
        }
    }
}
