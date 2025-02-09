using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace ShareLib.Interfaces
{
    public interface ICommandRepository
    {
        long Save<T>    (T      Item,   Company CurrentCompany, Year CurrentYear, User CurrentUser)     where T : class;
        void Delete<T>  (long   ID,     Company CurrentCompany, Year CurrentYear, User CurrentUser)     where T : class;
    }
}
