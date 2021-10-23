using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notifications.Refactor2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notifications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        IMediator Mediator;
        public NotificationController(IMediator Mediator_)
        {
            Mediator = Mediator_;
        }
        [HttpGet]
        public IActionResult SaveChanges()
        {
            //PersistenceService service = new PersistenceService(
            //    new Refactor.Mediator(new NotificationHandler1(), new NotificationHandler2(), new NotificationHandler3()));
            PersistenceService service = new PersistenceService(Mediator);

            service.SaveChanges();
            return Ok("Save");

        }
    }
}
