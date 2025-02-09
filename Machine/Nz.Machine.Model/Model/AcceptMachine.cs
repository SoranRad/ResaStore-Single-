using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.Models;

namespace Nz.Machine.Model.Model
{
    public class AcceptMachine : ISqlQueryMaker, ICodeEntity
    {
        public Guid     ID                  { get; set; }
        public long     FK_People           { get; set; }
        public short    FK_Salmali          { get; set; }
        public int      Shomare             { get; set; }
        public DateTime TarixAccept         { get; set; }
        public TimeSpan TimeAccept          { get; set; }
        public string   Mobile              { get; set; }
        public string   HomeAddress         { get; set; }
        public string   Job                 { get; set; }
        public string   WorkAddress         { get; set; }

        public string   Plak                { get; set; }
        public string   KindMachine         { get; set; }
        public decimal  Kilometer           { get; set; }
        public string   MachineColor        { get; set; }
        public string   ShomareShasi        { get; set; }
        public string   ShomareMotor         { get; set; }

        public bool     LastikYadak         { get; set; }
        public bool     AcharCharx          { get; set; }
        public bool     Jak                 { get; set; }
        public bool     Radio               { get; set; }
        public bool     Panel               { get; set; }
        public bool     Fandak              { get; set; }
        public bool     DozdGir             { get; set; }
        public bool     Anten               { get; set; }
        public bool     Ghalbagh            { get; set; }
        public bool     GhoflRing           { get; set; }
        public bool     MosalaXatar         { get; set; }
        public bool     GhoflFarman         { get; set; }
        public bool     GhoflPedal          { get; set; }

        public byte     Gas                 { get; set; }
        public decimal  Benzin              { get; set; }

        public string   CustomerRequest     { get; set; }
        public string   Descipt             { get; set; }

        public byte[]   BenzinPic           { get; set; }

        public Image    BenzinImage
        {
            get
            {
                if (BenzinPic == null)
                    return null;

                MemoryStream ms = new MemoryStream(BenzinPic);
                return Image.FromStream(ms);
            }
        }

        [NotMapped]
        public string   PeopleTitle         { get; set; }
        [NotMapped]
        public string   PersianStr          { get; set; }
        [NotMapped]
        public byte     PersianMonthNo      { get; set; }

        [NotMapped] public string Saat => new DateTime(this.TimeAccept.Ticks).ToString("HH:mm");

        public string GetItem()
        {
            return $@"

SELECT 
	   tam.ID,
       LTRIM(RTRIM(tam.Shomare))        AS Shomare,
       tam.TarixAccept,
       tam.TimeAccept,
       LTRIM(RTRIM(tam.Mobile))         AS Mobile,
       tam.FK_People,
       LTRIM(RTRIM(tam.HomeAddress))    AS HomeAddress,
       LTRIM(RTRIM(tam.Job))            AS Job,
       LTRIM(RTRIM(tam.WorkAddress))    AS WorkAddress,
       LTRIM(RTRIM(tam.Plak))           AS Plak,
       LTRIM(RTRIM(tam.KindMachine))    AS KindMachine,
       tam.Kilometer,
       LTRIM(RTRIM(tam.MachineColor))   AS MachineColor,
       LTRIM(RTRIM(tam.ShomareShasi))   AS ShomareShasi,
       LTRIM(RTRIM(tam.ShomareMotor))   AS ShomareMotor,
       tam.LastikYadak,
       tam.AcharCharx,
       tam.Jak,
       tam.Radio,
       tam.Panel,
       tam.Fandak,
       tam.DozdGir,
       tam.Anten,
       tam.Ghalbagh,
       tam.GhoflRing,
       tam.MosalaXatar,
       tam.GhoflFarman,
       tam.GhoflPedal,
       tam.Gas,
       tam.BenzinPic,
       tam.Benzin,
       LTRIM(RTRIM(tam.CustomerRequest))    AS CustomerRequest,
       LTRIM(RTRIM(tam.Descipt))            AS Descipt,
       LTRIM(RTRIM(ta.title))               AS PeopleTitle,
	   dd.PersianStr,
	   dd.PersianMonthNo
	   

FROM        Machine.tbl_AcceptMachine   AS tam
INNER JOIN  Base.tbl_Ashxas             AS ta   ON ta.ID            = tam.FK_People
INNER JOIN  General.DimDate             AS dd   ON tam.TarixAccept  = dd.GregorianDate

WHERE 
        tam.ID = @ID
";
        }

        public string GetList()
        {
            return $@"
SELECT 
	   tam.ID,
       LTRIM(RTRIM(tam.Shomare))        AS Shomare,
       tam.TarixAccept,
       tam.TimeAccept,
       LTRIM(RTRIM(tam.Mobile))         AS Mobile,
       tam.FK_People,
       LTRIM(RTRIM(tam.HomeAddress))    AS HomeAddress,
       LTRIM(RTRIM(tam.Job))            AS Job,
       LTRIM(RTRIM(tam.WorkAddress))    AS WorkAddress,
       LTRIM(RTRIM(tam.Plak))           AS Plak,
       LTRIM(RTRIM(tam.KindMachine))    AS KindMachine,
       tam.Kilometer,
       LTRIM(RTRIM(tam.MachineColor))   AS MachineColor,
       LTRIM(RTRIM(tam.ShomareShasi))   AS ShomareShasi,
       LTRIM(RTRIM(tam.ShomareMotor))   AS ShomareMotor,
       tam.LastikYadak,
       tam.AcharCharx,
       tam.Jak,
       tam.Radio,
       tam.Panel,
       tam.Fandak,
       tam.DozdGir,
       tam.Anten,
       tam.Ghalbagh,
       tam.GhoflRing,
       tam.MosalaXatar,
       tam.GhoflFarman,
       tam.GhoflPedal,
       tam.Gas,
       tam.Benzin,
       LTRIM(RTRIM(tam.CustomerRequest))    AS CustomerRequest,
       LTRIM(RTRIM(tam.Descipt))            AS Descipt,
       LTRIM(RTRIM(ta.title))               AS PeopleTitle,
	   dd.PersianStr,
	   dd.PersianMonthNo
	   

FROM        Machine.tbl_AcceptMachine   AS tam
INNER JOIN  Base.tbl_Ashxas             AS ta   ON ta.ID            = tam.FK_People
INNER JOIN  General.DimDate             AS dd   ON tam.TarixAccept  = dd.GregorianDate

WHERE 
        tam.FK_Salmali = @Year 
    AND (dd.PersianMonthNo= @Month OR @Month=13)
";
        }

        public string GenerateCode()
        {
            return $@"
SELECT MAX(tam.Shomare) FROM Machine.tbl_AcceptMachine AS tam
WHERE tam.FK_Salmali = @Year
";

        }

        public string UniqueCode()
        {
            return $@"
SELECT COUNT(tam.Shomare) FROM Machine.tbl_AcceptMachine AS tam
WHERE tam.Shomare = @Shomare AND tam.FK_Salmali = @Year
";

        }

        [NotMapped]
        public bool Light1 => this.Gas >= 1;
        [NotMapped]
        public bool Light2 => this.Gas >= 2;
        [NotMapped]
        public bool Light3 => this.Gas >= 3;
        [NotMapped]
        public bool Light4 => this.Gas >= 4;
        [NotMapped]
        public bool Light5 => this.Gas >= 5;
        [NotMapped]
        public bool Light6 => this.Gas >= 6; 


    }
}
