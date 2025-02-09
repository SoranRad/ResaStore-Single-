using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.Models;

namespace NZ.General.DataLayer.DapperConfig
{
    public class CompanyConfig : DapperEntityConfiguration<Company>
    {
        public CompanyConfig()
        {
            SetItem(@"
SELECT 
	   ti.ID ,
       ltrim(Rtrim(ti.Code ))           AS Code,
       ltrim(Rtrim(ti.title ))          AS title,
       ltrim(Rtrim(ti.tarikh ))         AS tarikh,
       ltrim(Rtrim(ti.modir ))          AS modir,
       ltrim(Rtrim(ti.molahezat ))      AS molahezat,
       ltrim(Rtrim(ti.address ))        AS address,
       ltrim(Rtrim(ti.tel ))            AS tel,
       ltrim(Rtrim(ti.mobile ))         AS mobile,
       ltrim(Rtrim(ti.fax ))            AS fax,
       ltrim(Rtrim(ti.code_posti ))     AS code_posti,
       ltrim(Rtrim(ti.code_melli))      AS code_melli,
       ltrim(Rtrim(ti.code_eqtesadi))   AS code_eqtesadi,
       ltrim(Rtrim(ti.tel2 ))           AS tel2,
       ltrim(Rtrim(ti.mobile2 ))        AS mobile2,
       ltrim(Rtrim(ti.email ))          AS email,
       ltrim(Rtrim(ti.website ))        AS website,
       ti.logo ,
       ti.mohr 
	   
FROM General.tbl_Info AS ti
WHERE ti.ID=@ID

");
        }
    }
}
