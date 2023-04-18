using Conference.Models;
using Conference.Repositories;
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
        private Meeting _meeting;
        public ViewMeetingForm(int meetingId)
        {
            InitializeComponent();
            using (DatabaseContext context = new DatabaseContext())
            {
                _meeting = context.Meetings.First(person => meetingId == person.Id);
            }
            textSectionName.Text = _meeting.Section;
            textDayTime.Text = _meeting.Date;
            textCount.Text = _meeting.People.Count.ToString();
            DisplayPeopleOnMeeting();
        }

        private void addPersonToMeeting_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayPeopleOnMeeting()
        {

        }
    }
}
