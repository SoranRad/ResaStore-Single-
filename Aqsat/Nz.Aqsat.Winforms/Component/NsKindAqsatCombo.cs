using MS_Control;
using MS_Control.Controls;
using Nz.Aqsat.Bussiness;
using Nz.Aqsat.Model.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.EditControls;

namespace Nz.Aqsat.Winforms.Component
{
    public partial class NsKindAqsatCombo : MS_ComboBox_Janus
    {
	    #region Logging
	    private static readonly log4net.ILog log =
		    log4net
			    .LogManager
			    .GetLogger
				    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
	    #endregion
		#region Fields
		private bool _Do_Refresh = true;

	    #endregion
	    #region Constructor
		public NsKindAqsatCombo()
        {
            InitializeComponent();
        }
        #endregion

		#region Methods

		public void RefreshKinds()
        {
	        try
	        {
		        var mgr		= new Manager();
				var _List	= mgr.GetList<Aqsat_Kind>(null)?.ToList();

				var kinds = _List
					.Select(x => new UIComboBoxItem() { DataRow = x, Text = x.Title, Value = x.ID })
					.ToArray();
				this.DataSource = _List;
				this.DisplayMember = "Title";
				//this.DA
	        }
			catch (Exception ex)
	        {
				log.Error(ex);
				MS_Message.Show("خطا در خواندن انواع قسط", "", ex.Message, MessageBoxButtons.OK);
			}
        }

        public void SetValue(Aqsat_Kind Kind)
        {
	        var item = this.Items.OfType<UIComboBoxItem>()
		        .SingleOrDefault(x => (x.DataRow as Aqsat_Kind).ID == Kind.ID);

	        this.SelectedItem = item;
        }

		public void SetValue(short Kind)
		{
			var item = this.Items.OfType<UIComboBoxItem>()
				.SingleOrDefault(x => (x.DataRow as Aqsat_Kind).ID == Kind);

			this.SelectedItem = item;
		}

		public Aqsat_Kind GetValue()
		{
			var item = this.SelectedItem as UIComboBoxItem;
			if (item != null)
				return item.DataRow as Aqsat_Kind;
			return null;
		}

		#endregion

	}
}
