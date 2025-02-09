using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Base
{
    public partial class FormListChequeBook : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
                                log4net
                                    .LogManager
                                    .GetLogger
                                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        //private short               _Select = 0;
        //private FormNewChequeBook   _FormNewChequeBook;
        private Manager             _Manager;
        #endregion
        #region Constractor
        public FormListChequeBook()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager= new Manager();
        }

        #endregion
        #region Methods
        private void RefreshGrid                ()
        {
            try
            {

                mS_GridX1.DataSource = _Manager
                                        .GetList<ChequeBook>(
                                             new
                                             {
                                                 Year = SystemConstant.ActiveYear.Salmali
                                             })
                                        ?.ToList();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void CreateFormNew              ()
        {
            //_FormNewChequeBook?.Dispose();

            //_FormNewChequeBook = new Form_Cache(Cache);
            //_FormNewChequeBook.MS_Do_Save += Frm_MS_Do_Save;
            //_FormNewChequeBook.FormClosed += Frm_FormClosed;
        }
        private void Frm_MS_Do_Save             (object sender, EventArgs e)
        {
            var pos = mS_GridX1.VerticalScrollPosition;
            RefreshGrid();
            var id = Convert.ToInt16(((AddingNewEventArgs)e).NewObject);

            var row = mS_GridX1.GetRows()
                .SingleOrDefault(x => (x.DataRow as Accounts).ID == id);
            if (row == null) return;

            mS_GridX1.MoveTo(row);
            mS_GridX1.EnsureVisible(row.Position);

            if ((bool)sender)
                mS_GridX1.VerticalScrollPosition = pos;
        }
        private void Frm_FormClosed             (object sender, FormClosedEventArgs e)
        {
            
        }
        #endregion
        private void FormListChequeBook_Load    (object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void ms_Add_Click               (object sender, EventArgs e)
        {
            CreateFormNew();
            //_FormNewChequeBook.ShowDialog(this);
        }

        private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter("");
        }
    }
}
