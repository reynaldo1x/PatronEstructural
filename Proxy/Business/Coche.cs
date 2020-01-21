using Proxy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Business
{
    public class Coche : IService
    {
        private int cLlave;

        public Coche(int _llave)
        {
            cLlave = _llave;
        }

        public string EncenderCoche(int idLlave)
        {
            return "Prendiendo coche";
        }

        public int ObtenerCodigo()
        {
            return cLlave;
        }
    }
}
