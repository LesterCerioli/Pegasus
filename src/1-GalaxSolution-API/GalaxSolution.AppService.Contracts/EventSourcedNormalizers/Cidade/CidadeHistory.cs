using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalaxSolution.AppService.Contracts.EventSourcedNormalizers.Cidade
{
    public static class CidadeHistory
    {
        public static IList<CidadeHistoryData> HistryData { get; set; }
        public static List<CidadeHistoryData> HistoryData { get; private set; }

        public static IList<CidadeHistoryData> ToJavaScriptCidadeHistory(IList<StoredEvent> storedEvents)
        {
            HistoryData = new List<CidadeHistoryData>();
            CidadeHistoryDeserializer(storedEvents);

            var sorted = HistoryData.OrderBy(c => c.Timestamp);
            var list = new List<CidadeHistoryData();
            var last = new CidadeHistoryData();

            foreach (var change in sorted)
            {

            }
        }

        private static void CidadeHistoryDeserializer(IList<StoredEvent> storedEvents)
        {
            throw new NotImplementedException();
        }
    }

    public class StoredEvent
    {
    }
}
