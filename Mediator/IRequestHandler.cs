using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    // manejador de peticiones , manejar respuesta de objetos que no quieran que se les devuelva alguna respuesta, peticiones que no quieren que se les devuelva un valor
    public interface IRequestHandler<RequestType> where RequestType :IRequest
    {
        Task Handle(RequestType request, CancellationToken cancellationToken);
    }
    // manejador de peticiones que requieren de un tipo de respuesta
    public interface IRequestHandler<RequestType,ResponseType> where RequestType : IRequest<ResponseType>
    {
        Task<ResponseType> Handle(RequestType request, CancellationToken cancellationToken);
    }
}
