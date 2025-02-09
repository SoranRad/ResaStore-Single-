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
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.App
{
    public class BidingFactorItems : IBindingList
    {
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #region Fields
        private ListChangedEventHandler     onListChanged;
        private FactorHead                  _Factor;
        #endregion
        #region constructor
        public BidingFactorItems       (FactorHead Factor)
        {
            _Factor = Factor;
        }
        #endregion
        #region Property
        public object   this[int index]
        {
            get
            {
                var list = _Factor.FactorItems.Where(x => x.State != Enums.NzItemState.Deleted);
                return index < list.Count() 
                                ? list.ToList()[index] 
                                : null;
            }
            set
            {
                var list = _Factor.FactorItems.Where(x => x.State != Enums.NzItemState.Deleted);
                if(index < list.Count())
                    list.ToList()[index] = (FactorItem)value;
            }
                //=> _Factor.FactorItems.Where(x => x.State != Enums.NzItemState.Deleted).ToList()[index] =(FactorItem) value;
        }

        public bool         AllowNew                    => true;
        public bool         AllowEdit                   => true;
        public bool         AllowRemove                 => true;
        public int          Count                       => _Factor.FactorItems.Count(x => x.State != Enums.NzItemState.Deleted);

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
            var item            = (FactorItem) value;
            if (item == null)
                return -1;
            item.State          = Enums.NzItemState.AddedNew;
            item.FK_Title       = _Factor.ID;
            item.FactorHead     = _Factor;
            item.FK_Anbar_Az    = 1;
            item.FK_Salmali     = SystemConstant.ActiveYear.Salmali;
            item.FactorHead     = _Factor;
            _Factor.FactorItems.Add(item);
            return 0;
        }
        public void         AddIndex        (PropertyDescriptor property)
        {
             
        }
        public object       AddNew          ()
        {
            var r           = new FactorItem(); 
            r.State         = Enums.NzItemState.AddedNew;
            r.radif         = GetNewRowNumber()+1;
            r.FK_Title      = _Factor.ID;
            r.FactorHead    = _Factor;
            r.FK_Salmali    = SystemConstant.ActiveYear.Salmali;
            r.FK_Anbar_Az   = 1;
            r.FactorHead    = _Factor;
            _Factor.FactorItems.Add(r);
            return r;
        }
        public void         ApplySort       (PropertyDescriptor property, ListSortDirection direction)
        {
             
        }

        public void         Clear           ()
        {
            _Factor.FactorItems.MSZ_ForEach(x =>
            {
                x.State = Enums.NzItemState.Deleted;
            });
        }
        public bool         Contains        (object value)
        {
            if (value is FactorItem row)
            {
                _Factor
                    .FactorItems
                    .Any(
                        x => x.State != Enums.NzItemState.Deleted && x == row);
            }
            return false;
        }
        public void         CopyTo          (Array array, int index)
        {
            array = _Factor.FactorItems.ToArray();

        }

        public int          Find            (PropertyDescriptor property, object key)
        {
            throw new NotImplementedException();
        }
        public IEnumerator  GetEnumerator   ()
        {
            return _Factor.FactorItems.Where(x=>x.State!=Enums.NzItemState.Deleted).GetEnumerator();
        }
        public int          IndexOf         (object value)
        {
            var i = (FactorItem) value;
            return _Factor.FactorItems.Where(x => x.State != Enums.NzItemState.Deleted).ToList().IndexOf(i);
        }

        public void         Insert          (int index, object value)
        {
            throw new NotImplementedException();
        }
        public void         Remove          (object value)
        {
            var i = (FactorItem)value;
            if (i.ID == 0)
                _Factor.FactorItems.Remove(i);
            else 
                i.State = Enums.NzItemState.Deleted;

            ReOrderRowNumber((i.radif));
        }
        public void         RemoveAt        (int index)
        {
            var i=_Factor.FactorItems.Where(x=>x.State!=Enums.NzItemState.Deleted).ToList()[index];
            if (i.ID == 0)
                _Factor.FactorItems.Remove(i);
            else
                i.State = Enums.NzItemState.Deleted;

            ReOrderRowNumber(i.radif);
        }
        public void         RemoveIndex     (PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }
        public void         RemoveSort      ()
        {
            throw new NotImplementedException();
        }

        public void         AddOrUpdate     (NzObject Object, Enums.NzSalingKind Kind,decimal meqdar = 1)
        {
            var row = _Factor
                            .FactorItems
                            .FirstOrDefault(x =>    x.State != Enums.NzItemState.Deleted
                                                 && x.FK_Kala == Object.Code
                                           );

            decimal Price = 0;

            switch (Kind)
            {
                case Enums.NzSalingKind.Normal:
                    Price = Object.nerkh_frosh;
                    break;
                case Enums.NzSalingKind.Crumbs:
                    Price = Object.nerkh_frosh1??0;
                    break;
                case Enums.NzSalingKind.Colleague:
                    Price = Object.nerkh_frosh2??0;
                    break;
                case Enums.NzSalingKind.Misc:
                    Price = Object.nerkh_frosh3??0;
                    break;
            }

            var index = 0;
            if (row == null)
            {
                row = new FactorItem()
                {
                    State           = Enums.NzItemState.AddedNew,
                    radif           = GetNewRowNumber() + 1,
                    FactorHead      = _Factor,
                    FK_Salmali      = SystemConstant.ActiveYear.Salmali,
                    FK_Anbar_Az     = 1,
                    meqdar          = meqdar,
                    nerkh           = Price,
                    mablaq          = meqdar * Price,
                    UnitTitle       = Object.UnitTitle,
                    FK_Kala         = Object.Code,
                    ObjectTitle     = Object.title,
                    
                };
                if (row.nerkh <= 0)
                {
                    SystemSounds.Beep.Play();
                    MS_Message.Show("برای این کالا هیچ نرخ فروشی مشخص نشده است." +
                                    "\n لطفا نرخ فروش را مشخص کنید");
                    return;
                }
                _Factor.FactorItems.Add(row);
                index       = _Factor
                    .FactorItems
                    .Where(x => x.State != Enums.NzItemState.Deleted)
                    .ToList().IndexOf(row);
                onListChanged?.Invoke(this, new ListChangedEventArgs(ListChangedType.ItemAdded, index));
            }
            else
            {
                try
                {
                    row.meqdar += meqdar;


                    var mablaq = row.meqdar * Price; //row.nerkh;
                    var takhfif = row.takhfif_darsad > 0
                                            ? (mablaq * row.takhfif_darsad / 100)
                                            : row.takhfif;
                    row.nerkh   = Price;
                    row.takhfif = takhfif;
                    row.mablaq  = mablaq - takhfif;
                    index       = _Factor
                                    .FactorItems
                                    .Where      (x=>x.State != Enums.NzItemState.Deleted)
                                    .ToList     ()
                                    .IndexOf    (row);

                    row.State   = Enums.NzItemState.Modified;
                    onListChanged?.Invoke(this, new ListChangedEventArgs(ListChangedType.ItemChanged, index));
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }
            }
        }
        #endregion
        #region Misc Methods

        private int         GetNewRowNumber         ()
        {
            if (!_Factor.FactorItems.Any())
                return 0;
            return _Factor
                    .FactorItems
                    .Where(x => x.State != Enums.NzItemState.Deleted)
                    .Max(x=>x.radif);
        }
        private void        ReOrderRowNumber        (int Row)
        {
            var Radif = Row;
            _Factor
                .FactorItems
                .Where          (x=>x.State != Enums.NzItemState.Deleted
                                    && x.radif >= Row )
                .MSZ_ForEach   (x =>
                {
                    x.radif = Radif++;
                    if(x.State != Enums.NzItemState.AddedNew)
                        x.State = Enums.NzItemState.Modified;
                    onListChanged?.Invoke(this, new ListChangedEventArgs(ListChangedType.ItemChanged, x.radif - 1));
                });
        }
        public void         ReOrderRowNumber        ()
        {
            int Radif = 1;

            _Factor
                .FactorItems
                .Where          (x=>x.State!=Enums.NzItemState.Deleted)
                .MSZ_ForEach    (x =>
                {
                    x.radif = Radif++;
                    if (x.State != Enums.NzItemState.AddedNew)
                        x.State = Enums.NzItemState.Modified;
                });
        }
        public  void        MoveUpRow               (int Index) { }
        public  void        MoveDownRow             (int Index) { }
        public  void        MoveUpRow               (FactorItem Item) { }
        public  void        MoveDownRow             (FactorItem Item) { }
        #endregion
    }
}
