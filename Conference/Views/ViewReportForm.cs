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
    public partial class ViewReportForm : Form
    {
        private Report _report;
        public ViewReportForm(int reportId)
        {
            InitializeComponent();
            using (DatabaseContext context = new DatabaseContext())
            {
                _report = context.Reports.First(report => reportId == report.Id);
            }
            textName.Text = _report.Name;
            textTheme.Text = _report.Theme;
            textSpeciality.Text = _report.Speciality;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
