using System;
using System.Collections.Generic;

namespace DSAndAlgo
{
	class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{ 
				try
				{
					Console.Out.WriteLine(" Input Array ");
					Console.WriteLine();
					string[] array = Console.ReadLine().Split(',');

					//long n = Convert.ToInt64(Console.ReadLine());
					//Console.Out.Write( $" number of digits in 19925202 : {Mathematical.NumberOfDigitsIterative(19925202)}");
					//Console.Out.Write( $" Number 19925202 Palindrome : {Mathematical.PalindromeNumberWithArray(199891)}");
					//Console.Out.Write($" Number {n} Reversed : {Mathematical.ReverseTheNumber(n)}  Palindrome : {Mathematical.PalindromeNumeberEfficient(n)}");
					//Console.Out.Write($" Number {n} Factorial : {Mathematical.FactorialIterative(n)}");
					//long trailingZeros = 0;
					//Console.Out.WriteLine($" Number {n} Factorial : {Mathematical.FactorialIterativeWithTrailingZeros(n,ref trailingZeros)}");
					//Console.Out.WriteLine($"Trailing Zeros : {trailingZeros}");
					//int capacity = Convert.ToInt32(Console.In.ReadLine());
					//if (array.Length > capacity)
					//{
					//	Console.Out.WriteLine($"Input array is bigger");
					//	return;
					//}
					

					int[] arr = new int[array.Length];
					//for (int i = 0; i < array.Length; ++i)
					//{
					//	arr[i] = Convert.ToInt32(array[i]);
					//}
					LinkedList<int> list = new LinkedList<int>();
					for (int i = 0; i < array.Length; ++i)
					{
						list.AddLast(Convert.ToInt32(array[i]));
					}

					//Console.Out.WriteLine($"Element"); 
					//int element = Convert.ToInt32(Console.In.ReadLine());
					//Console.Out.WriteLine($"Position");
					//int pos = Convert.ToInt32(Console.In.ReadLine());
					//long m = Convert.ToInt64(Console.ReadLine());
					//Console.Out.WriteLine($" Greatest Common Diviser of {n} and {m} is : {Mathematical.GCDEuclidMod2(n, m)}");
					//Console.Out.WriteLine($" Added {element} at {pos} : {ArrayAlgo.Insert(arr,i,capacity,element,pos)}");
					//Console.Out.WriteLine($" Delete {element} : {ArrayAlgo.DeleteOn(arr,i,capacity,element)}");
					///Console.Out.WriteLine($" Largest  : {ArrayAlgo.LargestOn(arr)}");
					//Console.Out.WriteLine($" Second Largest  : {ArrayAlgo.SecondLargestOn(arr)}");
					//Console.Out.WriteLine($" Sorted  : {ArrayAlgo.IsSortedOn(arr)}");
					//int size = ArrayAlgo.RemoveDuplicatesFromSortedOn(arr);
					//Console.Out.WriteLine($" Remove Duplecates  : {size}");
					//if (size > 0)
					//{
					//	Console.WriteLine("\n**************************");
					//	for (int j = 0; j < size; j++)
					//		Console.Out.Write(arr[j] + ",");
					//}
					//Console.Out.WriteLine($" Move Zeros To End ");
					//ArrayAlgo.ZerosToEndOn(arr);
					//ArrayAlgo.LeftRotateArrayByOne(arr);
					//Console.Out.WriteLine($" All Leaders ");
					//Console.WriteLine("\n**************************");
					//ArrayAlgo.AllLeadersInArray(arr);
					//Console.WriteLine("\n**************************");
					//for (int j = 0; j < arr.Length; j++)
					//	Console.Out.Write(arr[j] + ",");
					//int[,] multiArray = new int[4, 4] {
					//	{1,2,3,4},
					//	{5,6,7,8},
					//	{9,10,11,12},
					//	{13,14,15,16}
					//};
					//for (int j = 0; j < multiArray.GetLength(0); j++)
					//{
					//	Console.Out.WriteLine();
					//	for (int k = 0; k < multiArray.GetLength(1); k++)
					//		Console.Out.Write(" " + multiArray[j, k] + " ");
					//}
					//Console.Out.WriteLine();
					//Console.Out.WriteLine($" snake pattern ");
					//Console.Out.WriteLine($" Boundry Traversal ");
					//ArrayAlgo.PrintMatrixInSnakePattern(multiArray);
					//ArrayAlgo.PrintBoundryOfMatrix(multiArray);
					//ArrayAlgo.TransposeOfMatrix(multiArray);
					//ArrayAlgo.RotateMatrixBy90UsingTranspose(multiArray);
					//ArrayAlgo.PrintMatrixInSpiralSequence(multiArray);
					//Console.Out.WriteLine($"\n Number Of Distinct Elements : {HashSetProblems.CountOfDistinctObjectsInAnArray(arr)}");
					//Console.Out.WriteLine(" Sum ");
					//int sum = Convert.ToInt32(Console.In.ReadLine());
					//HashSetProblems.FindAllPairsWithGivenSum(arr, sum);
					//HashSetProblems.FrequencyOfElement(arr);

					Console.Out.WriteLine();
					LinkedListProblems.ReverseLinkedDoublyLinkedList(list);
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
				}
			}
		}
	}
	
}
