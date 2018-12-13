using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс, описывающий контакт.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Поле с именем контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле с фамилией контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Поле с номером.
        /// </summary>
        public PhoneNumber Phone;

        /// <summary>
        /// Поле с датой рождения.
        /// </summary>
        private DateTime _birthDate;

        /// <summary>
        /// Поле с электронной почтой.
        /// </summary>
        private string _email;

        /// <summary>
        /// Поле с ID Вконтакте.
        /// </summary>
        private string _vkId;

        /// <summary>
        /// Создание контакта.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="phone">Номер телефона</param>
        /// <param name="birthDate">Дата рождения</param>
        /// <param name="email">Электронная почта</param>
        /// <param name="vkId">Id Вконтакте</param>
        public Contact(string name, string surname, long phone, DateTime birthDate, string email, string vkId)
        {
            Name = name;
            Surname = surname;
            Phone = new PhoneNumber(phone);
            BirthDate = birthDate;
            Email = email;
            VkId = vkId;
        }

        /// <summary>
        /// Ввод имени контакта.
        /// </summary>
        public string Name
        {
            get => _name;

            set
            {
                if (value != string.Empty && value.Length < 50)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Некорректный ввод имени");
                }
            }
        }

        /// <summary>
        /// Ввод фамилии контакта.
        /// </summary>
        public string Surname
        {
            get => _surname;

            set
            {
                if (value != string.Empty && value.Length < 50)
                {
                    _surname = value;
                }
                else
                {
                    throw new ArgumentException("Некорректный ввод фамилии");
                }
            }
        }

        /// <summary>
        /// Вводы даты рождения.
        /// </summary>
        public DateTime BirthDate
        {
            get => _birthDate;

            set
            {
                if (value.Year > 1900)
                {
                    _birthDate = BirthDate;
                }
                else
                {
                    throw new ArgumentException("Некорректный ввод даты рождения");
                }
            }
        }

        /// <summary>
        /// Ввод электронной почты.
        /// </summary>
        public string Email
        {
            get => _email;

            set
            {
                if (value != string.Empty && value.Length < 50)
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Некорректный ввод электронной почты");
                }
            }
        }

        /// <summary>
        /// Ввод ID Вконтакте.
        /// </summary>
        public string VkId
        {
            get => _vkId;

            set
            {
                if (value != string.Empty && value.Length < 15)
                {
                    _vkId = value;
                }
                else
                {
                    throw new ArgumentException("Некорректный ввод ID Вконтакте");
                }
            }
        }
    }
}
