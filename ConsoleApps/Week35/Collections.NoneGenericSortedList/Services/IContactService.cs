using PhoneBookSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.NoneGenericSortedList.Services
{
    internal interface IContactService
    {
        public bool Add(Contact contact);

        public void Update(string name, Contact updatedContact);

        public Contact Search(string name);

        public SortedList GetAll();

        public void Delete(string name);

        public void Save();

        public void LoadContacts();
        void Add();
    }
}
