using System;
using System.Collections.Generic;
using System.Linq;


namespace GalaxSolution.AppService.Contracts.EventSourcedNormalizers.City
{
    public static class CityHistory
    {
        public static IList<CityHistoryData> HistryData { get; set; }
        public static List<CityHistoryData> HistoryData { get; private set; }

        public static IList<CityHistoryData> ToJavaScriptCityHistory(IList<StoredEvent> storedEvents)
        {
            HistoryData = new List<CityHistoryData>();
            CityHistoryDeserializer(storedEvents);

            var sorted = HistoryData.OrderBy(c => c.Timestamp);
            var list = new List<CityHistoryData();
            var last = new CityHistoryData();

            foreach (var change in sorted)
            {
                var jsslot = new CityHistoryData
                {
                    Id = change.Id == Guid.Empty.ToString() || change.Id == last.Id
                        ? ""
                        : change.Id,
                    Name = string.IsNullOrWhiteSpace(change.Nome) || change.Nome == last.Nome
                        ? ""
                        : change.Name,
                };

            }
        }

        private static void CityHistoryDeserializer(IList<StoredEvent> storedEvents)
        {
            throw new NotImplementedException();
        }
    }

    public class StoredEvent
    {
    }
}
