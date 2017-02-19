using System.ComponentModel;
using System.Windows.Forms;
using CarRental.View.Infra.Validation.Shell;

namespace CarRental.View.Infra.Validation
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

        public static ValidationUnit PreValid(this Control control, ErrorProvider errorProvider, CancelEventArgs e)
        {
            return new ValidationUnit(control, errorProvider, e);
        }

        public static ValidationUnit Required(this ValidationUnit unit)
        {
            var res = unit.Control.Text.Required();
            if (res.Valid) return unit;
            unit.SetError(res.Message);

            return unit;
        }

        public static ValidationUnit Numbers(this ValidationUnit unit)
        {
            var res = unit.Control.Text.Numbers();
            if (res.Valid) return unit;
            unit.SetError(res.Message);

            return unit;
        }

    }
}
