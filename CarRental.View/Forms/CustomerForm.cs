using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.View.Infra;
using CarRental.View.Infra.Validation;
using CarRental.View.Model;

namespace CarRental.View.Forms
{
    public partial class CustomerForm : Form
    {
        public User User { get; set; }
        public IRentalService RentalService { get; set; }
        private bool _validationEnabled;

        private GridValueProvider<CarInfo, CarInfoViewModel> CarsProvider { get; }
        private GridValueProvider<Order, OrderViewModel> OrdersProvider { get; }

        public CustomerForm(User user, ICarService carService, IRentalService rentalService)
        {
            InitializeComponent();
            HideNewOrderControls();

            User = user;
            RentalService = rentalService;

            CarsProvider = new CarsInfoProvider(carService.GetAllAvailableCars, dataGridView)
            {
                ExcludeColumns = { "Id", "Balance", "TotalCars" }
            };
            OrdersProvider = new OrdersProvider(user, RentalService, dataGridView);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            OrdersProvider.SetData();
            if (OrdersProvider.DomainModelEmpty)
            {
                CarsProvider.SetData();
            }
        }

        private void CreateNewOrderBtn_Click(object sender, EventArgs e)
        {
            SetCarsInfoData();
            ShowNewOrderControls();
            HideOrdersListControls();
        }

        private async void OrderBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            try
            {
                await PostNewOrder();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            SetOrdersInfoData();
            HideNewOrderControls();
            ShowOrdersListControls();
        }

        private bool ValidateForm()
        {
            _validationEnabled = true;
            errorProvider1.Clear();
            var res = ValidateChildren();
            _validationEnabled = false;
            return res;
        }

        private void SetCarsInfoData()
        {
            CarsProvider.SetData();
        }
        private void SetOrdersInfoData()
        {
            OrdersProvider.SetData();
        }

        private async Task PostNewOrder()
        {
            Order order = GetInputsData();
            order.Customer = User;
            order.RentalDate = DateTime.Now;
            await RentalService.CreateOrder(order);
        }
        private Order GetInputsData()
        {
            var selectedRow = dataGridView.SelectedRows[0];
            var res = new Order();
            var id = (int)selectedRow.Cells["id"].Value;
            res.Car = new CarDTO(id);
            int hours = int.Parse(HoursTextBox.Text);
            res.Lease = new TimeSpan(hours, 0, 0);

            return res;
        }

        private void ShowOrdersListControls()
        {
            OrdersListPanel.Visible = true;
        }
        private void HideOrdersListControls()
        {
            OrdersListPanel.Visible = false;
        }

        private void ShowNewOrderControls()
        {
            NewOrderPanel.Visible = true;
        }
        private void HideNewOrderControls()
        {
            NewOrderPanel.Visible = false;
        }

        private bool ShouldValidate()
        {
            return !_validationEnabled;
        }

        private void HoursTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            ((TextBox)sender).PreValid(errorProvider1, e).Numbers().Required();
        }
        private void dataGridView_Validating(object sender, CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            dataGridView.GridValidation(ComErrors, e);
        }
    }
}
