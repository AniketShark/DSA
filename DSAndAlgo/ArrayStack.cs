using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgo
{
	public class ArrayStack
	{
		private int _size;
		private int _top;
		private int[] _arr;
		public ArrayStack(int size) 
		{
			_top = -1;
			_size = size;
			_arr = new int[size];
		}

		public ArrayStack(int[] arr)
		{
			_arr = arr;
			_top = arr.Length - 1;
			_size = arr.Length;
		}

		public void push(int val)
		{
		    if(_top >= _size - 1)
			{
				Console.WriteLine("Stack Overflow");
				return;
			}

			_top++;
			_arr[_top] = val;
		}

		public int pop()
		{
			if(_top <= -1)
			{
				Console.WriteLine("Stack Underflow");
				return 0;
			}
			int top = _arr[_top];
			_top--;
			return top;
		}

		public int peek()
		{
			if (_top >= 0 || _top < _size)
				return _arr[_top];
			else
				return 0;
		}


		public bool insert(int val, int pos)
		{
			return true;
		}
	}
}
