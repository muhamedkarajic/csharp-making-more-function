using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    public class Wallet
    {
        private IList<Money> Content { get; set; } = new List<Money>();

        public void Add(Money money)
        {
            this.Content.Add(money ?? throw new ArgumentNullException(nameof(money)));
        }

        public Amount Charge(Currency currency, decimal amount)
        {
        }
    }
}
