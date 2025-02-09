using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;

namespace ShareLib.ViewModel
{
    public class PeopleDocument :ISqlQueryMaker
    {
        public byte[] Sign      { get; set; }
        public byte[] Pic       { get; set; }
        public byte[] Warranty  { get; set; }

        public string GetItem()
        {
            return @"
SELECT 

ImgSign.Image		AS Sign,
ImgPic.Image		AS Pic,
ImgWarranty.Image	AS Warranty

FROM Base.tbl_Ashxas AS ta

LEFT OUTER JOIN General.tbl_Image AS ImgSign		ON ImgSign.ID		= ta.FK_Image_Emza
LEFT OUTER JOIN General.tbl_Image AS ImgPic			ON ImgPic.ID		= ta.FK_Image_Tasvir
LEFT OUTER JOIN General.tbl_Image AS ImgWarranty	ON ImgWarranty.ID	= ta.FK_Image_Zemanat

WHERE ta.ID = @ID
";
        }
        public string GetList()
        {
            return @"";
        }
    }
}
