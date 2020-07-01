using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Threading;
//using Counter;

namespace Typing_0
{
    class Counter
    {
        int dia_min, dia_max;
        public Counter()
        {
            dia_min = 0;
            dia_max += dia_min + 1;
        }
        public Counter(int dia_min, int dia_max)
        {
            this.dia_min = dia_min;
            this.dia_max = dia_max;
        }

        public int Increment_()
        {
            while (dia_min != dia_max)
            {
                Console.Write($"{dia_min} ");
                Thread.Sleep(500);
                Console.Clear();
                dia_min++;
            }
            return dia_min;
        }
        public int Decrement_()
        {
            while (dia_max != dia_min)
            {
                Console.Write($"{dia_max} ");
                Thread.Sleep(500);
                Console.Clear();
                dia_max--;
            }
            return dia_max;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Assembly oka = Assembly.LoadFrom("Counter.csproj");
                Type[] cltypes = oka.GetTypes();
                foreach (Type to in cltypes)
                {
                    Console.WriteLine($"Классы: {to.Name}");
                }
                Console.WriteLine();
                Type first = cltypes[0];
                Console.WriteLine($"Использовано: {first.Name}");
            }
        }
    }
}
