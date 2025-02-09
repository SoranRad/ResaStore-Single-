using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using ShareLib.Interfaces;

namespace Nz.Anbar.Model.Model
{
    public class ObjectImages : ISqlQueryMaker
    {
        public ObjectImages()
        {
            Objects = new HashSet<NzObject>();
        }

        public long                     ID                  { get; set; }
        public byte[]                   Image               { get; set; }


        public ICollection<NzObject>    Objects             { get; set; }
        
        public string   GetItem     ()
        {
            return @"
                    SELECT 
		                    ti.ID,
		                    ti.Image 

                    FROM General.tbl_Image AS ti
                    WHERE ti.ID = @ID
            ";

        }
        public string   GetList     ()
        {
            return @"
                     SELECT 
		                    ti.ID,
                            ti.Image 
		                    
                     FROM Base.tbl_Kala_Xadamat     AS tkx
                     INNER JOIN General.tbl_Image   AS ti   ON ti.ID = tkx.FK_Image
            ";
        }
    }
}
