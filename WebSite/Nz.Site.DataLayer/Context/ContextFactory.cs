using Nz.Aqsat.DataLayer.Context;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Bar.DataLayer.Context
{
    public class ContextFactory : IDbContextFactory<SiteContext>
    {
        public SiteContext Create()
        {
            ConnectionManager.ConStr = @"Server=.\sqlentr;Database=DB_NzResaaStore;User Id=sa;Password=123456;MultipleActiveResultSets=True;Persist Security Info = True;MultipleActiveResultSets=true;App=NzResaaStore;";
            return new SiteContext(ConnectionManager.Create(), true);
        }
    }
}
