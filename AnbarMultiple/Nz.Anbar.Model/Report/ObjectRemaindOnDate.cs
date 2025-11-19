using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report
{
    public class ObjectRemaindOnDate
    {
        public int      Code                { get; set; }
        public short    FK_GroupKala_1th    { get; set; }
        public short    FK_GroupKala_2th    { get; set; }

        public string   ObjectTitle         { get; set; }
        public string   SubGroupTitle       { get; set; }
        public string   MainGroupTitle      { get; set; }


        public decimal  Init                { get; set; }
        public decimal  Input               { get; set; }
        public decimal  Output              { get; set; }
        public decimal  RemainMablaq        { get; set; }

        public decimal  Remaind             => Init + Input - Output;
    }
}
