using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    class Kalkulacka
    {
        public static void VyberOperaciu(string operacia)
        {
            switch (operacia)
            {
                case "s":
                    Spocitaj(PrvyParameter(), DruhyParameter());
                    break;
                case "o":
                    Odpocitaj(PrvyParameter(), DruhyParameter());
                    break;
                case "n":
                    Vynasob(PrvyParameter(), DruhyParameter());
                    break;
                case "d":
                    Vydel(PrvyParameter(), DruhyParameter());
                    break;
                case "f":
                    VypocitajFaktorial(PrvyParameter());
                    break;
                case "exit":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Operacia nebola najdena.\nSkuste to znova.");
                    break;
            }
        }

        private static double PrvyParameter()
        {
            Console.WriteLine("Zadajte cislo.");
            return double.Parse(Console.ReadLine());
        }

        private static double DruhyParameter()
        {
            Console.WriteLine("Zadajte druhe cislo.");
            return double.Parse(Console.ReadLine());
        }

        private static void Spocitaj(double a, double b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
        }

        private static void Odpocitaj(double a, double b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, (a - b));
        }

        private static void Vynasob(double a, double b)
        {
            Console.WriteLine("{0} x {1} = {2}", a, b, (a * b));
        }

        private static void Vydel(double a, double b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, (a / b));
        }

        private static void VypocitajFaktorial(double n)
        {
            long F;

            F = 1;
            for (int i = 2; i <= n; i++)
            {
                F = F * i;
            }

            Console.WriteLine("{0}! = {1}", n, F);
        }

    }
}
