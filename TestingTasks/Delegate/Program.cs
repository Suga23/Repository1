/* При работе с событиями создаётся объект класса, 
* в котором объявлено событие, далее идёт обращение 
* к эвенту посредством объекта класса и присваивание 
* ему метода при помощи += после чего запуск события 
* при помощи объекта класса и вызова метода связанного 
* с событием в классе */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* 2 класса Ping и Pong один уведомляет 
 другого, о том, что "произошёл пинг",
 другой - о том, что "произошёл понг",
 одна пара объектов "играют" между собой,
 другая пара - между собой и т.д.
 и выводить на консоль соответсвующие сообщения,

 что-то вроде такого:

 Ping received Pong.
 Pong received Ping.
 Ping received Pong.
 Pong received Ping.
 Ping received Pong.*/
namespace Delegate
{
    delegate void deleg();
    class Evt
    {
        public event deleg evente;

        public void OnEvent()
        {
            if(evente != null)
            {
                evente();
            }
        }
    }
    class Ping
    {
        public void PingEvt()
        {
            Console.WriteLine("Ping received Pong.");
        }
    }
    class Pong
    {
        public void PongEvt()
        {
            Console.WriteLine("Pong received Ping.");
        }
    }
}

class Program
{               
    static void Main(string[] args)
    {
        Delegate.Evt e = new Delegate.Evt();
        Delegate.Ping pi = new Delegate.Ping();
        Delegate.Pong po = new Delegate.Pong();

        e.evente += pi.PingEvt;
        e.evente += po.PongEvt;

        e.OnEvent();
        e.OnEvent();
        Console.ReadLine();
    }
}