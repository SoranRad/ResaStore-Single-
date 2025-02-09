using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using ShareLib;

namespace Nz.Anbar.Model.Model
{
    public class PreFactorItems
    {
        public long                 ID                  { get; set; }
        public int                  FK_Title            { get; set; }
        public long                 FK_Kala             { get; set; }
        public decimal              Count               { get; set; }

        public string               ObjectTitle         { get; set; }
        public long                 ObjectCode          { get; set; }
        public string               UnitTitle           { get; set; }
        public Enums.NzItemState    State               { get; set; } 

        public PreFactor            PreFactor           { get; set; }
        public NzObject             NzObject            { get; set; }
    }
}
