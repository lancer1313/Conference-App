using Conference.Repositories;
using Conference.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Conference.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newPersonBtn_Click(object sender, EventArgs e)
        {
            PersonAdditionForm form = new PersonAdditionForm(this);
            form.ShowDialog();
        }

        private void newMeetingBtn_Click(object sender, EventArgs e)
        {
            MeetingAdditionForm form = new MeetingAdditionForm(this);
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayPeople();
            DisplayMeetings();
            DisplayReports();
        }

        public void DisplayPeople()
        {
            peopleTable.Rows.Clear();
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Person> people = context.People.ToList();
                foreach (Person person in people)
                {
                    int index = peopleTable.Rows.Add();
                    peopleTable.Rows[index].Cells[0].Value = person.Id;
                    peopleTable.Rows[index].Cells[1].Value = person.FirstName;
                    peopleTable.Rows[index].Cells[2].Value = person.LastName;
                    peopleTable.Rows[index].Cells[3].Value = person.Role;
                    peopleTable.Rows[index].Cells[4].Value = person.PhoneNumber;
                    peopleTable.Rows[index].Cells[5].Value = person.Email;
                    peopleTable.Rows[index].Cells[6].Value = "Подробнее...";
                    peopleTable.Rows[index].Cells[7].Value = "Удалить";
                }
            }
        }

        public void DisplayMeetings()
        {
            meetingsTable.Rows.Clear();
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Meeting> meetings = context.Meetings.Include(m => m.People).ToList();
                foreach (Meeting meeting in meetings)
                {
                    int index = meetingsTable.Rows.Add();
                    meetingsTable.Rows[index].Cells[0].Value = meeting.Id;
                    meetingsTable.Rows[index].Cells[1].Value = meeting.Section;
                    meetingsTable.Rows[index].Cells[2].Value = meeting.Date;
                    meetingsTable.Rows[index].Cells[3].Value = meeting.People.Count;
                    meetingsTable.Rows[index].Cells[4].Value = "Подробнее...";
                    meetingsTable.Rows[index].Cells[5].Value = "Удалить";
                }
            }
        }

        public void DisplayReports()
        {
            reportTable.Rows.Clear();
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Report> reports = context.Reports.ToList();
                foreach (Report report in reports)
                {
                    int index = reportTable.Rows.Add();
                    reportTable.Rows[index].Cells[0].Value = report.Id;
                    reportTable.Rows[index].Cells[1].Value = report.Name;
                    reportTable.Rows[index].Cells[2].Value = report.Theme;
                    reportTable.Rows[index].Cells[3].Value = report.Speciality;
                    reportTable.Rows[index].Cells[4].Value = "Подробнее...";
                }
            }
        }

        private void meetingsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                ViewMeetingForm form = new ViewMeetingForm(Convert.ToInt32(meetingsTable.Rows[e.RowIndex].Cells[0].Value), this);
                form.ShowDialog();
            }
            else if (e.ColumnIndex == 5)
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    int meetingId = Convert.ToInt32(meetingsTable.Rows[e.RowIndex].Cells[0].Value);
                    Meeting meeting = context.Meetings.First(m => m.Id == meetingId);
                    context.Meetings.Remove(meeting);
                    context.SaveChanges();
                    DisplayMeetings();
                }
            }
            else
            {
                return;
            }
        }

        private void peopleTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                ViewPersonForm form = new ViewPersonForm(Convert.ToInt32(peopleTable.Rows[e.RowIndex].Cells[0].Value), this);
                form.ShowDialog();
            }
            else if (e.ColumnIndex == 7)
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    int personId = Convert.ToInt32(peopleTable.Rows[e.RowIndex].Cells[0].Value);
                    Person person = context.People.First(p => p.Id == personId);
                    context.People.Remove(person);
                    context.SaveChanges();
                    DisplayPeople();
                    DisplayReports();
                    DisplayMeetings();
                }
            }
            else
            {
                return;
            }
            
        }

        private void reportTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                ViewReportForm form = new ViewReportForm(Convert.ToInt32(reportTable.Rows[e.RowIndex].Cells[0].Value));
                form.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void showAllDataReportBtn_Click(object sender, EventArgs e)
        {
            DisplayReports();
        }

        private void filterReportBtn_Click(object sender, EventArgs e)
        {
            if (filterItemReport.Text == "")
            {
                MessageBox.Show("Введите критерий фильтрации");
                return;
            }
            if (filterValueReport.Text == "")
            {
                MessageBox.Show("Введите значение для фильтрации");
                return;
            }

            reportTable.Rows.Clear();
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Report> reports = context.Reports.ToList();
                foreach (Report report in reports)
                {
                    if (filterItemReport.Text == "Специальность")
                    {
                        if (report.Speciality == filterValueReport.Text)
                        {
                            int index = reportTable.Rows.Add();
                            reportTable.Rows[index].Cells[0].Value = report.Id;
                            reportTable.Rows[index].Cells[1].Value = report.Name;
                            reportTable.Rows[index].Cells[2].Value = report.Theme;
                            reportTable.Rows[index].Cells[3].Value = report.Speciality;
                            reportTable.Rows[index].Cells[4].Value = "Подробнее...";
                        }
                    }
                }
            }
        }

        private void searchReportBtn_Click(object sender, EventArgs e)
        {
            if (searchItemReport.Text == "")
            {
                MessageBox.Show("Введите критерий поиска");
                return;
            }
            if (searchValueReport.Text == "")
            {
                MessageBox.Show("Введите значение для поиска");
                return;
            }

            reportTable.Rows.Clear();
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Report> reports = context.Reports.ToList();
                foreach (Report report in reports)
                {
                    if (searchItemReport.Text == "Название")
                    {
                        if (!report.Name.Contains(searchValueReport.Text))
                        {
                            continue;
                        }
                    }
                    else if (searchItemReport.Text == "Тематика")
                    {
                        if (!report.Theme.Contains(searchValueReport.Text))
                        {
                            continue;
                        }
                    }
                    int index = reportTable.Rows.Add();
                    reportTable.Rows[index].Cells[0].Value = report.Id;
                    reportTable.Rows[index].Cells[1].Value = report.Name;
                    reportTable.Rows[index].Cells[2].Value = report.Theme;
                    reportTable.Rows[index].Cells[3].Value = report.Speciality;
                    reportTable.Rows[index].Cells[4].Value = "Подробнее...";
                }
            }
        }

        private void showAllDataPeopleBtn_Click(object sender, EventArgs e)
        {
            DisplayPeople();
        }

        private void filterPeopleBtn_Click(object sender, EventArgs e)
        {
            if (filterItemPeople.Text == "")
            {
                MessageBox.Show("Введите критерий фильтрации");
                return;
            }
            if (filterValuePeople.Text == "")
            {
                MessageBox.Show("Введите значение для фильтрации");
                return;
            }

            peopleTable.Rows.Clear();
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Person> people = context.People.ToList();
                foreach (Person person in people)
                {
                    if (filterItemPeople.Text == "Должность")
                    {
                        if (person.Role == filterValuePeople.Text)
                        {
                            int index = peopleTable.Rows.Add();
                            peopleTable.Rows[index].Cells[0].Value = person.Id;
                            peopleTable.Rows[index].Cells[1].Value = person.FirstName;
                            peopleTable.Rows[index].Cells[2].Value = person.LastName;
                            peopleTable.Rows[index].Cells[3].Value = person.Role;
                            peopleTable.Rows[index].Cells[4].Value = person.PhoneNumber;
                            peopleTable.Rows[index].Cells[5].Value = person.Email;
                            peopleTable.Rows[index].Cells[6].Value = "Подробнее...";
                            peopleTable.Rows[index].Cells[7].Value = "Удалить";
                        }
                    }
                }
            }
        }

        private void searchPeopleBtn_Click(object sender, EventArgs e)
        {
            if (searchItemPeople.Text == "")
            {
                MessageBox.Show("Введите критерий поиска");
                return;
            }
            if (searchValuePeople.Text == "")
            {
                MessageBox.Show("Введите значение для поиска");
                return;
            }

            peopleTable.Rows.Clear();
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Person> people = context.People.ToList();
                foreach (Person person in people)
                {
                    if (searchItemPeople.Text == "Имя")
                    {
                        if (!person.FirstName.Contains(searchValuePeople.Text))
                        {
                            continue;
                        }
                    }
                    else if (searchItemPeople.Text == "Фамилия")
                    {
                        if (!person.LastName.Contains(searchValuePeople.Text))
                        {
                            continue;
                        }
                    }
                    else if (searchItemPeople.Text == "Номер телефона")
                    {
                        if (!person.PhoneNumber.Contains(searchValuePeople.Text))
                        {
                            continue;
                        }
                    }
                    else if (searchItemPeople.Text == "Эл. почта")
                    {
                        if (!person.Email.Contains(searchValuePeople.Text))
                        {
                            continue;
                        }
                    }
                    int index = peopleTable.Rows.Add();
                    peopleTable.Rows[index].Cells[0].Value = person.Id;
                    peopleTable.Rows[index].Cells[1].Value = person.FirstName;
                    peopleTable.Rows[index].Cells[2].Value = person.LastName;
                    peopleTable.Rows[index].Cells[3].Value = person.Role;
                    peopleTable.Rows[index].Cells[4].Value = person.PhoneNumber;
                    peopleTable.Rows[index].Cells[5].Value = person.Email;
                    peopleTable.Rows[index].Cells[6].Value = "Подробнее...";
                    peopleTable.Rows[index].Cells[7].Value = "Удалить";
                }
            }
        }

        private void showAllDataMeetingsBtn_Click(object sender, EventArgs e)
        {
            DisplayMeetings();
        }

        private void filterMeetingsBtn_Click(object sender, EventArgs e)
        {
            if (filterItemMeeting.Text == "")
            {
                MessageBox.Show("Введите критерий поиска");
                return;
            }
            if (filterValueMeeting.Text == "")
            {
                MessageBox.Show("Введите значение для поиска");
                return;
            }

            meetingsTable.Rows.Clear();
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Meeting> meetings = context.Meetings.Include(m => m.People).ToList();
                foreach (Meeting meeting in meetings)
                {
                    if (filterItemMeeting.Text == "Количество участников")
                    {
                        if (meeting.People.Count.ToString() == filterValueMeeting.Text)
                        {
                            int index = meetingsTable.Rows.Add();
                            meetingsTable.Rows[index].Cells[0].Value = meeting.Id;
                            meetingsTable.Rows[index].Cells[1].Value = meeting.Section;
                            meetingsTable.Rows[index].Cells[2].Value = meeting.Date;
                            meetingsTable.Rows[index].Cells[3].Value = meeting.People.Count;
                            meetingsTable.Rows[index].Cells[4].Value = "Подробнее...";
                            meetingsTable.Rows[index].Cells[5].Value = "Удалить";
                        }
                    }
                }
            }
        }

        private void searchMeetingsBtn_Click(object sender, EventArgs e)
        {
            if (searchItemMeeting.Text == "")
            {
                MessageBox.Show("Введите критерий поиска");
                return;
            }
            if (searchValueMeeting.Text == "")
            {
                MessageBox.Show("Введите значение для поиска");
                return;
            }

            meetingsTable.Rows.Clear();
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Meeting> meetings = context.Meetings.Include(m => m.People).ToList();
                foreach (Meeting meeting in meetings)
                {
                    if (searchItemMeeting.Text == "Дата проведения")
                    {
                        if (!meeting.Date.Contains(searchValueMeeting.Text))
                        {
                            continue;
                        }
                    }
                    if (searchItemMeeting.Text == "Секция")
                    {
                        if (!meeting.Section.Contains(searchValueMeeting.Text))
                        {
                            continue;
                        }
                    }
                    int index = meetingsTable.Rows.Add();
                    meetingsTable.Rows[index].Cells[0].Value = meeting.Id;
                    meetingsTable.Rows[index].Cells[1].Value = meeting.Section;
                    meetingsTable.Rows[index].Cells[2].Value = meeting.Date;
                    meetingsTable.Rows[index].Cells[3].Value = meeting.People.Count;
                    meetingsTable.Rows[index].Cells[4].Value = "Подробнее...";
                    meetingsTable.Rows[index].Cells[5].Value = "Удалить";
                }
            }
        }
    }
}
