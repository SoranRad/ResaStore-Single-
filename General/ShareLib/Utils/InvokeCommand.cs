using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;

namespace ShareLib.Utils
{
    public static class InvokeCommand
    {
        public static void Invoke(ICommand Command)
        {
            Command?.Execute();
        }
    }
}
