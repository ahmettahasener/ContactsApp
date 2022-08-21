using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Methods
    {
        public void Search(string value, List<Contact> list)
        {
            foreach (var item in list)
            {
                if (item.Name.Contains(value) || item.Surname.Contains(value) || item.Phone.Contains(value))
                {
                    Console.WriteLine(" Your Search Results: ");
                    Console.WriteLine("A person with this name is registered in your directory. \n**********************************************");
                    Console.WriteLine("Name: {0}", item.Name);
                    Console.WriteLine("Surname: {0}", item.Surname);
                    Console.WriteLine("Phone Number: {0}", item.Phone);
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("There is no person with this name in your contacts. Please make a selection.");
                }
            }
        }

        public void ListDirectory(List<Contact> list)
        {
            Console.WriteLine("******Your contacts******");

            foreach (var item in list)
            {
                Console.WriteLine("Name: {0}", item.Name);
                Console.WriteLine("Surname: {0}", item.Surname);
                Console.WriteLine("Phone Number: {0}", item.Phone);
                Console.WriteLine("-");

            }
        }
        public void ContactUpdate(Contact item)
        {
            Console.Write(" Please enter new name: ");
            string name1 = Console.ReadLine();
            item.Name = name1;
            Console.Write(" Please enter new surname: ");
            string surname2 = Console.ReadLine();
            item.Surname = surname2;
            Console.Write(" Please enter new phone number: ");
            string Phone2 = Console.ReadLine();
            item.Phone = Phone2;


            Console.WriteLine("Updated name: " + item.Name);
            Console.WriteLine("Updated name: " + item.Surname);
            Console.WriteLine("Updated name: " + item.Phone);
        }
    }
}
