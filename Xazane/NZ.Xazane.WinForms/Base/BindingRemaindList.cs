using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Control;
using NZ.Xazane.Model.Models;
using NZ.Xazane.Model.ViewModel;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Base
{
    public class BindingRemaindList : IBindingList
    {
        #region Fields
        public event ListChangedEventHandler    onListChanged;
        private List<RemaindList>               _List;
        #endregion
        #region Constructor
        public BindingRemaindList(List<RemaindList> List)
        {
            _List = List;
        }
        #endregion
        #region Property
        public object this[int index]
        {
            get => _List[index];
            set => _List[index] = (RemaindList)value;
        }

        public bool     AllowNew            => false;
        public bool     AllowEdit           => true;
        public bool     AllowRemove         => false;
        public int      Count               => _List.Count;

        public object   SyncRoot            => throw new NotImplementedException();
        public bool     IsSorted            => true;
        public bool     IsSynchronized      => false;
        public bool     IsReadOnly          => false;
        public bool     IsFixedSize         => false;
        public bool     SupportsSearching   => true;
        public bool     SupportsSorting     => false;

        public bool     SupportsChangeNotification  => true;
        
        #endregion
        #region Methods

        public PropertyDescriptor               SortProperty    => throw new NotImplementedException();
        public ListSortDirection                SortDirection   => throw new NotImplementedException();
        public event ListChangedEventHandler    ListChanged
        {
            add
            {
                onListChanged += value;
            }
            remove
            {
                onListChanged -= value;
            }
        }

        public int      Add         (object value)
        {
            return -1;
        }
        public void     AddIndex    (PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }
        public object   AddNew      ()
        {
            return null;
        }
        public void     ApplySort   (PropertyDescriptor property, ListSortDirection direction)
        {
            throw new NotImplementedException();
        }
        public void     Clear       ()
        {
            
        }

        public bool     Contains    (object value)
        {
            throw new NotImplementedException();
        }
        public void     CopyTo      (Array array, int index)
        {
            array = _List.ToArray();
        }
        public int      Find        (PropertyDescriptor property, object key)
        {
            throw new NotImplementedException();
        }

        public int      IndexOf     (object value)
        {
            var i = (RemaindList)value;
            return _List.IndexOf(i);
        }
        public void     Insert      (int index, object value)
        {
            throw new NotImplementedException();
        }

        public void     Remove      (object value)
        {
            if (value is RemaindList row)
            {
                var index       = IndexOf(value);
                row.ID_DP       = null;
                row.takhfif     = null;
                row.sharh       = string.Empty;
                row.kind        = (byte)Enums.NzPaymentOperatingKind.Bank_POS;

                onListChanged?.Invoke(this, new ListChangedEventArgs(ListChangedType.ItemChanged, index));
            }
        }
        public void     RemoveAt    (int index)
        {
            try
            {
                Remove(this[index]);
            }
            catch (Exception)
            {
                
            }

        }
        public void     RemoveIndex (PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }
        public void     RemoveSort  ()
        {
            throw new NotImplementedException();
        }

        public void     Update      (RemaindList Row, DPOperation Item)
        {
            Row.ID_DP           = Item.ID;
            Row.FK_Salmali      = Item.FK_Salmali;
            Row.FK_User_Add     = Item.FK_User_Add;
            Row.FK_User_Edit    = Item.FK_User_Edit;
            Row.kind            = Item.kind;
            Row.sharh           = Item.sharh;
            Row.takhfif         = Item.takhfif;
            Row.tarikh          = Item.tarikh;
            Row.tarikh_add      = Item.tarikh_add;
            Row.tarikh_edit     = Item.tarikh_edit;
        }
        public IEnumerator GetEnumerator()
        {
            return _List.GetEnumerator();
        }

        public void ListChangedInvoke(ListChangedType type, int Index)
        {
            onListChanged?.Invoke(this, new ListChangedEventArgs(type, Index));
        }

        #endregion
    }
}
