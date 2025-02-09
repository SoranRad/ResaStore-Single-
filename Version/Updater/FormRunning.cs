using System.Drawing;
using System.Media;
using System.Windows.Forms;
using MS_Control.MainForms;
using Updater.Service;

namespace Updater
{
    public partial class FormRunning : Form_Mother_IRANSans
    {
        private readonly string _fileLocation;

        public FormRunning(string FileLocation)
        {
            _fileLocation = FileLocation;
            InitializeComponent();
            this.Location = new Point
            (
                Screen.PrimaryScreen.WorkingArea.Right - this.Width,
                Screen.PrimaryScreen.WorkingArea.Bottom - this.Height
            );
        }

        private void Nz_Cancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Nz_OK_Click(object sender, System.EventArgs e)
        {
            if (ExtractService.IsRunnig(_fileLocation))
                SystemSounds.Beep.Play();
            else
                this.DialogResult = DialogResult.OK;
        }
    }
}
