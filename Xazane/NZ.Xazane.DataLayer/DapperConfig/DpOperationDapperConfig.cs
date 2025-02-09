using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Models;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig
{
    public class DpOperationDapperConfig : DapperEntityConfiguration<DPOperation>
    {
        public DpOperationDapperConfig()
        {
            this.SetMaxSerial(@"
SELECT MAX(tad.serial) FROM Xazane.tbl_Amaliat_DP AS tad
WHERE tad.kind = @Kind AND tad.FK_Salmali = @Year");

            this.SetCodeUnique(@"
SELECT COUNT(tad.ID) FROM Xazane.tbl_Amaliat_DP AS tad
WHERE tad.kind =@Kind AND tad.FK_Salmali = @Year  AND tad.serial=@Serial
");

            this.SetItem(@"
SELECT tad.ID ,
       tad.FK_Salmali ,
       tad.FK_User_Add ,
       tad.FK_User_Edit ,
       tad.FK_Faktor ,
       tad.FK_ShaXs ,
       tad.FK_ShaXs_Enteqal ,
       tad.FK_Qest_Main ,
       tad.FK_Qest_Riz ,
       tad.serial ,
       tad.takhfif ,
       tad.kind ,
       tad.tarikh ,
       tad.tarikh_add ,
       tad.tarikh_edit ,
       LTRIM(RTRIM(tad.sharh )) sharh,
       tad.is_ok 
	   
FROM Xazane.tbl_Amaliat_DP AS tad
WHERE tad.ID=@ID;

SELECT tax.ID ,
       tax.FK_Salmali ,
       tax.FK_Xazaneh_Bad ,
       tax.FK_Xazaneh_Bas ,
       tax.FK_DP ,
       tax.FK_User_Add ,
       tax.FK_User_Edit ,
       tax.serialPeygiri ,
       tax.serial ,
       tax.mablaq ,
      LTRIM(RTRIM(tax.sharh )) sharh,
       tax.kind ,
       tax.tarikh ,
       tax.tarikh_add ,
       tax.tarikh_edit,
	   LTRIM(RTRIM(CreditAccount.title ))  AS CreditAccountTitle,
	   LTRIM(RTRIM(DebitAccount.title ))   AS DebitAccountTitle
FROM Xazane.tbl_Amaliat_Xazaneh AS tax
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh AS DebitAccount ON DebitAccount.ID = tax.FK_Xazaneh_Bad
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh AS CreditAccount ON CreditAccount.ID = tax.FK_Xazaneh_Bas

WHERE tax.FK_DP=@ID;

SELECT tac.ID ,
       tac.FK_Bank ,
       tac.FK_Hesab_Pardaxtani ,
       tac.FK_Daste_Cheque ,
       tac.FK_DP ,
       tac.FK_User_Add ,
       tac.FK_User_Edit ,
       tac.tarikh_sar_resid ,
       tac.kind ,
       tac.mablaq ,
       LTRIM(RTRIM(tac.shomare_check)) AS  shomare_check,
       LTRIM(RTRIM(tac.babat )) AS babat,
       tac.tarikh_add ,
       tac.tarikh_edit ,
       tac.is_ok ,
       tac.FK_Salmali_Vaziat ,
       tac.FK_Xazaneh_Vaziat ,
       tac.FK_Shaxs_Vaziat ,
       tac.FK_User_Add_Vaziat ,
       tac.FK_User_Edit_Vaziat ,
       tac.Kind_Vaziat ,
       tac.Tarix_Vaziat ,
       tac.Tarix_Edit_Vaziat ,
       tac.Tarix_Add_Vaziat ,
       LTRIM(RTRIM(tac.Sharh_Vaziat))	AS Sharh_Vaziat,
	   dd.PersianStr					AS PersianUsanceStr,
	   LTRIM(RTRIM(thx.title))			AS PayAccountTitle,
	   LTRIM(RTRIM(tb.title))			AS BankTitle

	   
FROM Xazane.tbl_Amaliat_Check				AS tac
LEFT OUTER JOIN General.DimDate				AS dd	ON dd.GregorianDate = tac.tarikh_sar_resid
LEFT OUTER JOIN Base.tbl_Bank				AS tb	ON tb.ID = tac.FK_Bank
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thx	ON thx.ID = tac.FK_Hesab_Pardaxtani

WHERE tac.FK_DP=@ID;
");
        }
    }
}
