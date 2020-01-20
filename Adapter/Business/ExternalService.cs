using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Business
{
    public class ExternalService : IExternalService
    {
        public string GetTotalString()
        {
            return "001542";
        }
    }
}
