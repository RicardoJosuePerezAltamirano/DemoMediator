using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiMediatR.Notifications
{
    public class PingNotificationHandler2 : INotificationHandler<PingNotification>
    {
        public Task Handle(PingNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Ping 2...");
            return Task.CompletedTask;
        }
    }
}
