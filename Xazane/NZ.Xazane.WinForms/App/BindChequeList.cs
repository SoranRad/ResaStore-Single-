using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Control;
using NZ.Xazane.Model.Models;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.App
{
    public class BindChequeList : IBindingList
    {
        #region Fields
        public      event ListChangedEventHandler   onListChanged;
        private     DPOperation                     _DpHead;
        #endregion
        #region Constructor
        public BindChequeList(DPOperation DpHead)
        {
            _DpHead = DpHead;
        }
        #endregion
        #region Property
        public object this[int index]
        {
            get => _DpHead.ChequeOP.Where(x => x.State != Enums.NzItemState.Deleted).ToList()[index];
            set => _DpHead.ChequeOP.Where(x => x.State != Enums.NzItemState.Deleted).ToList()[index] = (ChequeOperation)value;
        }

        public bool     AllowNew                    => true;
        public bool     AllowEdit                   => true;
        public bool     AllowRemove                 => true;
        public int      Count                       => _DpHead.ChequeOP.Count(x => x.State != Enums.NzItemState.Deleted);

        public object   SyncRoot                    => throw new NotImplementedException();
        public bool     IsSorted                    => true;
        public bool     IsSynchronized              => false;
        public bool     IsReadOnly                  => false;
        public bool     IsFixedSize                 => false;

        public bool     SupportsChangeNotification  => true;
        public bool     SupportsSearching           => true;
        public bool     SupportsSorting             => false;
        #endregion
        #region Methods

        public PropertyDescriptor               SortProperty => throw new NotImplementedException();
        public ListSortDirection                SortDirection => throw new NotImplementedException();
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

        public int          Add             (object value)
        {
            var item            = (ChequeOperation)value;
            item.State          = Enums.NzItemState.AddedNew;
            item.FK_DP          = _DpHead.ID;
            item.DpHead         = _DpHead;
            item.kind           = _DpHead.kind;
            item.FK_User_Add    = SystemConstant.ActiveUser.ID;
            item.tarikh_add     = DateTime.Now;

            _DpHead.ChequeOP.Add(item);
            return 0;
        }
        public void         AddIndex        (PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }
        public object       AddNew          ()
        {
            var item            = new ChequeOperation();
            item.State          = Enums.NzItemState.AddedNew;
            item.FK_DP          = _DpHead.ID;
            item.DpHead         = _DpHead;
            item.kind           = _DpHead.kind;
            item.FK_User_Add    = SystemConstant.ActiveUser.ID;
            item.tarikh_add     = DateTime.Now;
            _DpHead.ChequeOP.Add(item);
            return item;
        }
        public void         ApplySort       (PropertyDescriptor property, ListSortDirection direction)
        {
            throw new NotImplementedException();
        }

        public void         Clear           ()
        {
            _DpHead.ChequeOP.MSZ_ForEach(x =>
            {
                x.State = Enums.NzItemState.Deleted;
            });
        }
        public bool         Contains        (object value)
        {
            throw new NotImplementedException();
        }
        public void         CopyTo          (Array array, int index)
        {
            array = _DpHead.ChequeOP.ToArray();
        }

        public int          Find            (PropertyDescriptor property, object key)
        {
            throw new NotImplementedException();
        }

        public int          IndexOf         (object value)
        {
            var i   = (ChequeOperation)value;
            return _DpHead.ChequeOP.ToList().IndexOf(i);
        }
        public void         Insert          (int index, object value)
        {
            throw new NotImplementedException();
        }

        public void         Remove          (object value)
        {
            var i = (ChequeOperation)value;
            if (i.ID == 0)
                _DpHead.ChequeOP.Remove(i);
            else
                i.State = Enums.NzItemState.Deleted;
        }
        public void         RemoveAt        (int index)
        {
            var i = _DpHead.ChequeOP.Where(x => x.State != Enums.NzItemState.Deleted).ToList()[index];
            if (i.ID == 0)
                _DpHead.ChequeOP.Remove(i);
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
        public IEnumerator  GetEnumerator   ()
        {
            return _DpHead.ChequeOP.Where(x => x.State != Enums.NzItemState.Deleted).GetEnumerator();
        }
        #endregion
    }
}
