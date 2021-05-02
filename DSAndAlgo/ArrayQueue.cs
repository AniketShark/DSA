using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgo
{
	public class ArrayQueue
	{
		private int[] _arr;
		private int _head;
		private int _tail;
		private int _size;

		public ArrayQueue(int size)
		{
			_arr = new int[size];
			_size = size;
			_head = 0;
			_tail = 0;
		}

		public ArrayQueue(int[] array)
		{
			_arr = array;
			_size = array.Length;
			_head = 0;
			_tail = array.Length;
		}

		public void enqueue(int item)
		{
			if (_tail >= _size)
			{
				Console.WriteLine("Queue is Full");
				return;
			}
			_arr[_tail] = item;
		}

		public int dequeue()
		{
			if (_head == _tail)
			{
				_head = 0;
				_tail = 0;
				Console.WriteLine("Queue is Empty : Resetting Head And Tail");
				return -1;
			}

			int val = _arr[_head];
			_arr[_head] = -1;
			_head++;
			return val;
		}

	}
}
