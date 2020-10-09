using Galax.Solution.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace GalaxSolution.AppService.Implementation.EventSourcedNormalizers.ProductGroup
{
    public static class ProductGroupHistory
    {
        public static IList<ProductGroupHistoryData> HistoryData { get; set; }

        public static IList<ProductGroupHistoryData> ToJavaScriptProductGroupHistory(IList<StockedEvent> stockedEvents)
        {
            HistoryData = new List<ProductGroupHistoryData>();
            ProductGroupHistoryDeserializer(stockedEvents);

            var sorted = HistoryData.OrderBy(a => a. TimeStamp);
            var list = new List<ProductGroupHistoryData>();
            var last = new ProductGroupHistoryData();

            foreach (var change in sorted) 
            {
                var jssSlot = new ProductGroupHistoryData
                {
                    Id = change.Id == Guid.Empty.ToString() || change.Id == last.Id
                        ? ""
                        : change.Id,
                    Name = string.IsNullOrWhiteSpace(change.Name) || change.Name == last.Name
                        ? ""
                        : change.Name,
                    Action = string.IsNullOrWhiteSpace(change.Action) ? "" : change.Action,
                    TimeStamp = change.TimeStamp,
                    Who = change.Who

                };

                list.Add(jssSlot);
                last = change;

            }

            return list;

        }

        private static void ProductGroupHistoryDeserializer(IEnumerable<StoredEvent> stockedEvents) 
        {
            foreach (var e in stockedEvents) 
            {
                var historyData = JsonSerializer.Deserialize<ProductGroupHistoryData>(e.Data);
                historyData.TimeStamp = DateTime.Parse(historyData.TimeStamp).ToString("yyyy'-'MM'-'dd' - 'HH' : 'mm' : 'ss'");
                
                switch (e.MessageType) 
                {
                    case "ProductGroupRegisteredEvent":
                        historyData.Action = "Registered";
                        historyData.Who = e.User;
                        break;

                    case "ProductGroupUpdatedEvent":
                        historyData.Action = "Updated";
                        historyData.Who = e.User;
                        break;

                    case "ProductGroupRemovedEvent":
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