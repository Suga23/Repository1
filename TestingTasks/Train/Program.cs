using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

/* Создайте структуру с именем train, содержащую поля: название пункта назначения,
 номер поезда, время отправления. Ввести данные в массив из пяти элементов типа train,
 упорядочить элементы по номерам поездов. Добавить возможность вывода информации о поезде,
 номер которого введен пользователем. Добавить возможность сортировки массива по пункту
 назначения, причем поезда с одинаковыми пунктами назначения должны быть упорядочены
 по времени отправления. Как получить мой архив гугл. */
namespace Train
{
    struct Train
    {
        public string Destination;
        public int TrainNumber;
        public DepartureTime DepartureTime;
    }
    class CrazyTrain
    {
        Train tr;
        public CrazyTrain(string Destination, int TrainNumber, DepartureTime DepartureTime)
        {
            tr.Destination = Destination;
            tr.TrainNumber = TrainNumber;
            tr.DepartureTime = DepartureTime;
        }
        #region SortBytrainNumber
        public void SortByTrainNumber(params CrazyTrain[] arr)
        {
            CrazyTrain k;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].tr.TrainNumber > arr[j].tr.TrainNumber)
                    {
                        k = arr[i];
                        arr[i] = arr[j];
                        arr[j] = k;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Информация о поезде №{arr[i].tr.TrainNumber}:\nНаправление: {arr[i].tr.Destination}\nВремя отправления: {arr[i].tr.DepartureTime.SummerTime()}\n");
            }
        }
        #endregion
        public void SortByDestination(params CrazyTrain[] arr)
        {
            CrazyTrain a;            
            for (int i = 0; i < arr.Length - 1; i++)
            {                
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].tr.Destination == arr[j].tr.Destination)
                    {
                        if (arr[i].tr.DepartureTime > arr[j].tr.DepartureTime)
                        {
                            a = arr[i];
                            arr[i] = arr[j];
                            arr[j] = a;
                        }
                    }
                    if ((arr[i].tr.Destination.ToCharArray()[0] > arr[j].tr.Destination.ToCharArray()[0]))                    
                    {
                        a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Информация о поезде №{arr[i].tr.TrainNumber}:\nНаправление: {arr[i].tr.Destination}\nВремя отправления: {arr[i].tr.DepartureTime.SummerTime()}\n");
            }
        }
        public void SortByDepartureTime(params CrazyTrain[] arr)
        {
            CrazyTrain a;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].tr.DepartureTime > arr[j].tr.DepartureTime)
                    {
                        //Console.WriteLine($"arr[{i}] = { arr[i].tr.DepartureTime.SummerTime()}, arr[{j}] = { arr[j].tr.DepartureTime.SummerTime()}");
                        a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                        //Console.WriteLine($"arr[{i}] = { arr[i].tr.DepartureTime.SummerTime()}, arr[{j}] = { arr[j].tr.DepartureTime.SummerTime()}\n\n");
                    }
                }                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Информация о поезде №{arr[i].tr.TrainNumber}:\nНаправление: {arr[i].tr.Destination}\nВремя отправления: {arr[i].tr.DepartureTime.SummerTime()}\n");
            }
        }
    public void TrainInfo() 
        {
            Console.WriteLine($"Информация о поезде №{tr.TrainNumber}:\nНаправление: {tr.Destination}\nВремя отправления: {tr.DepartureTime.SummerTime()}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CrazyTrain[] trains = new CrazyTrain[5];
            trains[0] = new CrazyTrain("Царицыно", 4, new DepartureTime(16, 30));
            trains[1] = new CrazyTrain("Столбовая", 2, new DepartureTime(11, 20));
            trains[2] = new CrazyTrain("Красный Строитель", 5, new DepartureTime(15, 50));
            trains[3] = new CrazyTrain("Бутово", 1, new DepartureTime(11, 20));
            trains[4] = new CrazyTrain("Подольск", 3, new DepartureTime(15, 30));
            Console.WriteLine("Нажмите:\n1 - информация о поездах\n2 - сортировать по номеру поезда\n3 - cортировать по направлению\n4 - сортировать по времени");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Информация о поездах: ");
                    for (int i = 0; i < trains.Length; i++)
                    {
                        trains[i].TrainInfo();
                    }
                    break;
                case 2:
                    Console.WriteLine("Сортировать по номеру поезда:");
                        trains[1].SortByTrainNumber(trains);                                        
                        break;
                case 3:
                    Console.WriteLine("Сортировать по направлению:");
                        trains[0].SortByDestination(trains);                    
                        break;
                case 4:
                    Console.WriteLine("Сортировать по времени:");
                        trains[2].SortByDepartureTime(trains);                   
                        break;
            }
            Console.ReadLine();
        }
    }
}