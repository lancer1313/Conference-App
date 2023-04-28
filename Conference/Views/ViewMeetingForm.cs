using Conference.Models;
using Conference.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference.Views
{
    public partial class ViewMeetingForm : Form
    {
        private MainForm _mainForm;
        private int _meetingId;
        public ViewMeetingForm(int meetingId, MainForm mainForm)
        {
            InitializeComponent();
            _meetingId = meetingId;
            _mainForm = mainForm;
            Meeting meeting;
            using (DatabaseContext context = new DatabaseContext())
            {
                meeting = context.Meetings.Include(meeting => meeting.People).First(meeting => _meetingId == meeting.Id);
            }
            textSectionName.Text = meeting.Section;
            textDayTime.Text = meeting.Date;
            textCount.Text = meeting.People.Count.ToString();
            DisplayPeopleOnMeeting();
        }

        private void addPersonToMeeting_Click(object sender, EventArgs e)
        {
            AddPeopleToMeetingForm form = new AddPeopleToMeetingForm(_meetingId, _mainForm, this);
            form.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void DisplayPeopleOnMeeting()
        {
            peopleOnMeetingTable.Rows.Clear();
            Meeting meeting;
            using (DatabaseContext context = new DatabaseContext())
            {
                meeting = context.Meetings
                    .Include(meeting => meeting.People)
                    .ThenInclude(person => person.Reports)
                    .First(meeting => _meetingId == meeting.Id);
            }
            foreach (Person person in meeting.People)
            {
                int index = peopleOnMeetingTable.Rows.Add();
                peopleOnMeetingTable.Rows[index].Cells[0].Value = person.Id;
                peopleOnMeetingTable.Rows[index].Cells[1].Value = person.FirstName;
                peopleOnMeetingTable.Rows[index].Cells[2].Value = person.LastName;
                peopleOnMeetingTable.Rows[index].Cells[3].Value = person.Role;
                Report? personReport = person.Reports.Find(report => report.Theme == meeting.Section);
                peopleOnMeetingTable.Rows[index].Cells[4].Value = personReport == null ? "Гость" : "Участник";
            }
        }
    }
}
