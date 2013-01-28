using KnockoutSignalR.Models;
using System.Collections.Generic;

namespace KnockoutSignalR
{
    public class CurrencyService
    {
        public static List<CurrencyViewModel.Currency> GetCurrencies()
        {
            return new List<CurrencyViewModel.Currency>()
                        {
                            new CurrencyViewModel.Currency() {Code = "USD", Price = 1.00000M},
                            new CurrencyViewModel.Currency() {Code = "EUR", Price = 0.75103M},
                            new CurrencyViewModel.Currency() {Code = "GBP", Price = 0.63163M},
                            new CurrencyViewModel.Currency() {Code = "INR", Price = 53.8253M},
                            new CurrencyViewModel.Currency() {Code = "AUD", Price = 0.95095M},
                            new CurrencyViewModel.Currency() {Code = "CAD", Price = 1.00020M},
                            new CurrencyViewModel.Currency() {Code = "ZAR", Price = 9.04965M},
                            new CurrencyViewModel.Currency() {Code = "NZD", Price = 1.18616M},
                            new CurrencyViewModel.Currency() {Code = "JPY", Price = 89.3339M}
                        };
        }
    }
}