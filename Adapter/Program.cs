using Adapter.Business;
using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Adaptador adp = new Adaptador(new ExternalService());
            Console.WriteLine(adp.GetTotal());
            Console.ReadLine();
        }
    }
}
