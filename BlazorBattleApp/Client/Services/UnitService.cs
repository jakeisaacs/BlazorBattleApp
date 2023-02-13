using BlazorBattleApp.Shared;

namespace BlazorBattleApp.Client.Services
{
    public class UnitService : IUnitService
    {
        public IList<Unit> Units => new List<Unit>()
        {
            new Unit {Id = 1, Title = "Knight", Attack = 10, Defense = 10, CurrencyCost = 100 },
            new Unit {Id = 1, Title = "Archer", Attack = 15, Defense = 5, CurrencyCost = 150 },
            new Unit {Id = 1, Title = "Mage", Attack = 20, Defense = 1, CurrencyCost = 200 }

        };
        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();

        public void addUnits(int unitId)
        {
            var unit = Units.First(unit => unit.Id == unitId);
            MyUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.Hitpoints });
        }
    }
}
