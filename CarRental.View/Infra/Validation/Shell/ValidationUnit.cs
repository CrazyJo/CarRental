using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental.View.Infra.Validation.Shell
{
    public class ValidationUnit
    {
        public Control Control { get; set; }
        public ErrorProvider ErrorProvider { get; set; }
        public CancelEventArgs CancelEventArgs { get; set; }

        public ValidationUnit(Control control, ErrorProvider errorProvider, CancelEventArgs cancelEventArgs)
        {
            Control = control;
            ErrorProvider = errorProvider;
            CancelEventArgs = cancelEventArgs;
        }

        public void SetError(string value)
        {
            CancelEventArgs.Cancel = true;
            ErrorProvider.SetError(Control, value);
        }
    }
}
