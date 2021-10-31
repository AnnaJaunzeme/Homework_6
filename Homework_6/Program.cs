using System;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Array[] Array1 = { new Array(12345), new Array(24), new Array(99), new Array(1709), new Array(1)};
            Array[] Array2 = new Array[5];

            Array1.CopyTo(Array2, 0);

            Console.WriteLine("Array1: ");
            foreach (Array elements in Array1)
            {
                Console.WriteLine(elements.element);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Array2: ");
            foreach (Array elements in Array2)
            {
                Console.WriteLine(elements.element);
            }
            Console.ReadLine();
        }
        public class Array
        {
            public int element;
            public Array (int element)
            {
                this.element = element;
            }
        }
    }
}