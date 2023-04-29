using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Conference.Models;
using Conference.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Conference.Views
{
    public partial class JoinMeetingForm : Form
    {
        private MainForm _mainForm;
        private ViewPersonForm _viewPersonForm;
        private int _personId;
        public JoinMeetingForm(int personId, MainForm mainForm, ViewPersonForm viewPersonForm)
        {
            InitializeComponent();
            _personId = personId;
            _mainForm = mainForm;
            _viewPersonForm = viewPersonForm;
            DisplayMeetings();
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
            using (DatabaseContext context = new DatabaseContext())
            {
                Meeting meeting = context.Meetings.First(meeting => 
                Convert.ToInt32(personMeetingsTable.Rows[e.RowIndex].Cells[0].Value.ToString()) == meeting.Id);
                Person person = context.People.First(person => _personId == person.Id);
                person.Meetings.Add(meeting);
                context.SaveChanges();
                MessageBox.Show("Участник успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DisplayMeetings();
            _viewPersonForm.DisplayPersonsMeetings();
            _mainForm.DisplayMeetings();
        }

        private void DisplayMeetings()
        {
            personMeetingsTable.Rows.Clear();
            using (DatabaseContext context = new DatabaseContext())
            {
                Person person = context.People
                    .Include(person => person.Reports)
                    .Include(person => person.Meetings)
                    .First(person => _personId == person.Id);
                List<Meeting> meetings = context.Meetings.ToList();
                foreach (Meeting meeting in meetings)
                {
                    if (person.Meetings.Any(meetingCur => meetingCur.Id == meeting.Id))
                        continue;
                    int index = personMeetingsTable.Rows.Add();
                    personMeetingsTable.Rows[index].Cells[0].Value = meeting.Id;
                    personMeetingsTable.Rows[index].Cells[1].Value = meeting.Section;
                    personMeetingsTable.Rows[index].Cells[2].Value = meeting.Date;
                    personMeetingsTable.Rows[index].Cells[3].Value = person.Reports.Any(report => report.Theme == meeting.Section) ? "Выступающий" : "Гость";
                    personMeetingsTable.Rows[index].Cells[4].Value = "Добавить";
                }
            }
        }
    }
}
