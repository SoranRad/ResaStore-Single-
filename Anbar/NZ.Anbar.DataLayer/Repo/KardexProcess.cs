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
        private static void     MakeRemainLastPrice     (StorageContext db, IList<FactorItem> Items,int StartIndex, decimal Price)
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
                                                && x.FK_Kala     == Item.FK_Kala 
                                                && x.FK_Anbar_Az == Item.FK_Anbar_Az))
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
                                    x.FactorHead.kind >= 11 
                                &&  x.FactorHead.kind < 100
                                &&  x.FK_Anbar_Az   == Item.FK_Anbar_Az
                                &&  x.FK_Kala       == Item.FK_Kala
                                &&  x.FK_Salmali    == Item.FK_Salmali)
                    .ToList ()
                    .Where  (x=>!ListDelete.Contains(x.ID))
                    .ToList ();
             
            AddNewFactorItems   (kardex, Factor, Item);
            CascadeUpdate(db,kardex);
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
                    .Where      (x =>   x.FK_Anbar_Az   == Item.FK_Anbar_Az
                                    &&  x.FK_Kala       == Item.FK_Kala
                                    &&  x.FK_Salmali    == Item.FK_Salmali)
                    .ToList     ()
                    .Where      (x => !ListDelete.Contains(x.ID))
                    .ToList     ();

            AddNewFactorItems   (kardex, Factor, Item);
            CascadeUpdate       (db,     kardex);

            if ((oldRow != null) && (oldRow.FK_Kala != Item.FK_Kala || oldRow.FK_Anbar_Az != Item.FK_Anbar_Az))
                Delete(db, Factor, oldRow, ListDelete);
        }
        public  static void     Delete                  (StorageContext db, FactorHead Factor, FactorItem Item, List<long> ListDelete)
        {
            var kardex =
                db
                    .FactorItems
                    .Include    (x => x.FactorHead)
                    .Where      (x =>       x.FK_Anbar_Az   == Item.FK_Anbar_Az
                                        &&  x.FK_Kala       == Item.FK_Kala
                                        &&  x.ID            != Item.ID
                                        &&  x.FK_Salmali    == Item.FK_Salmali)
                    .ToList ()
                    .Where  (x => !ListDelete.Contains(x.ID))
                    .ToList ();

            AddNewFactorItems   (kardex, Factor, Item);
            CascadeUpdate(db,  kardex);
        }

        private static void     CascadeUpdate           (StorageContext db, IEnumerable<FactorItem> Items)
        {
            //== لیست ورود ها به انبار
            var InputList = Items
                                .Where      (x => x.FactorHead.kind >= 11 && x.FactorHead.kind < 50)
                                .OrderBy    (x => x.FactorHead.tarikh.Date)
                                .ThenBy     (x => x.FactorHead.kind)
                                .ThenBy     (x => x.FactorHead.Serial)
                                .ToList     ();
            //== لیست خروج ها به انبار

            var OutputList = Items
                                .Where      (x => x.FactorHead.kind >= 50 && x.FactorHead.kind < 100)
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
            //for (int i = 0; i < InputList.Count; i++)
            //    InputList[i].Remain = InputList[i].meqdar;
            SetRemainOfInput(InputList, 0);


            var IndexOfIn       = 0;
            var IndexOfOut      = 0;
            var Continue        = false;

            

            decimal ValueOfIn   = InputList[0].meqdar;
            decimal ValueOfOut  = OutputList[0].meqdar;

            

            while (IndexOfOut < OutputList.Count && IndexOfIn < InputList.Count)
            {
                // در صورتی که فاکتور مرجع مشخص شده باشد.
                // برای فاکتور فروش
                if (!Continue && OutputList[IndexOfOut].FactorHead.FK_Mabna != null)
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

                        rowIn.Remain    -= rowOut.meqdar;
                        rowIn.Remain    = rowIn.Remain < 0 ? 0 : rowIn.Remain;
                        
                        var kind        = rowIn.FactorHead.kind;
                        var nerx        = ( kind == (byte)Enums.NzFactorKind.BargshtFrosh
                                           ? rowIn.nerkh_2
                                           : rowIn.nerkh ) * rowOut.meqdar;

                        var CostDescriptor = "";
                        if (kind == (byte)Enums.NzFactorKind.BargshtFrosh)
                            CostDescriptor = $"{rowIn.FactorHead.Serial}.ب\n";
                        else if (kind == (byte)Enums.NzFactorKind.AvalDore)
                            CostDescriptor = $"{rowIn.CostDescriptor}.س.ق\n";
                        else
                            CostDescriptor = $"{rowIn.FactorHead.Serial}\n";

                        //====

                        if(rowOut.nerkh_2 != nerx)
                            rowOut.nerkh_2 = nerx;

                        if(rowOut.CostDescriptor != CostDescriptor)
                            rowOut.CostDescriptor = CostDescriptor;

                        //====

                        IndexOfOut ++;
                        ValueOfOut = OutputList[IndexOfOut].meqdar;
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

                    var kind            = InputList[IndexOfIn].FactorHead.kind ;
                    var CostDescriptor  = "";
                    if (kind == (byte) Enums.NzFactorKind.BargshtFrosh)
                        CostDescriptor = $"{InputList[IndexOfIn].FactorHead.Serial}.ب\n";
                    else if (kind == (byte)Enums.NzFactorKind.AvalDore)
                        CostDescriptor = $"{InputList[IndexOfIn].CostDescriptor}.س.ق\n";
                    else 
                        CostDescriptor = $"{InputList[IndexOfIn].FactorHead.Serial}\n";
                    
                    var row         = OutputList[IndexOfOut];
                    var tmp         = (Continue ? row.nerkh_2 : 0) + ValueOfOut * nerx;

                    if (tmp != row.nerkh_2 || Continue)
                        row.nerkh_2 = tmp;

                    row.CostDescriptor = (Continue ? row.CostDescriptor + " , " : string.Empty) + CostDescriptor;

                    IndexOfOut++;
                    if (IndexOfOut >= OutputList.Count)
                    {
                        return;
                    }

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

                    var kind = InputList[IndexOfIn].FactorHead.kind;
                    var CostDescriptor = "";

                    if (kind == (byte)Enums.NzFactorKind.BargshtFrosh)
                        CostDescriptor = $"{InputList[IndexOfIn].FactorHead.Serial}.ب\n";

                    else if (kind == (byte)Enums.NzFactorKind.AvalDore)
                        CostDescriptor = $"{InputList[IndexOfIn].CostDescriptor}.س.ق\n";
                    else
                        CostDescriptor = $"{InputList[IndexOfIn].FactorHead.Serial}\n";

                    
                    var row     = OutputList[IndexOfOut];
                    var tmp     = (Continue ? row.nerkh_2 : 0) + ValueOfOut * nerx;

                    if (tmp != row.nerkh_2 || Continue)
                        row.nerkh_2 = tmp;

                    row.CostDescriptor = (Continue ? row.CostDescriptor + " , " : string.Empty) + CostDescriptor;


                    IndexOfOut++;
                    if (IndexOfOut >= OutputList.Count)
                    {
                        return;
                    }

                    IndexOfIn++;
                    if (IndexOfIn >= InputList.Count)
                    {
                        IndexOfIn--;
                        MakeRemainLastPrice(db, OutputList, IndexOfOut, InputList[IndexOfIn].nerkh);
                        return;
                    }

                    ValueOfOut  = OutputList[IndexOfOut].meqdar;
                    ValueOfIn   = InputList[IndexOfIn].meqdar;
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

                    var kind = InputList[IndexOfIn].FactorHead.kind;
                    var CostDescriptor = "";

                    if (kind == (byte)Enums.NzFactorKind.BargshtFrosh)
                        CostDescriptor = $"{InputList[IndexOfIn].FactorHead.Serial}.ب\n";
                    else if (kind == (byte)Enums.NzFactorKind.AvalDore)
                        CostDescriptor = $"{InputList[IndexOfIn].CostDescriptor}.س.ق\n";
                    else
                        CostDescriptor = $"{InputList[IndexOfIn].FactorHead.Serial}\n";

                    if (tmp != row.nerkh_2 || Continue)
                        row.nerkh_2 = tmp;

                    row.CostDescriptor = (Continue ? row.CostDescriptor + " , " : string.Empty) + CostDescriptor;

                    ValueOfOut -= ValueOfIn;
                    IndexOfIn ++;
                    if (IndexOfIn >= InputList.Count)
                    {
                        IndexOfIn--;
                        nerx = 
                            InputList[IndexOfIn].FactorHead.kind == (byte) Enums.NzFactorKind.BargshtFrosh
                                ? InputList[IndexOfIn].nerkh_2
                                : InputList[IndexOfIn].nerkh;

                        if (kind == (byte)Enums.NzFactorKind.BargshtFrosh)
                            CostDescriptor = $"{InputList[IndexOfIn].FactorHead.Serial}.ب\n";
                        else if (kind == (byte)Enums.NzFactorKind.AvalDore)
                            CostDescriptor = $"{InputList[IndexOfIn].CostDescriptor}.س.ق\n";
                        else
                            CostDescriptor = $"{InputList[IndexOfIn].FactorHead.Serial}\n";
                        
                        row.nerkh_2         = (Continue ? row.nerkh_2 : 0) + ValueOfOut * nerx;
                        row.CostDescriptor  = (Continue ? row.CostDescriptor + " , " : string.Empty) + CostDescriptor;

                        MakeRemainLastPrice(db, OutputList, IndexOfOut, nerx);
                        return;
                    }

                    ValueOfIn   = InputList[IndexOfIn].meqdar;
                    Continue    = true;
                }
            }
        }

    }
}
