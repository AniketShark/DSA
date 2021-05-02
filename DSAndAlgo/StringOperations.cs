using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgo
{
	public class StringOperations
	{
		public bool IsPalindrome(char[] str)
		{
			int start = 0;
			int end = str.Length - 1;

			while(start < end)
			{
				if(str[start] != str[end])
				{
					return false;
				}
				start++;
				end--;
			}
			return true;
		}

		public bool CanFormPalindrome(char[] str)
		{
			List<char> charList = new List<char>();
			bool even = str.Length % 2 == 0 ? true : false;
			if(even)
			{
				return true;
			}

			return false;
		}
	}
}
