using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class _50RupeeHanlder:Handler
    {
        public _50RupeeHanlder(IHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int MoneyValue => 50;
    }
}
