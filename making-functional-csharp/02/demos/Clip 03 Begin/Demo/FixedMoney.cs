using System;

namespace Demo
{
    public class FixedMoney : Money
    {
        public Currency Currency { get; }
        public decimal Amount { get; }

        protected FixedMoney(Currency currency, decimal amount)
        {
            if (currency == null)
                throw new ArgumentNullException(nameof(currency));
            if (amount <= 0)
                throw new ArgumentException("Negative amount.");

            this.Currency = currency;
        }
    }
}
