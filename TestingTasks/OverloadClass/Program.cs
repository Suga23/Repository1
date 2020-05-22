using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
// Создать класс Money для работы с денежными суммами в котором для рублей и копеек предусмотрены независимые целочисленные данные. Реализовать метод вывода суммы на экран. 
// На основе класса Money создать класс Good для работы с товаром. Предусмотреть метод, осуществляющий уменьшение цены на заданное число процентов. 
namespace TestingTasks
{
    class Money
    {
        decimal sum;
        public Money(decimal rub, decimal cent)
        {
            sum = rub + (cent / 100);
            Console.WriteLine($"Сумма без скидки равна {sum}");
        }
        public Money(decimal rub, decimal cent, decimal percent)
        {
            if (percent >= 100)
            {
                Console.WriteLine("Ошибка.");
            }
            else
            {
                cent += rub * 100;
                rub = cent - (cent * percent / 100);
                sum = Math.Round(rub / 100, 2);
                Console.WriteLine($"Сумма за вычетом скидки равна {sum}");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Money[] ob = new Money[5];
            ob[0] = new Money(100, 550);
            ob[1] = new Money(500, 68);
            ob[2] = new Money(500, 720, 5);
            ob[3] = new Money(250, 0, 50);
            ob[4] = new Money(1500, 250, 100);
            Console.ReadLine();
        }
    }
}
