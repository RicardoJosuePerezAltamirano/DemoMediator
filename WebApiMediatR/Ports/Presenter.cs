using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMediatR.Ports
{
    public class Presenter : ICreateProductOutputPort
    {
        public string Content { get; private set; }
        public void Handle(int response)
        {
            Content = $"Id de producto {response}";
        }
    }
}
