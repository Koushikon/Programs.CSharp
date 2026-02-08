using System;

namespace Divisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            string[] str_arr = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(str_arr, int.Parse);

            if (arr.Length == str_arr.Length)
            {
                int half = arr.Length / 2;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < half)
                    {
                        int number_length = (int)Math.Floor(Math.Log10(arr[i])) + 1;
                        arr[i] = arr[i] / (int)Math.Pow(10, number_length - 1);
                    }
                    else
                    {
                        arr[i] = arr[i] % 10;
                    }
                }

                num = Convert.ToInt32(string.Join("", arr));

                Console.WriteLine((num % 11 == 0) ? "OUI" : "NON");
            }
            else
                Console.WriteLine("Length was different");
        }
    }
}