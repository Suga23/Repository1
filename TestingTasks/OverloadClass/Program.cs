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
        int[] Mark1;
        public Middle(string lN, string ini, int gN, params int[] aP)
        {
            st.lastName = lN;
            st.initials = ini;
            st.groupNumber = gN;
            st.academicPerformance = aP;
        }
        public void AcademicPerfomance()
        {

            for (int i = 0; i < st.academicPerformance.Length; i++)
            {
                Mark1 = st.academicPerformance;
            }
            return (int)Mark1.GetValue(st.academicPerformance.Length);
        }
        private int MiddleMark()
        {
            for (int i = 0; i < st.academicPerformance.Length; i++)
            {
                Mark += st.academicPerformance[i];
            }
            return Mark / st.academicPerformance.Length;
        }

        public void Show()
        {


            Console.WriteLine($"Фамилия: {st.lastName}\nИнициалы: {st.initials}\nНомер группы: {st.groupNumber}\nУспеваемость: {AcademicPerfomance()}\nСредний бал: {MiddleMark()}\n");
        }
        class Program
        {
            static void Main(string[] args)
            {

                Middle[] students = new Middle[5];
                Console.WriteLine("Введите данные первого студента: ");
                int[] arr0 = new int[5] { 5, 5, 5, 3, 4 };
                int[] arr1 = new int[5] { 5, 5, 4, 5, 4 };
                int[] arr2 = new int[5] { 5, 5, 4, 4, 5 };
                int[] arr3 = new int[5] { 3, 4, 5, 5, 4 };
                int[] arr4 = new int[5] { 5, 5, 3, 3, 4 };
                students[0] = new Middle("Белугин", "П.А.", 1, arr0);
                students[1] = new Middle("Датко", "Т.Б.", 1, arr1);
                students[2] = new Middle("Зуев", "Д.А.", 1, arr2);
                students[3] = new Middle("Карелов", "М.Б.", 1, arr3);
                students[4] = new Middle("Машин", "Г.И.", 1, arr4);
                for (int i = 0; i < students.Length; i++)
                {
                    students[i].Show();
                }
                Console.ReadLine();
            }
        }
    }
}