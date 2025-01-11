using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection
{
    static class Phonebook
    {
        private static List<Contact> list_contact = new List<Contact>();

        public static void Add(Contact contact)
        {
            Phonebook.list_contact.Add(contact);
        }
        public static void Display()
        {
            foreach (Contact obj in Phonebook.list_contact)
            {
                Console.WriteLine(obj.ToString() + "\n");
            }
          
        }
        public static Contact Search_By_Name(string name)
        {
            foreach (Contact obj in Phonebook.list_contact)
            {
                if(string.Compare(obj.Name, name, true) == 0)
                {
                    return obj;
                }
            }
            return null;
        }
        public static bool Contains(Contact myContact)
        {
            foreach (Contact obj in Phonebook.list_contact)
            {
                if(obj.Equals(myContact))
                {
                    return true;
                }
            }
                return false;
        }

        private static void Display3()
        {
            int counter = 0;
            while (counter < Phonebook.list_contact.Count)
            {
                Contact obj = Phonebook.list_contact[counter];
                Console.WriteLine(obj.ToString() + "\n");
                counter++;
            }
        }

        private static void Display2()
        {
            for (int i = 0; i < Phonebook.list_contact.Count; i++)
            {
                Contact obj = Phonebook.list_contact[i];
                Console.WriteLine(obj.ToString() + "\n");
            }
        }
    }
}
