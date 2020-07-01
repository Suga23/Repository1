using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/* Составить описание класса для определения одномерных массивов 
 * строк фиксированной длины. Предусмотреть контроль выхода за 
 * пределы массива, возможность обращения к отдельным строкам массива 
 * по индексам, выполнения операций поэлементного сцепления двух массивов 
 * с образованием нового массива, слияния двух массивов с исключением 
 * повторяющихся элементов, а также вывод на экран элемента массива по 
 * заданному индексу и всего массива.*/

class ArrayContsr
{
    string[] arr;
    public int Length;
    public ArrayContsr(int size)
    {
        Length = size;
        arr = new string[size];
    }
    public string this[int index]
    {
        get
        {
            try
            {
                if (IndexCheck(index))
                {
                    return arr[index];
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Массив не сконструирован.");
            }
            return null;
        }
        set
        {
            try {
            if(IndexCheck(index))
            {
                arr[index] = value;
            }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
    public void ArrayUnion(string[] str1, params string[] str2)
    {
        Console.WriteLine("Создание нового массива: ");
        string[] StrArr = str1.Concat(str2).ToArray();

        for (int i = 0; i < StrArr.Length; i++)
        {
            Console.WriteLine(StrArr[i]);
        }
    }
    //public void ArrayFill()
    //{
    //    Console.WriteLine("\nЗаполнение массива: ");
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        arr[i] = str[i];
    //        Console.WriteLine($"{arr[i]} ");
    //    }
    //}
    public void TwoArrays(ArrayContsr arr1, ArrayContsr arr2)
    {
        Console.WriteLine("\nСлияние массивов: ");
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] == arr2[i])
            {
                Console.WriteLine(arr1[i]);
            } else {
            arr1[i] += arr2[i];
            Console.WriteLine(arr1[i]);
            }
        }
    } 
    public void Finderr(int a)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == a)
            {
                Console.WriteLine($"\nСодержимое индекса {a}: {arr[a]}");
            }
        }
        Console.WriteLine("Весь массив:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    private bool IndexCheck(int index)
    {
        if (index >= 0 && index < Length)
        {
            return true;
        }
        return false;
    }
}
namespace Description
{
    class Program
    {
        static void Main(string[] args)
        {           
            ArrayContsr arr = new ArrayContsr(3);
            ArrayContsr arr1 = new ArrayContsr(3);
            string[] rrst = new string[] { "один", "два", "три", "четыре" };
            for (int i = 0; i < 4; i++)
            {
                //string a = Console.ReadLine();
                arr[i] = rrst[i];
                Console.WriteLine(arr[i]);
            }

            string[] rst = new string[] { "четыре", "пять", "шесть" };
            for (int i = 0; i < rst.Length; i++)
            {
                arr1[i] = rst[i];
            }
            //arr1.Finderr(2);
            //arr.TwoArrays(arr, arr1);
            Console.ReadLine();
        }
    }
}
