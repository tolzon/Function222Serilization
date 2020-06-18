using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionAppSerialization.DomainEvents
{
    public class DoThingEvent : DomainEvent
    {
        public string CustomerId { get; set; }
    }
}
