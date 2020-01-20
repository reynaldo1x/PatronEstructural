using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Interface
{    

    public class Adaptador : IClient
    {
        private IExternalService _adaptador;

        public Adaptador(IExternalService Adapter)
        {
            _adaptador = Adapter;
        }

        public decimal GetTotal()
        {
            var stotal = _adaptador.GetTotalString();
            return Convert.ToDecimal(stotal);
        }
    }
}
