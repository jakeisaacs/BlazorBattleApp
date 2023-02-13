namespace BlazorBattleApp.Client.Services
{
    public class CurrencyServices : ICurrencyServices
    {
        public event Action OnChange;
        public int Currency { get; set; } = 1000;

        public void ConsumeCurrency(int amount)
        {
            Currency -= amount;
            CurrencyChanged();
        }

        public void AddCurrency(int amount)
        {
            Currency += amount;
            CurrencyChanged();
        }

        void CurrencyChanged() => OnChange.Invoke();
    }
}
