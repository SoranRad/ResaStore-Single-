using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.Tarikh;
using MS_Print_Dialog;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Print
{
    public class Print
    {
        #region Fields
        private List<long>                  _ListIDs;
        private FactorManager               _Manager;
        private Enums.NzKindPrint           _PrintKind;
        private readonly string             _remaind;
        private Print_Dialog                _PrintDiag;
        private List<MS_Report_Loading>     _ListReport;
        private string                      _ReportPath;
        private MSWait FrmWait              = new MSWait();
        #endregion
        #region Property
        [DefaultValue(false)]
        public bool DirectPrint { get; set; }
        #endregion
        #region Constructor
        public              Print   (FactorManager Manager, long ID,            Enums.NzKindPrint PrintKind,string Remaind=null)
        {
            FrmWait         .Show();
            Application     .DoEvents();

            _Manager        = Manager;
            _PrintKind      = PrintKind;
            _remaind        = Remaind;
            _ListIDs        = new List<long>(){ID};

            SetPrintFile    ();
            Load            ();
        }
        public              Print   (FactorManager Manager, List<long> List,    Enums.NzKindPrint PrintKind)
        {
            FrmWait.Show();
            Application.DoEvents();
            _Manager        = Manager??new FactorManager();
            _PrintKind      = PrintKind;
            _ListIDs        = List;
            SetPrintFile    ();
            Load            ();
        }
        #endregion
        private void        SetPrintFile    ()
        {
            _ReportPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _ReportPath += "\\Print\\Anbar\\";
            switch (_PrintKind)
            {
                case Enums.NzKindPrint.PaperA4:
                    _ReportPath += "Factor_A4.mrt";
                    break;
                case Enums.NzKindPrint.PaperA5:
                    _ReportPath += "Factor_A5.mrt";
                    break;
                case Enums.NzKindPrint.PosPrint:
                    _ReportPath += "Pos_Print.mrt";
                    break;
            }
        }
        private void        Load            ()
        {
            try
            {
                var Factors             = _Manager.GetPrintFactor(_ListIDs);
                if (Factors == null)
                    throw new Exception();

                var Co                  = SystemConstant.ActiveCompany;

                _ListReport =
                    Factors
                    .GroupBy(x => new
                    {
                        x.ID,
                        x.PersianTarix,
                        x.addressHome,
                        x.codeEqtesadi,
                        x.codeMeli,
                        x.mobDowom,
                        x.mobile,
                        x.telDowom,
                        x.Cache,
                        x.Pos,
                        x.Serial,
                        x.addresswork,
                        x.fax,
                        x.sharh,
                        x.title,
                        x.kind,
                        x.Cheque,
                        x.tel,

                        x.mablaq_KOl,
                        x.mablaq_takhfif,
                        x.Darsad_Takhfif,
                        x.mablaq_Maliat,
                        x.Darsad_Maliat,
                        x.Ezafat,
                        x.Remaind
                    })
                    .Select(x => new MS_Report_Loading
                    {
                        BusinessObject_Name = "List",
                        Report_Address      =_ReportPath,

                        List_Data           = x.Select(y=>new
                                                {
                                                    y.radif,
                                                    y.FK_Kala,
                                                    y.ObjectTitle,
                                                    y.UnitTitle,
                                                    y.meqdar,
                                                    y.nerkh,
                                                    y.takhfif,
                                                    y.takhfif_darsad,
                                                    y.mablaq

                                                }).OrderBy(y =>y.radif).ThenBy(y => y.FK_Kala),
                        List_Parametter     = x.Key.kind>=11 && x.Key.kind < 50
                        ? new Dictionary<string, object>()
                                   {
                                       {"txt"              , x.Key.sharh},
                                       {"noh_faktor"       , ((Enums.NzFactorKind)x.Key.kind).NzToString()},
                                       {"company"          , SystemConstant.ActiveCompany.title},
                                       {"serial"           , x.Key.Serial.ToString()},
                                       {"tarikh"           , x.Key.PersianTarix},
                                       {"mablaq"           , x.Key.mablaq_KOl},

                                       {"name_1"           , x.Key.title},
                                       {"code_meli_1"      , (x.Key.codeEqtesadi?? "") + " " + (x.Key.codeMeli ?? "")},
                                       {"tel_1"            , (x.Key.tel??"") + " " + (x.Key.telDowom??"")},
                                       {"fax_1"            , x.Key.fax??""},
                                       {"mobile_1"         , (x.Key.mobile??"") + " " + (x.Key.mobDowom??"")},
                                       {"address_1"        , x.Key.addressHome},

                                       {"name_2"           , Co.title},
                                       {"code_meli_2"      , Co.code_melli},
                                       {"code_eqtesadi_2"  , Co.code_eqtesadi},
                                       {"tel_2"            , (Co.tel??"")+" "+ (Co.tel2??"")},
                                       {"fax_2"            , Co.fax},
                                       {"mobile_2"         , (Co.mobile??"") + " " + (Co.mobile2??"")},
                                       {"address_2"        , Co.address},

                                       {"banki"            , x.Key.Pos},
                                       {"naqdi"            , x.Key.Cache},
                                       {"chak"             , x.Key.Cheque},
                                                             
                                       {"mablaq_takhfif"   , x.Key.mablaq_takhfif},
                                       {"Darsad_Takhfif"   , x.Key.Darsad_Takhfif},
                                       {"mablaq_Maliat"    , x.Key.mablaq_Maliat},
                                       {"Darsad_Maliat"    , x.Key.Darsad_Maliat},
                                       {"Ezafat"           , x.Key.Ezafat},
                                       {"Remaind"          , x.Key.Remaind},


                                       {"mab_kol_harf"     , MS_Util.num2str(x.Key.mablaq_KOl.ToString("F0")).Trim()},
                                       {"mola"             , Co.molahezat??""},
                                       {"RemaindShaxs"     , _remaind}


                                    }
                        : new Dictionary<string, object>()
                                {
                                    {"txt"              , x.Key.sharh},
                                    {"noh_faktor"       , ((Enums.NzFactorKind)x.Key.kind).NzToString()},
                                    {"company"          , SystemConstant.ActiveCompany.title},
                                    {"serial"           , x.Key.Serial.ToString()},
                                    {"tarikh"           , x.Key.PersianTarix},
                                    {"mablaq"           , x.Key.mablaq_KOl},

                                    {"name_2"           , x.Key.title},
                                    {"code_meli_2"      , (x.Key.codeEqtesadi?? "") + " " + (x.Key.codeMeli ?? "")},
                                    {"tel_2"            , (x.Key.tel??"") + " " + (x.Key.telDowom??"")},
                                    {"fax_2"            , x.Key.fax??""},
                                    {"mobile_2"         , (x.Key.mobile??"") + " " + (x.Key.mobDowom??"")},
                                    {"address_2"        , x.Key.addressHome},

                                    {"name_1"           , Co.title},
                                    {"code_meli_1"      , Co.code_melli},
                                    {"code_eqtesadi_1"  , Co.code_eqtesadi},
                                    {"tel_1"            , (Co.tel??"")+" "+ (Co.tel2??"")},
                                    {"fax_1"            , Co.fax},
                                    {"mobile_1"         , (Co.mobile??"") + " " + (Co.mobile2??"")},
                                    {"address_1"        , Co.address},

                                    {"banki"            ,x.Key.Pos},
                                    {"naqdi"            ,x.Key.Cache},
                                    {"chak"             ,x.Key.Cheque},

                                    {"mablaq_takhfif"   ,x.Key.mablaq_takhfif},
                                    {"Darsad_Takhfif"   ,x.Key.Darsad_Takhfif},
                                    {"mablaq_Maliat"    ,x.Key.mablaq_Maliat},
                                    {"Darsad_Maliat"    ,x.Key.Darsad_Maliat},
                                    {"Ezafat"           ,x.Key.Ezafat},
                                    {"Remaind"          ,x.Key.Remaind},

                                    {"mab_kol_harf"     , MS_Util.num2str(x.Key.mablaq_KOl.ToString("F0")).Trim()},
                                    {"mola"             , Co.molahezat??""},
                                    {"RemaindShaxs"     , _remaind}
                                 }
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به لود فاکتور برای چاپ نیست","خطا",ex.Message,MessageBoxButtons.OK);
            }
        }
        public  void        Show            (IWin32Window Frm)
        {
            _PrintDiag = new Print_Dialog(_ListReport);
            FrmWait.Close();
            Print_Dialog._Do_Direct_Print = DirectPrint;
            _PrintDiag.ShowDialog(Frm);
        }

    }
}
