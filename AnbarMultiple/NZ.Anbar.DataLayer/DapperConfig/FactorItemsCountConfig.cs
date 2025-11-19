using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig
{
    public class FactorItemsCountConfig : DapperEntityConfiguration<FactorItemsCount>
    {
        public FactorItemsCountConfig()
        {
            this.SetItem(this.Item);
        }


        private  string Item = 
            @"SELECT COUNT(tar.ID) AS ItemsCount FROM Anbar.tbl_Amaliat_Riz AS tar";
    }
}
