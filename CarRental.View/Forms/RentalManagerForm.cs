using System.Windows.Forms;
using CarRental.Services;
using CarRental.Services.Entities;

namespace CarRental.View.Forms
{
    public partial class RentalManagerForm : Form
    {
        public RentalManagerForm(User user, RentalService rentalService, CarService carService, UserService userService)
        {
            InitializeComponent();
        }
    }
}
