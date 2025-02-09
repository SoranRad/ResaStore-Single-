using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Utils;

namespace Nz.Machine.DataLayer.Context
{
    public class ContextFactory : IDbContextFactory<MachineContext>
    {
        public MachineContext Create()
        {
            ConnectionManager.ConStr = @"Server=.\sqlnegin;Database=DB_NzResaaStore;User Id=sa;Password=123456;MultipleActiveResultSets=True;Persist Security Info = True;MultipleActiveResultSets=true;App=NzResaaStore;";
            return new MachineContext(ConnectionManager.Create(), true);
        }
    }
}
