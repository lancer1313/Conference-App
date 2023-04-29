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
    public partial class AddPeopleToMeetingForm : Form
    {
        private MainForm _mainForm;
        private ViewMeetingForm _viewMeetingForm;
        private int _meetingId;
        public AddPeopleToMeetingForm(int meetingId, MainForm mainForm, ViewMeetingForm viewMeetingForm)
        {
            InitializeComponent();
            _meetingId = meetingId;
            _mainForm = mainForm;
            _viewMeetingForm = viewMeetingForm;
            DisplayPeople();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void peopleToAddTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5)
            {
                return;
            }
            using (DatabaseContext context = new DatabaseContext())
            {
                Person person = context.People.First(person =>
                Convert.ToInt32(peopleToAddTable.Rows[e.RowIndex].Cells[0].Value.ToString()) == person.Id);
                Meeting meeting = context.Meetings.First(meeting => _meetingId == meeting.Id);
                meeting.People.Add(person);
                context.SaveChanges();
                MessageBox.Show("Участник успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DisplayPeople();
            _viewMeetingForm.DisplayPeopleOnMeeting();
            _mainForm.DisplayMeetings();
        }

        private void DisplayPeople()
        {
            peopleToAddTable.Rows.Clear();
            using (DatabaseContext context = new DatabaseContext())
            {
                Meeting meeting = context.Meetings
                    .Include(meeting => meeting.People)
                    .First(meeting => _meetingId == meeting.Id);
                List<Person> people = context.People.Include(person => person.Reports).ToList();
                foreach (Person person in people)
                {
                    if (meeting.People.Any(personCur => personCur.Id == person.Id))
                        continue;
                    int index = peopleToAddTable.Rows.Add();
                    peopleToAddTable.Rows[index].Cells[0].Value = person.Id;
                    peopleToAddTable.Rows[index].Cells[1].Value = person.FirstName;
                    peopleToAddTable.Rows[index].Cells[2].Value = person.LastName;
                    peopleToAddTable.Rows[index].Cells[3].Value = person.Role;
                    Report? personReport = person.Reports.Find(report => report.Theme == meeting.Section);
                    peopleToAddTable.Rows[index].Cells[4].Value = personReport != null ? "Выступающий" : "Гость";
                    peopleToAddTable.Rows[index].Cells[5].Value = "Добавить";
                }
            }
        }

    }
}
