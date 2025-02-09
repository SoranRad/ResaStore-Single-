using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.Schedule.Model;
using Janus.Windows.GridEX;
using MS_Control;
using NZ.Anbar.Business;
using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.ViewModel;
using Nz.Anbar.WinForms.App;
using ShareLib;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace Nz.Anbar.WinForms.Report
{
    public partial class FormReviewFactorPayment : Form
    {
        #region Fields
        private ReportManager       _Manager;
        private Enums.NzFactorKind  _Kind;
        #endregion
        #region Constructor
        public FormReviewFactorPayment()
        {
            _Manager = new ReportManager();
            InitializeComponent();
        }
        #endregion
        #region Methods
        private void SetFactorKind                      ()
        {
            if (NzFactorKinds.SelectedTab == NzTabPurchase)
                _Kind = Enums.NzFactorKind.Xarid;
            else if (NzFactorKinds.SelectedTab == NzTabPurchaseBack)
                _Kind = Enums.NzFactorKind.BargashXarid;
            else if (NzFactorKinds.SelectedTab == NzTabSale)
                _Kind = Enums.NzFactorKind.Frosh;
            else if (NzFactorKinds.SelectedTab == NzTabSaleBack)
                _Kind = Enums.NzFactorKind.BargshtFrosh;
        }
        private void RefreshGrid                        ()
        {
            SetFactorKind();

                var list =
                    _Manager.GetReport<ReviewFactorPayment>(new
                    {
                        Year = SystemConstant.ActiveYear.Salmali,
                        Kind = (byte) _Kind,
                    }, null);

                NzGridHeads.DataSource = list?.ToList();
        }
        private void EditFactor                         ()
        {
            if(NzGridHeads.CurrentRow.RowType!=RowType.Record)
                return;
            var ID =  ((ReviewFactorPayment) NzGridHeads.CurrentRow.DataRow).ID;
            
            if (_Kind == Enums.NzFactorKind.Frosh)
                new Form_SelectSaleFactor(ID).ShowDialog(this);
            else
                new Form_Purchase(Convert.ToInt64(ID), _Kind).ShowDialog(this);
        
            var Spos = NzGridHeads.VerticalScrollPosition;
            var Rpos = NzGridHeads.CurrentRow.Position;

            RefreshGrid();

            NzGridHeads.MoveTo(Rpos);
            NzGridHeads.EnsureVisible(Rpos);
            NzGridHeads.VerticalScrollPosition = Spos;

        }
        private void LoadPaymentList                    ()
        {
            var row = NzGridHeads.CurrentRow.DataRow as ReviewFactorPayment;

            var kind        = Enums.FormOperation.FactorPaymentList;
            var Msg         = new FactorPaymentMessage()
            {
                Kind        = (byte)_Kind < 50
                    ? Enums.NzPaymentOperatingKind.Pardaxt
                    : Enums.NzPaymentOperatingKind.Daryaft,
                Description = "بابت تسویه فاکتور " + row.Serial,
                IDFactor    = row.ID,
                IDPeople    = row.FK_AshXas_ID??0,
            };

            var frm = Form_Factory._Form_Factory_Xazaneh.GetFormForEdit(kind,Msg);

            frm?.Set_Form_Param(Msg);
            (frm as Form)?.ShowDialog(this);

            var Spos = NzGridHeads.VerticalScrollPosition;
            var Rpos = NzGridHeads.CurrentRow.Position;

            RefreshGrid();

            NzGridHeads.MoveTo(Rpos);
            NzGridHeads.EnsureVisible(Rpos);
            NzGridHeads.VerticalScrollPosition = Spos;
        }

        private void ChangeState()
        {
            if(NzGridHeads.CurrentRow.RowType!=RowType.Record)
                return;
            var ID =  ((ReviewFactorPayment) NzGridHeads.CurrentRow.DataRow).ID;

            _Manager.GetItem<UpdateFactorState>(new {ID},null);
        
            new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                    Form_Notify.FarsiMessageBoxIcon.اضافه)
                .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);

            var Spos = NzGridHeads.VerticalScrollPosition;
            var Rpos = NzGridHeads.CurrentRow.Position;

            RefreshGrid();

            NzGridHeads.MoveTo(Rpos);
            NzGridHeads.EnsureVisible(Rpos);
            NzGridHeads.VerticalScrollPosition = Spos;

        }
        #endregion
        private void NzGridHeads_ColumnButtonClick      (object sender, ColumnActionEventArgs e)
        {
            switch (e.Column.Key)
            {
                case "E":
                    EditFactor();
                    break;
                case "V":
                    ChangeState();
                    break;
                case "P":
                    LoadPaymentList(); 
                    break;
            }
        }

        private void NzFactorKinds_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            RefreshGrid();
        }

        private void FormReviewFactorPayment_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
