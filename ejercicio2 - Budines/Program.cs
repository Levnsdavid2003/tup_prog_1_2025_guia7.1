using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Budines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double masa, masaRestante;
            int budines, paquetes, cajas, budinSobrante, paqueteSobrante;

            Console.WriteLine("Ingrese la cantidad de masa a producir en Kg");
            masa = Convert.ToDouble(Console.ReadLine());

            budines = (int)(masa * 1000) / 55;
            budinSobrante = (budines % 12);
            masaRestante = (masa * 1000) % 55;

            paquetes = budines / 12;
            paqueteSobrante = budines % 12;

            cajas = paquetes / 20;
            
            Console.WriteLine("Budines en total: {0}. Paquetes producidos: {1}. Cajas producidas: {2}", budines, paquetes, cajas);
            Console.WriteLine("Masa restante: {0}grs. Budines sobrantes: {1}. Paquetes sobrantes: {2}", masaRestante, budinSobrante, paqueteSobrante);
            Console.ReadKey();

        }
    }
}
