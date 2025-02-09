using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Interfaces
{
    public interface IPaymentCommand
    {
        void        SetMount        (decimal Price);
        void        SetFactore      (long ID);
        void        SetPerson       (long ID);
        void        ResetPay        ();
        void        LoadComponent   (long IdFactor=0,decimal Mablaq=0);
        void        CachePayment    ();
        void        BankPayment     ();
        void        SendToPos       ();
        decimal     GetCache        ();
        decimal     GetPos          ();
    }
}
