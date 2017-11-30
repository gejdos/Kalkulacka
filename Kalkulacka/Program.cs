using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n------------------------------------------------------------------------------------");
                Console.WriteLine("Vyberte operaciu\n-----------------");
                Console.WriteLine("s - spocitaj\no - odpocitaj\nn - vynasob\nd - vydel\nf - vypocitaj faktorial\nexit - ukoncit aplikaciu");
                Console.WriteLine("------------------------------------------------------------------------------------");

                Kalkulacka.VyberOperaciu(Console.ReadLine());

                Console.ReadKey();
            }
        }
    }
}
