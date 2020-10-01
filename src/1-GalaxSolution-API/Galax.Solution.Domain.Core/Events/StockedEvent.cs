﻿using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Core.Events
{
    public class StockedEvent : Event
    {
        
        public StockedEvent(Event theEvent, string data, string user)
        {
            Id = Guid.NewGuid();
            AggregateId = theEvent.AggregateId;
            MessageType = theEvent.MessageType;
            Data = data;
            User = user;

        }
        protected StockedEvent() { }
        public Guid Id { get; private set; }
        public string Data { get; private set; }
        public string User { get; private set; }

    }
}
