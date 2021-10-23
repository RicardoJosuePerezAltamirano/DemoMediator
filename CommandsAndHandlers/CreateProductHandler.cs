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
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>// tipo de request , tipo de retorno
    {
        // todo comando necesita un manejador
        public Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // logica para crear un producto 
            Debug.WriteLine($"crear proucto nuevo {request.Name}");
            return Task.FromResult(new Random().Next(1, 1000));
        }
    }
}
