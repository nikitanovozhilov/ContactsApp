using ContactsApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class ContactForm : Form
    {
        public Contact Contact;


        public ContactForm()
        {
            InitializeComponent();
        }

        // Отмена ввода.
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Открытие контакта или создание нового.
        private void ContactForm_Load(object sender, EventArgs e)
        {
            if (Contact == null) Contact = new Contact();
            else PhoneField.Text = Contact.Phone.Number.ToString();


            SurnameField.Text = Contact.Surname;
            NameField.Text = Contact.Name;
            BirthdayField.Value = Contact.BirthDate;

            EmailField.Text = Contact.Email;
            VkField.Text = Contact.VkId;
        }

        // Ввод данных контакта.
        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                Contact.Surname = SurnameField.Text;
                Contact.Name = NameField.Text;
                Contact.BirthDate = BirthdayField.Value;
                Contact.Phone.Number = long.Parse(PhoneField.Text);
                Contact.Email = EmailField.Text;
                Contact.VkId = VkField.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //Подсветка ошибок поля "Surname".
        private void SurnameField_TextChanged(object sender, EventArgs e)
        {
            if (SurnameField.Text.Length == 0 || SurnameField.Text.Length > 50)
            {
                SurnameField.BackColor = Color.LightSalmon;
            }
            else
            {
                SurnameField.BackColor = Color.White;
            }
        }

        //Подсветка ошибок поля "Name".
        private void NameField_TextChanged(object sender, EventArgs e)
        {
            if (NameField.Text.Length == 0 || NameField.Text.Length > 50)
            {
                NameField.BackColor = Color.LightSalmon;
            }
            else
            {
                NameField.BackColor = Color.White;
            }
        }

        //Подсветка ошибок поля "Phone".
        private void PhoneField_TextChanged(object sender, EventArgs e)
        {
            long num = 0;
            if (PhoneField.Text.Length == 0 || PhoneField.Text.Length > 11 || PhoneField.Text[0] != '7' ||
                !long.TryParse(PhoneField.Text,out num))
            {
                PhoneField.BackColor = Color.LightSalmon;
            }
            else
            {
                PhoneField.BackColor = Color.White;
            }
        }

        //Подсветка ошибок поля "Email".
        private void EmailField_TextChanged(object sender, EventArgs e)
        {
            if (EmailField.Text.Length == 0 || EmailField.Text.Length > 50)
            {
                EmailField.BackColor = Color.LightSalmon;
            }
            else
            {
                EmailField.BackColor = Color.White;
            }
        }

        //Подсветка ошибок поля "vk.com".
        private void VkField_TextChanged(object sender, EventArgs e)
        {
            if (VkField.Text.Length == 0 || VkField.Text.Length > 15)
            {
                VkField.BackColor = Color.LightSalmon;
            }
            else
            {
                VkField.BackColor = Color.White;
            }
        }
    }
}