using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

/*Создайте структуру с именем student, содержащую поля: фамилия и инициалы, номер группы, 
успеваемость (массив из пяти элементов). Создать массив из десяти элементов такого типа,
упорядочить записи по возрастанию среднего балла. Добавить возможность вывода фамилий и 
номеров групп студентов, имеющих оценки, равные только 4 или 5.*/
namespace OverloadClass
{
    struct Student
    {
        public string lastName;
        public string initials;
        public int groupNumber;
        public int[] academicPerformance;
    }
    class Middle
    {
        Student st;
        int Mark;
        int Mark1;
        public Middle(string lN, string ini, int gN, params int[] aP)
        {
            st.lastName = lN;
            st.initials = ini;
            st.groupNumber = gN;
            st.academicPerformance = aP;
        }
        public void Show()
        {
            for (int i = 0; i < st.academicPerformance.Length; i++)
            {
                Mark1 = st.academicPerformance[i];
            }

            for (int i = 0; i < st.academicPerformance.Length; i++)
            {
                Mark += st.academicPerformance[i];
            }

            Console.WriteLine($"Фамилия: {st.lastName}\nИнициалы: {st.initials}\nНомер группы: {st.groupNumber}\nУспеваемость: {Mark1}\nСредний бал: {Mark / st.academicPerformance.Length}");

        }
        class Program
        {
            static void Main(string[] args)
            {

                Middle[] students = new Middle[10];
                Console.WriteLine("Введите данные первого студента: ");
                int[] arr = new int[5] { 5, 3, 5, 3, 4 };
                students[0] = new Middle("Belugin", "P.A.", 1, arr);
                students[0].Show();
                Console.ReadLine();
            }
        }
    }
}