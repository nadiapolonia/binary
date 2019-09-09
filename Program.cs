using System;

namespace binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Sort(numbers);
            Console.WriteLine("Hello World!");

        }



        // static void NumberArray(int[] number) {
        //     int[] sequence = Enumberable.Range(1,1000).ToArray();
        // }

        public static int BinarySearch(int[] numbers, int item)
        {
            return BinarySearch(numbers, 0, numbers.Length - 1, item);
        }

        public static int BinarySearch(int[] numbers, int lower, int higher, int item)
        {
            if (lower <= higher)
            {
                int guess = lower + (higher - lower) / 2;

                if (numbers[guess] == item)
                    return guess;

                if (numbers[guess] > item)
                    return BinarySearch(numbers, guess + 1, higher, item);

            }
            return -1;
        }

    }
}
