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
using Microsoft.EntityFrameworkCore;

namespace Conference.Views
{
    public partial class ViewPersonForm : Form
    {
        private int _personId;
        private MainForm _mainForm;
        public ViewPersonForm(int personId, MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _personId = personId;
            Person person;
            using (DatabaseContext context = new DatabaseContext())
            {
                person = context.People
                    .Include(person => person.Reports)
                    .Include(person => person.Meetings)
                    .First(person => _personId == person.Id);
            }
            textFirstName.Text = person.FirstName;
            textLastName.Text = person.LastName;
            textRole.Text = person.Role;
            textPhoneNumber.Text = person.PhoneNumber;
            textEmail.Text = person.Email;
            DisplayPersonsMeetings();
            DisplayPersonsReports();
        }

        private void newReportBtn_Click(object sender, EventArgs e)
        {
            ReportAdditionForm form = new ReportAdditionForm(_personId, _mainForm, this);
            form.ShowDialog();
        }

        private void joinMeetingBtn_Click(object sender, EventArgs e)
        {
            JoinMeetingForm form = new JoinMeetingForm(_personId, _mainForm, this);
            form.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void personsReportTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                ViewReportForm form = new ViewReportForm(Convert.ToInt32(personsReportTable.Rows[e.RowIndex].Cells[0].Value));
                form.ShowDialog();
            }
            else if (e.ColumnIndex == 5)
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    Report report = context.Reports.First(rep => rep.Id == Convert.ToInt32(personsReportTable.Rows[e.RowIndex].Cells[0].Value));
                    context.Reports.Remove(report);
                    context.SaveChanges();
                    DisplayPersonsReports();
                    _mainForm.DisplayReports();
                }
            }
            else
            {
                return;
            }
        }

        private void personMeetingsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    int meetingId = Convert.ToInt32(personMeetingsTable.Rows[e.RowIndex].Cells[0].Value);
                    Meeting meeting = context.Meetings.First(m => m.Id == meetingId);
                    Person person = context.People.Include(p => p.Meetings).First(p => p.Id == _personId);
                    person.Meetings.Remove(meeting);
                    context.SaveChanges();
                    DisplayPersonsMeetings();
                    _mainForm.DisplayMeetings();
                }
            }
            else
            {
                return;
            }
        }

        public void DisplayPersonsMeetings()
        {
            personMeetingsTable.Rows.Clear();
            Person person;
            using (DatabaseContext context = new DatabaseContext())
            {
                person = context.People
                    .Include(person => person.Reports)
                    .Include(person => person.Meetings)
                    .First(person => _personId == person.Id);
            }
            foreach (Meeting meeting in person.Meetings)
            {
                int index = personMeetingsTable.Rows.Add();
                personMeetingsTable.Rows[index].Cells[0].Value = meeting.Id;
                personMeetingsTable.Rows[index].Cells[1].Value = meeting.Section;
                personMeetingsTable.Rows[index].Cells[2].Value = meeting.Date;
                Report? report = person.Reports.Find(report => report.Theme == meeting.Section);
                personMeetingsTable.Rows[index].Cells[3].Value = report == null ? "Гость" : "Выступающий";
                personMeetingsTable.Rows[index].Cells[4].Value = "Удалить";
            }
        }

        public void DisplayPersonsReports()
        {
            personsReportTable.Rows.Clear();
            Person person;
            using (DatabaseContext context = new DatabaseContext())
            {
                person = context.People
                    .Include(person => person.Reports)
                    .Include(person => person.Meetings)
                    .First(person => _personId == person.Id);
            }
            foreach (Report report in person.Reports)
            {
                int index = personsReportTable.Rows.Add();
                personsReportTable.Rows[index].Cells[0].Value = report.Id;
                personsReportTable.Rows[index].Cells[1].Value = report.Name;
                personsReportTable.Rows[index].Cells[2].Value = report.Theme;
                personsReportTable.Rows[index].Cells[3].Value = report.Speciality;
                personsReportTable.Rows[index].Cells[4].Value = "Подробнее...";
                personsReportTable.Rows[index].Cells[5].Value = "Удалить";
            }
        }
    }
}
