using System;

namespace ConsoleApp1
{
    /// <summary>
    /// Задача с о.м. на нахождение среднего курса валют,
    /// самого высокого и самого низкого
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //double[] array = new double[31];
            //Random rnd = new Random();// конструктор без параметра
            /////<summary>
            /////Заполнение о.м. cлучацным образом
            /////</summary>
            //for (byte i = 0; i < array.Length; i++)
            //{
            //    array[i] = 60 + 5 * rnd.NextDouble();//60-65
            //    Console.WriteLine($"array[{i}] = {array[i]:c2}");
            //}
            //double sum = 0;
            /////<summary>
            /////Накопление суммы
            /////</summary>
            //for (byte i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}
            //Console.WriteLine($"Среднее значение курса валюты = {(double)sum / array.Length:f2}");
            //double min = array[0];
            //double max = array[0];
            //byte indexMin = 0;
            //byte indexMax = 0;
            //for (byte i = 1; i < array.Length; i++)
            //{

            //    if (array[i] < min)
            //    {
            //        min = array[i]; indexMin = i;
            //    }
            //    if (array[i] > max)
            //    {
            //        max = array[i]; indexMax = i;
            //    }
            //}
            //Console.WriteLine($"Cамый низкий курс валюты = {min:c2}\tДата: {indexMin}\n" +
            //    $"Самый высокий курса валюты = {max:c2}\tДата: {indexMax}");



            ///<summary>
            ///Сортировка о.м по возрастанию > 
            ///</summary>
            int[] array = { -5, 1, 9, 0, 4, -4, 3 };
            //for (int i = 0; i < array.Length;i++)
            //{
            //    for (int j = i+1; j<array.Length;j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            int p = array[i];
            //            array[i] = array[j];
            //            array[j] = p;
            //        }

            //    }

            //}
            Array.Sort(array);
            foreach (int elem in array)
            {
                Console.Write($"{elem}\t");
            }
            Console.WriteLine();
            Array.Reverse(array);
            foreach (int elem in array)
            {
                Console.Write($"{elem}\t");
            }

            Console.Read();












        }
    }
}
