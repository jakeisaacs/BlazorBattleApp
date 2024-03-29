﻿using Microsoft.AspNetCore.Components;

namespace BlazorBattleApp.Client.Pages
{
    public partial class Counter : ComponentBase
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount = (currentCount + 1) % 10;
        }
    }
}
