using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_7_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int liczba = Int32.Parse(Console.ReadLine());

            if (liczba % 2 == 0) 
            {

                Console.WriteLine("Liczba jest liczbą parzystą");
            }

            else

            {
                Console.WriteLine("Liczba nie jest lisczbą parzystą");

            }
            Console.ReadLine();

        }
  
    }
}
