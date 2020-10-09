using Galax.Solution.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace GalaxSolution.AppService.Implementation.EventSourcedNormalizers.ProductInput
{
    public static class ProductInputHistory
    {
        public static IList<ProductInputHistoryData> HistoryData { get; set; }

        public static IList<ProductInputHistoryData> ToJAvaScriptProductInputHistory(IList<StockedEvent> stockedEvents) 
        {
            HistoryData = new List<ProductInputHistoryData>();
            ProductInputHistoryDeserializer(stockedEvents);

            var sorted = HistoryData.OrderBy(a => a.TimeStamp);
            var list = new List<ProductInputHistoryData>();
            var last = new ProductInputHistoryData();

            foreach (var change in sorted)
            {
                var jssSlot = new ProductInputHistoryData
                {
                    Id = change.Id == Guid.Empty.ToString() || change.Id == last.Id
                        ? ""
                        : change.Id,
                    Number = string.IsNullOrWhiteSpace(change.Number) || change.Number == last.Number
                        ? ""
                        : change.Number,
                    Date = string.IsNullOrWhiteSpace(change.Date) || change.Date == last.Date
                        ? ""
                        : change.Date.Substring(0, 10),
                    Amount = string.IsNullOrWhiteSpace(change.Amount) || change.Amount == last.Amount
                        ? ""
                        : change.Amount,

                    Action = string.IsNullOrWhiteSpace(change.Action) ? "" : change.Action,
                    TimeStamp = change.TimeStamp,
                    Who = change.Who

                };

                list.Add(jssSlot);
                last = change;

                    
            }
            return list;

        }

        private static void ProductInputHistoryDeserializer(IList<StockedEvent> stockedEvents)
        {
            foreach (var e in stockedEvents)
            {
                var historyData = JsonSerializer.Deserialize<ProductInputHistoryData>(e.Data);
                historyData.TimeStamp = DateTime.Parse(historyData.TimeStamp).ToString("yyyy'-'MM'-'dd' - 'HH' : 'mm' : 'ss'");

                switch (e.MessageType)
                {
                    case "ProductInputRegisteredEvent":
                        historyData.Action = "Registered";
                        historyData.Who = e.User;
                        break;

                    case "ProductInputUpdatedEvent":
                        historyData.Action = "Updated";
                        historyData.Who = e.User;
                        break;

                    case "ProductInputRemovedEvent":
                        historyData.Action = "Removed";
                        historyData.Who = e.User;
                        break;

                    default:
                        historyData.Action = "Unrecognized";
                        historyData.Who = e.User ?? "Anonymous";
                        break;


                }

                HistoryData.Add(historyData);


            }
        }
    }
}