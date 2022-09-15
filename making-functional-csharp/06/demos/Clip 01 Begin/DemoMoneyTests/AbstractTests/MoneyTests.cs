using Demo;

namespace DemoMoneyTests.AbstractTests
{
    public abstract class MoneyTests
    {
        protected abstract Timestamp TimeWithinValidity { get; }
        protected abstract Money CreateMoney(Currency currency, decimal amount);

        protected Currency TestCurrency => new Currency() {Symbol = "USD"};
        protected Currency DifferentTestCurrency => new Currency() {Symbol = "EUR"};
    }
}
