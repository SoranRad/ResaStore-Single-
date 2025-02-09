using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.General.Business;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.General.WinForms.Base
{
    public class BankBinding : IBindingList
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        public event ListChangedEventHandler onListChanged;
        private List<Bank>          _ListNotes;
        public string Title         { get; set; }
        #endregion
        #region Constractor
         public BankBinding(List<Bank> List)
        {
            _ListNotes = List;
           
        }
        #endregion
        #region Property
        public object this[int index]
        {
            get => _ListNotes.ToList()[index];
            set => _ListNotes.ToList()[index] = (Bank)value;
        }

        public bool     AllowNew =>         true;
        public bool     AllowEdit =>        true;
        public bool     AllowRemove =>      true;
        public int      Count =>            _ListNotes.Count;

        public object   SyncRoot =>         throw new NotImplementedException();
        public bool     IsSorted =>         true;
        public bool     IsSynchronized =>   false;
        public bool     IsReadOnly =>       false;
        public bool     IsFixedSize =>      false;

        public bool     SupportsChangeNotification =>   true;
        public bool     SupportsSearching =>            true;
        public bool     SupportsSorting =>              false;
        #endregion
        #region Methods
        public PropertyDescriptor   SortProperty    => throw new NotImplementedException();
        public ListSortDirection    SortDirection   => throw new NotImplementedException();
        public event ListChangedEventHandler ListChanged
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

        public int          Add             (object value)
        {
            var item        = (Bank)value;
            item.title      = Title ;
            _ListNotes.Add(item);
            return 0;
        }
        public void         AddIndex        (PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }
        public object       AddNew          ()
        {
            var item        = new Bank();
            item.title      = Title;
            _ListNotes.Add(item);
            return item;
        }
        public void         ApplySort       (PropertyDescriptor property, ListSortDirection direction)
        {
            throw new NotImplementedException();
        }
        public void         Clear           ()
        {
            _ListNotes.Clear();
        }
        public bool         Contains        (object value)
        {
            throw new NotImplementedException();
        }
        public void         CopyTo          (Array array, int index)
        {
            array = _ListNotes.ToArray();
        }
        public int          Find            (PropertyDescriptor property, object key)
        {
            throw new NotImplementedException();
        }
        public int          IndexOf         (object value)
        {
            var i       = (Bank)value;
            return      _ListNotes.IndexOf(i);
        }
        public void         Insert          (int index, object value)
        {
            throw new NotImplementedException();
        }
        public void         Remove          (object value)
        {
            var index   = IndexOf(value);
            RemoveAt(index);
        }
        public void         RemoveAt        (int index)
        {
            var i   = _ListNotes[index];
            try
            {
                var Mgr     = new Manager();
                Mgr.Delete(i);
                onListChanged?.Invoke(this, new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
            }
            catch (Exception e)
            {
                log.Error(e);
            }

        }
        public void         RemoveIndex     (PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }
        public void         RemoveSort      ()
        {
            throw new NotImplementedException();
        }
        public IEnumerator  GetEnumerator   ()
        {
            return _ListNotes.GetEnumerator();
        }
        #endregion
    }
}
