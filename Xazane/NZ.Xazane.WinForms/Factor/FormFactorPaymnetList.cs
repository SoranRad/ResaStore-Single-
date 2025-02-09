using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.MainForms;
using NZ.Xazane.Business;
using NZ.Xazane.Model.ViewModel;
using NZ.Xazane.WinForms.App;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.Xazane.WinForms.Factor
{
    public partial class FormFactorPaymentList : Form_Mother_IRANSans, IForm_Editor
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        private readonly FactorPaymentMessage   _message;
        private long                            _IdFactor;
        private DpManager                       _Manager;
        private FormPayment                     _Form;
        private Enums.NzPaymentOperatingKind    _Kind;

        #endregion
        #region Constructor
        public FormFactorPaymentList(FactorPaymentMessage Message)
        {
            InitializeComponent();
            _message    = Message;
            _Manager    = new DpManager();
            _Kind       = _message.Kind;
        }
        #endregion
        #region Methods

        private void RefreshGrid                        ()
        {
            try
            {
                
                var list =
                    _Manager.GetView<FactorPaymentList>(new
                    {
                        IdFactor = _message.IDFactor

                    });
                NzGridHeads.DataSource = list?.ToList();

                if (NzGridHeads.RowCount > 0)
                    NzGridHeads.MoveFirst();

                if (NzItems.Checked)
                    RefreshItem();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات");
            }
        }
        private void RefreshItem                        ()
        {
            if(NzGridHeads.CurrentRow==null || NzGridHeads.CurrentRow.RowType!=RowType.Record)
                return;
            if(NzGridHeads.CurrentRow.DataRow is FactorPaymentList row)
            {
                try
                {
                    var DP = _Manager.GetItem(row.ID);

                    ResetItems();
                    if (DP == null)
                        return;

                    var cache   = DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte) Enums.NzPaymentOperatingKind.Naqd);
                    var pos     = DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte) Enums.NzPaymentOperatingKind.Bank_POS);

                    #region Cache
                    if (cache != null)
                    {
                        NzCacheTitle.Text           = _Kind == Enums.NzPaymentOperatingKind.Daryaft
                                                        ? cache.DebitAccountTitle
                                                        : cache.CreditAccountTitle;
                        NzCacheAmount.MS_Decimal    = cache.mablaq;
                        NzCacheDesc.Text            = cache.sharh;
                    }
                    #endregion
                    #region POS
                    if (pos != null)
                    {
                        NzPosTitle.Text             = _Kind == Enums.NzPaymentOperatingKind.Daryaft
                                                        ? pos.DebitAccountTitle
                                                        : pos.CreditAccountTitle;
                        NzPosAmount.MS_Decimal      = pos.mablaq;
                        NzPosIdentity.Text          = pos.serialPeygiri?.ToString();
                        NzPosDesc.Text              = pos.sharh;
                    }
                    #endregion
                    #region Cheque
                    NzGridItems.DataSource          = DP.ChequeOP?.ToList();
                    #endregion
                }
                catch (Exception ex)
                {
                    MS_Message.Show("خطا در خواندن اطلاعات", "خطا", ex.Message, MessageBoxButtons.OK);
                }

            }
        }
        private void ResetItems                         ()
        {
            NzCacheTitle.Text =
                NzCacheAmount.Text =
                    NzCacheDesc.Text = "";

            NzPosTitle.Text =
                NzPosAmount.Text =
                    NzPosIdentity.Text =
                        NzPosDesc.Text = "";
            var str = _Kind == Enums.NzPaymentOperatingKind.Daryaft
                ? @"BankTitle"
                : @"PayAccountTitle";
            var str2 = _Kind == Enums.NzPaymentOperatingKind.Daryaft
                ? @"PayAccountTitle"
                : @"BankTitle";

            NzGridItems.RootTable.Columns[str].Visible      = true;
            NzGridItems.RootTable.Columns[str2].Visible     = false;
            NzGridItems.DataSource                          = null;
        }
        private void Edit                               ()
        {
            if(NzGridHeads.CurrentRow.RowType != RowType.Record)
                return;
            if (NzGridHeads.CurrentRow.DataRow is FactorPaymentList row)
            {
                Create_Form(row);
                _Form.Show(this);
            } 
            else 
                return;

            var Spos = NzGridHeads.VerticalScrollPosition;
            var Rpos = NzGridHeads.CurrentRow.Position;

            RefreshGrid();

            NzGridHeads.MoveTo(Rpos);
            NzGridHeads.EnsureVisible(Rpos);
            NzGridHeads.VerticalScrollPosition = Spos;
        }

        private void Print                              (Enums.NzKindPrint PrintKind)
        {
            List<long> ListIDs;

            if (NzGridHeads.GetCheckedRows().Any())
            {
                ListIDs = NzGridHeads
                    .GetCheckedRows()
                    .Select(x =>
                        (x.DataRow as PaymentList).ID
                    )
                    .ToList();
            }
            else
            {
                if(NzGridHeads.CurrentRow.RowType!=RowType.Record)
                    return;
                var ID =(NzGridHeads.CurrentRow.DataRow as PaymentList).ID;

                ListIDs = new List<long>(){ID};
            }

            new App.Print(ListIDs,PrintKind, _Kind).Show(this);
        }

        private void Create_Form                        (FactorPaymentList Pay)
        {
            _Form?.Dispose();
            _Form = Pay == null
                ? new FormPayment(_message) 
                : new FormPayment(Pay.ID, _Kind);

            
            _Form.MS_Do_Save += Frm_MS_Do_Save;
            _Form.FormClosed += Frm_FormClosed;
        }
        private void Frm_MS_Do_Save                     (object sender, EventArgs e)
        {
            var pos     = NzGridHeads.VerticalScrollPosition;
            RefreshGrid();
            var newItem = (e as AddingNewEventArgs)?.NewObject;

            if(newItem ==null)
                return;

            var id      = Convert.ToInt64(newItem);
            var row     = NzGridHeads
                            .GetRows()
                            .SingleOrDefault(x => ((FactorPaymentList) x.DataRow).ID == id);

            if (row == null) 
                return;

            NzGridHeads.MoveTo(row);
            NzGridHeads.EnsureVisible(row.Position);

            if ((bool)sender)
                NzGridHeads.VerticalScrollPosition = pos;
        }
        private void Frm_FormClosed                     (object sender, FormClosedEventArgs e)
        {
            //Create_Form(null);
        }
        
        public void Set_Form_Param                      (params object[] List_Parametter)
        {

        }

        #endregion
        private void FormFactorPaymentList_Load         (object sender, EventArgs e)
        {
            this.Text = _message.Kind == Enums.NzPaymentOperatingKind.Daryaft 
                ? "لیست دریافت های فاکتور " 
                : "لیست پرداخت های فاکتور ";

            RefreshGrid();
        }
        private void NzItems_Click                      (object sender, EventArgs e)
        {
            Splitter1.Visible   = NzItems.Checked;
            NzTabInfo.Visible   = NzItems.Checked;

            if (NzItems.Checked)
                RefreshItem();
        }

        private void NzPrint_Click                      (object sender, EventArgs e)
        {
            NzPrint.ShowDropDown();
        }
        private void NzPrintA4_Click                    (object sender, EventArgs e)
        {
           Print(Enums.NzKindPrint.PaperA4);
        }
        private void NzPrintA5_Click                    (object sender, EventArgs e)
        {
            Print(Enums.NzKindPrint.PaperA5);

        }

        private void NzGridHeads_SelectionChanged       (object sender, EventArgs e)
        {
            if(NzItems.Checked)
                RefreshItem();
        }
        private void NzGridHeads_ColumnButtonClick      (object sender, ColumnActionEventArgs e)
        {
            switch (e.Column.Key)
            {
                case "E":
                    Edit();
                    break;
                case "D":
                    try
                    {
                        var ResultDel = MS_Message.Show("آیـا بـرای حــذف ردیـف مـورد نـظر مـطـمئـنـیـد؟"
                            , "تـوجـه"
                            , ""
                            , MessageBoxButtons.YesNo
                            , MSMessage.FarsiMessageBoxIcon.سوال);

                        if (ResultDel != DialogResult.Yes)
                            return;

                        if (NzGridHeads.CurrentRow.DataRow is FactorPaymentList row)
                            _Manager.Delete(row.ID);                      

                        new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
                                Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                            .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);


                        var Spos = NzGridHeads.VerticalScrollPosition;
                        var Rpos = NzGridHeads.CurrentRow.Position;

                        RefreshGrid();

                        if (Rpos > 0 && Rpos >= NzGridHeads.RowCount)
                            Rpos--;

                        NzGridHeads.MoveTo(Rpos);
                        NzGridHeads.EnsureVisible(Rpos);
                        NzGridHeads.VerticalScrollPosition = Spos;

                    }
                    catch (Exception ex)
                    {
                        MS_Message.Show("خطا در حذف فاکتور ","خطا",ex.Message,MessageBoxButtons.OK);
                    }
                    break;
            }
        }
        private void NzGridHeads_RowDoubleClick         (object sender, RowActionEventArgs e)
        {
            Edit();
        }


        private void NzAdd_Click                        (object sender, EventArgs e)
        {
            Create_Form(null);
            //_Form.Set_Form_Param(_message);
            _Form.Show(this);
        }
        private void NzRefreshList_Click                (object sender, EventArgs e)
        {
            RefreshGrid();
        }
        
        private void mS_GridX_Setting2_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting2.FillParametter(this.Text);
        }
    }
}
