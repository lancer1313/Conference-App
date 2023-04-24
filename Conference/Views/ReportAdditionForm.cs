using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conference.Models;
using Conference.Repositories;

namespace Conference.Views
{
    public partial class ReportAdditionForm : Form
    {
        private MainForm _mainForm;
        private ViewPersonForm _parentForm;
        private Person _person;
        public ReportAdditionForm(int personId, MainForm mainForm, ViewPersonForm parentForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _parentForm = parentForm;
            using (DatabaseContext context = new DatabaseContext())
            {
                _person = context.People.First(person => personId == person.Id);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newReportBtn_Click(object sender, EventArgs e)
        {
            string validationResult = ValidateFields(textName.Text, textTheme.Text, textSpeciality.Text);
            if (validationResult != "OK")
            {
                errorLabel.Text = validationResult;
                return;
            }
            errorLabel.Text = "";

            using (DatabaseContext context = new DatabaseContext())
            {
                Report report = new Report();
                report.Name = textName.Text;
                report.Theme = textTheme.Text;
                report.Speciality = textSpeciality.Text;
                context.Reports.Add(report);

                report.Person = _person;
                context.SaveChanges();
                MessageBox.Show("Доклад успешно создан", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _mainForm.DisplayReports();
            _parentForm.DisplayPersonsReports();
        }

        private string ValidateFields(string name, string theme, string speciality)
        {
            if (name == "")
            {
                return "Введите название доклада";
            }
            if (theme == "")
            {
                return "Введите тематику доклада";
            }
            if (speciality == "")
            {
                return "Выберите специальность из списка";
            }
            return "OK";
        }
    }
}
