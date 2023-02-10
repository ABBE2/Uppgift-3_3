using System;
namespace uppgift3_3
{
    class uppgift3_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int tid = Convert.ToInt32(Console.ReadLine());
            int pris = (tid * 80);
            if (pris > 950)
                Console.WriteLine("det blir 950kr");
            else
            {
                Console.WriteLine("Det blir " + pris + "kr");
            }
        }
    }
}