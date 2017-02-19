using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.View.Infra;
using CarRental.View.Model;

namespace CarRental.View.Forms
{
    public partial class CustomerForm : Form
    {
        public User User { get; set; }
        public CarService CarService { get; set; }
        public RentalService RentalService { get; set; }
        private bool _validationEnabled;

        private GridValueProvider<CarInfo, CarInfoViewModel> CarsProvider { get; }
        private GridValueProvider<Order, OrderViewModel> OrdersProvider { get; }

        public CustomerForm(User user, CarService carService, RentalService rentalService)
        {
            InitializeComponent();
            HideNewOrderControls();

            User = user;
            CarService = carService;
            RentalService = rentalService;

            CarsProvider = new CarsInfoProvider(carService, dataGridView);
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
            if (!ValidateChildren()) return;
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
            _validationEnabled = true;
        }
        private void HideNewOrderControls()
        {
            NewOrderPanel.Visible = false;
            _validationEnabled = false;
        }

        private void HoursTextBox_Validating(object sender, CancelEventArgs e)
        {
            var input = (TextBox)sender;
            input.TextBoxValidation(HoursInputError, e);
        }
        private void dataGridView_Validating(object sender, CancelEventArgs e)
        {
            if (_validationEnabled)
                dataGridView.GridValidation(ComErrors, e);
        }
    }
}
