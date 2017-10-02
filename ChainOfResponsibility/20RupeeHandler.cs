using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class _20RupeeHandler : Handler
    {
        public _20RupeeHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int MoneyValue => 20;
    }
}
