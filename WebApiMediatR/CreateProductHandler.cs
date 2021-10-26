using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiMediatR
{
    public class CreateProductHandler : AsyncRequestHandler<CreateProduct>
    {
        protected override Task Handle(CreateProduct request, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"logica de creacion del producto");
            Debug.WriteLine($"{request.Name}");
            request.OutputPort.Handle(100);
            return Task.CompletedTask;
        }
    }
}
