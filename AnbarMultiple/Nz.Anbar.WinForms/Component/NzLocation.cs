using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Janus.Windows.EditControls;
using MS_Control.Controls;
using NZ.Anbar.Business;
using Nz.Anbar.Model.Model;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Component
{
    public partial class NzLocation : MS_ComboBox_Janus
    {
        private IEnumerable<Location> _list;

        public NzLocation()
        {
            InitializeComponent();
        }

        public void RefreshItems(bool ShowAll = false)
        {
            var mgr = new Manager();

            _list = mgr.GetList<Location>();

            if (_list == null || !_list.Any())
                return;
            
            Items.Clear();

            
            if (!ShowAll)
                _list = _list.Where(x => !x.Is_Disable);

            var arr =_list
                    .Select (x =>
                                new UIComboBoxItem
                                {
                                    Text = x.Title,
                                    Value = x.ID,
                                    DataRow = x,
                                }
                            )
                    .ToArray();

            Items.Insert(0,new UIComboBoxItem()
            {
                Text = "",
                Value = null,
                DataRow = null,
            });

            Items.AddRange(arr);

        }

        public void SetLocation(short? id)
        {
            if (id == null)
                SelectedIndex = -1;
            else
            {
                SelectedValue = id;
            }
        }

        public Location GetLocation()
        {

            return SelectedItem?.DataRow as Location;
        }
         
    }
}
