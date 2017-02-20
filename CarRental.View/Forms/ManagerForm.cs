using System;
using System.ComponentModel;
using System.Windows.Forms;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.View.Infra;
using CarRental.View.Infra.Validation;
using CarRental.View.Model;

namespace CarRental.View.Forms
{
    public partial class ManagerForm : Form
    {
        public User Manager { get; set; }
        public ICarService CarService { get; set; }
        private GridValueProvider<CarInfo, CarInfoViewModel> CarsProvider { get; }
        private bool _validationEnabled;

        public ManagerForm(User manager, ICarService carService)
        {
            InitializeComponent();
            Manager = manager;
            CarService = carService;
            CarsProvider = new CarsInfoProvider(carService.GetAllCars, DataGridView)
            {
                ExcludeColumns = { "Id" }
            };
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            CarsProvider.SetData();
        }
        private CarInfo GetFromInput()
        {
            var carInfo = new CarInfo { Car = new CarDTO() };
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
        private CarInfo GetSelectedRow(int rowIndex)
        {
            var res = new CarInfo { Car = new CarDTO() };
            var cells = DataGridView.Rows[rowIndex].Cells;
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
            ((TextBox) sender).PreValid(errorProvider1, e)
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

        private async void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var car = GetSelectedRow(e.RowIndex);
            await CarService.UpdateCar(car);
            UpdateGrid();
        }
        private async void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count != 1) return;
            var carId = (int)DataGridView.SelectedRows[0].Cells["id"].Value;
            await CarService.RemoveCar(carId);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            CarService.AddCar(GetFromInput());
            UpdateGrid();
        }
    }
}
