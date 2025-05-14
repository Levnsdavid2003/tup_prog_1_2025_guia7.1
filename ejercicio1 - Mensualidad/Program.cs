using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesadaNiñas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double monto, prc1, prc2, prc3, prc4, montoedad1, montoedad2, montoedad3, montoedad4;
            int edad1, edad2, edad3, edad4, edades;

            Console.WriteLine("Escriba el monto a repartir para las niñas:");
            monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese las edades de las 4 Niñas");
            edad1 = Convert.ToInt32(Console.ReadLine());
            edad2 = Convert.ToInt32(Console.ReadLine());
            edad3 = Convert.ToInt32(Console.ReadLine());
            edad4 = Convert.ToInt32(Console.ReadLine());

            edades = edad1 + edad2 + edad3 + edad4;

            prc1 = (edad1 * 100) / edades;
            prc2 = (edad2 * 100) / edades;
            prc3 = (edad3 * 100) / edades;
            prc4 = (edad4 * 100) / edades;

            montoedad1 = monto * prc1 / 100;
            montoedad2 = monto * prc2 / 100;
            montoedad3 = monto * prc3 / 100;
            montoedad4 = monto * prc4 / 100;

            Console.WriteLine("Niña 1: {0} años. Porcentaje asignado: {1}%. Monto a cobrar: {2}$", edad1, prc1, montoedad1);
            Console.WriteLine("Niña 2: {0} años. Porcentaje asignado: {1}%. Monto a cobrar: {2}$", edad2, prc2, montoedad2);
            Console.WriteLine("Niña 3: {0} años. Porcentaje asignado: {1}%. Monto a cobrar: {2}$", edad3, prc3, montoedad3);
            Console.WriteLine("Niña 4: {0} años. Porcentaje asignado: {1}%. Monto a cobrar: {2}$", edad4, prc4, montoedad4);
            Console.ReadKey();
        }
    }
}
