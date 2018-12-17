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
                if (valueString.Length != 11)
                {
                    throw new ArgumentException("Номер телефона должен состоять из 11 цифр, а было" + valueString.Length);
                }
                else if (valueString[0] != '7')
                {
                    throw new ArgumentException("Номер телефона должен начинаться с '7', а начинается с " + valueString[0]);
                }

                else
                {
                    _phoneNumber = value;
                }
            }
        }
    }
}
