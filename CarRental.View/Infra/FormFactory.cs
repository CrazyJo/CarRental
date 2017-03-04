using System.Linq;
using System.Windows.Forms;
using CarRental.Data;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.View.Forms;

namespace CarRental.View.Infra
{
    public class FormFactory
    {
        public Form Create(AuthResult authResult)
        {
            var res = authResult.User.Role.Any(r => r.Name.Equals(UserRole.Manager));
            if (res)
                return new ManagerForm(new CarService(), new OrderService(), new UserService());
            return new CustomerForm(authResult.User, new CarService(), new OrderService());
        }
    }
}
