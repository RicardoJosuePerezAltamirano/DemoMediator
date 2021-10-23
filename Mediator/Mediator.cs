using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    public class Mediator : IMediator
    {
        // recibir el ensamblado donde se encuentran los manejadores de peticiones
        Assembly HandlersAssembly;
        public Mediator(Assembly HandlersAssembly_)
        {
            HandlersAssembly = HandlersAssembly_;
        }

        ReturnType Handle<ReturnType,RequestType>(RequestType request,CancellationToken cancellationToken=default)
        {
            // buscara con reflexion un manejador de una peticion, el metodo handle devolvera un tipo apartir de una peticion del tipo request
            ReturnType result = default;
            Type RequestHandlerType;

            if(typeof(ReturnType).IsGenericType)
            {
                RequestHandlerType = typeof(IRequestHandler<,>);//tipo de manejador que se va a buscar en el assembly, si es generico es que requiere un tipo de retorno
            }
            else
            {
                RequestHandlerType = typeof(IRequestHandler<>);
            }
            Type Handler = HandlersAssembly.GetTypes().FirstOrDefault(t => t.GetInterfaces().Any(i => i.IsGenericType
               && i.GetGenericTypeDefinition() == RequestHandlerType
               && i.GetGenericArguments()[0] == request.GetType()));
            if(Handler!=null)
            {
                var HandlerInstance = Activator.CreateInstance(Handler);
                result = (ReturnType)Handler.GetMethod("Handle").Invoke(HandlerInstance, new object[] { request, cancellationToken });
            }
            else
            {
                throw new InvalidOperationException(string.Format("error, manejador no encontrado {0}", request.GetType()));
            }
            return result;
        }
        public Task Send(IRequest request, CancellationToken cancellationToken = default)
        {
            return Handle<Task, IRequest>(request, cancellationToken);
        }

        public Task<ResponseType> Send<ResponseType>(IRequest<ResponseType> request, CancellationToken cancellationToken = default)
        {
            return Handle<Task<ResponseType>, IRequest<ResponseType>>(request, cancellationToken);
        }
    }
}
