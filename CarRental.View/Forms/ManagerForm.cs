using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.View.Infra;
using CarRental.View.Infra.Validation;
using CarRental.View.Model;

namespace CarRental.View.Forms
{
    public partial class ManagerForm : Form
    {
        public ICarService CarService { get; set; }
        private GridValueProvider<CarInfo, CarInfoViewModel> CarsProvider { get; }
        private GridValueProvider<OrderDto, OrderViewModel> OrdersProvider { get; }
        private GridValueProvider<User, UserViewModel> UsersProvider { get; }
        private bool _validationEnabled;

        public ManagerForm(ICarService carService, IOrderService orderService, IUserService userService)
        {
            InitializeComponent();
            CarService = carService;
            CarsProvider = new CarsInfoProvider(carService.GetAllCars, DataGridView);
            OrdersProvider = new OrdersProvider(orderService, OrdersGrid);
            UsersProvider = new UsersProvider(userService, UsersGrid);
        }

        private async Task UpdateCarGridBySearchPattern()
        {
            int id;
            if (!int.TryParse(SearchTb.Text, out id)) return;
            var operationResult = await CarService.GetById(id);
            if (!operationResult.Successful || operationResult.Result == null) return;
            var carsVm = Mapper.Map<CarInfoViewModel>(operationResult.Result);
            DataGridView.DataSource = new List<CarInfoViewModel> { carsVm };
        }
        private async Task UpdateCarGrid()
        {
            await CarsProvider.SetData();
        }
        private async Task UpdateOrderGrid()
        {
            await OrdersProvider.SetData();
        }
        private async Task UpdateUserGrid()
        {
            await UsersProvider.SetData();
        }

        private CarInfo GetFromInput()
        {
            var carInfo = new CarInfo { Car = new CarDto() };
            carInfo.Car.Name = ModelTb.Text;
            carInfo.Car.Color = ColorTb.Text;
            carInfo.Balance = int.Parse(BalanceTb.Text);
            carInfo.TotalCars = int.Parse(TotalCarsTb.Text);
            carInfo.PricePerHour = double.Parse(PricePerHourTb.Text);

            return carInfo;
        }
        private bool ValidateForm()
        {
            _validationEnabled = true;
            errorProvider1.Clear();
            var res = ValidateChildren();
            _validationEnabled = false;
            return res;
        }
        private bool ShouldValidate()
        {
            return !_validationEnabled;
        }
        private bool ShouldEditRow(int columnIndex, int rowIndex)
        {
            var isId = DataGridView.Columns[columnIndex].Name.ToLower().Contains("id");
            var isCarInOrder = DataGridView.Columns[columnIndex].Name.ToLower().Contains("isinorder");
            var res = !(isId || isCarInOrder);
            return res;
        }
        private CarInfo GetSelectedRow(int rowIndex)
        {
            var res = new CarInfo { Car = new CarDto() };
            var cells = DataGridView.Rows[rowIndex].Cells;
            res.Car.Id = (int)cells["Id"].Value;
            res.Car.Name = (string)cells["Model"].Value;
            res.Car.Color = (string)cells["Color"].Value;
            res.Balance = (int)cells["Balance"].Value;
            res.TotalCars = (int)cells["TotalCars"].Value;
            res.PricePerHour = (double)cells["PricePerHour"].Value;
            return res;
        }

        private void ModelTb_Validating(object sender, CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            ((TextBox)sender).PreValid(errorProvider1, e).Required();
        }
        private void ColorTb_Validating(object sender, CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            ((TextBox)sender).PreValid(errorProvider1, e).Required();
        }
        private void BalanceTb_Validating(object sender, CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            ((TextBox)sender).PreValid(errorProvider1, e)
                .Numbers()
                .Required();
        }
        private void TotalCarsTb_Validating(object sender, CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            ((TextBox)sender).PreValid(errorProvider1, e)
                .Numbers()
                .Required();
        }
        private void PricePerHourTb_Validating(object sender, CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            ((TextBox)sender).PreValid(errorProvider1, e)
                .Numbers()
                .Required();
        }

        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var t = !ShouldEditRow(e.ColumnIndex, e.RowIndex);
            e.Cancel = t;
        }
        private async void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var car = GetSelectedRow(e.RowIndex);
            await CarService.UpdateCar(car);
            await UpdateCarGrid();
        }
        private async void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count != 1) return;
            var carId = (int)DataGridView.SelectedRows[0].Cells["id"].Value;
            await CarService.RemoveCar(carId);
            await UpdateCarGrid();
        }
        private async void AddBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            await CarService.AddCar(GetFromInput());
            await UpdateCarGrid();
        }
        private async void ManagerForm_Load(object sender, EventArgs e)
        {
            await UpdateOrderGrid();
        }

        private async void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage.Name)
            {
                case "UsersPage":
                    await UpdateUserGrid();
                    break;
                case "CarsPage":
                    await UpdateCarGrid();
                    break;
                case "OrdersPage":
                    await UpdateOrderGrid();
                    break;
            }
        }

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTb.Text))
            {
                await UpdateCarGrid();
            }
            else
            {
                await UpdateCarGridBySearchPattern();
            }
        }
    }
}
