using System;

namespace Arrays_and_Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomValues = new int[100];

            Console.WriteLine("Unsorted array of integers: \n");

            // Assign random values to array

            for (int i = 0; i < randomValues.Length; i++)
            {
                Random rng = new Random();

                randomValues[i] = rng.Next(1, 1001); // Assign a random value between 1 and 2 billion, because it's an int array, and it can totally do that, if it wants to.

                Console.WriteLine(randomValues[i]);
            }

            // Bubble sort

            for (int i = 0; i < randomValues.Length; i++)
            {
                for (int j = 0; j < randomValues.Length; j++)
                {
                    if (randomValues[j] > randomValues[i])
                    {
                        int placeholder = randomValues[i];
                        randomValues[i] = randomValues[j];
                        randomValues[j] = placeholder;
                    }
                }
            }

            // Print sorted array
            Console.WriteLine("\nArray after sorting: \n");
            for (int i = 0; i < randomValues.Length; i++)
            {
                Console.WriteLine(randomValues[i]);
            }

            // Reverse array
            Array.Reverse(randomValues);

            // Print reversed array
            Console.WriteLine("\nArray after reversing: \n");
            for (int i = 0; i < randomValues.Length; i++)
            {
                Console.WriteLine(randomValues[i]);
            }
        }
    }
}