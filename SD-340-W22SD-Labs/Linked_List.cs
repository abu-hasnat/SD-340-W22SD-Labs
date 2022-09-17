using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Linked_List
{
	public class Linked_List<T>
	{
		public List<Node<T>> Nodes { get; set; }

		/// <summary>
		/// Node
		/// </summary>
		public class Node<T>
		{
			public T Data { get; set; }
			public Node<T>? Next { get; set; }

			public Node(T data, Node<T>? next)
			{
				Data = data;
				Next = next;
			}

			public void Print()
			{
				Console.WriteLine(Data?.ToString());
			}
		}

		/// <summary>
		/// Add new Nodes 
		/// </summary>
		/// <param name="new_data"></param>
		public void Add(T new_data)
		{
			Node<T> node = new Node<T>(new_data, Nodes.Count > 0 ? Nodes.Last() : null);
			Nodes.Add(node);
		}


		public void printList()
		{
			foreach (Node<T> node in Nodes)
			{
				node.Print();
			}
		}
	}
}
