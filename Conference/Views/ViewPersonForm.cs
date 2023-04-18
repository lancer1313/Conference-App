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
    public partial class ViewPersonForm : Form
    {
        private Person _person;
        private MainForm _mainForm;
        public ViewPersonForm(int personId, MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            using (DatabaseContext context = new DatabaseContext())
            {
                _person = context.People.First(person => personId == person.Id);
            }
            textFirstName.Text = _person.FirstName;
            textLastName.Text = _person.LastName;
            textRole.Text = _person.Role;
            textPhoneNumber.Text = _person.PhoneNumber;
            textEmail.Text = _person.Email;
        }

        private void newReportBtn_Click(object sender, EventArgs e)
        {
            ReportAdditionForm form = new ReportAdditionForm(_mainForm);
            form.ShowDialog();
        }

        private void joinMeetingBtn_Click(object sender, EventArgs e)
        {
            //
            _mainForm.DisplayMeetings();
            DisplayPersonsMeetings();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void personMeetingsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                return;
            }
            ViewMeetingForm form = new ViewMeetingForm(Convert.ToInt32(personMeetingsTable.Rows[e.RowIndex].Cells[0].Value));
            form.ShowDialog();
        }

        private void personsReportTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                return;
            }
            ViewReportForm form = new ViewReportForm(Convert.ToInt32(personsReportTable.Rows[e.RowIndex].Cells[0].Value));
            form.ShowDialog();
        }

        private void DisplayPersonsMeetings()
        {
            
        }

        private void DisplayPersonsReports()
        {

        }
    }
}
