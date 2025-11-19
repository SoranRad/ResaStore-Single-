using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using MS_Control;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Model;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Base
{
    public class BindingPrefactor : IBindingList
    {
         private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #region Fields
        private ListChangedEventHandler     onListChanged;
        private PreFactor                   _PreFactor;
        #endregion
        #region constructor
        public BindingPrefactor       (PreFactor Factor)
        {
            _PreFactor = Factor;
        }
        #endregion
        #region Property
        public object   this[int index]
        {
            get
            {
                var list = _PreFactor.Items.Where(x => x.State != Enums.NzItemState.Deleted);
                return index < list.Count() 
                                ? list.ToList()[index] 
                                : null;
            }
            set
            {
                var list = _PreFactor.Items.Where(x => x.State != Enums.NzItemState.Deleted);
                if(index < list.Count())
                    list.ToList()[index] = (PreFactorItems)value;
            }
                //=> _Factor.FactorItems.Where(x => x.State != Enums.NzItemState.Deleted).ToList()[index] =(FactorItem) value;
        }

        public bool         AllowNew                    => true;
        public bool         AllowEdit                   => true;
        public bool         AllowRemove                 => true;
        public int          Count                       => _PreFactor.Items.Count(x => x.State != Enums.NzItemState.Deleted);

        public object       SyncRoot                    => throw new NotImplementedException();
        public bool         IsSorted                    => true;
        public bool         IsSynchronized              => false;
        public bool         IsReadOnly                  => false;
        public bool         IsFixedSize                 => false;

        public bool         SupportsChangeNotification  => true;
        public bool         SupportsSearching           => true;
        public bool         SupportsSorting             => false;
        #endregion
        #region Methods

        public PropertyDescriptor               SortProperty  => throw new NotImplementedException();
        public ListSortDirection                SortDirection  => throw new NotImplementedException();
        public event ListChangedEventHandler    ListChanged
        {
            add
            {
                if(value!=null)
                    onListChanged += value;
            }
            remove
            {
                if(value!=null)
                    onListChanged -= value;
            }
        }
        #endregion

        #region Methods

        public int          Add             (object value)
        {
            var item            = (PreFactorItems) value;
            if (item == null)
                return -1;
            item.State          = Enums.NzItemState.AddedNew;
            item.FK_Title       = _PreFactor.ID;
            item.PreFactor      = _PreFactor;
            item.FK_Kala        = item.FK_Kala;

            _PreFactor.Items.Add(item);
            return 0;
        }
        public void         AddIndex        (PropertyDescriptor property)
        {
             
        }
        public object       AddNew          ()
        {
            var r           = new PreFactorItems(); 
            r.State         = Enums.NzItemState.AddedNew;
            r.FK_Title      = _PreFactor.ID;
            r.PreFactor     = _PreFactor;
            _PreFactor.Items.Add(r);
            return r;
        }
        public void         ApplySort       (PropertyDescriptor property, ListSortDirection direction)
        {
             
        }

        public void         Clear           ()
        {
            _PreFactor.Items.MSZ_ForEach(x =>
            {
                x.State = Enums.NzItemState.Deleted;
            });
        }
        public bool         Contains        (object value)
        {
            if (value is PreFactorItems row)
            {
                _PreFactor.Items
                    .Any(
                        x => x.State != Enums.NzItemState.Deleted && x == row);
            }
            return false;
        }
        public void         CopyTo          (Array array, int index)
        {
            array =  _PreFactor.Items.ToArray();

        }

        public int          Find            (PropertyDescriptor property, object key)
        {
            throw new NotImplementedException();
        }
        public IEnumerator  GetEnumerator   ()
        {
            return  _PreFactor.Items.Where(x=>x.State!=Enums.NzItemState.Deleted).GetEnumerator();
        }
        public int          IndexOf         (object value)
        {
            var i = (PreFactorItems) value;
            return  _PreFactor.Items.Where(x => x.State != Enums.NzItemState.Deleted).ToList().IndexOf(i);
        }

        public void         Insert          (int index, object value)
        {
            throw new NotImplementedException();
        }
        public void         Remove          (object value)
        {
            var i = (PreFactorItems)value;
            if (i.ID == 0)
                _PreFactor.Items.Remove(i);
            else 
                i.State = Enums.NzItemState.Deleted;
             
        }
        public void         RemoveAt        (int index)
        {
            var i= _PreFactor.Items.Where(x=>x.State!=Enums.NzItemState.Deleted).ToList()[index];
            if (i.ID == 0)
                _PreFactor.Items.Remove(i);
            else
                i.State = Enums.NzItemState.Deleted;
        }
        public void         RemoveIndex     (PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }
        public void         RemoveSort      ()
        {
            throw new NotImplementedException();
        }

      
        #endregion 
    }
}
