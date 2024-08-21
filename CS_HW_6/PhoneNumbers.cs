using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_6
{
    class PhoneNumbers
    {
        private Dictionary<string, string> contacts = new Dictionary<string, string>();
        public void AddContact(string name, string phoneNumber)
        {
            contacts.Add(name, phoneNumber);
        }
        public void RemoveContact(string name)
        {
            contacts.Remove(name);
        }
        public string GetContact(string name)
        {
            if (contacts.TryGetValue(name, out string phoneNumber))
            {
                return phoneNumber;
            }
            return "Контакт найден.";
        }

        public void PrintAllContacts()
        {
            Console.WriteLine("Все контакты:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Имя: {contact.Key}, Телефон: {contact.Value}");
            }
        }
    }
}
