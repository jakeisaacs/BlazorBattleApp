namespace BlazorBattleApp.Client.Services
{
    public interface ICurrencyServices
    {
        event Action OnChange;
        int Currency { get; set; }

        void ConsumeCurrency(int amount);
        void AddCurrency(int amount);
    }
}
