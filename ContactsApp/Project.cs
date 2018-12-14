using System.Collections.Generic;
using Newtonsoft.Json;

namespace ContactsApp
{
    public class Project
    {
        /// <summary>
        /// Список контактов.
        /// </summary>
        public List<Contact> ContactList;

        public Project()
        {
            ContactList = new List<Contact>();
        }

        /// <summary>
        /// Сортировка списка по алфавиту.
        /// </summary>
        public List<Contact> Sort()
        {
            var list = ContactList;
            list.Sort((a, b) => a.Name.CompareTo(b.Name));
            return list;
        }

        /// <summary>
        /// Поиск по имени или фамилии.
        /// </summary>
        public List<Contact> GetByNameOrSurname(string text)
        {
            return ContactList.FindAll(a => a.Surname.Contains(text) || a.Name.Contains(text));
        }
    }
}
