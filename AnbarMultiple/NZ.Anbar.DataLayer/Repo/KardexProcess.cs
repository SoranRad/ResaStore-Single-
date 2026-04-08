using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.DataLayer.Context;
using NZ.Anbar.Model;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Anbar.DataLayer.Repo
{
    public static class KardexProcess
    {
        private static string   FormatString = "0,0.##;(0,0.##); ";
        private static string   FormatStringMeqdar = "0.##;(0.##); ";
        
        private static void     MakeRemainLastPrice     (IList<FactorItem> Items, int StartIndex, decimal Price)
        {
            for (int i = StartIndex; i < Items.Count; i++)
            {
                var tmp = Items[i].meqdar * Price;
                if (tmp != Items[i].nerkh_2)
                {
                    Items[i].nerkh_2 = tmp;
                    Items[i].CostDescriptor =
                        $"({Items[i].meqdar.ToString(FormatString)} × {Price.ToString(FormatString)} - {Items[i].FactorHead.Serial} )\n";
                }
            }
        }
        private static void     SetRemainOfInput        (IList<FactorItem> items, int StartIndex)
        {
            for (int i = StartIndex; i < items.Count ; i++)
                items[i].Remain = items[i].meqdar;
        }
        private static void     AddNewFactorItems       (IList<FactorItem> Items, FactorHead Factor, FactorItem Item)
        {
            foreach (var item in Factor
                                    .FactorItems
                                    .Where(x =>    x.ID == 0 
                                                && x.FK_Kala     == Item.FK_Kala ))
            {
                Items.Add(item);
            }
        }


        public  static void     Add                     (StorageContext db, FactorHead Factor, FactorItem Item, List<long> ListDelete)
        {
            var kardex =
                db
                    .FactorItems
                    .Include(x => x.FactorHead)
                    
                    .Where  (x =>
                                (
	                                (
		                                    x.FactorHead.kind           >= 11 
		                                &&  x.FactorHead.kind           < 100 
		                                &&  x.FactorHead.FK_Anbar_Az    == Factor.FK_Anbar_Az
		                            )
                                  ||(
	                                     x.FactorHead.kind          == (byte)Enums.NzFactorKind.EnteqalBeynAnbar 
	                                  && x.FactorHead.FK_Anbar_Be   == Factor.FK_Anbar_Az 
	                                )
                                )
                                &&  x.FK_Kala       == Item.FK_Kala
                                &&  x.FK_Salmali    == Item.FK_Salmali
                            )
                    .ToList ()
                    .Where  (x=>!ListDelete.Contains(x.ID))
                    .ToList ();
             
            AddNewFactorItems   (kardex, Factor, Item);
            CascadeUpdate(kardex,Factor.FK_Anbar_Az.Value);
        }
        public  static void     Update                  (StorageContext db, FactorHead Factor, FactorItem Item, List<long> ListDelete)
        {
            FactorItem oldRow;
            using (var dbTemp = new StorageContext(ConnectionManager.Create(), false))
            {
                oldRow = dbTemp.FactorItems.SingleOrDefault(x => x.ID == Item.ID);
            }

            var kardex =
                db
                    .FactorItems
                    .Include    (x=>x.FactorHead)
                    .Where      (x =>   
	                                (
		                                (
			                                    x.FactorHead.kind >= 11 
			                                &&  x.FactorHead.kind < 100 
			                                &&  x.FactorHead.FK_Anbar_Az == Factor.FK_Anbar_Az
			                            )
		                                ||
		                                (
			                                    x.FactorHead.kind == (byte)Enums.NzFactorKind.EnteqalBeynAnbar 
			                                &&  x.FactorHead.FK_Anbar_Be == Factor.FK_Anbar_Az 
			                            )
	                                ) 
	                                &&  x.FK_Kala       == Item.FK_Kala
	                                &&  x.FK_Salmali    == Item.FK_Salmali
                                )
                    .ToList     ()
                    .Where      (x => !ListDelete.Contains(x.ID))
                    .ToList     ();

            AddNewFactorItems   (kardex, Factor, Item);
            CascadeUpdate       (kardex, Factor.FK_Anbar_Az.Value);

            if ((oldRow != null) && (oldRow.FK_Kala != Item.FK_Kala))
                Delete(db, Factor, oldRow, ListDelete);
        }
        public  static void     Delete                  (StorageContext db, FactorHead Factor, FactorItem Item, List<long> ListDelete)
        {
            var kardex =
                db
                    .FactorItems
                    .Include    (x => x.FactorHead)
                    .Where      (x => 
	                                (
		                                (
			                                    x.FactorHead.kind >= 11 
			                                &&  x.FactorHead.kind < 100 
			                                &&  x.FactorHead.FK_Anbar_Az == Factor.FK_Anbar_Az
			                            )
		                                ||
		                                (
			                                    x.FactorHead.kind           == (byte)Enums.NzFactorKind.EnteqalBeynAnbar 
			                                &&  x.FactorHead.FK_Anbar_Be    == Factor.FK_Anbar_Az 
			                            )
	                                ) 
	                                &&  x.FK_Kala       == Item.FK_Kala
	                                &&  x.ID            != Item.ID
	                                &&  x.FK_Salmali    == Item.FK_Salmali
	                            )
                    .ToList ()
                    .Where  (x => !ListDelete.Contains(x.ID))
                    .ToList ();

            AddNewFactorItems   (kardex, Factor, Item);
            CascadeUpdate( kardex, Factor.FK_Anbar_Az.Value);
        }

        private static void     CascadeUpdate           ( IEnumerable<FactorItem> Items,short FK_Anbar)
        {
            //== لیست ورود ها به انبار
                var InputList = Items
                                .Where      (x =>    (x.FactorHead.kind >= 11 && x.FactorHead.kind < 50 && x.FactorHead.FK_Anbar_Az == FK_Anbar) 
                                                  || (x.FactorHead.kind == (byte)Enums.NzFactorKind.EnteqalBeynAnbar && x.FactorHead.FK_Anbar_Be == FK_Anbar))
                                .OrderBy    (x => x.FactorHead.tarikh.Date)
                                .ThenBy     (x => x.FactorHead.kind)
                                .ThenBy     (x => x.FactorHead.Serial)
                                .ToList     ();
            
            //== لیست خروج ها از انبار
            var OutputList = Items
                                .Where      (x => x.FactorHead.kind >= 50 && x.FactorHead.kind < 100 && x.FactorHead.FK_Anbar_Az == FK_Anbar)
                                .OrderBy    (x => x.FactorHead.tarikh)
                                .ThenBy     (x => x.FactorHead.kind)
                                .ThenBy     (x => x.FactorHead.Serial)
                                .ToList     ();

            /*
             * در صورتی که ورود به انبار داشته باشیم و
             * خروجی نداشته باشیم
             * کلیه مقدار مانده ورودی ها برابر مقدار موجود می شود
             */
            if (InputList.Any()  && OutputList.Count==0)
                SetRemainOfInput(InputList, 0);

            //==اگر ورود یا خروج نداشتیم خارج می شویم
            if (!InputList.Any() || !OutputList.Any())
                return;

            //===  صفر کردن مانده های ورودی برای پردازش از ابتدا
            SetRemainOfInput(InputList, 0);


            var IndexOfIn       = 0;
            var IndexOfOut      = 0;
            var Continue        = false;

            

            decimal ValueOfIn   = InputList[0].meqdar;
            decimal ValueOfOut  = OutputList[0].meqdar;

            

            while (IndexOfOut < OutputList.Count && IndexOfIn < InputList.Count)
            {

	            if (!Continue && OutputList[IndexOfOut].FactorHead.FK_Mabna != null 
	                          && OutputList[IndexOfOut].FactorHead.kind != (byte)Enums.NzFactorKind.HavaleXoruj
	                          )
	            {
		            var rowIn       = InputList
			            .FirstOrDefault
			            (x =>
				            x.Remain > 0 
				            && x.FK_Title == OutputList[IndexOfOut].FactorHead.FK_Mabna
			            );
		            if (rowIn != null)
		            {
			            var rowOut = OutputList[IndexOfOut];
			            var kind = rowIn.FactorHead.kind;

						if (rowOut.meqdar <= rowIn.meqdar)
						{
							rowIn.Remain -= rowOut.meqdar;
							var nerx = (kind == (byte)Enums.NzFactorKind.BargshtFrosh
								? rowIn.nerkh_2
								: rowIn.nerkh) * rowOut.meqdar;
							//====

							if (rowOut.nerkh_2 != nerx)
								rowOut.nerkh_2 = nerx;



							if (InputList.IndexOf(rowIn) == IndexOfIn)
							{
								if (rowIn.Remain <= 0)
								{
									IndexOfIn++;
									if (IndexOfIn >= InputList.Count)
										break;

									ValueOfIn = InputList[IndexOfIn].Remain;
								}
								else
								{
									ValueOfIn = rowIn.Remain;
								}

							}

							IndexOfOut++;
							if (IndexOfOut >= OutputList.Count)
								break;

							ValueOfOut = OutputList[IndexOfOut].meqdar;
							continue;
						}
						else
						{
							var tmp         = rowIn.Remain;
							rowIn.Remain    = 0;
							var nerx        = (kind == (byte)Enums.NzFactorKind.BargshtFrosh
								                    ? rowIn.nerkh_2
								                    : rowIn.nerkh) * tmp;


							rowOut.nerkh_2  = nerx;
							Continue        = true;
							ValueOfOut      -= tmp;

							if (InputList.IndexOf(rowIn) == IndexOfIn)
							{
								IndexOfIn++;
								if (IndexOfIn >= InputList.Count)
									break;
							}

							ValueOfIn = InputList[IndexOfIn].Remain;
						}
					}
	            }

                //مقداری خروج کمتر از مقدار ورود
                if (ValueOfOut < ValueOfIn)
                {
                    ValueOfIn       -= ValueOfOut;
                    InputList[IndexOfIn].Remain = ValueOfIn;

                    var nerx = 
                        InputList[IndexOfIn].FactorHead.kind == (byte) Enums.NzFactorKind.BargshtFrosh
                            ? InputList[IndexOfIn].nerkh_2
                            : InputList[IndexOfIn].nerkh;

                    var row         = OutputList[IndexOfOut];
                    var tmp         = (Continue ? row.nerkh_2 : 0) + ValueOfOut * nerx;

                    if (tmp != row.nerkh_2 || Continue)
                        row.nerkh_2 = tmp;

                    IndexOfOut++;
                    if (IndexOfOut >= OutputList.Count)
                        return;

                    ValueOfOut  = OutputList[IndexOfOut].meqdar;
                    Continue    = false ;
                }
                //مقداری خروج برابر مقدار ورود
                else if (ValueOfOut == ValueOfIn)
                {
                    ValueOfIn   -= ValueOfOut;
                    InputList[IndexOfIn].Remain = ValueOfIn;

                    var nerx = 
                        InputList[IndexOfIn].FactorHead.kind == (byte) Enums.NzFactorKind.BargshtFrosh
                            ? InputList[IndexOfIn].nerkh_2
                            : InputList[IndexOfIn].nerkh;

                    var row     = OutputList[IndexOfOut];
                    var tmp     = (Continue ? row.nerkh_2 : 0) + ValueOfOut * nerx;

                    if (tmp != row.nerkh_2 || Continue)
                        row.nerkh_2 = tmp;


                    IndexOfOut++;
                    if (IndexOfOut >= OutputList.Count)
                        return;

                    IndexOfIn++;
                    if (IndexOfIn >= InputList.Count)
                    {
                        IndexOfIn--;
                        MakeRemainLastPrice( OutputList, IndexOfOut, InputList[IndexOfIn].nerkh);
                        return;
                    }

                    ValueOfOut  = OutputList[IndexOfOut].meqdar;
                    ValueOfIn   = InputList[IndexOfIn].Remain;
                    Continue    = false;
                }
                //مقداری خروج بیشتر از مقدار ورود
                else
                {
                    InputList[IndexOfIn].Remain = 0;
                    var nerx = 
                        InputList[IndexOfIn].FactorHead.kind == (byte) Enums.NzFactorKind.BargshtFrosh
                            ? InputList[IndexOfIn].nerkh_2
                            : InputList[IndexOfIn].nerkh;

                    var row = OutputList[IndexOfOut];
                    var tmp = (Continue ? row.nerkh_2 : 0) + ValueOfIn * nerx;


                    if (tmp != row.nerkh_2 || Continue)
                        row.nerkh_2 = tmp;

                    ValueOfOut -= ValueOfIn;
                    IndexOfIn ++;
                    if (IndexOfIn >= InputList.Count)
                    {
                        IndexOfIn--;
                        nerx = 
                            InputList[IndexOfIn].FactorHead.kind == (byte) Enums.NzFactorKind.BargshtFrosh
                                ? InputList[IndexOfIn].nerkh_2
                                : InputList[IndexOfIn].nerkh;

                        row.nerkh_2         = (Continue ? row.nerkh_2 : 0) + ValueOfOut * nerx;

                        MakeRemainLastPrice( OutputList, IndexOfOut, nerx);
                        return;
                    }

                    ValueOfIn   = InputList[IndexOfIn].Remain;
                    Continue    = true;
                }
            }
        }

        
        public  static void     AddEnteqal              (StorageContext db, FactorHead Factor, FactorItem Item, List<long> ListDelete)
        {
            if(Factor.kind != (byte)Enums.NzFactorKind.EnteqalBeynAnbar)
                return;

            var kardex =
                db
                    .FactorItems
                    .Include(x => x.FactorHead)
                    
                    .Where  (x =>
	                            (
		                              (
			                              x.FactorHead.kind >= 11 
			                              &&  x.FactorHead.kind < 100 
			                              && x.FactorHead.FK_Anbar_Az == Factor.FK_Anbar_Be
			                          )
		                            ||(
			                            x.FactorHead.kind == (byte)Enums.NzFactorKind.EnteqalBeynAnbar 
			                            && x.FactorHead.FK_Anbar_Be == Factor.FK_Anbar_Be 
			                        )
	                            ) 
                                &&  x.FK_Kala       == Item.FK_Kala
                                &&  x.FK_Salmali    == Item.FK_Salmali
                            )
                    .ToList ()
                    .Where  (x=>!ListDelete.Contains(x.ID))
                    .ToList ();
             
            AddNewFactorItems   (kardex, Factor, Item);
            CascadeUpdate(kardex,Factor.FK_Anbar_Be.Value);
        }
        public  static void     UpdateEnteqal           (StorageContext db, FactorHead Factor, FactorItem Item, List<long> ListDelete)
        {
            if(Factor.kind != (byte)Enums.NzFactorKind.EnteqalBeynAnbar)
                return;


            FactorItem oldRow;
            using (var dbTemp = new StorageContext(ConnectionManager.Create(), false))
            {
                oldRow = dbTemp.FactorItems.SingleOrDefault(x => x.ID == Item.ID);
            }

            var kardex =
                db
                    .FactorItems
                    .Include    (x=>x.FactorHead)
                    .Where      (x =>   
	                    (
		                    (
			                    x.FactorHead.kind >= 11 
			                    &&  x.FactorHead.kind < 100 
			                    && x.FactorHead.FK_Anbar_Az == Factor.FK_Anbar_Be
			                )
		                    ||(
			                    x.FactorHead.kind == (byte)Enums.NzFactorKind.EnteqalBeynAnbar 
			                    && x.FactorHead.FK_Anbar_Be == Factor.FK_Anbar_Be 
			                )
	                    ) 
                        &&  x.FK_Kala       == Item.FK_Kala
                        &&  x.FK_Salmali    == Item.FK_Salmali)
                    .ToList     ()
                    .Where      (x => !ListDelete.Contains(x.ID))
                    .ToList     ();

            AddNewFactorItems   (kardex, Factor, Item);
            CascadeUpdate       (kardex, Factor.FK_Anbar_Be.Value);

            if ((oldRow != null) && (oldRow.FK_Kala != Item.FK_Kala))
                DeleteEnteqal(db, Factor, oldRow, ListDelete);
        }
        public  static void     DeleteEnteqal           (StorageContext db, FactorHead Factor, FactorItem Item, List<long> ListDelete)
        {
            if(Factor.kind != (byte)Enums.NzFactorKind.EnteqalBeynAnbar)
                return;


            var kardex =
                db
                    .FactorItems
                    .Include    (x => x.FactorHead)
                    .Where      (x => 
	                    (
		                    (
			                    x.FactorHead.kind >= 11 
			                    &&  x.FactorHead.kind < 100 
			                    && x.FactorHead.FK_Anbar_Az == Factor.FK_Anbar_Be
			                )
		                    ||(
			                    x.FactorHead.kind == (byte)Enums.NzFactorKind.EnteqalBeynAnbar 
			                    && x.FactorHead.FK_Anbar_Be == Factor.FK_Anbar_Be 
			                )
	                    ) 
                        &&  x.FK_Kala       == Item.FK_Kala
                        &&  x.ID            != Item.ID
                        &&  x.FK_Salmali    == Item.FK_Salmali)
                    .ToList ()
                    .Where  (x => !ListDelete.Contains(x.ID))
                    .ToList ();

            AddNewFactorItems   (kardex, Factor, Item);
            CascadeUpdate( kardex, Factor.FK_Anbar_Be.Value);
        }
    }
}
