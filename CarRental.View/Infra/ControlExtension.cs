using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace CarRental.View.Infra
{
    public static class ControlExtension
    {
        public static void GridValidation(this DataGridView grid, Control errorLabel, CancelEventArgs e)
        {
            if (grid.SelectedRows.Count == 0)
            {
                e.Cancel = true;
                errorLabel.Visible = true;
                errorLabel.Text = "Select the row";
                return;
            }
            if (grid.SelectedRows.Count > 1)
            {
                e.Cancel = true;
                errorLabel.Visible = true;
                errorLabel.Text = "Selected more than one row";
                return;
            }
            errorLabel.Visible = false;
            errorLabel.Text = "";
        }

        public static void TextBoxValidation(this Control textBox, Control errorLabel, CancelEventArgs e)
        {
            if (textBox == null) return;
            var res = textBox.Text.InputValidation();
            e.Cancel = !res.Valid;
            if (errorLabel == null) return;
            errorLabel.Visible = !res.Valid;
            errorLabel.Text = res.Message;
        }
    }
}
