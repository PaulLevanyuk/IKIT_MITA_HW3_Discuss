using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jay = new Jay();
            var SilentBob = new SilentBob();
            var Numbertrom = new Numbertron();
            int k;
            Console.WriteLine("Введите колличество чисел:\n");
            while (true)
            {
                try
                {
                    k = Convert.ToInt32(Console.ReadLine());
                    if (k > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверное значение, введите целое, положительное число\n");
                    }
                }
                catch (FormatException exception)
                {
                   Console.WriteLine("Неверное значение, введите целое, положительное число\n");
                }
            }
             Numbertrom.NewNumberevent += Jay.FetchNewNumber;
            Numbertrom.NewNumberevent += SilentBob.FetchNewNumber;
            for (int i = 0; i < k; i++)
            {
                Numbertrom.Generate();
            }
           
            if (Jay.Score>SilentBob.Score)
            {
                Console.WriteLine("{0} wins",Jay.Name);
            } else if (Jay.Score<SilentBob.Score)
            {
                Console.WriteLine("{0} wins",SilentBob.Name);
            } else if (Jay.Score==SilentBob.Score)
            {
                Console.WriteLine("DRAW");
            }
            Console.ReadKey();
        }
    }
}
