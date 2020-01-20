using Decorator.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        public class CrearCuentaxPagar
        {
            public void Main()
            {
                var cxp = new CuentasxPagar();
                var bd1 = new HistorialDecorator(cxp);
                var bd2 = new CorreoDecorator(bd1);
                bd2.Ejecutar();

                Console.ReadLine();
            }
        }

        public static void Main(string[] args)
        {
            new CrearCuentaxPagar().Main();
        }
    }
}
