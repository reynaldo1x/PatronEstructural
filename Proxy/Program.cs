using Proxy.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int llaveA = 75;
            int llaveB = 3;

            Coche servicio = new Coche(llaveA);
            Proxi proxy = new Proxi(servicio);

            string resVerdadera = proxy.EncenderCoche(llaveA);
            Console.WriteLine(resVerdadera);

            string resFalsa = proxy.EncenderCoche(llaveB);
            Console.WriteLine(resFalsa);

            Console.ReadLine();
        }
    }
}
