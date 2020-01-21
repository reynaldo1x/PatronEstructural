using Proxy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Business
{
    public class Proxi : IService
    {
        private readonly Coche service;

        public Proxi(Coche _service)
        {
            service = _service;
        }

        public string EncenderCoche(int llave)
        {
            if (EsCorrecto(llave))
            {
                return service.EncenderCoche(llave);
            }
            else
            {
                return "Llave no valida";
            }
        }

        private bool EsCorrecto(int llave)
        {
            if (service.ObtenerCodigo().Equals(llave))
                return true;
            return false;
        }
    }
}
