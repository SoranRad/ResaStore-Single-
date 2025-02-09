using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Report;
using ShareLib;
using ShareLib.Models;

namespace NZ.Xazane.WinForms.Report
{
    public class PeopleCircularModel
    {
        public int          code            { get; set; }
        public string       title           { get; set; }
        public string       namePedar       { get; set; }
        public string       codeMeli        { get; set; }
        public decimal      takhfif         { get; set; }
        public byte         kind            { get; set; }
        public string       Sharh           { get; set; }

        public decimal DRemaind             => (Enums.NzPaymentOperatingKind) this.kind == Enums.NzPaymentOperatingKind.RemaindCredit
                                            ? -this.takhfif
                                            : this.takhfif;

        public People                           People          { get; set; }              
        public IEnumerable<MoneyCircular>       Caches          { get; set; }
        public IEnumerable<MoneyCircular>       Pos             { get; set; }
        public IEnumerable<MoneyCircular>       Misc            { get; set; }
        public IEnumerable<PeopleCheque>        Cheque          { get; set; }
        public IEnumerable<PeopleChequeBack>    ChequeBack      { get; set; }
        public IEnumerable<PeopleChequeAssign>  ChequeAssign    { get; set; }

        public decimal GetBalance()
        {
            var cache           = this.Caches?.         Sum(x => x.Balance)??0;
            var pos             = this.Pos?.            Sum(x => x.Balance)??0;
            var Msic            = this.Misc?.           Sum(x => x.Balance)??0;
            var cheque          = this.Cheque?.         Sum(x => x.Balance)??0;
            var chequeBack      = this.ChequeBack?.     Sum(x => x.Balance)??0;
            var chequeAssign    = this.ChequeAssign?.   Sum(x => x.mablaq)??0;

            var Balance         = this.DRemaind 
                                     + cache
                                     + pos
                                     + Msic
                                     + cheque
                                     + chequeBack
                                     + chequeAssign;

            return Balance;
        }
    }

}
