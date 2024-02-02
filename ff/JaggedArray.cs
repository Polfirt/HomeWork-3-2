using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ff
{
    public sealed class JaggedArray : Array
    {
        private int[][] array;

        public JaggedArray(int size, bool userInput = false) : base(size)
        {
            array = new int[size][];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите количество элементов ступенчатого массива для строки {i + 1}: ");
                int subarraySize = Convert.ToInt32(Console.ReadLine());
                array[i] = new int[subarraySize];
            }

            if (userInput)
            {
                Initialize();
            }

            else
            {
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] = rnd.Next(1, 101);
                    }
                }
            }
        }

        public override void Initialize()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"Введите значение элемента {i},{j}: ");
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public override void Print()
        {
            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override double CalculateAverage()
        {
            double sum = 0;
            int totalElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    totalElements++;
                }
            }
            return sum / totalElements;
        }
    }
}
