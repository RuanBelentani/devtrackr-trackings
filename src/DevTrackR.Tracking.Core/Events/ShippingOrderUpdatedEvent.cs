using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTrackR.Tracking.Core.Events
{
    public class ShippingOrderUpdatedEvent
    {
        public ShippingOrderUpdatedEvent(string trackingCode, string contactEmail, string description)
        {
            TrackingCode = trackingCode;
            ContactEmail = contactEmail;
            Description = description;
        }

        public string TrackingCode { get; private set; }
        public string ContactEmail { get; private set; }
        public string Description { get; private set; }
    }
}