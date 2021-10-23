using Notifications.Refactor;
using Notifications.Refactor2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notifications
{
    public class PersistenceService
    {
        //readonly NotificationHandler1 Handler1;
        //readonly NotificationHandler2 Handler2;
        //readonly NotificationHandler3 Handler3;
        readonly IMediator Mediator;

        public PersistenceService(
           // NotificationHandler1 Handler1_
           //,NotificationHandler2 Handler2_
           // ,NotificationHandler3 Handler3_)
           IMediator Mediator_
           )
        {
            //Handler1 = Handler1_;
            //Handler2 = Handler2_;
            //Handler3 = Handler3_;
            Mediator = Mediator_;
        }
        public void SaveChanges()
        {
            // logica para guardar los camvio
            //Handler1.Handle("SaveChanges");
            //Handler2.Handle("SaveChanges");
            //Handler3.Handle("SaveChanges");
            Mediator.Publish("SaveChanges");
        }
        
    }
}
