using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ff
{
    public sealed class OneDimensionalArray : Array
    {
        private int[] array;

        public OneDimensionalArray(int size, bool userInput = false) : base(size)
        {
            array = new int[size];
            if (userInput)
            {
                Initialize();
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < size; i++)
                {
                    array[i] = rnd.Next(1, 101);
                }
            }
        }

        public override void Initialize()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите значение элемента {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public override void Print()
        {
            Console.WriteLine("Одномерный массив:");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public override double CalculateAverage()
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }
    }
}
