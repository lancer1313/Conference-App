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
    public partial class ReportAdditionForm : Form
    {
        private MainForm _mainForm;
        public ReportAdditionForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newReportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
