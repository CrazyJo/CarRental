using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.View.Infra;

namespace CarRental.View
{
    public static class Bootstrap
    {
        public static void Run()
        {
            //var lgf = new LoginForm();
            //lgf.ShowDialog();

            //if (!lgf.AuthResult.LogIn) return;
            //var form = new FormFactory().Create(lgf.AuthResult);
            var form = new FormFactory().Create(null);
            Application.Run(form);
        }
    }
}
