using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notifications.Refactor2
{
    public interface INotificationHandler
    {
        void Handle(string message);
    }
}
