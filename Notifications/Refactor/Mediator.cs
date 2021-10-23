using Notifications.Refactor2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notifications.Refactor
{
    public class Mediator:IMediator
    {
        //readonly NotificationHandler1 Handler1;
        //readonly NotificationHandler2 Handler2;
        //readonly NotificationHandler3 Handler3;
        readonly IEnumerable<INotificationHandler> Handlers;
        public Mediator(
           // NotificationHandler1 Handler1_
           //, NotificationHandler2 Handler2_
           // , NotificationHandler3 Handler3_)
           IEnumerable<INotificationHandler> Handlers_
            )
        {
            //Handler1 = Handler1_;
            //Handler2 = Handler2_;
            //Handler3 = Handler3_;
            Handlers = Handlers_;
        }
        public void Publish(string message)
        {
            //Handler1.Handle("SaveChanges");
            //Handler2.Handle("SaveChanges");
            //Handler3.Handle("SaveChanges");
            Handlers.ToList().ForEach(o =>
            {
                o.Handle(message);
            });
        }
    }
}
