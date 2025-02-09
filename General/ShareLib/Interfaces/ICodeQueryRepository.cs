using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace ShareLib.Interfaces
{
    public interface ICodeQueryRepository
    {
        bool IsCodeUnique<T>(int    Code, Company CurrentCompany, Year CurrentYear, User CurrentUser);
        bool IsCodeUnique<T>(short  Code, Company CurrentCompany, Year CurrentYear, User CurrentUser);
        bool IsCodeUnique<T>(byte   Code, Company CurrentCompany, Year CurrentYear, User CurrentUser);
        bool IsCodeUnique<T>(object Code, object  Kind, Company CurrentCompany, Year CurrentYear, User CurrentUser);


        int     GenerateCode<T>     (                       Company CurrentCompany, Year CurrentYear, User CurrentUser);
        int     GenerateCode<T>     (int    ParentCode,     Company CurrentCompany, Year CurrentYear, User CurrentUser);
        short   GenerateCode<T>     (short  ParentCode,     Company CurrentCompany, Year CurrentYear, User CurrentUser);
    }
}
