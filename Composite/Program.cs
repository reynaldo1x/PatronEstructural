using Composite.Business;
using System;
using Composite.DTO;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            UA UnidadA = new UA("1");
            ClavePresupuestal cp = new ClavePresupuestal();
            cp.Enero = 100;
            cp.Febrero = 200;

            Hijo ClavePresupuestal = new Hijo(cp);
            UnidadA.AgregarComponente(ClavePresupuestal);

            decimal total = UnidadA.ObtenerTotal();
        }
    }
}
