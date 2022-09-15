using System;

namespace Demo
{
    public class GiftCard : FixedMoney
    {
        public Date ValidBefore { get; }

        public GiftCard(Currency currency, decimal amount, Date validBefore)
            : base(currency, amount)
        {
            if (validBefore == null)
                throw new ArgumentNullException(nameof(validBefore));

            this.ValidBefore = validBefore;
        }
    }
}
