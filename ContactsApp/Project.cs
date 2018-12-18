using System;
using System.Collections.Generic;
using System.Linq;

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
            list.Sort((a, b) => a.Surname.CompareTo(b.Surname));
            return list;
        }

        /// <summary>
        /// Получение списка именинников.
        /// </summary>
        /// <returns></returns>
        public List<string> GetListBirthdayBoy()
        {
            var listContacts = ContactList.Where(
                a => a.BirthDate.Day == DateTime.Now.Day && a.BirthDate.Month == DateTime.Now.Month);

            return listContacts.Select(contact => contact.Surname).ToList();
        }

        /// <summary>
        /// Поиск по имени или фамилии.
        /// </summary>
        public List<Contact> GetByNameOrSurname(string text)
        {
            return Sort().FindAll(a => a.Surname.Contains(text) || a.Name.Contains(text));
        }
    }
}
