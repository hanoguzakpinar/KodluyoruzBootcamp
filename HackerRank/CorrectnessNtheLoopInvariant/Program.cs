using System;
using System.Linq;

class Solution
{
    public static void insertionSort(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A.Length; j++)
            {
                if (A[i] > A[j])
                {
                    int temp = A[j];
                    A[j] = A[i];
                    A[i] = temp;
                }
            }
        }

        for (int i = A.Length - 1; i >= 0; i--)
        {
            Console.Write(A[i] + " ");
        }
    }

    static void Main(string[] args)
    {
        Console.ReadLine();
        int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        insertionSort(_ar);
    }
}