using BlazorBattleApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattleApp.Client.Services
{
    public interface IUnitService
    {
        IList<Unit> Units { get; }
        IList<UserUnit> MyUnits { get; set; }

        void AddUnit(int unitId);
    }
}
