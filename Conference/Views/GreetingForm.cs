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
    public partial class GreetingForm : Form
    {
        private bool _flag = false;
        public GreetingForm()
        {
            InitializeComponent();
        }

        private async void GreetingForm_Load(object sender, EventArgs e)
        {
            await CloseFormWithDelay(5000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _flag = true;
            ShowMainForm();
        }

        private void ShowMainForm()
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => Close();
            mainForm.Show();
        }

        private async Task CloseFormWithDelay(int timeInMilliseconds)
        {
            await Task.Delay(timeInMilliseconds);
            if (!_flag)
                ShowMainForm();
        }

    }
}
