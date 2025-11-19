using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;

namespace Nz.Anbar.Model.Report
{
    public class BarcodeUnique : ICodeEntity
    {
        public string GenerateCode()
        {
            return "";
        }

        public string UniqueCode()
        {
            return @"

SELECT  COUNT(tkx.ID)
FROM Base.tbl_Kala_Xadamat AS tkx
WHERE  LTRIM(RTRIM(tkx.barcode)) = @BarCode

";
        }
    }
}
