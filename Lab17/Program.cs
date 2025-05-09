// Hoang Le
// hle2@northeaststate.edu
// Project 17

using System;
using System.Collections.Generic;

namespace Lab17
{
    /// <summary>
    /// Lab17 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main() 
        {
            // Create array with 20 random values
            Random rand = new Random();
            float[] numbers = new float[20];

            // Fill array with random values between 1 and 10
            Console.Write("Original array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 1001); 
                Console.Write($"{numbers[i]} ");
            }

            float sum = Sum(numbers);
            Console.WriteLine($"\n\nSum: {sum}");

            float avg = Average(numbers);
            Console.WriteLine($"Average: {avg}");

            float min = Min(numbers);
            Console.WriteLine($"Minimum: {min}");

            float max = Max(numbers);
            Console.WriteLine($"Maximum: {max}");

            Console.Write("Swapping array order: ");
            // Mirror the swap array from the end point to the mid point
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                numbers = Swap(numbers, i, numbers.Length - 1 - i);
            }

            // Print the swapped array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            int[] fib = Fibonacci(20);
            Console.Write("\n\nFibonacci: ");
            for (int i = 0; i < fib.Length; i++)
            {
                Console.Write($"{fib[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// sum all the elements in the array and return the value
        /// </summary>
        /// <param name="array"></param>
        /// <returns> total value </returns>
        static float Sum(float[] array)
        { 
            float total = 0.0f;

            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }

            return total;
        }

        /// <summary>
        /// find the average of all the elements in the array and return the value
        /// </summary>
        /// <param name="array"></param>
        /// <returns> avg value </returns>
        static float Average(float[] array) 
        { 
            float Total =0.0f;

            for (int i = 0; i < array.Length; i++) 
            {
                Total += array[i];
            }

            return Total / array.Length;
        }

        /// <summary>
        /// return the min value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns> min value </returns>
        static float Min(float[] array)
        {
            float min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        /// <summary>
        /// return the max value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns> max value </returns>
        static float Max(float[] array)
        {
            float max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        /// <summary>
        /// swap the array elements at the given index and return the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <returns></returns> swap the array
        static float[] Swap(float[] array, int index1, int index2)
        {
            float tempInput = array[index1];
            array[index1] = array[index2];
            array[index2] = tempInput;

            return array;
        }

        /// <summary>
        /// return an array with the first n (numValues) of the Fibonacci sequence
        /// </summary>
        /// <param name="numValues"></param>
        /// <returns> first nth value </returns>
        static int[] Fibonacci(int numValues)
        {
            int[] Array = new int[numValues];
            Array[0] = 0;
            Array[1] = 1;

            for (int i = 2; i < numValues; i++)
            {
                Array[i] = Array[i - 1] + Array[i - 2];
            }

            return Array;
        }
    }
}
