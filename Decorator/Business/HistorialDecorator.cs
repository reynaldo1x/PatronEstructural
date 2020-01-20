using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Business
{
    public class HistorialDecorator : IComponent
    {
        private IComponent DecoratorService;

        public HistorialDecorator(IComponent _component)
        {
            DecoratorService = _component;
        }

        public void Ejecutar()
        {
            DecoratorService.Ejecutar();
            this.GuardarHistorial();
        }

        private void GuardarHistorial()
        {
            Console.WriteLine("Se ha creado un historial de la Cuenta por Pagar");
        }
    }
}
