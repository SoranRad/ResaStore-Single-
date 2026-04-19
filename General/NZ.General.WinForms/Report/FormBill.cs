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
using MS_Control.Tarikh;
using MS_Print_Dialog;
using NZ.General.WinForms.Component;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;
using Stimulsoft.Report;

namespace NZ.General.WinForms.Report
{
    public partial class FormBill : Form
    {
        #region Fields
        private long _IDPeople = 0;
        #endregion
        #region Constructor
        public FormBill()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            Init();
        }
        public FormBill(long IDPeople)
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            Init();
            _IDPeople = IDPeople;
            NzCustomer.MS_Set_Select(IDPeople);
            NzReport.PerformClick();
        }
        #endregion
        #region Methods
        private void Init           ()
        {
            NzCustomer.Refresh_Grid((byte)3,null);
            NzGrid.FilterMode = FilterMode.None;

        }
        private void Print   ()
        {
            var path = Utility.GetPrintDirectory()+ "\\General\\"
                                                  + (NzTabInfo.SelectedIndex == 0? "SuratHesab" : "RizSuratHesab") 
                                                  + (NzA5Radio.Checked?"A5":"A4")
                                                  + (NsOfoghi.Checked ? "Ofoghi" : "Amoudi") 
                                                  + ".mrt";

            object list =
	            NzTabInfo.SelectedIndex == 0
		            ? (object)NzGrid
			            .GetDataRows()
			            .Select(x => x.DataRow as BillRowItem)
			            .ToList()
		            : (object)NzGridDetails
			            .GetDataRows()
			            .Select(x => x.DataRow as CircularRowItem)
			            .ToList();

			//if (NzTabInfo.SelectedIndex == 0)

   //         var list = NzGrid
   //                     .GetDataRows()
   //                     .Select(x => x.DataRow as BillRowItem)
   //                     .ToList();
            var PrnDiag = new Print_Dialog(path, "List", list);
            var people  = NzCustomer.MS_Get_Selected() as People;

            PrnDiag.Set_Variable("tarikh"           , new MS_Structure_Shamsi(DateTime.Now).ToShamsi());
            PrnDiag.Set_Variable("User"             , SystemConstant.ActiveUser.title);
            PrnDiag.Set_Variable("Company"          , SystemConstant.ActiveCompany.title);
            PrnDiag.Set_Variable("Name"             , people?.title);
            PrnDiag.Set_Variable("Address"          , people?.addressHome);
            PrnDiag.Set_Variable("CodeMeli"         , people?.codeMeli);
            PrnDiag.Set_Variable("Mobile"           , people?.mobile);
            PrnDiag.Set_Variable("Tel"              , people?.tel);

            PrnDiag.ShowDialog(this);
        }
        private void PrintDatail    ()
        {
            var path = Utility.GetPrintDirectory()+ "\\General\\RizSuratHesab"+(NzA5Radio.Checked?"A5":"")+".mrt";
            var list = NzGridDetails
                        .GetDataRows()
                        .Select(x => x.DataRow as CircularRowItem)
                        .ToList();
            var PrnDiag = new Print_Dialog(path, "List", list);
            var people  = NzCustomer.MS_Get_Selected() as People;

            PrnDiag.Set_Variable("tarikh"           , new MS_Structure_Shamsi(DateTime.Now).ToShamsi());
            PrnDiag.Set_Variable("User"             , SystemConstant.ActiveUser.title);
            PrnDiag.Set_Variable("Company"          , SystemConstant.ActiveCompany.title);
            PrnDiag.Set_Variable("Name"             , people?.title);
            PrnDiag.Set_Variable("Address"          , people?.addressHome);
            PrnDiag.Set_Variable("CodeMeli"         , people?.codeMeli);
            PrnDiag.Set_Variable("Mobile"           , people?.mobile);
            PrnDiag.Set_Variable("Tel"              , people?.tel);

            PrnDiag.ShowDialog(this);
        }

        private void RefreshPrintSuratHesab()
        {
	        var People = (NzCustomer.MS_Get_Selected() as People);
	        var Year = SystemConstant.ActiveYear.Salmali;

	        var ReportPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
	        ReportPath += "\\Print\\General\\SuratHesabJame.mrt";

	        var report = new StiReport();
	        report.Load(ReportPath);

	        var Anbar	= Form_Factory._Form_Factory_Anbar.GetBillRows(People.ID, Year, null, null);
	        var Xazane	= Form_Factory._Form_Factory_Xazaneh.GetBillRows(People.ID, Year, null, null);

	        if(Anbar!=null)
		        report.RegBusinessObject("Anbar",Anbar);

	        if(Xazane!=null)
		        report.RegBusinessObject("Xazane",Xazane);

			 
	        report.Dictionary.Variables["company"].Value	= SystemConstant.ActiveCompany.title; 
            report.Dictionary.Variables["Mande"].Value = NzCustomerRemain.Balance.ToString();
            report.Dictionary.Variables["MandeTitle"].Value = NzCustomerRemain.Balance > 0 ? "بدهکار" : "بستانکار";


            report.Dictionary.Variables["User"             ].Value	= SystemConstant.ActiveUser.title;
            //report.Dictionary.Variables["Company"          ].Value	= SystemConstant.ActiveCompany.title;
	        report.Dictionary.Variables["tarikh"           ].Value	= new MS_Structure_Shamsi(DateTime.Now).ToShamsi();
	        report.Dictionary.Variables["Name"             ].Value	= People?.title;
	        //report.Dictionary.Variables["Address"          ].Value	= People?.addressHome;
	        report.Dictionary.Variables["CodeMeli"         ].Value	= People?.codeMeli;
	        report.Dictionary.Variables["Mobile"           ].Value	= People?.mobile;
	        //report.Dictionary.Variables["Tel"              ].Value	= People?.tel;


	        report.Render(true);
			 
	        stiViewerControl1.Report = report; 
        }
        #endregion
        private void NzPrint_Click                      (object sender, EventArgs e)
        {
            Print();
            //if(NzTabInfo.SelectedIndex == 0)
            //    PrintSummary();
            //else
            //    PrintDatail();
        }
        private void NzReport_Click                     (object sender, EventArgs e)
        {
            if(NzCustomer.MS_Get_Selected()==null)
                return;


            var People      = NzCustomer.MS_Get_Selected() as People;
            NzCustomerRemain.NzSetCustoemr(People?.ID ?? 0);

            var DateFrom    = NzDateFrom.MS_Tarikh.HasValue && !NzAllYears.Checked
                                ? (DateTime?) NzDateFrom.MS_Tarikh.Value.ToDatetime()
                                : null;
            var DateTo      = NzDateTo.MS_Tarikh.HasValue && !NzAllYears.Checked
                                ? (DateTime?)NzDateTo.MS_Tarikh.Value.ToDatetime()
                                : null;

            var Year        = NzAllYears.Checked 
                                ? null 
                                : (short?) SystemConstant.ActiveYear.Salmali;

            var Group       = NzGroup.Checked ? (byte)1 : (byte)2;
            var TopCount    = NzTopCount.Value;

            var List        = new List<BillRowItem>();
            var List2       = new List<CircularRowItem>();
            Form_Factory
                .SystemList
                .MSZ_ForEach(x =>
                {
                    var list    = x.GetBillDetail(People.ID, Year, DateFrom, DateTo, Group);
                    var list2   = x.GetBillItems(People.ID, Year, DateFrom, DateTo, (byte)TopCount);

                    if (list != null)
                        List.InsertRange(0, list.Where(y => y.Credit > 0  || y.Debit > 0));

                    if(list2!=null)
                        List2.InsertRange(0,list2.Where(y => y.Credit > 0 || y.Debit > 0));
                });
            NzGrid.DataSource = List.ToList();

            decimal remaind = 0;

            List2
                .OrderBy(x=>x.Date)
                .ThenBy(x=>x.SubSystem)
                .ThenBy(x=>x.Kind)
                .MSZ_ForEach(x =>
                {
                    remaind     += x.Debit - x.Credit;
                    x.Remaind   = remaind;
                });

            NzGridDetails.DataSource = List2
                                        .OrderBy(x => x.Date)
                                        .ThenBy(x=>x.SubSystem)
                                        .ThenBy(x=>x.Kind)
                                        .ToList();

            RefreshPrintSuratHesab();
        }

        private void NzGrid_FormattingRow               (object sender, RowLoadEventArgs e)
        {
            if (e.Row.RowType == RowType.TotalRow)
            {
                e.Row.Cells["Title"].Text = "مانده حسـاب نهایی شخص :";
                var list = NzGrid.GetDataRows().Select(x => x.DataRow as BillRowItem);

                decimal Debit = 0, Credit = 0;

                if (list.Any())
                {
                    Debit  = list.Sum(x => x.Debit);
                    Credit = list.Sum(x => x.Credit);
                }

                var Remaind = Debit - Credit;

                if (Remaind > 0)
                {
                    e.Row.Cells["Debit"].Text = Remaind.ToString("0,0.##;(0,0.##); ");

                    e.Row.Cells["Debit"].FormatStyle = new GridEXFormatStyle()
                    {
                        TextAlignment = TextAlignment.Far,
                        ForeColor = Color.Green,
                    };
                }
                else if (Remaind < 0)
                {
                    e.Row.Cells["Credit"].Text = Remaind.ToString("0,0.##;(0,0.##); ");

                    e.Row.Cells["Credit"].FormatStyle = new GridEXFormatStyle()
                    {
                        TextAlignment = TextAlignment.Near,
                        ForeColor = Color.Maroon,
                    };
                }


            }
        }

        private void FormBill_Shown                     (object sender, EventArgs e)
        {
            NzCustomer.Focus();
        }
        private void NzGridDetails_FormattingRow        (object sender, RowLoadEventArgs e)
        {
            if (e.Row.RowType == RowType.TotalRow)
            {
                e.Row.Cells["Description"].Text = "مانده حسـاب نهایی شخص :";
                var list = NzGridDetails.GetDataRows().Select(x => x.DataRow as CircularRowItem);

                decimal Debit = 0, Credit = 0;

                if (list.Any())
                {
                    Debit   = list.Sum(x => x.Debit);
                    Credit  = list.Sum(x => x.Credit);
                }

                var Remaind                         = Debit - Credit;
                e.Row.Cells["Remaind"].Text         = Remaind.ToString("0,0.##;(0,0.##); ");
                e.Row.Cells["Remaind"].FormatStyle  = new GridEXFormatStyle()
                {
                    TextAlignment   = Remaind > 0 ? TextAlignment.Near  : TextAlignment.Far,
                    ForeColor       = Remaind > 0 ? Color.Green         : Color.Maroon,
                };
            }
        }
        private void NzCustomer_MS_On_Row_Selected      (object sender, MS_Control.TSDD.On_Selected e)
        {
            var current = NzCustomer.MS_Get_Selected() as People;
            if (current == null)
                return;

            NzCustomerRemain.NzSetCustoemr(current?.ID ?? 0);

            if (current.ID != _IDPeople)
            {
                _IDPeople = current.ID;
                NzReport.PerformClick();
            }
        }

        private void NzGridDetails_ColumnButtonClick    (object sender, ColumnActionEventArgs e)
        {
            if (NzGridDetails.CurrentRow?.DataRow is CircularRowItem row)
            {
                if (row.SubSystem == (byte) Enums.MS_System.Anbar)
                {
                    var kind = (Enums.NzFactorKind) row.Kind;

                    var factor = Form_Factory
                        .SystemList
                        .FirstOrDefault
                        (x => x.GetSystemKind() == Enums.MS_System.Anbar);

                    var frm =factor.GetFormForEdit
                        (kind==Enums.NzFactorKind.BargshtFrosh
                            ? Enums.FormOperation.SaleBack
                            : Enums.FormOperation.Factors
                        );

                    frm?.Set_Form_Param(row.ID,kind);

                    (frm as Form)?.ShowDialog();
                }
                else if (row.SubSystem == (byte) Enums.MS_System.Xazane)
                {
                    var kind = (Enums.NzPaymentOperatingKind)row.Kind;

                    var factor = Form_Factory
                        .SystemList
                        .FirstOrDefault
                        (x => x.GetSystemKind() == Enums.MS_System.Xazane);

                    IForm_Editor frm = null;
                    switch (kind)
                    {
                        case Enums.NzPaymentOperatingKind.Daryaft:
                        case Enums.NzPaymentOperatingKind.Pardaxt:
                            frm = factor.GetFormForEdit(Enums.FormOperation.Payment);
                            var para = new CircularBill()
                            {
                                ID      = row.ID,
                                Kind    = row.Kind,
                            };
                            frm?.Set_Form_Param(para);
                            (frm as Form)?.ShowDialog();
                            break;
                        case Enums.NzPaymentOperatingKind.Kosurat:
                        case Enums.NzPaymentOperatingKind.Addition:
                            frm         = factor.GetFormForEdit(Enums.FormOperation.Addition);
                            var para2   = new CircularBill()
                            {
                                ID      = row.ID,
                                Kind    = row.Kind,
                            };
                            frm?.Set_Form_Param(para2);
                            (frm as Form)?.ShowDialog();
                            break;
                        case Enums.NzPaymentOperatingKind.RemaindDebit:
                        case Enums.NzPaymentOperatingKind.RemaindCredit:
                            frm = factor.GetFormForEdit(Enums.FormOperation.Remaind);
                            (frm as Form)?.ShowDialog();
                            break;
                        case Enums.NzPaymentOperatingKind.Cheque:
                        case Enums.NzPaymentOperatingKind.AssignCheque:
                        case Enums.NzPaymentOperatingKind.chequePayBack:
                            frm = factor.GetFormForEdit(Enums.FormOperation.Cheque);
                            (frm as Form)?.ShowDialog();
                            break;
                    }
                    
                }
                else if (row.SubSystem == (byte) Enums.MS_System.Bar)
                {
	                var factor = Form_Factory
		                .SystemList
		                .FirstOrDefault
			                (x => x.GetSystemKind() == Enums.MS_System.Bar);

	                IForm_Editor frm = null;

	                frm = factor.GetFormForEdit(Enums.FormOperation.Bar);
	                frm?.Set_Form_Param(row.ID);
	                (frm as Form)?.ShowDialog();
                }

            }
        }
        private void NzXaridar_CheckedChanged           (object sender, EventArgs e)
        {
            NzDateFrom.Enabled = NzDateTo.Enabled = !NzAllYears.Checked;
        }
    }
}
