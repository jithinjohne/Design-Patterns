using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class _1RupeeHandler : Handler
    {
        public _1RupeeHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int MoneyValue => 1;
    }
}
