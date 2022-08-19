using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ContactsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Contacts = new Dictionary<string, string>();
            Contacts.Add("Oliver Jake","45653634654");
            Contacts.Add("Jack Connor","46546635654");
            Contacts.Add("Harry Callum","63463467979");
            Contacts.Add("Charlie Kyle","45674747654");
            Contacts.Add("Thomas Joe","47475475745");

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("You have {0} contact in your contacts.",Contacts.Count);
                Console.WriteLine("1 - Register Phone Number");
                Console.WriteLine("2 - Delete Phone Number");
                Console.WriteLine("3 - Update Phone Number");
                Console.WriteLine("4 - Directory Listing");
                Console.WriteLine("5 - Search in the Directory");
                Console.Write("Enter the action you want to do: ");
                Regex pattern = new Regex("^[a-zA-Z]+$");
                string process = Console.ReadLine();
                if (pattern.IsMatch(process))
                {
                    Console.WriteLine("Please enter a operation number and do not write non numeric characters.");
                }
                
                switch (process)
                {
                    case "1":
                        Console.Write("Please enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Please enter phone number: ");
                        string phone = Console.ReadLine();
                        Contacts.Add(name, phone);
                        Console.WriteLine(name + " added successfully.");
                        break;
                    case "2":
                        Console.Write("Please enter the name of the person you want to delete: ");
                        string name1 = Console.ReadLine();
                        if (Contacts.ContainsKey(name1))
                        {
                            Contacts.Remove(name1);
                            Console.WriteLine(name1 + " deleted successfully.");
                        }
                        else
                            Console.WriteLine("The person you are looking for was not found. Please enter a person's name in the directory.");
                        break;

                    case "3":
                        Console.Write("Please enter the name of the person you want to edit: ");
                        string name3 = Console.ReadLine();
                        Console.Write("Please enter the new number of the person you want to edit: ");
                        string phone_new = Console.ReadLine();
                        if (Contacts.ContainsKey(name3))
                        {
                            Contacts.Remove(name3);
                            Contacts.Add(name3, phone_new);
                            Console.WriteLine(name3 + " edited successfully.");
                        }
                        else
                            Console.WriteLine("The person you are looking for was not found. Please enter a person's name in the directory.");
                        break;
                    case "4":
                        Console.WriteLine("******Your contacts******");
                        foreach (var item in Contacts)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "5":
                        Console.Write("Please enter the name you want to search: ");
                        string name2 = Console.ReadLine();
                        bool status = Contacts.ContainsKey(name2);
                        
                        if (status)
                        {
                            Console.WriteLine("A person with this name is registered in your directory.");
                        }
                        else
                        {
                            Console.WriteLine("There is no person with this name in your contacts.");
                        } 
                        break;
                    default:
                        Console.WriteLine("Please enter a valid transaction.");
                        break;
                }
            }
        }
    }
}
