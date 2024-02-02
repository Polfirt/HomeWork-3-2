using System;
using System.Collections.Generic;


namespace ff
{ 
    class Program
    {
        static void Main()
        {
            Array[] arrays = new Array[3];

            Console.WriteLine("Если хотите ввести все сами, введите 'true', если же нет, то пишите 'false'.");
            bool v = bool.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество элементов для одномерного массива");
            int b = int.Parse(Console.ReadLine());

            arrays[0] = new OneDimensionalArray(b, v);

            Console.WriteLine("Введите количество строк и столбцов для двумерного массива");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            arrays[1] = new MultiDimensionalArray(c, d, v);

            Console.WriteLine("Введите количество строк для ступенчатого массива");
            int f = int.Parse(Console.ReadLine());

            arrays[2] = new JaggedArray(f, v);

            foreach (var array in arrays)
            {
                array.Print();
                Console.WriteLine($"Среднее значение: {array.CalculateAverage()}\n");
            }
        }
    }
}