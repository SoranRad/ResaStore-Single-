using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Model;
using ShareLib;

namespace Nz.Anbar.WinForms.Base
{
    public class BindingListPrice : IBindingList
    {

        #region Fields
        public event    ListChangedEventHandler     onListChanged;
        private         List<PriceList>             _List;
        #endregion
        #region Constructor
        public BindingListPrice(List<PriceList> List)
        {
            _List = List;
        }
        #endregion
        #region Property
        public object this[int index]
        {
            get => _List[index];
            set => _List[index] = (PriceList)value;
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

        public bool     SupportsChangeNotification  => true;
        public bool     SupportsSearching           => true;
        public bool     SupportsSorting             => false;
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
            var i = (PriceList)value;
            return _List.IndexOf(i);
        }
        public void     Insert      (int index, object value)
        {
            throw new NotImplementedException();
        }

        public void     Remove      (object value)
        {
            if (value is PriceList row)
            {
                //var index       = IndexOf(value);
                //row.ID_DP       = null;
                //row.takhfif     = null;
                //row.sharh       = string.Empty;
                //row.kind        = (byte)Enums.NzPaymentOperatingKind.Bank_POS;

                //onListChanged?.Invoke(this, new ListChangedEventArgs(ListChangedType.ItemChanged, index));
            }
        }
        public void     RemoveAt    (int index)
        {
            try
            {
                //Remove(this[index]);
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

        public void             Update          (PriceList Row, NzObject Item)
        {
            
        }
        public IEnumerator      GetEnumerator   ()
        {
            return _List.GetEnumerator();
        }
        #endregion
    }
}
