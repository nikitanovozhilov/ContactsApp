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
            var Name = "Иван";
            _contact.Name = Name;
            var actual = _contact.Name;
            Assert.AreEqual(Name, actual, "Геттер Name возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест сеттера Name")]
        public void NameTestSet_CorrectValue()
        {
            var Name = "Иван";
            _contact.Name = Name;
            var NewName = "Иван";
            var actual = _contact.Name;
            Assert.AreEqual(Name, actual, "Cеттер Name задает неправильное значение");
        }

        [Test(Description = "Проверка на ввод имени, длинной более 50 символов")]
        public void NameTestSet_Longer50()
        {
            var wrongName = "ИванИванИванИванИванИванИванИванИванИванИванИванИван";
            Assert.Throws<ArgumentException>(() => { _contact.Name = wrongName; }, "Должно возникать исключения," +
                                                                             " если имя содержит более 50 символов");
        }

        [Test(Description = "Проверка на имени, длиной 0 символов")]
        public void NameTestSet_Equal0()
        {
            var wrongName = "";
            Assert.Throws<ArgumentException>(() => { _contact.Name = wrongName; }, "Должно возникать исключения," +
                                                                                   " если имя не содержит символов");
        }

        /// <summary>
        /// Тесты Surname.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Surname")]
        public void SurnameTestGet_CorrectValue()
        {
            var Surname = "Иванов";
            _contact.Name = Surname;
            var actual = _contact.Name;
            Assert.AreEqual(Surname, actual, "Геттер Surname возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест сеттера Surname")]
        public void SurnameTestSet_CorrectValue()
        {
            var Surname = "Иванов";
            _contact.Surname = Surname;
            var NewSurname = "Иванов";
            var actual = _contact.Surname;
            Assert.AreEqual(Surname, actual, "Cеттер Surname задает неправильное значение");
        }

        [Test(Description = "Проверка на ввод фамилии, длинной более 50 символов")]
        public void SurnameTestSet_Longer50()
        {
            var wrongSurname = "ИвановИвановИвановИвановИвановИвановИвановИвановИванов";
            Assert.Throws<ArgumentException>(() => { _contact.Surname = wrongSurname; }, "Должно возникать исключения," +
                                                                                   " если фамилия содержит более 50 символов");
        }

        [Test(Description = "Проверка на ввод фамилии, длинной более 50 символов")]
        public void SurnameTestSet_Equal()
        {
            var wrongSurname = "";
            Assert.Throws<ArgumentException>(() => { _contact.Surname = wrongSurname; }, "Должно возникать исключения," +
                                                                                         " если фамилия не содержит символов");
        }

        /// <summary>
        /// Тесты BirthDate.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Birthday")]
        public void BirthDateTestGet_CorrectValue()
        {
            var BirthDate = DateTime.Now;
            _contact.BirthDate = BirthDate;
            var actual = _contact.BirthDate;
            Assert.AreEqual(BirthDate, actual, "Геттер BirthDate возвращает неправильное значение");
        }


    }
}
