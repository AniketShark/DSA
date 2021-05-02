using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgo
{
	public class ArrayAlgo
	{
		public static int[] LeftShiftWithMemoryOn(int[] arr, int n, int d)
		{
			int[] arr2 = new int[n];
			int p = d;
			for (int i = 0; i < n; i++, p++)
			{
				p = p % n;
				int temp = arr[p];
				arr2[i] = temp;
			}
			return arr2;
		}

		public static int[] ArrayReverse(int[] arr)
		{
			int start = 0;
			int end = arr.Length - 1;
			// Works only in odd number of elements
			while(start < end) // Works in every case
			{
				int temp = arr[start];
				arr[start] = arr[end];
				arr[end] = temp;
				start++;
				end--;
			}
			return arr;
		}

		public static int InsertOn(int[] arr,int size, int capacity,int element,int index)
		{
			if (index > capacity - 1 || index < 0 || size >= capacity)
				return 0;

			for (int i = size - 1; i >= index; i--)
				arr[i + 1] = arr[i];

			arr[index] = element;

			return size+1; 
		}

		public static int DeleteOn(int[] arr, int size, int capacity, int element)
		{
			if (size > capacity || size < 0)
				return 0;

			int index = LinearSearchOn(arr, size, element);

			if (index == -1)
				return size;

			Console.Out.WriteLine($" Index : {element}");
			for (int i = index; i < size-1; i++)
				 arr[i] = arr[i + 1]; 

			return size-1;
		}

		public static int LargestOn(int[] arr)
		{
			int largest = int.MinValue;

			for(int i = 0;i < arr.Length;i++)
			{
				if (arr[i] > largest)
					largest = arr[i];
			}

			return largest;
		}

		public static int SecondLargestOn(int[] arr)
		{
			int largest = arr[0];
			int secondLargest = -1;

			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] > largest)
				{
					secondLargest = largest;
					largest = arr[i];
				}
				else if (arr[i] != largest)
				{
					if (secondLargest == -1 || arr[i] > secondLargest)
					{
						secondLargest = arr[i];
					}
				}
			}
			return secondLargest;
		}

		public static bool IsSortedOn(int[] arr,bool ascending = true)
		{
			for(int i = 1; i < arr.Length; i++)
			{
				if (arr[i - 1] > arr[i])
					return false;
			}
			return true;
		}

		public static int RemoveDuplicatesFromSortedOn(int[] arr)
		{
			if (!IsSortedOn(arr))
			{
				Console.Out.WriteLine($" Array Need To Be Sorted ");
				return -1;
			}

			int d = 1;

			for(int i = 1; i < arr.Length;i++)
			{
				if(arr[i] != arr[d - 1])
				{
					arr[d] = arr[i];
					d++;
				}
			}
			return d;
		}

		/// <summary>
		/// Moving Zeros to the end of array
		/// </summary>
		/// <param name="arr"></param>
		public static void ZerosToEndOn(int[] arr)
		{
			int zeroCount = 0;

			for(int i = 0; i < arr.Length;i++)
			{
				if(zeroCount > 0)
				{
					if(arr[i] == 0)
					{
						zeroCount++;
					}
					else
					{
						arr[i - zeroCount] = arr[i];
						arr[i] = 0;
					}
				}
				else
				{
					if (arr[i] == 0)
						zeroCount++;
				}
			}
		}

		public static void LeftRotateArrayByOne(int[] arr)
		{
			int temp = arr[0];
			for(int i = 1;i < arr.Length;i++)
			{
				arr[i - 1] = arr[i];
			}
			arr[arr.Length - 1] = temp;
		}

		public static int LinearSearchOn(int[] arr, int length, int x)
		{
			for(int i = 0; i < length; i++)
			{
				if (arr[i] == x)
					return i;
			}
			return -1;
		}

		public static void AllLeadersInArray(int[] arr)
		{
			for(int i = 1; i < arr.Length;i++)
			{
				if (arr[i] > arr[i - 1])
					Console.Out.Write($"{arr[i]},");
			}
		}


		// Multidimentional Arrays
		public static void PrintMatrixInSnakePattern(int[,] arr)
		{
			int column = 0;
			int count = 0;

			int rows = arr.GetLength(0);
			int columns = arr.GetLength(1);

			for (int row = 0;row < rows; row++)
			{
				int increament = row % 2 == 0 ? 1 : -1;
				count = 0;
				column = column >= columns ? (columns - 1) : (column < 0) ? 0 : column;
				//Console.Out.WriteLine(); 
				while (count < arr.GetLength(1))
				{
					Console.Out.Write(" " + arr[row, column] + " "); 
					column = column + increament;
					count++;
				}
			}
		}

		public static void PrintBoundryOfMatrix(int[,] arr)
		{
			int r = arr.GetLength(0);
			int c = arr.GetLength(1);

			// This Function is O(R+C)
			if(r==1)
			{
				for (int i = 0;i < c; i++)
					Console.Out.Write(" " + arr[0, i] + " ");
			}
			else if(c == 1)
			{
				for (int i = 0; i < r; i++)
					Console.Out.Write(" " + arr[i, 0] + " ");
			}
			else
			{
				for (int i = 0;i < c; i++)
					Console.Out.Write(" " + arr[0, i] + " ");
				for (int i = 1; i < r; i++)
					Console.Out.Write(" " + arr[i, c-1] + " ");
				for (int i = c-2; i >= 0; i--)
					Console.Out.Write(" " + arr[r-1,i] + " ");
				for (int i = r-2; i > 0; i--)
					Console.Out.Write(" " + arr[i, 0] + " ");
			}
		}

		public static bool TransposeOfMatrix(int[,] arr)
		{
			Console.Out.WriteLine($" Transpose Matrix ");
			Console.WriteLine("**************************");
			int rows = arr.GetLength(0);
			int columns = arr.GetLength(1);

			if (rows != columns)
				return false;

			for (int i = 0;i < rows; i++)
			{
				for(int j = i+1;j < columns;j++)
				{
					int temp = arr[i, j];
					arr[i, j] = arr[j, i];
					arr[j, i] = temp;
				}
			}

			for (int j = 0; j < rows; j++)
			{
				Console.Out.WriteLine();
				for (int k = 0; k < columns; k++)
					Console.Out.Write(" " + arr[j, k] + " ");
			}

			return true;
		}

		public static bool RotateMatrixBy90UsingTranspose(int[,] arr)
		{
			// First Transpose the Matrix So that first column becomes
			// last row
			int rows = arr.GetLength(0);
			int columns = arr.GetLength(1);
			Console.Out.WriteLine($"\n Rotate Matrix By 90 Degrees");

			if (TransposeOfMatrix(arr))
			{
				Console.Out.WriteLine($"\n Reverse Columns  ");
				Console.WriteLine("\n **************************");
				for (int i = 0; i < columns; i++)
				{
					int start = 0;
					int end = rows - 1;
					while(start < end)
					{
						int temp = arr[start, i];
						arr[start, i] = arr[end, i];
						arr[end, i] = temp;
						start++;
						end--;
					}
				}
			}


			for (int j = 0; j < rows; j++)
			{
				Console.Out.WriteLine();
				for (int k = 0; k < columns; k++)
					Console.Out.Write(" " + arr[j, k] + " ");
			}

			return true;
		}

		public static bool PrintMatrixInSpiralSequence(int[,] arr)
		{
			int top  = 0;
			int left = 0;
			int bottom = arr.GetLength(0) - 1;
			int right  = arr.GetLength(1) - 1;

			while(bottom > top && right > left)
			{
				for (int i = left; i <= right; i++)
					Console.Out.Write(" " + arr[top, i] + " ");
				top++;
				for(int j = top; j <= bottom; j++)
					Console.Out.Write(" " + arr[j, right] + " ");
				right--;
				for (int i = right; i >= left; i--)
					Console.Out.Write(" " + arr[bottom, i] + " ");
				bottom--;
				for (int j = bottom; j >= top; j--)
					Console.Out.Write(" " + arr[j, left] + " ");
				left++;
			}

			return true;
		}
	} 
}
