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

        public Contact()
        {
            _birthDate = new DateTime(2000,1,1);
            Phone = new PhoneNumber(70000000000);
        }

        /// <summary>
        /// Ввод имени контакта.
        /// </summary>
        public string Name
        {
            get => _name;

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Поле 'Name' не может быть пустым");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Длина имени должна быть не более 50 символов, а была" + value.Length);
                }
                else
                {
                    _name = value;
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
                if (value == string.Empty)
                {
                    throw new ArgumentException("Поле 'Surname' не может быть пустым");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Длина фамилии должна быть не более 50 символов, а была" + value.Length);
                }
                else
                {
                    _surname = value;
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
                if (value.Year <= 1900)
                {
                    throw new ArgumentException("Дата рождения не может быть меньше 1900 года");
                }
                else if (value > DateTime.Today)
                {
                    throw new ArgumentException("Дата не должна быть больше " + DateTime.Today.ToShortDateString() +
                                                ", а была " + value.Date.ToShortDateString());
                }
                else
                {
                    _birthDate = value;
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
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Поле 'E-mail' не может быть пустым");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Длина адреса почты должна быть не более 50 символов," +
                                                " а была " + value.Length);
                }
                else
                    _email = value;
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
                if (value == string.Empty)
                {
                    throw new ArgumentException("Поле 'vk.com' не может быть пустым");
                }
                else if (value.Length > 15)
                {
                    throw new ArgumentException("Длина id Вконтакте должна быть не более 15 символов, а была " + value.Length);
                }
                else
                {
                    _vkId = value;
                    
                }
            }
        }
    }
}
