using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class _10RupeeHandler : Handler
    {
        public _10RupeeHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        protected override int MoneyValue => 10;
    }
}
