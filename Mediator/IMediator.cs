using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IMediator
    {
        // envia notificaciones , que tipo de peticion quieres
        Task Send(IRequest request, CancellationToken cancellationToken=default);
        Task<ResponseType> Send<ResponseType>(IRequest<ResponseType> request, CancellationToken cancellationToken = default);
    }
}
