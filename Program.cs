// replace ea elemnt of the array with its rank
// rank =  how large the element is 
using System;


public class Program
{
    public static void Main()
    {
        int[] arr = { 37, 12, 28, 9, 100, 56, 80, 5, 12 };
        int[] result = ReplaceWithRank(arr);

        Console.WriteLine(string.Join(", ", result));
    }

    public static int[] ReplaceWithRank(int[] arr)
    {

        var sortedUnique = arr.Distinct().ToList();
        sortedUnique.Sort();


        var rankMap = new Dictionary<int, int>();
        int rank = 1;
        foreach (var num in sortedUnique)
        {
            rankMap[num] = rank;
            rank++;
        }

      
        int[] rankedArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            rankedArr[i] = rankMap[arr[i]];
        }

        return rankedArr;
    }
}
