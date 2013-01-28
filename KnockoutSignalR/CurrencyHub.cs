using KnockoutSignalR.Models;
using Microsoft.AspNet.SignalR;
using System.Collections.Generic;

namespace KnockoutSignalR
{
    public class CurrencyHub : Hub
    {
        public void GetCurrencies()
        {
            Clients.Caller.setCurrencies(CurrencyService.GetCurrencies());
        }
    }
}