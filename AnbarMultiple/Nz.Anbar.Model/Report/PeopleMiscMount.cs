using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.Report
{
    public class PeopleMiscMount
    {
        public long         ID                  { get; set; }
        public int          Serial              { get; set; }
        public string       PersianStr          { get; set; }
        public decimal      darsad              { get; set; }
        public decimal      mablaq              { get; set; }
        public byte         kind                { get; set; }
        public byte         kindMisc            { get; set; }
        public string       ObjectTitle         { get; set; }
        public string       KindTitle           =>  this.ObjectTitle
                                                    + " " +
                                                    ((Enums.NzFactorKind)this.kind).NzToString();

        public decimal Mount
        {
            get
            {
                if (kind < 50)
                {
                    switch ((Enums.NzMiscMountKind)this.kindMisc)//-
                    {
                        case Enums.NzMiscMountKind.Off:
                            return mablaq;
                        case Enums.NzMiscMountKind.Extend:
                            return -mablaq;
                        case Enums.NzMiscMountKind.Tax:
                            return -mablaq;
                        default:
                            return mablaq;
                    }
                }
                else
                {
                    switch ((Enums.NzMiscMountKind)this.kindMisc)//+
                    {
                        case Enums.NzMiscMountKind.Off:
                            return -mablaq;
                        case Enums.NzMiscMountKind.Extend:
                            return mablaq;
                        case Enums.NzMiscMountKind.Tax:
                            return mablaq;
                        default:
                            return mablaq;
                    }
                }
            }

        }

    }
}
