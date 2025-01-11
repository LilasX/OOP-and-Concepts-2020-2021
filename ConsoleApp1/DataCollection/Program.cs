using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact mycontact = new Contact("Adam", "514-000-0000", "adam@gmail.com");
            Contact mycontact2 = new Contact("Lara", "514-000-1111", "lara@gmail.com");
            

            Phonebook.Add(mycontact);
            Phonebook.Add(mycontact2);
            mycontact2.Name = "fred lessard";

            Phonebook.Display();

            Contact obj = Phonebook.Search_By_Name("fred lessard");
            if (obj != null)
            {
                Console.WriteLine(obj.ToString());
            }
            else
            {
                Console.WriteLine("Contact is not found");
            }

            Contact mycontact3 = new Contact("Adam", "514-000-0000", "adam@gmail.com");

            bool found = Phonebook.Contains(mycontact3);
            if (found)
            {
                Console.WriteLine("Contact is found");
            }
            else
            {
                Console.WriteLine("Contact is not found");
            }

            Console.ReadKey();
        }

        private static void Queue_Demo()
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("One");
            myQueue.Enqueue("Two");
            myQueue.Enqueue("Three");

            Console.WriteLine("Peek : " + myQueue.Peek());
            Console.WriteLine("Dequeue : " + myQueue.Dequeue());
            Console.WriteLine("Dequeue : " + myQueue.Dequeue());
            Console.WriteLine("Dequeue : " + myQueue.Dequeue());

            Console.ReadKey();
        }

        private static void Stack_Demo()
        {
            //Stack myStack = new Stack();
            Stack<string> myStack = new Stack<string>();
            myStack.Push("One");
            //myStack.Push(2);
            myStack.Push("Two");
            myStack.Push("Three");

            Console.WriteLine("Count : " + myStack.Count);
            Console.WriteLine("Peek : " + myStack.Peek());

            Console.WriteLine("Pop : " + myStack.Pop());
            Console.WriteLine("Pop : " + myStack.Pop());
            Console.WriteLine("Pop : " + myStack.Pop());

            Console.ReadKey();
        }

        public static void ArrayList_Demo()
        {
            //ArrayList myArray = new ArrayList();
            List<string> myArray = new List<string>();
            Console.WriteLine("Capacity : " + myArray.Capacity);

            myArray.Add("One");
            //myArray.Add(2);
            myArray.Add("Two");

            Console.WriteLine("Capacity : " + myArray.Capacity);
            Console.WriteLine("Count : " + myArray.Count);

            foreach (Object items in myArray)
            {
                Console.WriteLine(items.ToString());
            }
            Console.WriteLine("==============");

            for (int i = 0; i < myArray.Count; i++)
            {
                Console.WriteLine(myArray[i].ToString());
            }

            Console.ReadKey();
        }
    }
}
