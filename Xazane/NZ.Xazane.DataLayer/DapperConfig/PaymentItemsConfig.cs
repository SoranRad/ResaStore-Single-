using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Models;
using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig
{
    public class PaymentItemsConfig : DapperEntityConfiguration<PaymentItems>
    {
        private string Item =
            @"  
                SELECT SUM(ItemsCount) AS ItemsCount
                FROM
                (
                    SELECT COUNT(tac.ID) AS ItemsCount FROM Xazane.tbl_Amaliat_Check AS tac
                        UNION ALL
                        SELECT COUNT(tax.ID) AS ItemsCount FROM Xazane.tbl_Amaliat_Xazaneh AS tax
                )AS Sub
            ";

        public PaymentItemsConfig()
        {
            this.SetItem(Item);
        }
    }
}
