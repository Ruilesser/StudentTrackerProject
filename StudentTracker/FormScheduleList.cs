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
    public partial class FormScheduleList : Form
    {
        public FormScheduleList()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void userBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void FormScheduleList_Load(object sender, EventArgs e)
        {
            adminPnl.Hide();
        }

        private void UserLabel_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            FormSchedule frm = new FormSchedule();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            FormSchedule frm = new FormSchedule();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
