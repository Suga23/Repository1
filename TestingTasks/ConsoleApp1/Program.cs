using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Train
    {
        public string Destination;
        public int TrainNumber;        
    }
    class CrazyTrain
    {
        Train tr;
        public CrazyTrain(string Destination, int TrainNumber)
        {
            tr.Destination = Destination;
            tr.TrainNumber = TrainNumber;
        }
        public static void Swap(CrazyTrain[] e1, CrazyTrain[] e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка пузырьком
        public static void BubbleSort(CrazyTrain[] array)
        {
            string[] str = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                str[i] += array[i].tr.Destination;
            }
            Array.Sort(str);
            //for (var i = 1; i < array.Length; i++)
            //{
            //    for (var j = 0; j < array.Length - i; j++)
            //    {
            //        if (array[j].tr.Destination > array[j + 1].tr.Destination)
            //        {
            //            Swap(array[j], array[j + 1]);
            //        }
            //    }
            //}
            Console.WriteLine(array);
        }
        public void SortByDestination(params CrazyTrain[] arr)
        {

            #region
            //CrazyTrain k;
            //string[] str = new string[arr.Length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    str[i] += arr[i].tr.Destination;
            //}
            //Array.Sort(str);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    //Console.WriteLine($"arr[{i}] = " + arr[i].tr.Destination);
            //    arr[i].tr.Destination = str[i];
            //    //Console.WriteLine($"arr[{i}] = "+ arr[i].tr.Destination);
            //}

            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    //arr[i].tr.Destination = str[i];
            //    for (int j = 1; j < arr.Length; j++)
            //    {
            //        //arr[i].tr.Destination = str[i];
            //        //Console.WriteLine($"arr[{i}] = {arr[i].tr.Destination}");                                        
            //        if (str[i] == arr[i].tr.Destination)
            //        {

            //            //Console.WriteLine($"arr[{i}] = { arr[i].tr.Destination}, arr[{j}] = { arr[i + 1].tr.Destination}"); 
            //            k = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = k;
            //            //Console.WriteLine($"arr[{i}] = { arr[i].tr.Destination}, arr[{j}] = { arr[i + 1].tr.Destination}\n\n");
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Информация о поезде №{arr[i].tr.TrainNumber}:\nНаправление: {arr[i].tr.Destination}\n");
            //}
            #endregion
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CrazyTrain[] trains = new CrazyTrain[5];
            trains[0] = new CrazyTrain("Царицыно", 4);
            trains[1] = new CrazyTrain("Столбовая", 2);
            trains[2] = new CrazyTrain("Красный Строитель", 5);
            trains[3] = new CrazyTrain("Бутово", 1);
            trains[4] = new CrazyTrain("Подольск", 3);
            Console.WriteLine("Сортировать по направлению:");
            //trains[0].BubbleSort(trains);
            Console.ReadLine();
        }
    }
}
