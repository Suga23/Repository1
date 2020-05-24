using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadClass
{
    abstract class Vehicle
    {
        public string machineMark, color, wheelsType;
        public double speed;
        public Vehicle(string machineMark, double speed, string wheelsType, string color)
        {
            this.machineMark = machineMark;
            this.speed = speed;
            this.wheelsType = wheelsType;
            this.color = color;
        }
        public abstract string Show();
    }
    class WheelCar : Vehicle
    {

        public WheelCar(string machineMark, double speed, string wheelsType, string color) : base(machineMark, speed, wheelsType, color)
        {

        }
        public override string Show()
        {
            return "Колёсный автомобиль представляет из себя бла-бла-бла.";
        }


    }

    class Cargo : WheelCar
    {
        string bodyType; // machineMark, color, wheelsType, 
        //double speed;
        int wheels;
        public Cargo(string machineMark, double speed, string color, string wheelsType, int wheels,  string bodyType) : base(machineMark, speed, wheelsType, color)
        {
            //this.machineMark = machineMark;
            //this.color = color;
            //this.wheelsType = wheelsType;
            //this.speed = speed;
            this.wheels = wheels;
            this.bodyType = bodyType;
        }
        public override string Show()
        {
            return $"Марка автомобиля:  {machineMark}\nМаксимальная скорость автомобиля:    {speed}\nЦвет автомобиля:  {color} км/ч\nТип колёс автомобиля:   {wheelsType}\nКоличество колёс: {wheels}\nТип кузова:   {bodyType}";
        }
    }

    class LightCar : WheelCar
    {
        public LightCar(string machineMark, double speed, string color, string wheelsType) : base(machineMark, speed, wheelsType, color)
        {

        }

        public override string Show()
        {
            return $"Марка автомобиля:  {machineMark}\nМаксимальная скорость автомобиля:    {speed}\nЦвет автомобиля:  {color} км/ч\nТип колёс автомобиля:   {wheelsType}";
        }
    }
}
