using System;

namespace ChainOfResponsibility
{
    public abstract class Handler : IHandler
    {
        private readonly IHandler nextHandler;

        protected Handler(IHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        protected abstract int MoneyValue { get; }

        public void Handle(int withdrawalAmount)
        {
            var pendingAmount = DisposeCash(withdrawalAmount);
            if (nextHandler == null)
            {
                Console.WriteLine("End of operation");
            }
            else
            {
                nextHandler.Handle(pendingAmount);
            }
        }

        protected int DisposeCash(int withdrawalAmount)
        {
            var notes = withdrawalAmount / MoneyValue;
            if (notes > 0)
            {
                Console.WriteLine($"{notes} * {MoneyValue.ToString()}");
            }
            return withdrawalAmount % MoneyValue;
        }
    }
}
