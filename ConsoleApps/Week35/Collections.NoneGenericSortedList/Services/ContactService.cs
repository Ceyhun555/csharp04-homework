using PhoneBookSystem.Constants;
using PhoneBookSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using static PhoneBookSystem.Constants.AppConstants;

namespace Collections.NoneGenericSortedList.Services
{

    internal class ContactService : IContactService, IFileService
    {
        private readonly SortedList _contacts;
        private object contact;

        public ContactService()
        {
            _contacts = new SortedList();
        }
        public bool Add(Contact contact)
        {
            if (_contacts.ContainsKey(contact.Name))
            {
                return false;
            }
            contact.LastModified = DateTime.Now;

            _contacts.Add(contact.Name, contact);

            return true;

        }

        public void Delete(string name)
        {
            if (_contacts.Contains(name))
            {
                _contacts.Remove(name);
                Console.WriteLine("Contact deleted.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void GetAll(SortedList _contacts)
        {
            if (_contacts.Count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            Console.WriteLine("\nPhone Book Contacts (Sorted by Name):\n");

            IDictioanryEnumerator enumerator = (IDictioanryEnumerator)_contacts.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Contact contact = (Contact)enumerator.Value;
                DisplayContact(contact);
                Console.WriteLine();
            }
        }

        public void LoadContacts()
        {
            LoadFromFile(_contacts, FilePath);
        }

        private void LoadFromFile(SortedList contacts, Stream filePath)
        {
            if (File.Exists(FilePath))
                return;

            string[] lines = File.ReadAllLines(FilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 5)
                {
                    Contact contact = new Contact
                    {
                        Name = parts[0],
                        PhoneNumber = parts[1],
                        Email = parts[2],
                        Address = parts[3],
                        LastModified = DateTime.Parse(parts[4])
                    };
                    if (!contacts.Contains(contact.Name))
                    {
                        contacts.Add(contact.Name, contact);
                    }
                }
            }
        }

        public void Save()
        {
            SaveToFile(_contacts);
        }

        private void SaveToFile(SortedList contacts)
        {
            using (StreamWriter writer = new StreamWriter(AppConstants.FilePath))
            {
                IDictionaryEnumerator enumerator = _contacts.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Contact contact = (Contact)enumerator.Value;
                    string line = string.Format("{0}|{1}|{2}|{3}|{4}",
                        contact.Name,
                        contact.PhoneNumber,
                        contact.Email,
                        contact.Address,
                        contact.LastModified.ToString("o"));
                    writer.WriteLine(line);
                }
            }
            Console.WriteLine("Changes saved. Exiting...");
        }

        public void Search(string name)
        {
            /* keye gore yoxla varsada contacti geri qaytar. */
            if (_contacts.ContainsKey(name))
            {
                DisplayContact((Contact)_contacts[name]);
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }

        }

        private void GetContactInput(string name)
        {
            while (!InputValidator.IsValidPhoneNumber(phoneNumber))
            {
                Console.Write("Invalid phone number. Try again: ");

            }
        }

        private void DisplayContact(Contact? contact)
        {
            Console.WriteLine($"\nName: {contact.Name}\nPhone: {contact.PhoneNumber}\nEmail: {contact.Email}\nAddress: {contact.Address}\nLast Modified: {contact.LastModified}\n");
        }

        public void Update(string name, Contact updatedContact)
        {
            /*Key e gore containsi yoxla. Update last modifiedi teze tarixe cevirmeliyem. Contact key e gore assignet update contact.
             */

            if (!_contacts.ContainsKey(name))
            {
                Console.WriteLine("Contact not found.");
                return;
            }
            string name = InputValidator.ReadNonEmptyString("Enter contact name to update: ");
            if (!_contacts.Contains(name))
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            Contact contact = (Contact)_contacts[name];

            contact.PhoneNumber = InputValidator.IsValidPhoneNumber("Enter new phone number: ");
            contact.Email = InputValidator.IsValidEmail("Enter new email: ");
            contact.Address = InputValidator.ReadNonEmptyString("Enter new address: ");
            contact.LastModified = DateTime.Now;

            Console.WriteLine("Contact updated successfully.");


        }

        private void GetContact(string name)
        {
            GetContactInput(name);
        }

        public void View()
        {
            if (_contacts.Count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            Console.WriteLine("\nPhone Book Contacts (Sorted by Name):\n");

            IDictionaryEnumerator enumerator = _contacts.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Contact contact = (Contact)enumerator.Value;
                DisplayContact(contact);
                Console.WriteLine();
            }
        }

        void IFileService.SaveToFile(SortedList _contacts)
        {
            SaveToFile(_contacts);
        }

        public SortedList ReadFromFile()
        {
            throw new NotImplementedException();
        }

        Contact IContactService.Search(string name)
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }
}
