using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalaxSolution.AppService.Contracts.EventSourcedNormalizers.LocalStorage
{
    public static class LocalStorageHistory
    {
        public static IList<LocalStorageHistoryData> HistryData { get; set; }
        public static List<LocalStorageHistoryData> HistoryData { get; private set; }

        public static IList<LocalStorageHistoryData> ToJavaScriptLocalStorageHistory(IList<StoredEvent> storedEvents)
        {
            HistoryData = new List<LocalStorageHistoryData>();
            LocalStorageHistoryDeserializer(storedEvents);

            var sorted = HistoryData.OrderBy(c => c.Timestamp);
            var list = new List<LocalStorageHistoryData();
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
                };

            }
        }

        private static void LocalStorageHistoryDeserializer(IList<StoredEvent> storedEvents)
        {
            throw new NotImplementedException();
        }

        private static void LocalStprageHistoryDeserializer(IList<StoredEvent> storedEvents)
        {
            throw new NotImplementedException();
        }
    }

    public class StoredEvent
    {
    }
}
