using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomTasks
{
    static void Main(string[] args)
    {
        BinaryWriter dataOut;
        BinaryReader dataIn;
        string item;
        int onhand;
        double cost;

        try
        {
            dataOut = new BinaryWriter(new FileStream(@"D:\Inventory.dat", FileMode.Create));
        }
        catch(IOException exc)
        {
            Console.WriteLine($"Не удаётся открыть файл товарных запасов для ввода");
            Console.WriteLine($"Причина: {exc.Message}");
            return;
        }

        try
        {
            dataOut.Write("Молотки");
            dataOut.Write(10);
            dataOut.Write(3.95);
            dataOut.Write("Отвертки");
            dataOut.Write(18);
            dataOut.Write(1.50);
            dataOut.Write("Плоскогубцы");
            dataOut.Write(5);
            dataOut.Write(4.95);
            dataOut.Write("Пилы");
            dataOut.Write(8);
            dataOut.Write(8.95);
        }
        catch (IOException exc)
        {
            Console.WriteLine($"Ошибка записи в файл товарных запасов\nПричина: {exc.Message}");
        }
        finally
        {
            dataOut.Close();
        }

        try
        {
            dataIn = new BinaryReader(new FileStream(@"D:\Inventory.dat", FileMode.Open));
        }
        catch (IOException exc)
        {
            Console.WriteLine($"He удается открыть файл товарных запасов для ввода\nПричина: {exc.Message}");
            return;
        }

        // Найти предмет, введенный пользователем.
        Console.Write("Введите наименование для поиска: ");
        string what = Console.ReadLine();

        try
        {
            for (;;)
            {
                // Читать данные о предмете хранения.
                item = dataIn.ReadString();
                onhand = dataIn.ReadInt32();
                cost = dataIn.ReadDouble();

                //Проверить, совпадает ли он с запрашиваемым предметом. Если совпадает, то отобразить сведения о нем.
                if (item.Equals(what, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{item}: {onhand} штук в наличии. Цена: {cost}:С за штуку");
                    Console.WriteLine($"Общая стоимость по наименованию <{item}>: {cost * onhand}:С.");
                    break;
                }
            }
        }
        catch (EndOfStreamException)
        {
            Console.WriteLine("Предмет не найден.");
        }
        catch (IOException exc)
        {
            Console.WriteLine("Ошибка чтения из файла товарных запасов");
            Console.WriteLine($"Причина: {exc.Message}");
        }
        finally
        {
            dataIn.Close();
        }
        //______________________________________
        //BinaryWriter dataOut;
        //BinaryReader dataIn;

        //int i = 10;
        //double d = 1023.56;
        //bool b = true;
        //string str = "Это тест";

        //try
        //{
        //    dataOut = new BinaryWriter(new FileStream(@"D:\69.txt", FileMode.Create));
        //}
        //catch (IOException exc)
        //{
        //    Console.WriteLine($"Ошибка открытия файла:{exc.Message}");
        //    return;
        //}
        //try
        //{
        //    Console.WriteLine($"Запись {i}");
        //    dataOut.Write(i);

        //    Console.WriteLine($"Запись {d}");
        //    dataOut.Write(d);

        //    Console.WriteLine($"Запись {b}");
        //    dataOut.Write(b);

        //    Console.WriteLine($"Запись {12.2 * 7.4}");
        //    dataOut.Write(12.2 * 7.4);

        //    Console.WriteLine($"Запись {str}");
        //    dataOut.Write(str);
        //}
        //catch(IOException exc)
        //{
        //    Console.WriteLine($"Ошибка ввода-вывода:\n{exc.Message}");
        //} finally
        //{
        //    dataOut.Close();
        //}

        //try
        //{
        //    dataIn = new BinaryReader(new FileStream(@"D:\69.txt", FileMode.Open));
        //}
        //catch(IOException exc)
        //{
        //    Console.WriteLine($"Ошибка открытия файла:\n{exc.Message}");
        //    return;
        //}
        //try
        //{
        //    i = dataIn.ReadInt32();
        //    Console.WriteLine($"Чтение {i}");

        //    d = dataIn.ReadDouble();
        //    Console.WriteLine($"Чтение {d}");

        //    b = dataIn.ReadBoolean();
        //    Console.WriteLine($"Чтение {b}");

        //    d = dataIn.ReadDouble();
        //    Console.WriteLine($"Чтесние {d}");

        //    str = dataIn.ReadString();
        //    Console.WriteLine($"Чтение {str}");
        //}
        //catch(IOException exc)
        //{
        //    Console.WriteLine($"Ошибка ввода-вывода:\n{exc.Message}");
        //} finally
        //{
        //    dataIn.Close();
        //}
        //______________________________________
        //StreamWriter words = null;
        //try
        //{
        //    words = new StreamWriter(@"D:\99.txt");
        //    Console.SetOut(words);
        //    Console.WriteLine("Начало");
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.WriteLine("Конец");
        //}
        //catch(IOException exc)
        //{
        //    Console.WriteLine(exc.Message);
        //}
        //finally
        //{
        //    if (words != null)
        //    {
        //        words.Close();
        //    }
        //}
        //______________________________________
        //FileStream words;
        //string str;
        //try
        //{
        //    words = new FileStream(@"D:\99.txt", FileMode.Open);

        //    StreamReader words_up = new StreamReader(words);
        //    while (!words_up.EndOfStream)
        //    {
        //        str = words_up.ReadLine();
        //        Console.WriteLine(str);
        //    }
        //}
        //catch (IOException exc)
        //{
        //    Console.WriteLine($"Ошибка открытия файла:\n{exc.Message}");
        //}
        //______________________________________
        //FileStream strm;
        //string str;
        //try
        //{
        //    strm = new FileStream(@"D:\75.txt", FileMode.Open);
        //    StreamReader strm1 = new StreamReader(strm);
        //    while((str = strm1.ReadLine()) != null)
        //    {
        //        Console.WriteLine(str);
        //    }
        //} catch (IOException exc)
        //{
        //    Console.WriteLine(exc);
        //}
        //string str;
        //StreamWriter words = null;
        //try
        //{
        //    words = new StreamWriter(@"D:\75.txt");
        //    do
        //    {
        //        str = Console.ReadLine();
        //        if(str != "стоп")
        //        {
        //            str = str + "\r\n";
        //            words.Write(str);
        //        }               
        //    } while (str != "стоп");
        //} catch(IOException exc)
        //{
        //    Console.WriteLine(exc.Message);
        //}
        //______________________________________
        // Открытие или создание файла
        //FileStream fin;
        //try
        //{
        //    fin = new FileStream(@"D:\100.txt", FileMode.OpenOrCreate);
        //    for (char i = 'A'; i < 'Z'; i++)
        //    {
        //        fin.WriteByte((byte)i);
        //    }
        //}
        //catch (IOException exc)
        //{
        //    Console.WriteLine(exc.Message);
        //}
        //______________________________________
        // Создание файла.
        //int i;
        //FileStream fin;
        //try
        //{
        //    fin = new FileStream(@"D:\100.txt", FileMode.Create);
        //    do
        //    {
        //        i = fin.ReadByte();
        //        if (i != -1)
        //        {
        //            Console.WriteLine((char)i);
        //        }
        //    } while (i != -1);
        //}
        //catch(IOException exc)
        //{
        //    Console.WriteLine(exc.Message);
        //}
        // ____________________________________________
        //
        //    ConsoleKeyInfo keypress;
        //    do
        //    {
        //        keypress = Console.ReadKey();
        //        Console.WriteLine($"\n{keypress.KeyChar}");
        //    } while (keypress.Key != ConsoleKey.Escape);
        //    Console.WriteLine();
    }
}
