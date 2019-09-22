using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                int nemuOption = Convert.ToInt32(Console.ReadLine());

                if(nemuOption == 0)
                {
                    break;
                }
            }
        }
    }
}
