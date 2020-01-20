using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Business
{
    public class BaseDecorator : IComponent
    {
        private IComponent DecoratorService;

        public BaseDecorator(IComponent _component)
        {
            DecoratorService = _component;
        }

        public void Ejecutar()
        {
            DecoratorService.Ejecutar();
        }
    }
}
