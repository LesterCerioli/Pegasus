using Galax.Solution.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace GalaxSolution.AppService.Implementation.EventSourcedNormalizers.Provider
{
    public static class ProviderHistory
    {
        public static IList<ProviderHistoryData> HistoryData { get; set; }

        public static IList<ProviderHistoryData> ToJavaScriptProviderHistory(IList<StockedEvent> stockedEvents)
        {
            HistoryData = new List<ProviderHistoryData>();
            ProviderHistoryDeserializer(stockedEvents);

            var sorted = HistoryData.OrderBy(a => a.TimeStamp);
            var list = new List<ProviderHistoryData>();
            var last = new ProviderHistoryData();

            foreach (var change in sorted)
            {
                var jssSlot = new ProviderHistoryData
                {
                    Id = change.Id == Guid.Empty.ToString() || change.Id == last.Id
                        ? ""
                        : change.Id,
                    SocialReason = string.IsNullOrWhiteSpace(change.SocialReason) || change.SocialReason == last.SocialReason
                        ? ""
                        : change.SocialReason,

                    FantasyName = string.IsNullOrWhiteSpace(change.FantasyName) || change.FantasyName == last.FantasyName
                        ? ""
                        : change.FantasyName,

                    Kind = string.IsNullOrWhiteSpace(change.Kind) || change.Kind == last.Kind
                        ? ""
                        : change.Kind,

                    Telephone = string.IsNullOrWhiteSpace(change.Telephone) || change.Telephone == last.Telephone
                        ? ""
                        : change.Telephone,

                    ContactName = string.IsNullOrWhiteSpace(change.ContactName) || change.ContactName == last.ContactName
                        ? ""
                        : change.ContactName,

                    ContactNumber = string.IsNullOrWhiteSpace(change.ContactNumber) || change.ContactNumber == last.ContactNumber
                        ? ""
                        : change.ContactNumber,

                    Address = string.IsNullOrWhiteSpace(change.Address) || change.Address == last.Address
                        ? ""
                        : change.Address,

                    Number = string.IsNullOrWhiteSpace(change.Number) || change.Number == last.Number
                        ? ""
                        : change.Number,

                    Complement = string.IsNullOrWhiteSpace(change.Complement) || change.Complement == last.Complement
                        ? ""
                        : change.Complement,

                    PostalCode = string.IsNullOrWhiteSpace(change.PostalCode) || change.PostalCode == last.PostalCode
                        ? ""
                        : change.PostalCode,

                    Action = string.IsNullOrWhiteSpace(change.Action) ? "" : change.Action,
                    TimeStamp = change.TimeStamp,
                    Who = change.Who

                };

                list.Add(jssSlot);
                last = change;

            }
            return list;

        }

        private static void ProviderHistoryDeserializer(IEnumerable<StockedEvent> stockedEvents)
        {
            foreach (var e in stockedEvents)
            {
                var historyData = JsonSerializer.Deserialize<ProviderHistoryData>(e.Data);
                historyData.TimeStamp = DateTime.Parse(historyData.TimeStamp).ToString("yyyy'-'MM'-'dd' - 'HH' : 'mm' : 'ss'");

                switch (e.MessageType)
                {
                    case "ProviderRegisteredEvent":
                        historyData.Action = "Registered";
                        historyData.Who = e.User;
                        break;

                    case "ProviderUpdatedEvent":
                        historyData.Action = "Updated";
                        historyData.Who = e.User;
                        break;

                    case "ProviderRemovedEvent":
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