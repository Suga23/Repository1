using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/* Описать класс, реализующий десятичный счетчик, 
 * который может увеличивать или уменьшать свое значение на единицу в заданном диапазоне. 
 * Предусмотреть инициализацию счетчика значениями по умолчанию и произвольными значениями. 
 * Счетчик имеет два метода: увеличения и уменьшения, — и свойство, 
 * позволяющее получить его текущее состояние. 
 * Написать программу, демонстрирующую все возможности класса.*/
namespace Counter
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
            while(dia_min != dia_max)
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
            while(dia_max != dia_min)
            {
                Console.Write($"{dia_max} ");
                Thread.Sleep(500);
                Console.Clear();
                dia_max--;
            }
            return dia_max;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапазон минимального и максимального значений:");
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Counter obj = new Counter(a, b);
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"{obj.Increment_()}");
                    break;
                case 2:
                    Console.WriteLine($"{obj.Decrement_()}");
                    break;
                case 3:
                    Console.Write($"\nДекремент:{obj.Decrement_()}\n");

                    Console.Write($"\nИнкремент:{obj.Increment_()}\n");
                    break;
            }
            Console.ReadLine();
        }
    }
}
