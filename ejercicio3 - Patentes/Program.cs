using System;
using System.Data.SqlTypes;

namespace GeneradorDePatentes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, A1, A2, A3;
            string letra, B1, B2, B3;

            letra = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine("Ingrese un número para generar la patente: ");
            num = Convert.ToInt32(Console.ReadLine());

            A1 = (num / 100) % 10;
            A2 = (num / 10) % 10;
            A3 = (num % 10);


            B1 = letra.Substring((num / 676000) % 26, ((num / 676000) % 26 - (num / 676000) % 26) + 1);
            B2 = letra.Substring((num / 26000) % 26, ((num / 26000) % 26 - (num / 26000) % 26) + 1);
            B3 = letra.Substring((num / 1000) % 26, ((num / 1000) % 26 - (num / 1000) % 26) + 1);

            Console.WriteLine("Patente generada:");
            Console.WriteLine(B1 + B2 + B3 + A1 + A2 + A3);

        }
    }
}
