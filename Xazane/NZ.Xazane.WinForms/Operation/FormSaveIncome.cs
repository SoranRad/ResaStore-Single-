using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control.MainForms;
using NZ.Xazane.WinForms.Component;
using ShareLib;

namespace NZ.Xazane.WinForms.Operation
{
    public partial class FormSaveIncome : Form_Mother_IRANSans
    {
        public FormSaveIncome()
        {
            InitializeComponent();
            nzAccounts3.Refresh_Grid(Enums.NzAccountKind.BankAccount,null);
            //test.Size
        }
    }
}
