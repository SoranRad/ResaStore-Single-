using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Machine.Model.Model;
using ShareLib.Interfaces;

namespace Nz.Machine.DataLayer.DapperConfig
{
    public class AcceptMachineConfig : DapperEntityConfiguration<AcceptMachine>
    {
        public AcceptMachineConfig()
        {
            SetList(@"

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
       tam.BenzinPic,
       LTRIM(RTRIM(tam.CustomerRequest))    AS CustomerRequest,
       LTRIM(RTRIM(tam.Descipt))            AS Descipt,
       LTRIM(RTRIM(ta.title))               AS PeopleTitle,
	   dd.PersianStr,
	   dd.PersianMonthNo
	   

FROM        Machine.tbl_AcceptMachine   AS tam
INNER JOIN  Base.tbl_Ashxas             AS ta   ON ta.ID            = tam.FK_People
INNER JOIN  General.DimDate             AS dd   ON tam.TarixAccept  = dd.GregorianDate

");
        }
    }
}
