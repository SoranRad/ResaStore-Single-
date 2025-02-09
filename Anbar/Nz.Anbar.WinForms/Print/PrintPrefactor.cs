using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.Tarikh;
using MS_Print_Dialog;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Print
{
    public class PrintPrefactor
    {

        #region Fields
        private readonly int                _id;
        private PrefactorManager            _Manager;
        private Print_Dialog                _PrintDiag;
        private string                      _ReportPath; 
        private MS_Wait                     FrmWait         = new MS_Wait(); 
        #endregion
        public PrintPrefactor(int ID)
        {
            _id = ID;
            FrmWait.Show();
            _Manager        = new PrefactorManager();
            _ReportPath     = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _ReportPath     += "\\Print\\Anbar\\Prefactor_A5.mrt";
             
        }
        #region Methods
       
        public  void    Show    (IWin32Window Frm)
        {
            var Factor = _Manager.GetItem(_id);

            if (Factor == null)
                throw new Exception();

            FrmWait.Close();

            var list = Factor
                .Items
                .Select(x => new
                {
                    x.FK_Kala,
                    x.Count,
                    x.ObjectCode,
                    x.ObjectTitle,
                    x.UnitTitle,
                })
                .OrderBy(y => y.FK_Kala)
                .ToList();

            _PrintDiag = new Print_Dialog(_ReportPath,"List",list);
           
            _PrintDiag.Set_Variable("noh_faktor",   Factor.Title);
            _PrintDiag.Set_Variable("company",      SystemConstant.ActiveCompany.title);
            _PrintDiag.Set_Variable("tarikh",       new MS_Structure_Shamsi(DateTime.Now).ToShamsi());

            _PrintDiag.ShowDialog(Frm);
        }
        #endregion

    }
}
