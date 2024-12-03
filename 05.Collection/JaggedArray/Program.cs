
namespace JaggedArray;

public class Program
{
    public static void Main()
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[] { 1, 2, 3, 4, 5 };
        jagged[1] = new int[] { 66, 77, 88 };
        jagged[2] = new int[] { 999 };

        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j] + " ");
            }
            Console.WriteLine();
        }


        int[][,] jagged_arr1 = new int[4][,] {
            new int[, ] { { 1, 3 }, { 5, 7 } },
            new int[, ] { { 0, 2 }, { 4, 6 }, { 8, 10 } },
            new int[, ] { { 7, 8 }, { 3, 1 }, { 0, 6 } },
            new int[, ] { { 11, 22 }, { 99, 88 }, { 0, 9 } }
        };

        for (int i = 0; i < jagged_arr1.Length; i++)
        {
            int x = 0;
            for (int j = 0; j < jagged_arr1[i].GetLength(x); j++)
            {
                for (int k = 0; k < jagged_arr1[j].Rank; k++)
                {
                    Console.Write("Jagged_Array[" + i + "][" + j + ", " + k + "]: " + jagged_arr1[i][j, k] + " ");
                }
                Console.WriteLine();
            }
            x++;
        }
    }
}