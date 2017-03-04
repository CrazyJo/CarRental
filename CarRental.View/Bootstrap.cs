using System;
using System.Windows.Forms;
using CarRental.Services;
using CarRental.View.Forms;
using CarRental.View.Infra;

namespace CarRental.View
{
    public static class Bootstrap
    {
        public static void Run()
        {
            try
            {
                var lgf = new LoginForm(new UserService());
                lgf.ShowDialog();

                if (!lgf.AuthResult.LogIn) return;
                var form = new FormFactory().Create(lgf.AuthResult);
                Application.Run(form);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
