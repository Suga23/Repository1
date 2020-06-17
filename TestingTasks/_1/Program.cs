using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    /*
     Создать класс с двумя переменными. Добавить функцию вывода на
     экран и функцию изменения этих переменных. Добавить функцию,
     которая находит сумму значений этих переменных, и функцию 
     которая находит наибольшее значение из этих двух переменных.

         */
    class Perem
    {
        int a, b;
        public Perem(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        //функция вывода
        public string Show()
        {
            return $"переменная a1: {a} и b1: {b}";
        }
        //функция изменения этих переменных
        public int Diference(int a, int b)
        {
            return a + b;
            // return $"Новая переменная a1: {a} и b1: {b}";
        }
        public int Diference(int a, int b, int c)
        {
            return a + b + c;
        }
        public bool Diference_bool(int x, int y)
        {
            if (x > y)
            {
                return true;
            }
            else if (y > x)
            {
                return false;
            }
            return false;
        }
        public void Diference(ref int a, ref int b)
        {
            Console.WriteLine("a + b = " + (a + b));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 5;
            int b1 = 6;
            int r1, r2;
            Perem p = new Perem(a1, b1);
            Console.WriteLine(p.Show());

            Console.WriteLine("Введите два числа ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            r1 = p.Diference(a1, a);
            r2 = p.Diference(b1, b);
            Console.WriteLine("1 Diference " + r1 + "  " + r2);
            Console.WriteLine("2 Diference sum " + p.Diference(r1, r2, 15));

            if (p.Diference_bool(r1, r2))
            {
                Console.WriteLine(" Diference_bool  a1 > b1");
            }
            else
            {
                Console.WriteLine("3 Diference_bool  b1 > a1");
            }
            p.Diference(ref r1, ref r2);
            Console.ReadLine();
        }
    }
}
