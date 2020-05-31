using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class DepartureTime
    {
        int h, m;
        public DepartureTime(int h, int m)
        {
            this.h = h;
            this.m = m;
        }

        public int hour{
            get
            {
                return h;
            }
            set
            {
                if(hour < 24)
                {
                    hour = value;
                } else
                {
                    Console.WriteLine("Введите корректное время!");
                }
            }
        }
        public int minute
        {
            get
            {
                return m;
            }
            set
            {
                if(minute < 60)
                {
                    minute = value;
                } else
                {
                    Console.WriteLine("Введите корректное время!");
                }
            }
        }
        public string SummerTime()
        {
            return $"{hour}:{minute}";
        }
    }
}
