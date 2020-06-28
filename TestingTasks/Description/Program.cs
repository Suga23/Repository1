using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DynamicArray;
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
    public int this[int index]
    {
        get
        {
            if (IndexCheck(index))
            {
                return index;
            } else
            {
                throw new ArgumentOutOfRangeException("Выход за границы массива.");
            }
        }
        set
        {
            if(IndexCheck(index))
            {
                index = value;
            } else
            {
                throw new ArgumentOutOfRangeException("Выход за границы массива.");
            }
        }
    }
    public void ArrayUnion(string[] str1, params string[] str2)
    {
        Console.WriteLine("Создание нового массива: ");
        string[] StrArr = new string[str1.Length + str2.Length + 1];
        //for (int i = 0; i < StrArr.Length; i++)
        //{
        //    //str1[i].Concat(str2[i]).ToArray()
        //    if (str1[i] == str2[i])
        //    {
        //        StrArr[i] += str1[i];
        //        Console.WriteLine(StrArr[i]);
        //    } else if (StrArr[i] == null)
        //    {
        //        StrArr[i] += str2[i];
        //        Console.WriteLine(StrArr[i]);
        //    }
        //    {
        //        StrArr[i] += str1[i];
        //        Console.WriteLine(StrArr[i]);
        //    }
        //}
        Console.WriteLine($"Длина массива StrArr = {StrArr.Length}");
        for (int i = 0; i < StrArr.Length; i++)
        {
            Console.WriteLine(StrArr[i]);
        }
    }
    public void ArrayFill(params string[] str)
    {
        Console.WriteLine("\nЗаполнение массива: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = str[i];
            Console.WriteLine($"{arr[i]} ");
        }
    }
    public void TwoArrays(string[] arr1, string[] arr2)
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
    public void ArrayFinderr(string[] strarr, int a)
    {
        for (int i = 0; i < strarr.Length; i++)
        {
            if (i == a)
            {
                Console.WriteLine($"\nСодержимое индекса {a}: {strarr[a]}");
            }
        }
        Console.WriteLine("Весь массив:");
        for (int i = 0; i < strarr.Length; i++)
        {
            Console.WriteLine(strarr[i]);
        }
    }
    private bool IndexCheck(int index)
    {
        if (index >= 0 && index <= Length)
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
            string[] rst = new string[3];

            for (int i = 0; i < rst.Length; i++)
            {
                rst[i] = Console.ReadLine();
            }
            ArrayContsr arr = new ArrayContsr(3);
            string[] rrst = new string[] { "один", "два", "три" };
            arr.ArrayFill(rrst);
            // Мы создаём метод, который запоняет наш массив словами.
            arr.ArrayFinderr(rst, 0);
            arr.TwoArrays(rrst, rst);
            arr.ArrayUnion(rrst, rst);
            Console.ReadLine();
        }
    }
}
