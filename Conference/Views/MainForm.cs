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
                }
            }
        }

        public void DisplayMeetings()
        {
            meetingsTable.Rows.Clear();
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Meeting> meetings = context.Meetings.ToList();
                foreach (Meeting meeting in meetings)
                {
                    int index = meetingsTable.Rows.Add();
                    meetingsTable.Rows[index].Cells[0].Value = meeting.Id;
                    meetingsTable.Rows[index].Cells[1].Value = meeting.Section;
                    meetingsTable.Rows[index].Cells[2].Value = meeting.Date;
                    meetingsTable.Rows[index].Cells[3].Value = meeting.People.Count;
                    meetingsTable.Rows[index].Cells[4].Value = "Подробнее...";
                }
            }
        }

        public void DisplayReports()
        {

        }

        private void meetingsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                return;
            }
            ViewMeetingForm form = new ViewMeetingForm(Convert.ToInt32(meetingsTable.Rows[e.RowIndex].Cells[0].Value));
            form.ShowDialog();
        }

        private void peopleTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 6)
            {
                return;
            }
            ViewPersonForm form = new ViewPersonForm(Convert.ToInt32(peopleTable.Rows[e.RowIndex].Cells[0].Value));
            form.ShowDialog();
        }

        private void reportTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                return;
            }
            ViewReportForm form = new ViewReportForm(Convert.ToInt32(reportTable.Rows[e.RowIndex].Cells[0].Value));
            form.ShowDialog();
        }
    }
}
