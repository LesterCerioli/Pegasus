using Galax.Solution.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace GalaxSolution.AppService.Implemementation.EventSourcedNormalizers.LocalStorage
{
     public static class LocalStorageHistory
    {
        public static IList<LocalStorageHistoryData> HistoryData{get; set;}
        public static List<LocalStorageHistoryData> HistoryData{get;private set;}

        public static IList<LocalStorageHistoryData> ToJavaScriptCityHistory(IList<StockedEvent> stockedEvents)
        {
            HistoryData = new List<LocalStorageHistoryData>();
            LocalStorageHistoryDeserializer(stockedEvents);

            var sorted = HistoryData.OrderBy(c => c.Timestamp);
            var list = new List<LocalStorageHistoryData>();
            var last = new LocalStorageHistoryData();

            foreach (var change in sorted)
            {
                var jsslot = new LocalStorageHistoryData
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

                list.Add(jsslot);
                last = change;


            }
            return list;
        }

        private static void LocalStorageHistoryDeserializer(IList<StockedEvent> stockedEvents)
        {
            
            foreach (var e in stockedEvents)
            {
                var historyData = JsonSerializer.Deserialize<localStorageHistoryData>(e.Data);
                historyData.Timestamp = DateTime.Parse(historyData.Timestamp).ToString("yyyy'-'MM'-'dd' - 'HH':'mm':'ss");

                switch (e.MessageType)
                {
                    case "LocalStorageRegisteredEvent":
                        historyData.Action = "Registered";
                        historyData.Who = e.User;
                        break;

                    case "LocalStorageUpdatedEvent":
                        historyData.Action = "Updated";
                        historyData.Who = e.User;
                        break;

                    case "LocalStorageRemovedEvent":
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