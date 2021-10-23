using Mediator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandsAndHandlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand>
    {
        /*responde la peticion*/
        public Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            //logica para eliminar el producto
            Debug.WriteLine($"eliminando el producto {request.Id}");
            return Task.CompletedTask;
        }
    }
}
