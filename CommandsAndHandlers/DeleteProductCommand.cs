using Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsAndHandlers
{
    public class DeleteProductCommand:IRequest// no quiero una respuesta
    {
        /*hace la peticion*/
        public int Id { get; set; }// necesito el id para eliminar el prouto
    }
}
