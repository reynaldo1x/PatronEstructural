using Composite.DTO;
using Composite.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Business
{
    public class UA : IComponent
    {
        protected string ua;
        
        protected List<IComponent> lista;

        public UA(string _ua)
        {
            ua = _ua;
            lista = new List<IComponent>(); ;
        }

        public decimal ObtenerTotal()
        {
            decimal total = 0;

            foreach (var item in lista)
            {
                total += item.ObtenerTotal();
            }

            return total;
        }

        public void AgregarComponente(IComponent comp)
        {
            this.lista.Add(comp);
        }
    }
}
