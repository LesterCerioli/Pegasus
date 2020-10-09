using Galax.Solution.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;


namespace Galax.AppService.Implementation.EventSourcedNormalizers.City
{
    public static class CityHistory
    {
        public static IList<CityHistoryData> HistoryData{get; set;}
        public static List<CityHistoryData> HistoryData{get;private set;}

        public static IList<CityHistoryData> ToJavaScriptCityHistory(IList<StockedEvent> stockedEvents)
        {
            HistoryData = new List<CityHistoryData>();
            CityHistoryDeserializer(stockedEvents);

            var sorted = HistoryData.OrderBy(c => c.Timestamp);
            var list = new List<CityHistoryData>();
            var last = new CityHistoryData();

            foreach (var change in sorted)
            {
                var jsslot = new CityHistoryData
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

        private static void CityHistoryDeserializer(IList<StockedEvent> stockedEvents)
        {
            
            foreach (var e in stockedEvents)
            {
                var historyData = JsonSerializer.Deserialize<CityHistoryData>(e.Data);
                historyData.Timestamp = DateTime.Parse(historyData.Timestamp).ToString("yyyy'-'MM'-'dd' - 'HH':'mm':'ss");

                switch (e.MessageType)
                {
                    case "CityRegisteredEvent":
                        historyData.Action = "Registered";
                        historyData.Who = e.User;
                        break;

                    case "CityUpdatedEvent":
                        historyData.Action = "Updated";
                        historyData.Who = e.User;
                        break;

                    case "CityRemovedEvent":
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