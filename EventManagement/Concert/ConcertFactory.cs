﻿using EventManagement.Entities;
using EventManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventManagement.Concert
{
    public class ConcertFactory
    {
        public static Concert Create(string titleGeo, string titleEng, string description, DateTime concertDate)
        {
            var concert = new Concert(
                new ConcertId(Guid.NewGuid().ToString()),
                new EventTitleSummary(new GeoTitle(titleGeo)).WithAnotherTitle(new EngTitle(titleEng)),
                new EventDescription(concertDate, description)
                );

            return concert;
        }
    }
}
