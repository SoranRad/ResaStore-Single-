using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Print_Dialog;
using Nz.Machine.DataLayer.Repo;
using Nz.Machine.Model.Model;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Machine.Winforms
{
    public class Print
    {
        private List<Guid>               _ListIDs;
        private Enums.NzKindPrint        _PrintKind;
        private Print_Dialog             _PrintDiag;
        private List<MS_Report_Loading>  _ListReport;
        private string                   _ReportPath;
        private MSWait                   FrmWait = new MSWait();

        public Print    (Guid Id,        Enums.NzKindPrint Kind)
        {
            FrmWait.Show();
            Application.DoEvents(); 
            _PrintKind = Kind;
            _ListIDs = new List<Guid>() { Id };
            SetPrintFile();
            Load();
        }
        public Print    (List<Guid> Ids, Enums.NzKindPrint Kind)
        {
            FrmWait.Show();
            Application.DoEvents();
            _PrintKind = Kind;
            _ListIDs = Ids;
            SetPrintFile();
            Load();
        }
        
        private void    SetPrintFile    ()
        {
            _ReportPath  = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _ReportPath += "\\Print\\Machine\\";
            switch (_PrintKind)
            {
                case Enums.NzKindPrint.PaperA4:
                    _ReportPath += "AcceptMachineA4.mrt";
                    break;
                case Enums.NzKindPrint.PaperA5:
                    _ReportPath += "AcceptMachineA5.mrt";
                    break;
            }
        }
        private void    Load            ()
        {
            try
            {
                var report = new ReportRepository(ConnectionManager.Create());

                var strWhere =  " WHERE " + string.Join(" OR ", _ListIDs.Select(x => " tam.ID = '" + x +"' "));

                var forms = report.List<AcceptMachine>(null, strWhere);
                
                if (forms == null)
                    throw new Exception();

                _ListReport =
                    forms
                        .Select(x=> new MS_Report_Loading
                        {
                            Report_Address =_ReportPath,
                            BusinessObject_Name = "",
                            List_Data = null,
                            List_Parametter = new Dictionary<string, object>()
                                   {
                                       {"company"           , SystemConstant.ActiveCompany.title},
                                       {"Shomare"           , x.Shomare},
                                       {"PeopleTitle"       , x.PeopleTitle},
                                       {"PersianStr"        , x.PersianStr},
                                       {"Saat"              , x.Saat},
                                       {"Mobile"            , x.Mobile},
                                       {"HomeAddress"       , x.HomeAddress},
                                       {"Job"               , x.Job},
                                       {"WorkAddress"       , x.WorkAddress},
                                                            
                                       {"Plak"              , x.Plak},
                                       {"KindMachine"       , x.KindMachine},
                                       {"Kilometer"         , x.Kilometer},
                                       {"MachineColor"      , x.MachineColor},
                                       {"ShomareShasi"      , x.ShomareShasi},
                                       {"ShomareMotor"      , x.ShomareMotor},

                                       {"LastikYadak"       , x.LastikYadak},
                                       {"AcharCharx"        , x.AcharCharx},
                                       {"Jak"               , x.Jak},
                                       {"Radio"             , x.Radio},
                                       {"Panel"             , x.Panel},
                                       {"Fandak"            , x.Fandak},
                                       {"DozdGir"           , x.DozdGir},
                                       {"Anten"             , x.Anten},
                                       {"Ghalbagh"          , x.Ghalbagh},
                                       {"GhoflRing"         , x.GhoflRing},
                                       {"MosalaXatar"       , x.MosalaXatar},
                                       {"GhoflFarman"       , x.GhoflFarman},
                                       {"GhoflPedal"        , x.GhoflPedal}, 
                                        
                                       {"CustomerRequest"   , x.CustomerRequest},
                                       {"Descipt"           , x.Descipt},

                                       {"Light1"            , x.Light1},
                                       {"Light2"            , x.Light2},
                                       {"Light3"            , x.Light3},
                                       {"Light4"            , x.Light4},
                                       {"Light5"            , x.Light5},
                                       {"Light6"            , x.Light6},
                                       {"Benzin"            , x.BenzinImage},
                                   },
                        }).ToList();
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به لود فاکتور برای چاپ نیست", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
        public  void    Show            (IWin32Window Frm)
        {
            _PrintDiag = new Print_Dialog(_ListReport);
            FrmWait.Close(); 
            _PrintDiag.ShowDialog(Frm);
        }

    }
}
