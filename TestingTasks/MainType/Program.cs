#define One

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MainType
{
    class MainClass
    {
        int a, b;
        public MainClass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void PlusInt()
        {
            Console.WriteLine($"Целочисленное сложение: {a + b}");
        }
        public void PlusDouble(double a, double b)
        {
            Console.WriteLine($"Двоичное сложение: {a + b}");
        }
        public int ReturnPlusInt()
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom("MainType.exe");

            Console.WriteLine("Доступные классы:");
            Type[] all_types = asm.GetTypes();
            foreach(Type a_t in all_types)
            {
                Console.WriteLine(a_t.Name);
            }
            
            Type mainClass = all_types[0];
            Console.WriteLine("Доступные конструкторы:");
            ConstructorInfo[] constr_info = mainClass.GetConstructors();
            foreach (ConstructorInfo c_i in constr_info)
            {
                Console.WriteLine($"Конструкторе: {c_i}\nЕго параметры:");
                ParameterInfo[] paramC_info = c_i.GetParameters();
                int i;
                for (i = 0; i < paramC_info.Length; i++)
                {
                    Console.WriteLine($"{paramC_info[i]}");
                
                
                }
            }
            int x;
            for (x = 0; x < constr_info.Length; x++)
            {
                ParameterInfo[] pi = constr_info[x].GetParameters();
                if (pi.Length == 2)
                {
                    break;
                }
            }
            object[] arr = new object[2];
            arr[0] = 5;
            arr[1] = 15;
            object reftlect = constr_info[x].Invoke(arr);

            Console.WriteLine("Доступные методы:");

            MethodInfo[] method_info = mainClass.GetMethods();
            foreach(MethodInfo method_i in method_info)
            {
                Console.WriteLine($"Метод {method_i}\nЕго параметры:");
                ParameterInfo[] paramM_info = method_i.GetParameters();
                for (int i = 0; i < paramM_info.Length; i++)
                {
                    Console.WriteLine($"{paramM_info[i]}");
                }
                Console.WriteLine();

                if (method_i.Name.CompareTo("PlusInt") == 0)
                {                 
                    method_i.Invoke(reftlect, null);
                }
                if (method_i.Name.CompareTo("PlusDouble") == 0)
                {
                    object[] d_arr = new object[2];
                    d_arr[0] = 1.45;
                    d_arr[1] = 16.76;
                    method_i.Invoke(reftlect, d_arr);
                }

                if (method_i.Name.CompareTo("ReturnPlusInt") == 0)
                {
                    method_i.Invoke(reftlect, null);
                }
            }

            
            Console.WriteLine();            
            Console.ReadLine();
        }
    }
}
