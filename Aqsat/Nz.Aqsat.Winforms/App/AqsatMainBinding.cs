using Nz.Aqsat.Model.Models;
using ShareLib;
using ShareLib.Utils;
using Stimulsoft.Base.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Control;

namespace Nz.Aqsat.Winforms.App
{
    public class AqsatMainBinding :IBindingList
    {
	    private static readonly log4net.ILog log =
		    log4net
			    .LogManager
			    .GetLogger
				    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
	    #region Fields
	    private ListChangedEventHandler onListChanged;
	    private Aqsat_Main _Aqsat;
		#endregion
		#region constructor
		public AqsatMainBinding(Aqsat_Main Aqsat)
		{
			_Aqsat = Aqsat;
		}
		#endregion
		#region Property
		public int		Count					=> _Aqsat.AqsatRizs.Count(x => x.State != Enums.NzItemState.Deleted);
		public bool		AllowNew				=> true;
		public bool		AllowEdit				=> true;
		public bool		AllowRemove				=> true;
		public object	SyncRoot				=> throw new NotImplementedException();
		public bool		IsSorted				=> true;
		
		public bool		IsSynchronized			=> false;
		public bool		IsReadOnly				=> false;
		public bool		IsFixedSize				=> false;

		public bool		SupportsChangeNotification=> true;
		public bool		SupportsSearching		=> true;
		public bool		SupportsSorting			=> false;

		public PropertyDescriptor				SortProperty	{ get; }
		public ListSortDirection				SortDirection	{ get; }
		public event ListChangedEventHandler	ListChanged;
		#endregion
		#region Methods
		public object this[int index]
		{
			get
			{
				var list = _Aqsat.AqsatRizs.Where(x => x.State != Enums.NzItemState.Deleted).OrderBy(x => x.Radif);
				return index < list.Count()
					? list.ToList()[index]
					: null;
			}
			set
			{
				var list = _Aqsat.AqsatRizs.Where(x => x.State != Enums.NzItemState.Deleted).OrderBy(x => x.Radif);
				if (index < list.Count())
					list.ToList()[index] = (Aqsat_Riz)value;
			}
			//=> _Factor.FactorItems.Where(x => x.State != Enums.NzItemState.Deleted).ToList()[index] =(FactorItem) value;
		}
		public int		Add					(object value)
		{
			var item = (Aqsat_Riz)value;
			if (item == null)
				return -1;
			item.State = Enums.NzItemState.AddedNew;
			item.FK_Main = _Aqsat.ID;
			item.AqsatMain = _Aqsat;
			_Aqsat.AqsatRizs.Add(item);
			return 0;
		}
		public bool		Contains			(object value)
		{
			if (value is Aqsat_Riz row)
			{
				_Aqsat
					.AqsatRizs
					.Any(
						x => x.State != Enums.NzItemState.Deleted && x == row);
			}
			return false;
		}
		public void		Clear				()
		{
			_Aqsat.AqsatRizs.Where(x=>x.CanModifyOrDelete).MSZ_ForEach(x =>
			{
				x.State = Enums.NzItemState.Deleted;
			});
		}
		public int		IndexOf				(object value)
		{
			var i = (Aqsat_Riz)value;
			return _Aqsat.AqsatRizs.Where(x => x.State != Enums.NzItemState.Deleted).OrderBy(x => x.Radif).ToList().IndexOf(i);
		}
		public void		Insert				(int index, object value)
		{
			throw new NotImplementedException();
		}
		public void		Remove				(object value)
		{
			var i = (Aqsat_Riz)value;
			if (i.ID == 0)
				_Aqsat.AqsatRizs.Remove(i);
			else
				i.State = Enums.NzItemState.Deleted;

			ReOrderRowNumber((i.Radif));
		}
		public void		RemoveAt			(int index)
		{
			var i = _Aqsat.AqsatRizs.Where(x => x.State != Enums.NzItemState.Deleted).OrderBy(x => x.Radif).ToList()[index];
			if (i.ID == 0)
				_Aqsat.AqsatRizs.Remove(i);
			else
				i.State = Enums.NzItemState.Deleted;

			ReOrderRowNumber();
		}
		
		public object	AddNew				()
		{
			var sarResid = _Aqsat.StartDate.AddDays( _Aqsat.DoreQest * (Count + 1));

			var r = new Aqsat_Riz();
			r.State = Enums.NzItemState.AddedNew;
			r.Radif = (byte)(GetNewRowNumber() + 1);
			r.FK_Main = _Aqsat.ID;
			r.AqsatMain = _Aqsat;
			r.tarixQest = sarResid;
			r.PersianTarixQest = sarResid.ToPersianDate();
			_Aqsat.AqsatRizs.Add(r);
			return r;
		}
		public void		AddIndex			(PropertyDescriptor property)
		{
			 
		}
		public void		ApplySort			(PropertyDescriptor property, ListSortDirection direction)
		{
			 
		}
		public int		Find				(PropertyDescriptor property, object key)
		{
			throw new NotImplementedException();
		}
		public void		RemoveIndex			(PropertyDescriptor property)
		{
			 
		}
		public void		RemoveSort			()
		{
			 
		}
		public void		CopyTo				(Array array, int index)
		{
			array = _Aqsat.AqsatRizs.ToArray();
		}
		#endregion
		#region Misc
		private void	ReOrderRowNumber	(int Row)
		{
			ReOrderRowNumber();
		}
		public void		ReOrderRowNumber	()
		{
			byte Radif = 1;

			_Aqsat
				.AqsatRizs
				.Where(x => x.State != Enums.NzItemState.Deleted)
				.OrderBy(x => x.Radif)
				.MSZ_ForEach(x =>
				{
					if (x.Radif != Radif)
					{
						x.Radif = Radif++;

						if (x.State != Enums.NzItemState.AddedNew)
							x.State = Enums.NzItemState.Modified;

						onListChanged?.Invoke(this, new ListChangedEventArgs(ListChangedType.ItemChanged, x.Radif - 1));
					}
					else
					{
						Radif++;
					}

				});
		}
		public int		GetNewRowNumber		()
		{
			if (!_Aqsat.AqsatRizs.Any())
				return 0;
			return _Aqsat.AqsatRizs
				.Where(x => x.State != Enums.NzItemState.Deleted)
				.Max(x => x.Radif);
		}

		#endregion
		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}
    }
}
