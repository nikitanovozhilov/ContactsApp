using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ContactsApp;

namespace СontactsAppUnitTests
{
    [TestFixture]
    public class PhoneNumberTest
    {
        private PhoneNumber _phoneNumber;

        [SetUp]
        public void InitPhone()
        {
            _phoneNumber=new PhoneNumber();
        }

        [Test(Description = "Позитивный тест геттера Number")]
        public void PhoneTestGet_CorrectValue()
        {
            var phone = 79998887766;
            _phoneNumber.Number = phone;
            var actual = _phoneNumber.Number;
            Assert.AreEqual(phone, actual, "Геттер Phone возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест геттера Number")]
        public void PhoneTestSet_CorrectValue()
        {
            var Phone = 79998887766;
            _phoneNumber.Number = Phone;
            var NewPhone = 79998887766;
            var actual = _phoneNumber.Number;
            Assert.AreEqual(Phone, actual, "Сеттер Phone задает неправильное значение");
        }

        [Test(Description = "Проверка на ввод номера телефона, длиной более 11 символов")]
        public void PhoneTestSet_Longer11()
        {
            var wrongPhone = 7888777666555;
            Assert.Throws<ArgumentException>(() => { _phoneNumber.Number = wrongPhone; }, "Должно возникать исключения," +
                                                                                   " если номер телефона содержит более 11 символов");
        }

        [Test(Description = "Проверка на первый символ номера телефона")]
        public void PhoneTestSet_FirstChar()
        {
            var wrongPhone = 89999998877;
            Assert.Throws<ArgumentException>(() => { _phoneNumber.Number = wrongPhone; }, "Должно возникать исключения," +
                                                                                          " если номер телефона начинается не с '7'");
        }
    }
}
