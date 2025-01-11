using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection
{
    class Contact
    {
        private string name;
        private string phone;
        private string email;

        public Contact(string name, string phone, string email)
        {
            this.Name = name;
            this.phone = phone;
            this.email = email;
        }

        public string Name { get => name; set => name = format_full(value); }

        public override string ToString()
        {
            string description = "Name : " + Name +"\n";
            description += "Phone : " + phone + "\n";
            description += "Email : " + email;

            return description;
            //return base.ToString();
        }
        private string format_capital(string input)
        {
            string first = input.Substring(0, 1);
            string last = input.Substring(1);

            return first.ToUpper() + last.ToLower();
        }
        private string format_full(string input)
        {
            string[] array = input.Split(' ');
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += format_capital(array[i]) + " ";
            }
            return result.TrimEnd(' ');
        }
        public override bool Equals(object obj)
        {
            if (obj is Contact)
            {
                //Contact objContact = (Contact)obj;
                Contact objContact = obj as Contact;
                if(string.Compare(objContact.Name, this.Name, true) == 0)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
