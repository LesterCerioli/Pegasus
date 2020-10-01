﻿using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.CPFEvents
{
    public class CPFRegisteredEvent : Event
    {
        public CPFRegisteredEvent(Guid id, string numCPF) 
        {
            Id = id;
            NumCPF = numCPF;
            AggregateId = id;

        }

        public Guid Id { get; set; }
        public string NumCPF { get; private set; }

    }
}
