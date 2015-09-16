using System.Windows.Forms;

namespace PDCPVS
{
    public partial class ErrorForm : Form
    {
        private ErrorForm()
        {
            InitializeComponent();
        }

        private void changeTextError(string errorText)
        {
            textBoxError.Text = errorText;
        }

        public static void ShowError(string ErrorMessage)
        {
            var error = new ErrorForm();
            error.changeTextError(ErrorMessage);
            error.ShowDialog();
        }
    }
}
