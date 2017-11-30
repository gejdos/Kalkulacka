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
            switch (operacia.ToLower())
            {
                case "s":
                    Spocitaj(PrvyParameter(operacia), DruhyParameter());
                    break;
                case "o":
                    Odpocitaj(PrvyParameter(operacia), DruhyParameter());
                    break;
                case "n":
                    Vynasob(PrvyParameter(operacia), DruhyParameter());
                    break;
                case "d":
                    Vydel(PrvyParameter(operacia), DruhyParameter());
                    break;
                case "f":
                    VypocitajFaktorial(PrvyParameter(operacia));
                    break;
                case "exit":
                    Console.WriteLine("Goodbye!");
                    System.Threading.Thread.Sleep(1000);
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Operacia nebola najdena.\nSkuste to znova.");
                    break;
            }
        }

        private static double PrvyParameter(string operacia)
        {
            string op;

            if (operacia == "f")
            {
                op = " cele ";
            }
            else
            {
                op = " prve ";
            }

            Console.WriteLine("Zadajte{0}cislo.", op);
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
            int cislo;

            if (!int.TryParse(n.ToString(), out cislo))
            {
                Console.WriteLine("Vstupnou hodnotou pre vypocet faktorialu musi byt cele cislo.");
                return;
            }

            F = 1;
            for (int i = 2; i <= n; i++)
            {
                F = F * i;
            }

            Console.WriteLine("{0}! = {1}", n, F);
        }

    }
}
