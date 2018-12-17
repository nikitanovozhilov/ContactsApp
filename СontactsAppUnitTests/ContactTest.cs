using System;
using System.Collections.Generic;
using ContactsApp;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace СontactsAppUnitTests
{
    [TestFixture]
    class ContactTest
    {
        private Contact _contact;
        private PhoneNumber _phoneNumber;

        [SetUp]
        public void InitContact()
        {
            _contact = new Contact();
            _phoneNumber = new PhoneNumber();
        }

        [Test(Description = "Позитивный тест геттера Name")]
        public void NameTestGet_CorrectValue()
        {

        }
    }
}
