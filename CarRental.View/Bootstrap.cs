using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var lgf = new LoginForm(new UserService());
            lgf.ShowDialog();

            if (!lgf.AuthResult.LogIn) return;
            var form = new FormFactory().Create(lgf.AuthResult);
            Application.Run(form);
        }
    }
}
