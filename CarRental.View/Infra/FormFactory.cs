using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.View.Forms;

namespace CarRental.View.Infra
{
    public class FormFactory
    {
        public Form Create(AuthResult authResult)
        {
            return new ManagerForm(new User { Id = 1 }, new CarService());
            //return new CustomerForm(new User { Id = 1 }, new CarService(), new RentalService());
        }
    }
}
