using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conference.Models;
using Conference.Repositories;

namespace Conference.Views
{
    public partial class PersonAdditionForm : Form
    {
        private MainForm _mainForm;
        private Dictionary<string, string> _regexPatterns = new Dictionary<string, string>()
        {
            {"firstName", @"^[А-ЯЁ][а-яё]*$" },
            {"lastName", @"^[А-ЯЁ][а-яё]*$" },
            {"phoneNumber", @"^([+]?[0-9\s-\(\)]{3,25})*$" },
            {"email", @"^[_a-z0-9-\+-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,})$" }
        };

        public PersonAdditionForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string validationResult = ValidateFields(textFirstName.Text, textLastName.Text, textRole.Text, textPhoneNumber.Text, textEmail.Text);
            if (validationResult != "OK")
            {
                errorLabel.Text = validationResult;
                return;
            }
            errorLabel.Text = "";

            using (DatabaseContext context = new DatabaseContext())
            {
                Person person = new Person();
                person.FirstName = textFirstName.Text;
                person.LastName = textLastName.Text;
                person.Role = textRole.Text;
                person.PhoneNumber = textPhoneNumber.Text;
                person.Email = textEmail.Text;

                context.People.Add(person);
                context.SaveChanges();
                MessageBox.Show("Участник успешно создан", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _mainForm.DisplayPeople();
        }

        private string ValidateFields(string firstName, string lastName, string role, string phoneNumber, string email)
        {
            if (firstName == "" || !Regex.IsMatch(firstName, _regexPatterns["firstName"]))
            {
                return "Неправильное имя! Принимается только кирилллица";
            }
            if (lastName == "" || !Regex.IsMatch(lastName, _regexPatterns["lastName"]))
            {
                return "Неправильная фамилия! Принимается только кирилллица";
            }
            if (role == "")
            {
                return "Выберите должность";
            }
            if (phoneNumber == "" || !Regex.IsMatch(phoneNumber, _regexPatterns["phoneNumber"]))
            {
                return "Неправильный номер телефона!";
            }
            if (email == "" || !Regex.IsMatch(email, _regexPatterns["email"]))
            {
                return "Неправильная электронная почта!";
            }
            return "OK";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
