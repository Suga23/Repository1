using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
/* Создать класс, содержащий динамический массив и количество элементов в нем. 
* Добавить конструктор, который выделяет память под заданное количество 
* элементов, и деструктор. Добавить методы, позволяющие заполнять массив 
* случайными числами, переставлять в данном массиве элементы в случайном порядке,
* находить количество различных элементов в массиве, выводить массив на экран.*/
class MainArray1
{
    int[] arr;
    int Length;
    public MainArray1(int size)
    {
        arr = new int[size];
        Length = size;
    }
    public int this[int index]
    {
        get
        {
            if(ArrayOverFlow(index))
            {
                return arr[index];
            } else
            {
                throw new Exception("При генерации произошла ошибка.");
            }
        }
        set
        {
            if(ArrayOverFlow(index))
            {
                arr[index] = value;
            } else
            {
                while()
                {
                    arr[index++] = value;
                }
            }
        }
    }
    private bool ArrayOverFlow(int index)
    {
        if(index >= 0 && index < Length)
        {
            return true;
        }
        return false;
    }
}
/* Необходимо сгенерировать массив с фиксированными значениями, разработать внутренний метод в котором, 
 * если происходит переполнение массива, то увеличивается длина этого массива и в открывшуюся ячейку добвляется наше значение */
namespace DynamicArray
{
    class Program
    {
        //static void Main(string[] args)
        //{

        //}
    }
}
