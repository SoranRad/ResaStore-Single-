using Janus.Windows.GridEX;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using ShareLib;
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
using MS_Control;
using static ShareLib.Enums;

namespace Nz.Anbar.WinForms.App
{
	public partial class FormSelectFactor : Form_Mother_IRANSans
	{
		#region Fields
		private ReportManager       _Manager;
		private Enums.NzFactorKind  _Kind = NzFactorKind.Frosh;

		public List<FactorItem> Items { get; set; }
		#endregion

		public FormSelectFactor()
		{
			InitializeComponent();
			_Manager                            = new ReportManager();
			this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
			SetCurrentMonth(); 
			ms_mah.SelectedTabChanged           += NzFactorKinds_SelectedTabChanged;
			
			RefreshGrid();
		}
		 #region Methods
        
        
        private void SetCurrentMonth                    ()
        {
            var mah                 = new MS_Structure_Shamsi(DateTime.Now)._Mah;
            ms_mah.SelectedIndex    = 13 - mah;
        }
        private void RefreshGrid                        ()
        {
            var Month = 13 - ms_mah.SelectedIndex;
            if (   _Kind == Enums.NzFactorKind.Xarid
                || _Kind == Enums.NzFactorKind.BargashXarid
                || _Kind == Enums.NzFactorKind.Frosh
                || _Kind == Enums.NzFactorKind.BargshtFrosh
            )
            {
                var list =
                    _Manager.GetReport<GeneralFactor>(new
                    {
                        Year = SystemConstant.ActiveYear.Salmali,
                        Kind = (byte) _Kind,
                        Month

                    }, null);

                NzGridHeads.DataSource = list?.ToList();
            }
            
            RefreshItem();
            NzGridHeads.MoveFirst();
        }
        private void RefreshItem                        ()
        {
            if(NzGridHeads.CurrentRow==null || NzGridHeads.CurrentRow.RowType!=RowType.Record)
                return;
            var ID = NzGridHeads.CurrentRow.Cells["ID"].Value;
            var list =
                _Manager.GetReport<FactorItem>(new
                {
                    ID
                }, null);

            NzGridItems.DataSource = list?.OrderBy(x=>x.radif)?.ToList();
            if (list != null && list.Count() > 20)
                NzGridItems.FilterMode = FilterMode.Automatic;
            else
                NzGridItems.FilterMode = FilterMode.None;
            NsCheckAll.Checked = false;
        }
        
        #endregion
        private void NzFactorKinds_SelectedTabChanged   (object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
	        RefreshGrid();
        }
        private void NzGridHeads_SelectionChanged       (object sender, EventArgs e)
        {
		        RefreshItem();
        }

		private void NsCheckAll_CheckedChanged(object sender, EventArgs e)
		{
            NzGridItems.GetRows().MSZ_ForEach(x=>x.IsChecked = NsCheckAll.Checked);
		}

		private void NsCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void ms_Save_Click(object sender, EventArgs e)
		{
			if (!NzGridItems.GetCheckedRows().Any())
			{
				MS_Message.Show("لطفا یک یا چند ردیف را انتخاب کنید");
                return;
			}

			Items = NzGridItems.GetCheckedRows().Select(x => x.DataRow as FactorItem).ToList();

			this.DialogResult = DialogResult.OK;
		}
	}
}
