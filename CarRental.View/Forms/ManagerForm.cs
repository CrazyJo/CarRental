using System.Windows.Forms;
using CarRental.Services;
using CarRental.Services.Entities;

namespace CarRental.View.Forms
{
    public partial class ManagerForm : Form
    {
        public ManagerForm(User user, RentalService rentalService, CarService carService, UserService userService)
        {
            InitializeComponent();
        }
    }
}
