using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ContactsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contact> Contactlist = new List<Contact>();
            Contact contact1 = new Contact("Oliver", "Jake", "45653634654");
            Contact contact2 = new Contact("Jack", "Connor", "46546635654");
            Contact contact3 = new Contact("Harry", "Callum", "63463467979");
            Contact contact4 = new Contact("Charlie", "Kyle", "45674747654");
            Contact contact5 = new Contact("Thomas", "Joe", "47475475745");
            Contactlist.Add(contact1);
            Contactlist.Add(contact2);
            Contactlist.Add(contact3);
            Contactlist.Add(contact4);
            Contactlist.Add(contact5);
            Methods methods = new Methods();


            while (true)
            {
                
                Console.WriteLine("");
                Console.WriteLine("1 - Register Phone Number");
                Console.WriteLine("2 - Delete Phone Number");
                Console.WriteLine("3 - Update Phone Number");
                Console.WriteLine("4 - Directory Listing");
                Console.WriteLine("5 - Search in the Directory");
                Console.WriteLine("6 - Exit the Application");
                Console.Write("Enter the action you want to do: ");

                Regex pattern = new Regex("^[a-zA-Z]+$");
                string process = Console.ReadLine();

                if (pattern.IsMatch(process))//On this line I blocked numeric input from keyboard.
                {
                    Console.WriteLine("Please enter a operation number and do not write non numeric characters.");
                }
                
                switch (process)
                {
                    case "1": //Add new contact.
                        Console.Write(" Please enter name: ");
                        string name = Console.ReadLine();
                        Console.Write(" Please enter surname: ");
                        string surname = Console.ReadLine();
                        Console.Write(" Please enter phone number: ");
                        string phone = Console.ReadLine();
                        Contact Contact = new Contact(name, surname, phone);
                        Contactlist.Add(Contact);
                        Console.Write("{0} {1} added your contacts successfully.",name,surname);
                        break;
                    case "2": //Delete contact.
                        Console.Write("Please enter the name of the person you want to delete: ");
                        string namesurname = Console.ReadLine();
                        foreach (var item in Contactlist.ToList())
                        {
                            if (item.Name == namesurname || item.Surname == namesurname)
                            {
                                Console.WriteLine("The person named {0} is about to be deleted from the directory, do you confirm? ?(y/n)", item.Name);
                                string answer = Console.ReadLine();
                                if (answer == "y")
                                {
                                    Contactlist.Remove(item);
                                    Console.WriteLine("The contact has been deleted.");
                                }
                                else if (answer == "n")
                                {
                                    Console.WriteLine("Deletion canceled.");
                                }
                                else if (answer != "n" || answer != "y")
                                {
                                    Console.WriteLine("You can just write 'y' or 'n'");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The person named {0} was not found in the directory", namesurname);
                                break;
                            }
                        }
                        break;

                    case "3": //Update or edit contact.
                        Console.Write("Please enter name of contact you want to edit: ");
                        string namesurname1 = Console.ReadLine();
                        foreach (var item in Contactlist)
                        {
                            if (item.Name == namesurname1 || item.Surname == namesurname1)
                            {
                                methods.ContactUpdate(item);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("The person named {0} was not found in the directory", namesurname1);
                                break;
                            }
                        }
                        break;
                    case "4": //List all contacts.
                        methods.ListDirectory(Contactlist);
                        break;
                    case "5": //Search to a specific person.
                        Console.WriteLine("Select the type you want to search.\n**********************************************");
                        Console.WriteLine("To search by first or last name: (1)\nTo search by phone number: (2)");

                        Regex pattern1 = new Regex("^[a-zA-Z]+$");
                        string num2 = Console.ReadLine();

                        if (pattern1.IsMatch(num2))//On this line I blocked numeric input from keyboard.
                        {
                            Console.WriteLine("Please enter a operation number and do not write non numeric characters.");
                        }
                        else
                        {
                            int num1 = Convert.ToInt32(num2);

                            if (num1 == 1)
                            {
                                Console.WriteLine("Enter the first or last name you want to search for: ");
                                string namesurname2 = Console.ReadLine();
                                methods.Search(namesurname2, Contactlist);
                                break;
                            }
                            else if (num1 == 2)
                            {
                                Console.WriteLine("Enter the phone number you want to call: ");
                                string phone3 = Console.ReadLine();
                                methods.Search(phone3, Contactlist);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You can only enter 1 or 2.");
                            }
                        }
                        break;
                    case "6": //It closes the program.
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid transaction.");
                        break;
                }
            }
        }
    }
}
