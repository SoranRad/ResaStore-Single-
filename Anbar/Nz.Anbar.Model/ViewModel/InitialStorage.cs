using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using ShareLib.Interfaces;

namespace Nz.Anbar.Model.ViewModel
{
    [NotMapped]
    public class InitialStorage : FactorHead, ISqlQueryMaker
    {
        public string GetItem()
        {
            return @"
SELECT TOP(1)tat.ID FROM Anbar.tbl_Amaliat_Title AS tat
WHERE tat.kind=@Kind AND tat.FK_Salmali =@Year
";
        }

        public string GetList()
        {
            throw new NotImplementedException();
        }
    }
}
