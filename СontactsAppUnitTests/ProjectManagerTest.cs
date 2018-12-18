using ContactsApp;
using Newtonsoft.Json;
using NUnit.Framework;
using System.IO;
using System.Linq;

namespace СontactsAppUnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        [Test(Description = "Позитивный тест сериализации. Сохранение")]
        public void TestProjectManagerSaveTToFile_CorrectValue()
        {
            Contact contact = new Contact();
            contact.Surname = "Petrow";
            contact.Name = "Petya";
            contact.VkId = "id01";
            contact.Email = "email";
            var project = new Project();
            project.ContactList.Add(contact);
            ProjectManager.SaveToFile(project);

            var actual = ProjectManager.LoadFromFile().ContactList.Last();
            Assert.AreEqual(contact.Surname, actual.Surname, "Сериализация работает неверно!");
        }
        [Test(Description = "Сохранение в неверный путь.")]
        public void TestProjectManagerSaveToFile_NotCorrectPath()
        {
            Contact contact = new Contact();
            contact.Surname = "Petrow";
            var project = new Project();
            project.ContactList.Add(contact);
            Assert.Throws<System.IO.IOException>(() => { ProjectManager.SaveToFile(project, "c:\\New Folder\\"); }, "Должно возникать исключение, если путь неверен.");
        }
        [Test(Description = "Открытие из неверного пути.")]
        public void TestProjectManagerLoadFromFile_NotCorrectPath()
        {
            Assert.Throws<System.IO.FileNotFoundException>(() => { var project = ProjectManager.LoadFromFile("c:\\New Folder\\"); }, "Должно возникать исключение, если путь неверен.");
        }

        [Test(Description = "Открытие испорченного файла пути.")]
        public void TestProjectManagerLoadFromFile_NotCorrectFile()
        {
            var text = "incorrect file";
            var fileName = "c:\\users\\nikit\\test.txt";
            File.WriteAllText(fileName, text);
            Assert.Throws<JsonReaderException>(() => { var project = ProjectManager.LoadFromFile(fileName); }, "Должно возникать исключение, если файл испорчен.");
        }
    }
}
