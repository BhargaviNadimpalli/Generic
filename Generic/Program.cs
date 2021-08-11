using System;
using System.Collections.Generic;
namespace Generic
{
    public class PrintArray<T>
    {
        private T[] inputArray;
        public PrintArray(T[] inputArray)
        {

            this.inputArray = inputArray;
            ToPrint(inputArray);
        }
        public void ToPrint(T[] inputArray)
        {
            foreach (var element in inputArray)
            {

                Console.WriteLine(element);
            }
            Console.WriteLine("-------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 3, 4, 2, 4, 5, 5 };
            double[] doubleArray = { 1.4, 2.3, 4.5, 5.6, 6.7 };
            char[] charArray = { 'b', 'h', 'a', 'g', 'i' };
            new PrintArray<int>(intArray);
            new PrintArray<double>(doubleArray);
            new PrintArray<char>(charArray);

        }
    }

}


