using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Data;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.Services.Infra;
using CarRental.View.Infra.Validation;

namespace CarRental.View.Forms
{
    public partial class RegistrationForm : Form
    {
        public IUserService UserService { get; }
        private bool _validationEnabled;

        public RegistrationForm(IUserService userService)
        {
            InitializeComponent();
            UserService = userService;
        }

        private User RetrieveFormData()
        {
            return new User
            {
                UserName = LoginTb.Text,
                FirstName = FirstNameTb.Text,
                LastName = LastNameTb.Text,
                Password = PasswordTb.Text
            };
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            var regiModel = RetrieveFormData();
            regiModel.Role.Add(new Role { Name = UserRole.Customer });
            var res = await UserService.Register(regiModel);
            if (res.Succeeded)
            {
                Close();
            }
            else
            {
                MessageBox.Show(res.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
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

        private void LoginTb_Validating(object sender, CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            ((TextBox)sender).PreValid(errorProvider1, e).Required();
        }
        private void FirstNameTb_Validating(object sender, CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            ((TextBox)sender).PreValid(errorProvider1, e).Required();
        }
        private void LastNameTb_Validating(object sender, CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            ((TextBox)sender).PreValid(errorProvider1, e).Required();
        }
        private void PasswordTb_Validating(object sender, CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            ((TextBox)sender).PreValid(errorProvider1, e).Required();
        }
    }
}
