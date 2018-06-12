﻿using System;
using System.Collections.Generic;

namespace Elect.Logger.Models.Event
{
    [Serializable]
    public class EventModel
    {
        public Guid Id { get; } = Guid.NewGuid();

        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.UtcNow;

        public EventType Type { get; set; } = EventType.Visit;

        // Visit

        public UtmModel Utm { get; set; }

        public RefererModel Referer { get; set; }

        public DateTimeOffset StartedTime { get; set; } = DateTimeOffset.UtcNow;

        /// <summary>
        ///     Only Visit have End Time
        /// </summary>
        public DateTimeOffset? EndedTime { get; set; }

        // Data

        /// <summary>
        ///     Canbe a Page/Screen/Popup or Element in a Screen
        /// </summary>
        public string Element { get; set; }

        public Dictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }
}