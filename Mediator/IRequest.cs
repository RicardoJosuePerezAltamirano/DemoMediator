using System;

namespace Mediator
{
    // repesentar peticiones que no devuelven un resultado
    public interface IRequest
    {
    }
    // repesentar peticiones que si devuelven un resultado
    public interface IRequest<RequestType>
    {
    }
}
