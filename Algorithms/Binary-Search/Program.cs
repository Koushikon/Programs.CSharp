using System;

namespace Binary_Search
{
    class Soution
    {
        public static int BinSearch(int[] items, int key)
        {
            int Start = 0, End = items.Length - 1, Mid = 0;

            while (Start <= End)
            {
                Mid = Start + (End - Start) / 2;

                if (key == items[Mid])
                    return Mid;
                else if (key > items[Mid])
                    Start = Mid + 1;
                else
                    End = Mid - 1;
            }
            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 5, 6, 7, 9, 11 };

            int Res = Soution.BinSearch(array, 9);
            Console.WriteLine(Res == -1 ? "Not Found" : $"Found at {Res} Position.");
        }
    }
}