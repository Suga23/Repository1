using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

// Разработать программу, в которой предусмотреть наследование минимум трех классов, например, средство передвижения, колесное средство передвижения, автомобиль, легковой автомобиль.
// В программе должен использоваться принцип полиморфизма. Предусмотреть накопление объектов классов в структуре типа массив, список или очередь, но не стек.
namespace OverloadClass
{    
    class Program
    {
        
        static void Main(string[] args)
        {
            LightCar ob = new LightCar("BMW", 250, "Красный", "Летняя резина");
            Console.WriteLine(ob.Show());
            //List<Cargo> ob = new List<Cargo>();
            //ob.Add(new Cargo() { machineMark = "Зил", speed = 120, color = "Красный.", wheelsType = "Летняя резина", wheels = 8, bodyType = "Открытый" });
            Console.ReadLine();
        }
    }////алвтмлв
}
//                      string machineMark, double speed, string color, string wheelsType, int wheels,  string bodyType) : base(machineMark, speed, wheelsType, color
//, speed = 120, color = "Красный", wheelsType = "Летняя резина", wheels = 8, 