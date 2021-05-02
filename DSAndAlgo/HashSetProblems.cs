using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgo
{
	public class HashSetProblems
	{
		public static int CountOfDistinctObjectsInAnArray(int[] array)
		{
			HashSet<int> set = new HashSet<int>();

			for(int i = 0; i < array.Length; i++)
			{
				set.Add(array[i]);
			}

			return set.Count;
		}

		public static void FindAllPairsWithGivenSum(int[] array,int sum)
		{
			HashSet<int> set = new HashSet<int>();

			for (int i = 0; i < array.Length; i++)
			{
				int temp = sum - array[i];

				if (set.Contains(temp))
				{
					Console.WriteLine($"Pair {temp} and {array[i]} Sum : {sum}");
				}
				else
				{
					set.Add(array[i]);
				}
				
			}
		}

		public static void IntersectionOf2Arrays(int[] arr1, int[] arr2)
		{
			HashSet<int> set = new HashSet<int>();
			int length = arr1.GetLength(0);

			for (int i = 0; i < arr1.GetLength(0);i++)
			{

			}
		}

		public static void FrequencyOfElement(int[] array)
		{
			Dictionary<int,int> set = new Dictionary<int,int>();

			for (int i = 0; i < array.Length; i++)
			{
				if (set.ContainsKey(array[i]))
					set[array[i]]++;
				else
					set.Add(array[i], 1);
			}

			foreach(var pair in set)
			{
				Console.Out.WriteLine($"{ pair.Key} : {pair.Value}");
			}
		}

	}
}
