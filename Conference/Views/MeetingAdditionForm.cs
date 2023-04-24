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
    public partial class MeetingAdditionForm : Form
    {
        private MainForm _parentForm;
        private Dictionary<string, string> _regexPatterns = new Dictionary<string, string>()
        {
            {"dayTime", @"^([01]?[0-9]|2[0-3]):[0-5][0-9]$" }
        };

        public MeetingAdditionForm(MainForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void newMeetingBtn_Click(object sender, EventArgs e)
        {
            string validationResult = ValidateFields(textSectionName.Text, textDayTime.Text);
            if (validationResult != "OK")
            {
                errorLabel.Text = validationResult;
                return;
            }
            errorLabel.Text = "";

            Meeting meeting = new Meeting();
            meeting.Section = textSectionName.Text;
            meeting.Date = dateTimePicker.Value.ToShortDateString() + " " + textDayTime.Text;

            using (DatabaseContext context = new DatabaseContext())
            {
                context.Meetings.Add(meeting);
                context.SaveChanges();
                MessageBox.Show("Собрание успешно создано", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _parentForm.DisplayMeetings();
        }

        private string ValidateFields(string sectionName, string dayTime)
        {
            if (sectionName == "")
            {
                return "Введите название секции собрания";
            }
            if (dayTime == "" || !Regex.IsMatch(dayTime, _regexPatterns["dayTime"]))
            {
                return "Введите корректное время начала";
            }
            return "OK";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
