using ContactsApp;
using System;
using System.IO;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private Project _contactList;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод добавления контакта.
        /// </summary>
        private void AddContact()
        {
            var form = new ContactForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _contactList.ContactList.Add(form.Contact);
                RefreshList();
            }
        }

        /// <summary>
        /// Метод редактирования контакта.
        /// </summary>
        private void EditContact()
        {
            if (ContactsList.SelectedItem != null)
            {
                var form = new ContactForm();
                form.Contact = (Contact) ContactsList.SelectedItem;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshList();
                }
            }
        }

        /// <summary>
        /// Метод удаления контакта.
        /// </summary>
        private void RemoveContact()
        {
            if (ContactsList.SelectedItem != null)
            {
                if (MessageBox.Show("Вы точно хотите удалить контакт?", "Предупреждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _contactList.ContactList.Remove((Contact) ContactsList.SelectedItem);
                    RefreshList();
                }
            }
        }

        // Открытие формы About.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        // Добавление контакта.
        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm add = new ContactForm();
            add.ShowDialog();
        }

        // Редактирование контакта.
        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void SplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        /// <summary>
        /// Метод обновления списка контактов.
        /// </summary>
        private void RefreshList()
        {
            ContactsList.DataSource = null;
            ContactsList.DataSource = _contactList.GetByNameOrSurname(FindBox.Text);
            ContactsList.DisplayMember = "Surname";
            ProjectManager.SaveToFile(_contactList, ProjectManager.DocumentsPath);
        }

        // Открытие файла с контактами или создание нового.
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(ProjectManager.DocumentsPath))
            {
                _contactList = ProjectManager.LoadFromFile(ProjectManager.DocumentsPath);
            }
            else
            {
                _contactList = new Project();
                ProjectManager.SaveToFile(_contactList, ProjectManager.DocumentsPath);
            }

            foreach (var surname in _contactList.GetListBirthdayBoy())
            {
                BirthdayTodayLabel.Text += surname + " ";
            }

            RefreshList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            RemoveContact();
        }

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveContact();
        }

        /// <summary>
        /// Вывод данных контакта.
        /// </summary>
        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsList.SelectedItem != null)
            {
                var contact = (Contact) ContactsList.SelectedItem;
                SurameField.Text = contact.Surname;
                NameField.Text = contact.Name;
                BirthdayDate.Value = contact.BirthDate;
                PhoneField.Text = contact.Phone.Number.ToString();
                EmailField.Text = contact.Email;
                VkField.Text = contact.VkId;
            }
        }

        // Exit.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FindBox_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void ContactsList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveContact();
            }
        }
    }
}