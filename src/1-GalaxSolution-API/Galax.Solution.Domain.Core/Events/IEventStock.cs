using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Core.Events
{
    public interface IEventStock
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
