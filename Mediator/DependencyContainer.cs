using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddMediator(this IServiceCollection servicesCollection,Assembly HandlerAssembly)
        {
            servicesCollection.AddSingleton<IMediator>(provider =>
                new Mediator(HandlerAssembly));
            return servicesCollection;
        }
    }
}
