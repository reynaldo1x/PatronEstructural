using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Business
{
    public class CorreoDecorator : IComponent
    {
        private IComponent DecoratorService;

        public CorreoDecorator(IComponent _component)
        {
            DecoratorService = _component;
        }

        public void Ejecutar()
        {
            DecoratorService.Ejecutar();
            this.EnviarCorreo();
        }

        private void EnviarCorreo()
        {
            Console.WriteLine("Se ha enviado un correo al cliente con el asunto 'CxP creado satisfactoriamente'");
        }
    }
}
