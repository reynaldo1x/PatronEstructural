using Composite.DTO;
using Composite.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Business
{
    public class Hijo : IComponent
    {
        protected ClavePresupuestal cp;

        public Hijo(ClavePresupuestal clave)
        {
            cp = clave;
        }

        public decimal ObtenerTotal()
        {
            decimal dTotal = (cp.Enero + cp.Febrero + cp.Marzo + cp.Abril + cp.Mayo + cp.Junio +
                cp.Julio + cp.Agosto + cp.Septiembre + cp.Octubre + cp.Noviembre + cp.Diciembre);

            return dTotal;
        }

    }
}
