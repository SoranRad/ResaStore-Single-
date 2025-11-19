using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report
{
    public class AnalyzeStorage
    {
        public int      Code            { get; set; }
        public string   Title           { get; set; }

        public decimal  Init            { get; set; }
        public decimal  Purchase        { get; set; }
        public decimal  SaleBack        { get; set; }
        public decimal  ResidVorud      { get; set; }
        public decimal  Sale            { get; set; }
        public decimal  PurchaseBack    { get; set; }
        public decimal  Zayeat          { get; set; }
        public decimal  Masraf          { get; set; }
        public decimal  EnteqalXoruj    { get; set; }
        public decimal  EnteqalVorud    { get; set; }
        public decimal  HavaleXoruj     { get; set; }


    }
    public class AnalyzeLevel1 : AnalyzeStorage
    {
        
    }
    public class AnalyzeLevel2 : AnalyzeStorage
    {

    }
    public class AnalyzeLevel3 : AnalyzeStorage
    {

    }
    public class AnalyzeLevel4 : AnalyzeStorage
    {

    }
    public class AnalyzeLevel5 : AnalyzeStorage
    {

    }
    public class AnalyzeLevel6 : AnalyzeStorage
    {

    }
}
