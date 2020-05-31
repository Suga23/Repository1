using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

/* Создайте структуру с именем train, содержащую поля: название пункта назначения,
 * номер поезда, время отправления. Ввести данные в массив из пяти элементов типа train,
 * упорядочить элементы по номерам поездов. Добавить возможность вывода информации о поезде,
 * номер которого введен пользователем. Добавить возможность сортировки массива по пункту
 * назначения, причем поезда с одинаковыми пунктами назначения должны быть упорядочены
 * по времени отправления.
 double TrainSpeed = 120;
 double Stolbovaya = 10;
 double time;
 */
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
        //private void SortByDepatrure(DepartureTime DepartureTime)
        //{
        //    for (int i =)
        //    {

        //    }
        //}
        public void TrainInfo() 
        {
            Console.WriteLine($"Информация о поезде №{tr.TrainNumber}:\nНаправление: {tr.Destination}\nВремя отправления: {tr.DepartureTime.SummerTime()}\n");
        }
    }
    /*создать класс, в котором запечатаны методы создания поезда, направление, число вагонов, кол-во пассажиров, даты изготовления, модель, скорость, масса, кол-во вагонов, всё это пойдёт на место TrainInfo.
    * всё это передаётся в записи номера поезда 
    Создаём конструктор который массивом object принимает в себя номер поезда и станцию
    добавить метод общих данных о поезде, расчёта времени в пути, направление
    Создать метод, в котором будет массив типа Object, куда будут передаваться параметры, а в методе Main() вызвать его.
         */
    class Program
    {
        static void Main(string[] args)
        {
            CrazyTrain[] trains = new CrazyTrain[5];
            trains[0] = new CrazyTrain("sdf", 1, new DepartureTime(10, 30));
            trains[1] = new CrazyTrain("sdf", 2, new DepartureTime(18, 30));
            trains[2] = new CrazyTrain("sdf", 3, new DepartureTime(15, 30));
            trains[3] = new CrazyTrain("sdf", 4, new DepartureTime(14, 20));
            trains[4] = new CrazyTrain("sdf", 5, new DepartureTime(18, 50));
            for (int i = 0; i < trains.Length; i++)
            {
                trains[i].TrainInfo();
            }
            Console.ReadLine();
        }
    }
}

// int[] arr = new int[5] {v,};