using CommandsAndHandlers;
using Mediator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorClientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        readonly IMediator Mediator;
        public CommandController(IMediator Mediator_)
        {
            Mediator = Mediator_;
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(string name)
        {
            int id= await Mediator.Send(new CreateProductCommand { Name = name });
            return Ok(id);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await Mediator.Send(new DeleteProductCommand { Id=id });
            return Ok("eliminado");
        }
    }
}
