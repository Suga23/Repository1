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
        public static bool operator >(DepartureTime op1, DepartureTime op2)
        {
            if (op1.h > op2.h)
            {
                return true;
            }
            else if (op1.h == op2.h && op1.m > op2.m)
            {
                return true;
            }
            else if (op1.h == op2.h && op1.m == op2.m)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(DepartureTime op1, DepartureTime op2)
        {
            if (op1.h < op2.h)
            {
                return true;
            }
            else if (op1.h == op2.h && op1.m < op2.m)
            {
                return true;
            }
            else if (op1.h == op2.h && op1.m == op2.m)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

    }
}
