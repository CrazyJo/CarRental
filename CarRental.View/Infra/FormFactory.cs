using System.Linq;
using System.Windows.Forms;
using CarRental.Data;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.Services.Infra;
using CarRental.View.Forms;

namespace CarRental.View.Infra
{
    public class FormFactory
    {
        public Form Create(AuthResult authResult)
        {
            if (authResult.User.Role.Any(r => r.Name.Equals(UserRole.Manager)))
                return new ManagerForm(authResult.User, new CarService());
            return new CustomerForm(authResult.User, new CarService(), new OrderService());
        }
    }
}
