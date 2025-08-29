using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            FormUserList frm = new FormUserList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            FormScheduleList frm = new FormScheduleList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            FormCourseList frm = new FormCourseList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            FormSettingsList frm = new FormSettingsList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void facultyBtn_Click(object sender, EventArgs e)
        {
            FormFacultyList frm = new FormFacultyList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            FormPositionList frm = new FormPositionList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
