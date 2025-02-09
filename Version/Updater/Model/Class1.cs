using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Updater.Model
{
    public class MessageContract<T>
    {
        public T Data { get; set; }
        public bool Result { get; set; }
        public string Message { get; set; }

    }

    public class MessageContract
    {

        public bool Result { get; set; }
        public string Message { get; set; }

    }
}
