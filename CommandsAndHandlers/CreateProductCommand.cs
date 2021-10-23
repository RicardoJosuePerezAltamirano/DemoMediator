using Mediator;
using System;

namespace CommandsAndHandlers
{
    public class CreateProductCommand:IRequest<int>
    {
        // esta peticion que quiere el id del producto que se haya creado
        public string Name { get; set; }// para crear el producto se necesita el nombre del producto 

    }
}
