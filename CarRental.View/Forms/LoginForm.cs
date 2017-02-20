using System;
using System.Windows.Forms;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.Services.Infra;
using CarRental.View.Infra.Validation;
using CarRental.View.Model;

namespace CarRental.View.Forms
{
    public partial class LoginForm : Form
    {
        public AuthResult AuthResult { get; set; }
        public IUserService UserService { get; set; }
        private bool _validationEnabled;

        public LoginForm(IUserService userService)
        {
            UserService = userService;
            AuthResult = new AuthResult { SignInStatus = SignInStatus.Failure };
            InitializeComponent();
        }

        private LoginViewModel GetLoginFormData()
        {
            return new LoginViewModel
            {
                UserName = tbLogin.Text,
                Password = tbPassword.Text
            };
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            var loginModel = GetLoginFormData();
            AuthResult = await UserService.Login(loginModel.UserName, loginModel.Password);
            if (AuthResult.LogIn)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Wrong login or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void tbLogin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            ((TextBox)sender).PreValid(errorProvider1, e).Required();
        }
        private void tbPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ShouldValidate()) return;
            ((TextBox)sender).PreValid(errorProvider1, e).Required();
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new RegistrationForm(UserService).ShowDialog();
            Show();
        }
    }
}
