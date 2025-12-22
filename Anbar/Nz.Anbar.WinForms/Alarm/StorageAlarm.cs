using Janus.Windows.GridEX;
using Janus.Windows.UI.Tab;
using MS_Control;
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.App;
using Nz.Anbar.WinForms.Provider;
using Nz.Anbar.WinForms.Report;
using NZ.Anbar.Business;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Utils;
using ShareLib.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nz.Anbar.WinForms.Alarm
{
    public partial class StorageAlarm : UserControl
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System
                    .Reflection
                    .MethodBase
                    .GetCurrentMethod()
                    .DeclaringType);
        #endregion

        private IEnumerable<PointOrder> _List;
        private IEnumerable<FactorReminder> _ListFactor;

		public StorageAlarm()
        {
            InitializeComponent();
        }

        public void         RefreshList     ()
        {
            try
            {
                var Mgr     = new ReportManager();
                _List       = Mgr.GetReport<PointOrder>
                (new
                    {
                        Year = SystemConstant.ActiveYear.Salmali
                    }, null
                );

                _ListFactor = Mgr.GetReport<FactorReminder>
                (new
	                {
		                Year = SystemConstant.ActiveYear.Salmali,
						Tarikh = DateTime.Now.Date
	                }, null
                );

				if (_List.Any())
                {
                    _List = _List.Where(x => x.Remaind <= x.point_bohrani).ToList();
                    NzTabAlarm.Text += " [ " + _List.Count() + " ]";
                }

                if (_ListFactor.Any())
                {
	                NsFactorReminder.Text += " [ " + _ListFactor.Count() + " ]";
				}

            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        public bool         AnyAlarm        ()
        {

			return _List.Any() || _ListFactor.Any();
        }
        public IEnumerable<UITabPage> GetTabPage      ()
        {
	        if (_List.Any())
	        {
		        NzGrid.DataSource = _List?.ToList();
		        yield return NzTabAlarm;
	        }

	        if (_ListFactor.Any())
	        {
		        NzGridHeads.DataSource = _ListFactor?.ToList();
		        yield return NsFactorReminder;
	        }
		}

        private void NzGrid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (NzGrid.CurrentRow.DataRow is PointOrder row)
            {
                var frm         = new FormCircularObject(row.Code);
                frm.MdiParent   =  StorageProvider.MainForm;
                frm.Show();
            }
        }

        private void RefreshGrid()
        {
	        try
	        {
		        var Mgr = new ReportManager();
		        NzGridHeads.DataSource = Mgr.GetReport<FactorReminder>
		        (new
			        {
				        Year = SystemConstant.ActiveYear.Salmali,
				        Tarikh = DateTime.Now.Date
			        }, null
		        );
	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
		        MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
	        }
        }
		private void LoadPaymentList()
		{
			var row = NzGridHeads.CurrentRow.DataRow as FactorReminder;
			var kid = ((Enums.NzFactorKind)row.kind);

			var kind = Enums.FormOperation.FactorPaymentList;
			var Msg = new FactorPaymentMessage()
			{
				Kind = (byte)kid < 50
					? Enums.NzPaymentOperatingKind.Pardaxt
					: Enums.NzPaymentOperatingKind.Daryaft,
				Description = "بابت تسویه فاکتور " + row.Serial,
				IDFactor = row.ID,
				IDPeople = row.FK_AshXas_ID ?? 0,
				Amount = row.mablaq,
			};

			var frm = Form_Factory._Form_Factory_Xazaneh.GetFormForEdit(kind, Msg);

			frm?.Set_Form_Param(Msg);
			(frm as Form)?.ShowDialog(this);

			RefreshGrid();


		}
		private void EditFactor()
		{
			if (NzGridHeads.CurrentRow.RowType != RowType.Record)
				return;
			var row = NzGridHeads.CurrentRow.DataRow as FactorReminder;
			var kid = ((Enums.NzFactorKind)row.kind);
			var ID = Convert.ToInt64(NzGridHeads.CurrentRow.Cells["ID"].Value);

			if (kid == Enums.NzFactorKind.PishFaktor
				|| kid == Enums.NzFactorKind.Xarid
				|| kid == Enums.NzFactorKind.BargashXarid
				|| kid == Enums.NzFactorKind.Frosh
			   )
			{
				new Form_Purchase(ID, kid).ShowDialog(this);
			}

			else if (kid == Enums.NzFactorKind.BargshtFrosh)
				new Form_SaleBack(ID, kid).ShowDialog(this);


			RefreshGrid();


		}
		private void NzGridHeads_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			switch (e.Column.Key)
			{
				case "E":
					EditFactor();
					break;

				case "P":
					LoadPaymentList();
					break;
			}
		}
	}
}
