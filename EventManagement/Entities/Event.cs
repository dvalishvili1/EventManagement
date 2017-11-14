﻿using EventManagement.ValueObjects;
using Shared;

namespace EventManagement.Entities
{
    public abstract class Event : AggregateRoot
    {
        private EventDescription EventDescription { get; set; }

        private EventTitleSummary EventTitle { get; set; }
        public Event()
        {
            var concert = new Concert(new EventId(""), null, null);            
        }
        //public Event(EventId eventId, EventDescription eventDescription, EventTitleSummary title)
        //{
        //    EventDescription = eventDescription;
        //    EventTitle = title;
        //    Id = eventId;
        //}
    }
}
