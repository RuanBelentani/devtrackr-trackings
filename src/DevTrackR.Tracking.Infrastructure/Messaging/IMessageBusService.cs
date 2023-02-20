using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTrackR.Tracking.Infrastructure.Messaging
{
    public interface IMessageBusService
    {
        void Publish(object data, string routingKey);
    }
}