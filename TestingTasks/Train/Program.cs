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
 * по времени отправления.*/
namespace OverloadClass
{
    struct Train
    {
        public string des;
        public int tN;
        public int dth;
        public int dtm;
        public string tI;
    }
    class CrazyTrain
    {
        Train tr;
        double TrainSpeed = 120;
        double Stolbovaya = 10;
        double time;
        public CrazyTrain(string Destination, int TrainNumber, int DepartureTimeMinHour, int DepartureTimeMin, string TrainInfo)
        {
            tr.des = Destination;
            tr.tN = TrainNumber;
            tr.dth = DepartureTimeMinHour;
            tr.dtm = DepartureTimeMin;
            tr.tI = TrainInfo;
        }
        private string CalculateTravelTime()
        {
            time = Stolbovaya / TrainSpeed;
            return $"{Math.Round(time, 2) * 100}";
        }
        public void Show()
        {
            Console.WriteLine($"{CalculateTravelTime()}");
        }
    }
    /*создать класс, в котором запечатаны методы создания поезда, направление, число вагонов, кол-во пассажиров, даты изготовления, модель, скорость, масса, кол-во вагонов, всё это пойдёт на место TrainInfo.
    * всё это передаётся в записи номера поезда 
    Создаём конструктор который массивом object принимает в себя номер поезда и станцию
    добавить метод общих данных о поезде, расчёта времени в пути, направление */
    class Program
    {
        static void Main(string[] args)
        {
            CrazyTrain ob = new CrazyTrain("Stolbovaya", 154, 16, 45, "Информация о поезде");
            ob.Show();
            Console.ReadLine();
        }
    }
}

// int[] arr = new int[5] {v,};