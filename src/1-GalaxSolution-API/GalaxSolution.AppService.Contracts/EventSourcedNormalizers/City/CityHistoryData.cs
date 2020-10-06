using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.AppService.Contracts.EventSourcedNormalizers.City
{
    public class CityHistoryData
    {
        public string Action { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Actived { get; set; }
        public object Timestamp { get; internal set; }
    }
}
