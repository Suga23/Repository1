using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
/*Описать класс, реализующий десятичный счетчик, 
 * который может увеличивать или уменьшать свое значение на единицу в заданном диапазоне. 
 * Предусмотреть инициализацию счетчика значениями по умолчанию и произвольными значениями. 
 * Счетчик имеет два метода: увеличения и уменьшения, — и свойство, 
 * позволяющее получить его текущее состояние. 
 * Написать программу, демонстрирующую все возможности класса.*/
namespace Counter
{
    class Counter
    {
        int a, dia_min, dia_max;
        public Counter()
        {
            a = 0;
        }
        public Counter(int a, int dia_min, int dia_max)
        {
            this.a = a;
            this.dia_min = dia_min;
            this.dia_max = dia_max;
        }

        public int Increment_()
        {
            while(A < dia_max)
            {
                A++;
            }
            return A;
        }
        public int Decrement_()
        {
            while(A > dia_min)
            {
                A--;
            }
            return A;
        }
        private int A
        {
            get
            {
                if (diapason(a, dia_min, dia_max)) {
                    Console.WriteLine(a);
                    return a;
                } else
                {
                    throw new ArgumentOutOfRangeException("Нарушение диапазона.");
                }
            }
            set
            {
                if(diapason(a, dia_min, dia_max))
                {
                    a = value;
                } else
                {
                    throw new ArgumentOutOfRangeException("Нарушение диапазона.");
                }
            }
        }
        private bool diapason(int a, int dia_min, int dia_max)
        {
            if (a >= dia_min && a <= dia_max && dia_min < dia_max)
            {
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter obj = new Counter(15, -15, 321);
            Console.WriteLine($"Положение точки A :\n{obj.Decrement_()}");
            Console.ReadLine();
        }
    }
}
