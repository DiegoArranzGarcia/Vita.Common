﻿using System;

namespace Vita.Core.Domain.Events
{
    public abstract class IntegrationEvent
    {
        public Guid Id { get; set; }
        public DateTimeOffset OcurredAt { get; set; } = DateTimeOffset.UtcNow;
        public string Type { get; set; }
    }
}
