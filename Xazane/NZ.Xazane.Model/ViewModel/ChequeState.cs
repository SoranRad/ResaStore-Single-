using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.Model.ViewModel
{
    public class ChequeState
    {
        public string DateAdd       { get; set; }
        public string DateEdit      { get; set; }
        public string UserAdd       { get; set; }
        public string UserEdit      { get; set; }

        public string Date          { get; set; }
        public string PeopleAssign  { get; set; }
        public string Description   { get; set; }

        public byte   Kind          { get; set; }
        public byte   MainKind      { get; set; }
        public string   AccountAct    { get; set; }

    }
}
