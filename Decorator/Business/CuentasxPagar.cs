using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Business
{
    public class CuentasxPagar : IComponent
    {
        public void Ejecutar()
        {
            Console.WriteLine("CxP creado!");
        }
    }
}
