using Galax.Solution.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace GalaxSolution.AppService.Implementation.EventSourcedNormalizers.CNPJ
{
    public static class CNPJHistory
    {
        public static IList<CNPJHistoryData> HistoryData { get; set; }

        public static IList<CNPJHistoryData> ToJavaScriptCNPJHistory(IList<StockedEvent> stockedEvents) 
        {
            HistoryData = new List<CNPJHistoryData>();
            CNPJHistoryDeserializer(stockedEvents);

            var sorted = HistoryData.OrderBy(b => b.TimeStamp);
            var list = new List<CNPJHistoryData>();
            var last = new CNPJHistoryData();

            foreach (var change in sorted)
            {
                var jssSlot = new CNPJHistoryData
                {
                    Id = change.Id == Guid.Empty.ToString() || change.Id == last.Id
                        ? ""
                        : change.Id,
                    NumCNPJ = string.IsNullOrWhiteSpace(change.NumCNPJ) || change.NumCNPJ == last.NumCNPJ
                        ? ""
                        : change.NumCNPJ,
                    Action = string.IsNullOrWhiteSpace(change.Action) ? "" : change.Action,
                    TimeStamp = change.TimeStamp,
                    Who = change.Who
                };

                list.Add(jssSlot);
                last = change;
            }
            return list;

        }

        private static void CNPJHistoryDeserializer(IList<StockedEvent> stockedEvents)
        {
            foreach (var e in stockedEvents)
            {
                var historyData = JsonSerializer.Deserialize<CNPJHistoryData>(e.Data);
                historyData.TimeStamp = DateTime.Parse(historyData.TimeStamp).ToString("yyyy'-'MM'-'dd' - 'HH' : 'mm' : 'ss'");

                switch (e.MessageType)
                {
                    case "CNPJRegisteredEvent":
                        historyData.Action = "Registered";
                        historyData.Who = e.User;
                        break;

                    case "CNPJUpdatedEvent":
                        historyData.Action = "Updated";
                        historyData.Who = e.User;
                        break;

                    case "CNPJRemovedEvent":
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