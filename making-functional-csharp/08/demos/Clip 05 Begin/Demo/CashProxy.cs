using Demo.Finance;

namespace Demo
{
    public class CashProxy : Money
    {
        private Money Implementation { get; }
        private decimal PercentageFee { get; }

        public CashProxy(Money implementation, decimal percentageFee)
        {
            this.Implementation = implementation;
            this.PercentageFee = percentageFee;
        }
    }
}
