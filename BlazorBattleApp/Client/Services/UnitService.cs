﻿using BlazorBattleApp.Shared;
using Blazored.Toast.Services;

namespace BlazorBattleApp.Client.Services
{
    public class UnitService : IUnitService
    {
        private readonly IToastService _toastService;

        public UnitService(IToastService toastService) 
        {
            _toastService = toastService;
        }
        public IList<Unit> Units => new List<Unit>()
        {
            new Unit {Id = 1, Title = "Knight", Attack = 10, Defense = 10, CurrencyCost = 100 },
            new Unit {Id = 2, Title = "Archer", Attack = 15, Defense = 5, CurrencyCost = 150 },
            new Unit {Id = 3, Title = "Mage", Attack = 20, Defense = 1, CurrencyCost = 200 }

        };
        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();

        public void AddUnit(int unitId)
        {
            var unit = Units.First(unit => unit.Id == unitId);
            MyUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.HitPoints });
            _toastService.ShowSuccess($"Your {unit.Title} has been created!");
        }
    }
}
