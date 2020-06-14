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
        int a;
        public Counter()
        {
            a = 0;
        }
        public Counter(int a)
        {
            this.a = a;
        }

        public int Increment_(int dia)
        {
            while(a < dia)
            {
                a++;
            }
            return a;
        }
        public int Decrement_(int dia)
        {
            while(a > dia)
            {
                a--;                
            }
            Console.WriteLine(a_Counter);
            return a;
        }
        public int a_Counter
        {
            get {
                return a;
            }            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter obj = new Counter(15);
            Console.WriteLine(obj.Increment_(100));
            Console.ReadLine();
        }
    }
}
