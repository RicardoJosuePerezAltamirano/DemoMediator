using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMediatR.Ports;

namespace WebApiMediatR
{
    public class CreateProduct : IRequest
    {
        public CreateProduct(string name_,ICreateProductOutputPort outputPort_)
        {
            Name = name_;
            OutputPort = outputPort_;
        }
        public string Name { get; set; }
        public ICreateProductOutputPort OutputPort { get;  }
    }
}
