using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class UpdateFactorStateConfig  : DapperEntityConfiguration<UpdateFactorState>
    {
        public UpdateFactorStateConfig()
        {
            SetItem(@"UPDATE Anbar.tbl_Amaliat_Title SET is_ok = (CASE WHEN is_ok=1 THEN 0 ELSE 1 END ) WHERE ID = @ID");
        }
    }
}
