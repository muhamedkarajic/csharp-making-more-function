using System;

namespace Demo
{
    public class BankCard : Money
    {
        public Month ValidBefore { get; }

        public BankCard(Month validBefore)
        {
            if (validBefore == null)
                throw new ArgumentNullException(nameof(validBefore));

            this.ValidBefore = validBefore;
        }
    }
}
