using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgo
{
	public class Mathematical
	{
		public static long ReverseTheNumber(long n)
		{
			long reverse = 0;
			while (n != 0)
			{
				long r = n % 10;
				n = n / 10;
				reverse = reverse * 10 + r;
			}

			return reverse;
		}
	
		// Count Digits In Number
		public static long NumberOfDigitsIterative(long n)
		{
			int count = 0;
			while (n != 0)
			{
				n = n / 10;
				++count;
			}
			return count;
		}

		public static long NumberOfDigitsRecursive(long n)
		{
			if (n == 0)
				return n;
			return 1 + NumberOfDigitsRecursive(n/10);
		}

		public static long NumberOfDigitsLogarithmic(long n)
		{
			return (long)Math.Floor(Math.Log10(n) + 1);
		}

		// Palindrome Number
		public static bool PalindromeNumberWithArray(int n)
		{
			int digits = (int)NumberOfDigitsLogarithmic(n);
			int[] number = new int[digits];

			int count = digits;
			while (count > 0)
			{
				count--;
				int r = n % 10;
				n = n / 10;
				number[count] = r;
			}

			int left = 0;
			int right = digits-1;

			while(left < right)
			{
				if(number[left] != number[right])
				{
					return false;
				}
				left++;
				right--;
			}

			for (int i = 0; i < number.Length; i++)
				Console.Out.Write(number[i] + ",");
			return true;
		}
		
		public static bool PalindromeNumeberEfficient(long n)
		{
			long original = n;
			long reverse = 0;
			while (n != 0)
			{
				long r = n % 10;
				n = n / 10;
				reverse = reverse * 10 + r;
			}

			if (original == reverse)
				return true;
			return false;
		}


		// Factorial Of Number
		public static long FactorialIterative(long n)
		{
			if (Math.Sign(n) == -1)
			{
				Console.Out.Write($"Negative Numbers are not allowed in factorial");
				return 0;
			}
			long factorial = n;
			while(n > 1)
			{
				factorial *= (n - 1);
				n = n - 1;
			}
			return factorial;
		}

		public static long FactorialRecursive(long n)
		{
			if (Math.Sign(n) == -1)
			{
				Console.Out.Write($"Negative Numbers are not allowed in factorial");
				return 0;
			}
			if (n == 0)
				return 1;

			return n * FactorialRecursive(n-1);
		}

		public static long FactorialIterativeWithTrailingZeros(long n,ref long trailingZeros)
		{
			trailingZeros = 0;
			for(int i = 5;i < n; i=i*5)
			{
				trailingZeros += (n / i);
			}
			//decimal primeFactor = n / 5;
			//trailingZeros = (long)Math.Floor(primeFactor);
			if (Math.Sign(n) == -1)
			{
				Console.Out.Write($"Negative Numbers are not allowed in factorial");
				return 0;
			}
			long factorial = n;
			while (n > 1)
			{
				factorial *= (n - 1);
				n = n - 1;
			}
			return factorial;
		}

		public static long TrailingZeros(long n)
		{
			long trailingZeros = 0;
			while (n % 10 == 0)
			{
				trailingZeros++;
				n = n / 10;
			}

			return trailingZeros;
		}

		public static long TrailingZerosWithLoop(long n)
		{
			long trailingZeros = 0;
			for (int i = 5; i < n; i = i * 5)
			{
				trailingZeros += (n / i);
			}
			return trailingZeros;
		}

		/// <summary>
		/// Greatest Common Diviser
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <returns></returns>

		public static long GCD(long n, long m)
		{
			long gcd = Math.Min(n, m);

			while (gcd > 0)
			{
				if (n % gcd == 0 && m % gcd == 0)
					break;
				gcd--;
			}

			return gcd;
		}

		/// <summary>
		/// GCD by Euclidian Subtraction
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		public static long GCDEuclidSubtraction(long n,long m)
		{
			while(n != m)
			{
				if (n > m)
					n = n - m;
				else
					m = m - n;
			}
			return m;
		}

		/// <summary>
		/// This was my first attempt at GCD Mod Version
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		public static long GCDEuclidMod(long n, long m)
		{
			long gcd = Math.Min(n, m);

			if (gcd == 0)
				return Math.Max(n, m);

			if (gcd == n)
				m = m % n;
			else
				n = n % m;

			return GCDEuclidMod(n, m);
		}

		/// <summary>
		/// This is the most efficient way to calculate GCD
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		public static long GCDEuclidMod2(long n, long m)
		{
			if (m == 0)
				return n;

			return GCDEuclidMod2(m, n%m);
		}


		/// <summary>
		/// Least Common Multiplier
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <returns></returns> 
		public static long LCM(long n,long m)
		{
			long max =  Math.Max(n, m);
			long lcm = max;
			int count = 1;
			while(true)
			{
				if (lcm % n == 0 && lcm % m == 0)
					break;
				lcm = count * max;
				count++;
			}

			return lcm;
		}

		public static long LCMEfficient(long n, long m)
		{
			return (n * m) / GCDEuclidMod2(n, m);
		}

	}
}
