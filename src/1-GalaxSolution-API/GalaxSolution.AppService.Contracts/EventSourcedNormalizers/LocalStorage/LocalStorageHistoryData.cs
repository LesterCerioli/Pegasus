using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.AppService.Contracts.EventSourcedNormalizers.LocalStorage
{
    public class LocalStorageHistoryData
    {
        public object Name { get; internal set; }
        public object Id { get; internal set; }
        public object Timestamp { get; internal set; }
    }
}
