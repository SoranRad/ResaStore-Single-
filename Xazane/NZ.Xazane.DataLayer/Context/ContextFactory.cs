using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Utils;

namespace NZ.Xazane.DataLayer.Context
{
    public class ContextFactory : IDbContextFactory<XazaneContext>
    {
        public XazaneContext Create()
        {
            ConnectionManager.ConStr = @"Data Source=.\sqlentr;Initial Catalog=DB_NzResaaStore_Single;Integrated Security=True;Persist Security Info = True;MultipleActiveResultSets=true;App=NzResaaStore;";
            return new XazaneContext(ConnectionManager.Create(), true);
        }
    }
}
