using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.DataLayer.Repo;
using Nz.Anbar.Model.Model;
using Nz.Anbar.Model.ViewModel;

namespace NZ.Anbar.Business
{
    public class PrefactorManager
    {
        private PrefactorRepository _Repo;
        public PrefactorManager()
        {
            _Repo =new PrefactorRepository();
        }
         
        public void                     Save            (PreFactor Factor)
        {
            _Repo.Save(Factor);
        }
        public void                     Delete          (long ID)
        {
            _Repo.Delete(ID);
        }
        public PreFactor               GetItem         (long ID)
        {
            return _Repo.GetItem(ID);
        }
        public IEnumerable<PreFactor>  GetList         (object param)
        {
            return _Repo.GetList(param);
        }
        
        //public IEnumerable<PrintFactor> GetPrintFactor  (long ID)
        //{
        //    var list = new List<long>() {ID};

        //    return _Repo.GetAllPrint(list);
        //}
         
    }
}
