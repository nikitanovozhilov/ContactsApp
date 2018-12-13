using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс с номером телефона.
    /// </summary>
    public class PhoneNumber
    {
        private long _phoneNumber;

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
                if (valueString.Length == 11 && valueString[0] == '7')
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
