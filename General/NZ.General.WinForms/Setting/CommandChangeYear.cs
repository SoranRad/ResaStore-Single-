using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NZ.General.WinForms.Misc;
using ShareLib.Interfaces;

namespace NZ.General.WinForms.Setting
{
    public class CommandChangeYear : ICommand
    {
        private Form    _MainForm;
        public          CommandChangeYear   (Form MainForm)
        {
            _MainForm = MainForm;
        }
        public void     Execute             ()
        {
            new FormChangeYear().ShowDialog(_MainForm);
        }
    }
}
