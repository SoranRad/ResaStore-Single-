using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace ShareLib.Interfaces
{
    public interface IQueryRepository
    {
        T               GetItem<T>  (T Item);
        IEnumerable<T>  GetList<T>  (long Parent, Company CurrentCompany, Year CurrentYear, User CurrentUser);
    }
}
