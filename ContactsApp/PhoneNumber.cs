using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс с номером телефона.
    /// </summary>
    public class PhoneNumber
    {
        private long _phoneNumber;

        public PhoneNumber()
        {
        }

        public PhoneNumber(long phone)
        {
            Number = phone;
        }

        public long Number
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                var valueString = value.ToString();
                long num = 0;
                if (valueString.Length == 11 && valueString[0] == '7' && long.TryParse(valueString, out num))
                {
                    _phoneNumber = value;
                }

                else
                {
                    throw new ArgumentException("Номер телефона введён некорректно");
                }
            }
        }
    }
}
