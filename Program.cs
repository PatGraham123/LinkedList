using System;


namespace LinkedList
{
    class Program
    {
        /// <summary>
        /// Runs the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();

            ll.Insert(44);
            ll.Print();
            ll.Insert(88);
            ll.Print();
            ll.Insert(33);
            ll.Print();
            ll.Insert(66);
            ll.Print();

            
            ll.Delete(88);
            Console.WriteLine("After Delete...");
            ll.Print();
            int noOfNodes = ll.Count();
            Console.WriteLine($"list contains returns {noOfNodes} nodes");

            //88 Was deleted previously
            Console.WriteLine($"list found(88) = {ll.Find(88)}");
            Console.WriteLine($"list found(44) = {ll.Find(44)}");
            
            Console.WriteLine("Linked List before clear contains:");
            ll.Print();
            ll.Clear();
            Console.WriteLine("Linked List after clear contains:");
            ll.Print();
            

        }
    }

    /// <summary>
    /// LinkedList
    /// </summary>
    public class LinkedList
    {
        Node start;

        /// <summary>
        /// Linked List Constructor
        /// </summary>
        public LinkedList()
        {
            start = null;
        }

        /// <summary>
        /// Linked List Constructor with a value included
        /// </summary>
        /// <param name="x"></param>
        public LinkedList(int x)
        {
            Node start = new Node(x);
        }

        /// <summary>
        /// Clear the List by removing all nodes
        /// </summary>
        public void Clear()
        {
            // Iterate over the list and delete each node in the list using the Delete method
            Node p = start;
            while(p != null)
            {
                Delete(p.Data);
                p = p.Next;
                
            }
           start = null;
        }

        /// <summary>
        /// Returns the count of elements in the list
        /// </summary>
        /// <returns>The Count on Nodes in the Linked List</returns>
        public int Count()
        {
            // Iterate over the list and return the count of nodes in the list
            int length = 0;
            Node p = start;
            
            while (p != null)
            {
                p = p.Next;
                length++;
            }
            return length;
        }

        /// <summary>
        /// Removes the node containing the designated value
        /// </summary>
        /// <param name="value">Designated value</param>
        public void Delete(int value)
        {
            var p = start;
            if (p == null)
            {
                return;
            }
            else if (p.Data == value)
            {
                p = p.Next;
                return;
            }

            else
            {
                while (p.Next != null)
                {
                    if (p.Next.Data == value)
                    {
                        p.Next = p.Next.Next;
                        return;
                    }

                    p = p.Next;
                }
            }
            
        }


        /// <summary>
        /// Searches the Linked List for the designated value
        /// </summary>
        /// <param name="value">designated search value</param>
        /// <returns>boolean indicating whether the value exists in the linked list</returns>
        public bool Find(int value)
        {
            var p = start;
            

            if (p == null)
            {
                return false;
            }
            else if (p.Data == value)
            {
                return true;
            }
            else
            {
                while (p.Next != null)
                {
                    if (p.Data == value)
                    { 
                        return true;
                    }
                    p = p.Next;
                }
            }
            return false;
        }

        /// <summary>
        /// Inserts a node in the list based in the value.  The list will be maintained in
        /// ascending order.
        /// </summary>
        /// <param name="x">Value to insert in the list</param>
        public void Insert(int x)
        {
            Node newNode = new Node(x);
            if (Count() == 0)
            {
                start = newNode;
            }
            else
            {
                Node p = start;
                while(p.Next != null)
                {
                    p = p.Next;
                }
                p.Next = newNode;
            }

        }

    /// <summary>
    /// Print out the contents of the Linked List
    /// </summary>
    public void Print()
    {
        // Iterate over the List and dump the nodes
        for (Node p = start; p != null; p = p.Next)
            Console.Write(p.Data + " ");

        Console.WriteLine("");
    }

}

/// <summary>
/// Node Class
/// </summary>
public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Constructor with Data
        /// </summary>
        /// <param name="data"></param>
        public Node(int data)
        {
            this.Data = data;
        }

        /// <summary>
        /// All parameter Constructor
        /// </summary>
        /// <param name="data">node data</param>
        /// <param name="next">reference to the next node in the list</param>
        public Node(int data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
    }



}
