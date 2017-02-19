using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Services.Entities;

namespace CarRental.View
{
    public partial class LoginForm : Form
    {
        public AuthResult AuthResult { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }
    }
}
