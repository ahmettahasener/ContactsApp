using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Contact
    {
        private string name;
        private string surname;
        private string phone;

        public Contact(string name, string surname, string phone)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
        }

        public Contact()
        {

        }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
