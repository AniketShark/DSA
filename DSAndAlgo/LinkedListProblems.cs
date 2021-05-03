using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgo
{
	public class LinkedListProblems
	{

		public static void PrintMiddleOfLinkedList<T>(LinkedList<T> linkedList)
		{
			var fast = linkedList.GetEnumerator();
			var slow = linkedList.GetEnumerator();
			while(fast.Current != null)
			{
				try
				{
					fast.MoveNext();
					slow.MoveNext();
					if (!fast.MoveNext())
					{
						Console.Out.WriteLine($" Mid : {slow.Current.ToString()}");
						break;
					}
				}
				catch(Exception e)
				{
					Console.Out.WriteLine($"Exception : {e.Message}");
				}
			}
		}


		public static void FlatteningLinkedList<T>(LinkedListNode<T> linkedList)
		{

		}

		public static void ReverseLinkedDoublyLinkedList(LinkedList<int> linkedList)
		{
			Console.Out.WriteLine($" Linked List ");
			var ite = linkedList.GetEnumerator();
			while (ite.MoveNext())
			{
				Console.Out.WriteLine($"Item : {ite.Current}");
			}

			LinkedListNode<int> start  = linkedList.First;
			LinkedListNode<int> end    = linkedList.Last;

			while(start.Previous != end && start != end)
			{
				int temp = start.Value;
				start.Value = end.Value;
				end.Value = temp;

				start = start.Next;
				end = end.Previous;
			}

			var ite2 = linkedList.GetEnumerator();

			Console.Out.WriteLine($" Linked List Reversed");
			while (ite2.MoveNext())
			{
				Console.Out.WriteLine($"Item : {ite2.Current}");
			}
		}

	}
}
