using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMediatR.Notifications;
using WebApiMediatR.Ports;

namespace WebApiMediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        readonly IMediator Mediator;
        public MessageController(IMediator Mediator_)
        {
            Mediator = Mediator_;
        }

        [HttpGet("SendAndWaitForResponse")]
        public async Task<IActionResult> SendAndWaitforResponse()
        {
            var response = await Mediator.Send(new Ping());
            return Ok(response);
        }
        [HttpGet("SendWithoutResponse/message")]
        public async Task<IActionResult> SendWithOutReponse(string message)
        {
            var request = new OneWay();
            request.Message = message;
            var response = await Mediator.Send(request);
            return Ok();
        }
        [HttpGet("SendWithOutputPort/name")]
        public async Task<IActionResult> SendWithOutputPort(string name)
        {
            var presenter = new Presenter();
            var request = new CreateProduct(name,presenter);
            //request.Message = message;
            var response = await Mediator.Send(request);
            return Ok(presenter.Content);
        }
        [HttpGet("sendNotification")]
        public async Task<IActionResult> SendNotifications()
        {
            await Mediator.Publish(new PingNotification());
            return Ok();
        }
    }
}
