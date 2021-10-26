using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiMediatR.Notifications
{
    public class PingNotificationHandler1 : INotificationHandler<PingNotification>
    {
        public Task Handle(PingNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Ping 1...");
            return Task.CompletedTask;

        }
    }
}
